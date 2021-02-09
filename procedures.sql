DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addInvestment`(IN idInvType INT, val DECIMAL(10,2), invName VARCHAR(45), dataS VARCHAR(100), INOUT id INT)
BEGIN
	INSERT INTO `investment` (`idInvestmentType`, `value`, `invName`, `dataSource`)
    VALUES (idInvType, val, invName, dataS);
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `addUserInvestment`(IN idUser INT, idInvestment INT, datePurchased DATETIME, valPurchased DECIMAL(10,2))
BEGIN
	INSERT INTO `UserInvestment`(`idUser`, `idInvestment`, `datePurchased`, `valuePurchased`, `diffrence`)
    VALUES (idUser, idInvestment, datePurchased, valPurchased, (SELECT diffrence(valPurchased, (SELECT `value` FROM `Investment` WHERE `idInvestment` = idInvestment))));
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `editInvestmentValue`(IN id INT, val DECIMAL(10,2))
BEGIN
	UPDATE `Investment` SET `value` = val WHERE `idInvestment` = id;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updateDifference`(IN id INT, investmentID INT)
BEGIN
	UPDATE `UserInvestment`
    SET diffrenece = (SELECT diffrence(`valuePurchased`, (SELECT `value` FROM `Investment` WHERE `idInvestment` = idInvestment)))
    WHERE `idUser` = id AND `idInvestment` = investmentID;
END$$
DELIMITER ;




