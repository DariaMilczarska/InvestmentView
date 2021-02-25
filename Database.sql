CREATE TABLE `currency` (
  `idCurrency` int NOT NULL AUTO_INCREMENT,
  `Shorthand` varchar(4) NOT NULL,
  `value` decimal(10,2) NOT NULL,
  `dataSource` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idCurrency`),
  UNIQUE KEY `Shortahand_UNIQUE` (`Shorthand`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

CREATE TABLE `history` (
  `idHistory` int NOT NULL AUTO_INCREMENT,
  `idUser` int NOT NULL,
  `idInvestment` int NOT NULL,
  `valuePurchased` decimal(10,2) NOT NULL,
  `valueSold` decimal(10,2) NOT NULL,
  `difference` decimal(10,2) NOT NULL,
  `differenceInP` decimal(10,2) NOT NULL,
  `datePurchased` datetime NOT NULL,
  `dateSold` datetime NOT NULL,
  PRIMARY KEY (`idHistory`),
  KEY `fkUser_idx` (`idUser`),
  KEY `fkInvestment_idx` (`idInvestment`),
  CONSTRAINT `fkInvestment` FOREIGN KEY (`idInvestment`) REFERENCES `investment` (`idInvestment`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fkUser` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8;

CREATE TABLE `investment` (
  `idInvestment` int NOT NULL AUTO_INCREMENT,
  `idInvestmentType` int NOT NULL,
  `idCurrency` int NOT NULL,
  `value` decimal(10,2) NOT NULL,
  `invName` varchar(45) NOT NULL,
  `dataSource` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idInvestment`),
  UNIQUE KEY `name_UNIQUE` (`invName`),
  KEY `fkInvestmentType_idx` (`idInvestmentType`),
  KEY `fkCurrency_idx` (`idCurrency`),
  CONSTRAINT `fkCurrency` FOREIGN KEY (`idCurrency`) REFERENCES `currency` (`idCurrency`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fkInvestmentType` FOREIGN KEY (`idInvestmentType`) REFERENCES `investmenttype` (`idInvestmentType`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

CREATE TABLE `investmenttype` (
  `idInvestmentType` int NOT NULL AUTO_INCREMENT,
  `invName` varchar(45) NOT NULL,
  PRIMARY KEY (`idInvestmentType`),
  UNIQUE KEY `name_UNIQUE` (`invName`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;

CREATE TABLE `user` (
  `idUser` int NOT NULL AUTO_INCREMENT,
  `login` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idUser`),
  UNIQUE KEY `login_UNIQUE` (`login`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

CREATE TABLE `userinvestment` (
  `idUserInvestment` int NOT NULL AUTO_INCREMENT,
  `idUser` int NOT NULL,
  `idInvestment` int NOT NULL,
  `datePurchased` datetime NOT NULL,
  `valuePurcharsed` decimal(10,2) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `ValuePLN` decimal(10,2) NOT NULL,
  `difference` decimal(10,2) NOT NULL,
  `differenceInP` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idUserInvestment`),
  KEY `fkIdUser_idx` (`idUser`),
  KEY `fkIdInvestment_idx` (`idInvestment`),
  CONSTRAINT `fkIdInvestment` FOREIGN KEY (`idInvestment`) REFERENCES `investment` (`idInvestment`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fkIdUser` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `curencyview_view` AS select `currency`.`Shorthand` AS `shorthand`,`currency`.`value` AS `value` from `currency`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `fullinvestment_view` AS select `i`.`invName` AS `Name`,`it`.`invName` AS `Type`,`ui`.`valuePurcharsed` AS `Rate`,`ui`.`amount` AS `Amount`,`ui`.`ValuePLN` AS `ValuePLN`,`i`.`value` AS `RateNow`,`ui`.`datePurchased` AS `DateBought`,`GETREALINVESTMENTVALUE`(`i`.`idInvestment`,`ui`.`amount`) AS `ValueNow`,`ui`.`difference` AS `Profit`,`ui`.`differenceInP` AS `ProfitPercent` from (((`investment` `i` join `investmenttype` `it` on((`i`.`idInvestmentType` = `it`.`idInvestmentType`))) join `userinvestment` `ui` on((`i`.`idInvestment` = `ui`.`idInvestment`))) join `currency` `c` on((`c`.`idCurrency` = `i`.`idCurrency`)));
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `history_view` AS select `i`.`invName` AS `Name`,`history`.`valuePurchased` AS `ValuePurchased`,`history`.`valueSold` AS `ValueSold`,`history`.`difference` AS `Difference`,`history`.`differenceInP` AS `DifferenceInP`,`history`.`datePurchased` AS `DatePurchased`,`history`.`dateSold` AS `DateSold` from (`history` join `investment` `i` on((`history`.`idInvestment` = `i`.`idInvestment`)));

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addCurrency`(IN short varchar(4), val decimal(10,2), dataSource varchar(100), INOUT id int)
BEGIN
	Insert into `currency`(`Shorthand`, `value`, `dataSource`) values (short, val, dataSource);
    SET id = (Select `idCurrency` from `Currency` order by `idCurrency` desc limit 1); 
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addHistoryInvestment`(IN idU int, idInv int, valPLN decimal(10,2), fullAmount decimal(10,2), valS decimal (10,2), am decimal(10,2),
										 dateP datetime)
BEGIN
	Insert into `History`(`idUser`, `idInvestment`, `valuePurchased`, `valueSold`, `difference`,`differenceInP`,`datePurchased`, `dateSold`)
    Values(idU, idInv, (am*valPLN/fullAmount), valS,
    (valS - (am*valPLN/fullAmount)), (select differenceInP((am*valPLN/fullAmount), (valS - (am*valPLN/fullAmount)))), dateP, curdate());
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addInvestment`(IN idInvType INT,currency int, val DECIMAL(10,2), invName VARCHAR(45), dataS VARCHAR(100), INOUT id INT)
BEGIN
	INSERT INTO `investment` (`idInvestmentType`, `idCurrency`,`value`, `invName`, `dataSource`)
    VALUES (idInvType,currency, val, invName, dataS);
    SET id = (SELECT `idInvestment` FROM `Investment` ORDER BY `idInvestment` DESC LIMIT 1); 
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addInvestmentType`(IN invName VARCHAR(45), INOUT id INT)
BEGIN
	INSERT INTO `InvestmentType` (`invName`) VALUES (invName);
    SET id = (SELECT `idInvestmentType` FROM `InvestmentType` ORDER BY `idInvestmentType` DESC LIMIT 1);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addUser`(IN login VARCHAR(45), pass VARCHAR(45), INOUT id INT)
BEGIN
	INSERT INTO `User` (`login`, `password`) VALUES (login, pass);
    SET id = (SELECT `idUser` FROM `User` ORDER BY `idUser` DESC LIMIT 1);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addUserInvestment`(IN idUser INT, idInvestment INT, datePurchased DATETIME, valPurchased DECIMAL(10,2), amount DECIMAL(10,2), valPLN decimal(10,2),INOUT id int)
BEGIN
	INSERT INTO `UserInvestment`(`idUser`, `idInvestment`, `datePurchased`, `valuePurcharsed`, `amount`, `ValuePLN`, `difference`, `differenceInP`)
    VALUES (idUser, idInvestment, datePurchased, valPurchased, amount, valPLN, (SELECT difference(valPLN, idInvestment, amount)), (SELECT differenceInP(valPLN,  (SELECT difference(valPLN, idInvestment, amount)))));
    SET id = (SELECT `idUserInvestment` FROM `UserInvestment` ORDER By `idUserInvestment` DESC LIMIT 1);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteUserInvestment`(IN idUI INT)
BEGIN
	Delete from `UserInvestment` where `idUserInvestment` = idUI;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `editInvestmentValue`(IN id INT, val DECIMAL(10,2))
BEGIN
	UPDATE `Investment` SET `value` = val WHERE `idInvestment` = id;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `EditUserInvestment`(In idInv int, valPLN decimal(10,2), am decimal(10,2), valP decimal(10,2))
BEGIN
	Update `UserInvestment` SET `valuePurcharsed` = (`valuePurcharsed` * `amount` + valP * am)/(`amount`+ am), 
		   `ValuePLN` = (`ValuePLN` + valPLN), `amount` = (`amount` + am) 
			where `idInvestment` = idInv;
    Update `UserInvestment` Set `difference` = (select difference(ValuePLN, idInvestment, amount)), 
			`differenceInP` =  (SELECT differenceInP(ValuePLN,  (SELECT difference(ValuePLN, idInvestment, amount))))
			where `idInvestment` = idInv;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetCurrency_All`()
BEGIN
	Select * From Currency;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetInvestment`(IN iName varchar(45))
BEGIN
	Select * from `Investment` where `invName` = iName;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetInvestment_All`()
BEGIN
	SELECT * FROM Investment;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getInvestmentType`(In typeName varchar(45))
BEGIN
	Select `ui`.`ValuePLN` from `UserInvestment` `ui`
    INNER JOIN `Investment` i ON `ui`.`idInvestment` = `i`.`idInvestment`
    INNER JOIN `InvestmentType` it ON `it`.`IdInvestmentType` = `i`.`idInvestmentType`
    where `it`.`invName` = typeName;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetInvestmentTypes_All`()
BEGIN
	SELECT * FROM InvestmentType;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetInvestmentView`(IN invName varchar(45))
BEGIN
	select * from `fullinvestment_view` where `InvestitionName` = invName;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetUserInvestment`(IN idU INT, idI INT)
BEGIN
	Select * from `UserInvestment` where `idUser` = idU and `idInvestment` = idI;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetUserInvestment_All`()
BEGIN
	SELECT * FROM `UserInvestment`;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updateCurrency`(IN id INT, val decimal(10,2))
BEGIN
	Update `currency` set `value` = val where `idCurrency` = id;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updateDifference`(IN id INT, investmentID INT, amount int)
BEGIN
	UPDATE `UserInvestment`
    SET `difference` = (SELECT difference(`ValuePLN`, investmentID, amount))
    WHERE `idUser` = id AND `idInvestment` = investmentID;
    UPDATE `UserInvestment`
    SET `differenceInP` = (select differenceInP(`ValuePLN`, `difference`)) WHERE `idUser` = id AND `idInvestment` = investmentID;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `withdrawPartOfInvestemnt`(IN idUI int, val double)
BEGIN
	update `userInvestment` set `amount` = `amount` - (val/(select `value` from `Investment` where `Investment`.`idInvestment` = `UserInvestment`.`idInvestment`)), 
    `ValuePLN` = `ValuePLN` - val
    where `idUserInvestment` = idUI;
    
    update `userInvestment` set  `difference` = (select difference(`ValuePLN`, `idInvestment`, `amount`)),
     `differenceInP` = (SELECT differenceInP(`ValuePLN`,  (SELECT difference(`ValuePLN`, `idInvestment`, `amount`))))
     where `idUserInvestment` = idUI;
    
END$$
DELIMITER ;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` FUNCTION `difference`(valB DECIMAL(10,2), idInvestment INT, amount Decimal(10,2)) RETURNS decimal(10,2)
BEGIN
    return (Select GetRealInvestmentValue(idInvestment, amount) - valB);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` FUNCTION `differenceInP`(valB decimal(10,2), diff decimal(10,2)) RETURNS decimal(10,2)
BEGIN
	RETURN 100*((valB + diff)/valB) - 100;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` FUNCTION `GetRealInvestmentValue`(idInv INT, amount decimal(10,2)) RETURNS decimal(10,2)
BEGIN
	declare temp decimal(10,2);
    declare curr decimal(10,2);
    declare result decimal(10,2);
	Set temp = (Select `value` from `Investment` Where `idInvestment` = idInv);
    set curr = (Select `c`.`value` from `Investment` i  inner join `currency` c on c.idCurrency = i.idCurrency where `i`.`idInvestment` = idInv); 
    Set result = amount * temp * curr;
    Return result;
END$$
DELIMITER ;

