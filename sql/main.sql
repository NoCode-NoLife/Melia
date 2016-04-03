CREATE DATABASE IF NOT EXISTS `melia` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `melia`;

CREATE TABLE IF NOT EXISTS `accounts` (
  `accountId` bigint(20) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL,
  `teamName` varchar(64) NULL,
  `authority` int(11) NOT NULL DEFAULT '0',
  `settings` varchar(512) NOT NULL DEFAULT '',
  PRIMARY KEY (`accountId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `characters` (
  `characterId` bigint(20) NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `teamName` varchar(32) NULL,
  `job` smallint(6) NOT NULL,
  `gender` tinyint(4) NOT NULL,
  `hair` tinyint(4) NOT NULL,
  `level` int(11) NOT NULL DEFAULT '1',
  `bx` float NOT NULL,
  `by` float NOT NULL,
  `bz` float NOT NULL,
  `zone` int(11) NOT NULL,
  `x` float NOT NULL,
  `y` float NOT NULL,
  `z` float NOT NULL,
  `exp` int(11) NOT NULL DEFAULT '0',
  `maxExp` int(11) NOT NULL DEFAULT '1000',
  `hp` int(11) NOT NULL DEFAULT '100',
  `maxHp` int(11) NOT NULL DEFAULT '100',
  `sp` int(11) NOT NULL DEFAULT '50',
  `maxSp` int(11) NOT NULL DEFAULT '50',
  `stamina` int(11) NOT NULL DEFAULT '25000',
  `maxStamina` int(11) NOT NULL DEFAULT '25000',
  `str` float NOT NULL DEFAULT '1',
  `con` float NOT NULL DEFAULT '1',
  `int` float NOT NULL DEFAULT '1',
  `spr` float NOT NULL DEFAULT '1',
  `dex` float NOT NULL DEFAULT '1',
  `statByLevel` float NOT NULL DEFAULT '0',
  `statByBonus` float NOT NULL DEFAULT '0',
  `usedStat` float NOT NULL DEFAULT '0',
  PRIMARY KEY (`characterId`),
  KEY `accountId` (`accountId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `items` (
  `itemUniqueId` bigint(20) NOT NULL AUTO_INCREMENT,
  `characterId` bigint(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `sort` int(11) NOT NULL,
  `equipSlot` tinyint(4) NOT NULL DEFAULT '127',
  PRIMARY KEY (`itemUniqueId`),
  KEY `characterId` (`characterId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `skills` (
  `skillUniqueId` bigint(20) NOT NULL,
  `characterId` bigint(11) NOT NULL,
  `jobId` int(5) NOT NULL,
  `skillId` int(11) NOT NULL,
  `level` smallint(4) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

ALTER TABLE `characters`
  ADD CONSTRAINT `characters_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `items`
  ADD CONSTRAINT `items_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `skills`
  ADD CONSTRAINT `skills_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

