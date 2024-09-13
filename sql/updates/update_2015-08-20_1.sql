CREATE TABLE IF NOT EXISTS `items` (
  `characterId` bigint(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `sort` int(11) NOT NULL,
  KEY `characterId` (`characterId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `items`
  ADD CONSTRAINT `items_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
