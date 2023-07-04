CREATE TABLE `party` (
  `partyId` bigint(20) NOT NULL AUTO_INCREMENT,
  `leaderId` bigint(20) NOT NULL,
  `name` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `characters` ADD `partyId` bigint(20) NOT NULL AFTER `accountId`;

ALTER TABLE `characters`
  ADD CONSTRAINT `party_ibfk_1` FOREIGN KEY (`partyId`) REFERENCES `party` (`partyId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `party`
  ADD CONSTRAINT `party_ibfk_1` FOREIGN KEY (`leaderId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;