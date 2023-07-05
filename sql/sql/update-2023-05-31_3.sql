CREATE TABLE IF NOT EXISTS `account_properties` (
  `propertyId` bigint(20)  NOT NULL,
  `accountId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `account_properties`
  ADD PRIMARY KEY (`propertyId`),
  ADD KEY `itemId` (`accountId`);

  ALTER TABLE `account_properties`
  MODIFY `propertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `account_properties`
  ADD KEY `account_properties_ibfk_1` (`accountId`);
  
ALTER TABLE `account_properties`
  ADD CONSTRAINT `account_properties_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `item_properties` (
  `propertyId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


ALTER TABLE `item_properties`
  ADD PRIMARY KEY (`propertyId`),
  ADD KEY `itemId` (`itemId`);


ALTER TABLE `item_properties`
  MODIFY `propertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `item_properties`
  ADD CONSTRAINT `item_properties_ibfk_1` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `warehouse` (
  `characterId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `sort` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`characterId`,`itemId`),
  ADD KEY `itemId` (`itemId`);

ALTER TABLE `warehouse`
  ADD CONSTRAINT `warehouse_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `warehouse_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `party` (
  `partyId` bigint(20) NOT NULL AUTO_INCREMENT,
  `leaderId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `note` varchar(64) NOT NULL,
  `dateCreated` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `questSharing` tinyint(1) DEFAULT '1',
  `expDistribution` tinyint(1) DEFAULT '1',
  `itemDistribution` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`partyId`),
  KEY `leaderId` (`leaderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;
  
ALTER TABLE `characters` ADD `partyId` BIGINT NOT NULL DEFAULT '0' AFTER `silver`;

ALTER TABLE `party`
  ADD KEY `party_ibfk_1` (`leaderId`);
  
ALTER TABLE `party`
  ADD CONSTRAINT `party_ibfk_1` FOREIGN KEY (`leaderId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `guild` (
  `guildId` bigint(20) NOT NULL AUTO_INCREMENT,
  `leaderId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `dateCreated` DATETIME DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`guildId`),
  KEY `leaderId` (`leaderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;
  
ALTER TABLE `characters` ADD `guildId` BIGINT NOT NULL DEFAULT '0' AFTER `partyId`;
ALTER TABLE `characters` ADD `sessionKey` varchar(41) DEFAULT '' AFTER `guildId`;

ALTER TABLE `guild`
  ADD KEY `guild_ibfk_1` (`guildId`);
  
ALTER TABLE `guild`
  ADD CONSTRAINT `guild_ibfk_1` FOREIGN KEY (`guildId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `houses` (
  `houseId` bigint(20) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `ownerId` bigint(20) NOT NULL,
  `ownerName` varchar(255) NOT NULL,
  `mapId` int(11) NOT NULL,
  `lastEnterTime` DATETIME NOT NULL,
  PRIMARY KEY (`houseId`),
  KEY `ownerId` (`ownerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `house_props` (
  `propId` bigint(20) NOT NULL AUTO_INCREMENT,
  `houseId` bigint(20) NOT NULL,
  `furnitureId` int(11) NOT NULL,
  `monsterId` int(11) NOT NULL,
  `x` float NOT NULL,
  `y` float NOT NULL,
  `z` float NOT NULL,
  `dir` tinyint(4) NOT NULL,
  PRIMARY KEY (`propId`),
  KEY `houseId` (`houseId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;

ALTER TABLE `characters` ADD `houseId` INT NOT NULL DEFAULT '0' AFTER `guildId`;

ALTER TABLE `houses`
  ADD KEY `houses` (`houseId`);
  
ALTER TABLE `houses`
  ADD CONSTRAINT `house_ibfk_1` FOREIGN KEY (`ownerId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `house_props`
  ADD KEY `house_props` (`propId`);
  
ALTER TABLE `house_props`
  ADD CONSTRAINT `house_props_ibfk_1` FOREIGN KEY (`houseId`) REFERENCES `houses` (`houseId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `market_items` (
  `marketitemUniqueId` bigint(20) NOT NULL AUTO_INCREMENT,
  `itemUniqueId` bigint(20) NOT NULL,
  `sellerId` bigint(20) NOT NULL,
  `buyerId` bigint(20) NOT NULL,
  `price` bigint(20) NOT NULL,	
  `dateRegistered` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `dateExpired` DATETIME NOT NULL,
  `status` tinyint(4) NOT NULL,
  PRIMARY KEY (`marketitemUniqueId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;

ALTER TABLE `market_items`
  ADD KEY `market_items_ibfk_1` (`itemUniqueId`);

ALTER TABLE `market_items`
  ADD CONSTRAINT `market_items_ibfk_1` FOREIGN KEY (`itemUniqueId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `market_items`
  ADD CONSTRAINT `market_items_ibfk_2` FOREIGN KEY (`sellerId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `market_items`
  ADD CONSTRAINT `market_items_ibfk_3` FOREIGN KEY (`buyerId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `help` (
  `characterId` bigint(20) NOT NULL,
  `helpId` smallint(6) NOT NULL,
  `shown` tinyint(1) DEFAULT 0 NOT NULL,
  PRIMARY KEY (`characterId`, `helpId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;

ALTER TABLE `help`
  ADD CONSTRAINT `help_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;