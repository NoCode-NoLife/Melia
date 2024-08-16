CREATE TABLE IF NOT EXISTS `guild` (
  `guildId` bigint(20) NOT NULL AUTO_INCREMENT,
  `leaderId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `dateCreated` DATETIME DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`guildId`),
  KEY `leaderId` (`leaderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

ALTER TABLE `characters` ADD `guildId` BIGINT NOT NULL DEFAULT '0' AFTER `partyId`;

ALTER TABLE `guild`
  ADD KEY `guild_ibfk_1` (`guildId`);

ALTER TABLE `guild`
  ADD CONSTRAINT `guild_ibfk_1` FOREIGN KEY (`guildId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;