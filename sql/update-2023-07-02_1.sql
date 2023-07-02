CREATE TABLE `party` (
  `partyId` bigint(20) NOT NULL AUTO_INCREMENT;
  `name` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `party_member` (
  `partyMemberId` bigint(20) NOT NULL AUTO_INCREMENT;
  `partyId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

ALTER TABLE `party_member`
  ADD CONSTRAINT `party_member_ibfk_1` FOREIGN KEY (`partyId`) REFERENCES `party` (`partyId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `party_member`
  ADD CONSTRAINT `party_member_ibfk_2` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;