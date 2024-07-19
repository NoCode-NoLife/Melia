CREATE TABLE IF NOT EXISTS `collections` (
  `accountId` bigint(20) NOT NULL,
  `collectionId` int(11) NOT NULL,
  `isComplete` boolean NOT NULL default false,
  `timesRedeemed` tinyint NOT NULL default 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `collections` ADD INDEX (`accountId`, `collectionId`);

CREATE TABLE IF NOT EXISTS `collection_items` (
  `accountId` bigint(20) NOT NULL,
  `collectionId` int(11) NOT NULL,
  `itemId` int(11)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `collection_items` ADD INDEX (`accountId`, `collectionId`);

ALTER TABLE `collection_items`
  ADD CONSTRAINT `collection_item_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;