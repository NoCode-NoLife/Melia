CREATE TABLE IF NOT EXISTS `storage_team` (
  `accountId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `position` int(11) NOT NULL,
  PRIMARY KEY (`accountId`, `itemId`),
  KEY `itemId` (`itemId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Drop the first foreign key if it exists
-- ALTER TABLE `storage_team`
-- DROP FOREIGN KEY `storage_team_ibfk_1`;

-- Drop the second foreign key if it exists
-- ALTER TABLE `storage_team`
-- DROP FOREIGN KEY `storage_team_ibfk_2`;

-- Add the first foreign key constraint
ALTER TABLE `storage_team`
ADD CONSTRAINT `storage_team_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

-- Add the second foreign key constraint
ALTER TABLE `storage_team`
ADD CONSTRAINT `storage_team_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;
