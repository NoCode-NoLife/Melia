CREATE TABLE IF NOT EXISTS `collections` (
  `accountId` bigint(20) NOT NULL,
  `collectionId` int(11) NOT NULL,
  `itemId` int(11)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `collections` ADD INDEX (`accountId`, `collectionId`);

ALTER TABLE `collections`
  ADD CONSTRAINT `collections_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;