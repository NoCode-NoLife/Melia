CREATE TABLE `storage_team` (
  `accountId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `position` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

ALTER TABLE `storage_team`
  ADD PRIMARY KEY (`accountId`,`itemId`),
  ADD KEY `itemId` (`itemId`);

ALTER TABLE `storage_team`
  ADD CONSTRAINT `storage_team_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `storage_team_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;
