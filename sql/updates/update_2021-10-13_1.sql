CREATE TABLE `inventory` (
  `characterId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `sort` int(11) NOT NULL,
  `equipSlot` tinyint(4) NOT NULL DEFAULT '127'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TRIGGER `cascadeDeleteItem` AFTER DELETE ON `inventory` FOR EACH ROW
	DELETE FROM `items` WHERE `itemUniqueId` = OLD.`itemId`;

ALTER TABLE `inventory`
  ADD PRIMARY KEY (`characterId`,`itemId`),
  ADD KEY `itemId` (`itemId`);

ALTER TABLE `inventory`
  ADD CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;

INSERT INTO `inventory` (SELECT `characterId`, `itemUniqueId` AS `itemId`, `sort`, `equipSlot` FROM `items`);
ALTER TABLE `items` DROP FOREIGN KEY `items_ibfk_1`;
ALTER TABLE `items` DROP `characterId`;
ALTER TABLE `items` DROP `sort`;
ALTER TABLE `items` DROP `equipSlot`;
