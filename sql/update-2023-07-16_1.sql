CREATE TABLE `storage_personal` (
  `characterId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `position` int(11) NOT NULL,
  PRIMARY KEY (`characterId`,`itemId`),
  KEY `itemId` (`itemId`),
  CONSTRAINT `storage_personal_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `storage_personal_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
SELECT * FROM melia.inventory;