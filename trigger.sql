CREATE DEFINER=`root`@`localhost` TRIGGER `userinvestment_BEFORE_DELETE` BEFORE DELETE ON `userinvestment` FOR EACH ROW BEGIN
	Insert into `History`(`idUser`, `idInvestment`, `valuePurchased`, `valueSold`, `difference`,`differenceInP`,`datePurchased`, `dateSold`)
    Values(old.idUser, old.idInvestment, old.ValuePLN, 
    GetRealInvestmentValue(old.idInvestment, old.amount), old.difference, old.differenceInP, old.datePurchased, curdate());
END