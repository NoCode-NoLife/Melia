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