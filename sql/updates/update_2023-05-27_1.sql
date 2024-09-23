CREATE TABLE IF NOT EXISTS `friends` (
  `friendId` bigint(20) NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `friendAccountId` bigint(20) NOT NULL,
  `state` tinyint(1) NOT NULL DEFAULT '0',
  `registerDate` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `group` varchar(20) NOT NULL DEFAULT '',
  `note` varchar(20) NOT NULL DEFAULT '',
  PRIMARY KEY (`friendId`),
  UNIQUE KEY `accountId` (`accountId`,`friendAccountId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;
  
ALTER TABLE `friends`
  ADD CONSTRAINT `friends_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;
  
ALTER TABLE `friends`
  ADD CONSTRAINT `friends_ibfk_2` FOREIGN KEY (`friendAccountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;