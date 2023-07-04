CREATE TABLE IF NOT EXISTS `party` (
  `partyId` bigint(20) NOT NULL AUTO_INCREMENT,
  `leaderId` bigint(20) NOT NULL,
  `leaderTeamName` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
  `name` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
  `description` varchar(255) NOT NULL,
  `creationTime` datetime NOT NULL,
  PRIMARY KEY (`partyId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;

ALTER TABLE `accounts` ADD `partyId` bigint(20) NOT NULL DEFAULT '0' AFTER `accountId`;

ALTER TABLE `party`
  ADD CONSTRAINT `party_ibfk_1` FOREIGN KEY (`leaderId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `accounts`
  ADD CONSTRAINT `accounts_ibfk_1` FOREIGN KEY (`partyId`) REFERENCES `party` (`partyId`) ON DELETE CASCADE ON UPDATE CASCADE;