-- Add partyId column to characters table for party persistence
ALTER TABLE `characters` ADD COLUMN `partyId` BIGINT NOT NULL DEFAULT '0' AFTER `usedStat`;

-- Create party table for storing party information
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
