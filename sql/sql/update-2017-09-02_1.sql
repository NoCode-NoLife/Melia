CREATE TABLE IF NOT EXISTS `chatMacros` (
  `chatMacroId` bigint(20) NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `index` tinyint(4) NOT NULL,
  `message` varchar(128) NOT NULL,
  `pose` tinyint(4) NOT NULL DEFAULT 0,
  PRIMARY KEY (`chatMacroId`),
  CONSTRAINT `FK_ChatMacro_accountId` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE,
  CONSTRAINT `UQ_ChatMacro_index` UNIQUE (`accountId`, `index`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;
