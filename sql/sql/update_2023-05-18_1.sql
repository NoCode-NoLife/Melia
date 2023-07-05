CREATE TABLE `mail` (
  `mailId` bigint(20)  NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `status` tinyint(4) NOT NULL,
  `sender` varchar(128) NOT NULL,
  `subject` varchar(128) NOT NULL,
  `message` varchar(2048) DEFAULT NULL,
  `startDate` datetime DEFAULT '1900-01-01 00:00:00',
  `expirationDate` datetime DEFAULT NULL,
  `createdDate` datetime DEFAULT NULL,
  PRIMARY KEY (`mailId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `mail`
  ADD KEY `mail_ibfk_1` (`accountId`);
  
ALTER TABLE `mail`
  ADD CONSTRAINT `mail_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `mail_items` (
  `mailItemUniqueId` bigint(20) NOT NULL AUTO_INCREMENT,
  `mailId` bigint(20) NOT NULL,
  `itemId` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `status` tinyint(4) NOT NULL,
  PRIMARY KEY (`mailItemUniqueId`),
  KEY `mailId` (`mailId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

ALTER TABLE `mail_items`
  ADD KEY `mail_items_ibfk_1` (`mailId`);
  
ALTER TABLE `mail_items`
  ADD CONSTRAINT `mail_items_ibfk_1` FOREIGN KEY (`mailId`) REFERENCES `mail` (`mailId`) ON DELETE CASCADE ON UPDATE CASCADE;