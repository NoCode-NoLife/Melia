CREATE TABLE IF NOT EXISTS `cards` (
  `characterId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `sort` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `cards`
  ADD PRIMARY KEY (`characterId`,`itemId`),
  ADD KEY `itemId` (`itemId`);

ALTER TABLE `cards`
  ADD CONSTRAINT `cards_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cards_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `item_properties` (
  `propertyId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


ALTER TABLE `item_properties`
  ADD PRIMARY KEY (`propertyId`),
  ADD KEY `itemId` (`itemId`);


ALTER TABLE `item_properties`
  MODIFY `propertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `item_properties`
  ADD CONSTRAINT `item_properties_ibfk_1` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;