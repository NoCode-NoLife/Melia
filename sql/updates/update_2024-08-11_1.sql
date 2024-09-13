CREATE TABLE `character_etc_properties` (
  `propertyId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

ALTER TABLE `character_etc_properties`
  ADD PRIMARY KEY (`propertyId`),
  ADD KEY `characterId` (`characterId`);

ALTER TABLE `character_etc_properties`
  MODIFY `propertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `character_etc_properties`
  ADD CONSTRAINT `character_etc_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `character_etc_properties_ibfk_2` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
