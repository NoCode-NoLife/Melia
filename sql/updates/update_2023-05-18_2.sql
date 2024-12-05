CREATE TABLE IF NOT EXISTS `companions` (
  `companionId` bigint(20) NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `characterId` bigint(20) NULL DEFAULT NULL,
  `monsterId` int(11) NOT NULL,
  `name` varchar(64) NOT NULL,
  `slot` tinyint(1) NOT NULL,
  `barrackLayer` tinyint(1) NOT NULL DEFAULT '1',
  `bx` float NOT NULL,
  `by` float NOT NULL,
  `bz` float NOT NULL,
  `dx` float NOT NULL,
  `dy` float NOT NULL,
  `exp` int(11) NOT NULL DEFAULT '0',
  `stamina` int(11) NOT NULL DEFAULT '60000',
  `adoptTime` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `active` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`companionId`),
  KEY `accountId` (`accountId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

ALTER TABLE `companions`
  ADD CONSTRAINT `companions_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `companions`
  ADD CONSTRAINT `companions_ibfk_2` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE SET NULL ON UPDATE CASCADE;