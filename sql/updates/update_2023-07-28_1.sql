CREATE TABLE IF NOT EXISTS `mail` (
  `mailId` bigint(20)  NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `status` tinyint(4) NOT NULL,
  `sender` varchar(128) NOT NULL,
  `subject` varchar(128) NOT NULL,
  `message` varchar(2048) DEFAULT NULL,
  `startDate` datetime DEFAULT '2016-04-01 00:00:00',
  `expirationDate` datetime DEFAULT '2038-01-01 00:00:00',
  `createdDate` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`mailId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `mail`
  ADD KEY `mail_ibfk_1` (`accountId`);
  
ALTER TABLE `mail`
  ADD CONSTRAINT `mail_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `mail_items` (
  `mailItemId` bigint(20) NOT NULL AUTO_INCREMENT,
  `mailId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `id` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `status` tinyint(4) NOT NULL,
  PRIMARY KEY (`mailItemId`),
  KEY `mailId` (`mailId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

ALTER TABLE `mail_items`
  ADD KEY `mail_items_ibfk_1` (`mailId`);
  
ALTER TABLE `mail_items`
  ADD CONSTRAINT `mail_items_ibfk_1` FOREIGN KEY (`mailId`) REFERENCES `mail` (`mailId`) ON DELETE CASCADE ON UPDATE CASCADE;