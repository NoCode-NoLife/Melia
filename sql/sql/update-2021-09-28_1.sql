CREATE TABLE `character_properties` (
  `propertyId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `id` int(11) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


ALTER TABLE `character_properties`
  ADD PRIMARY KEY (`propertyId`),
  ADD KEY `characterId` (`characterId`);


ALTER TABLE `character_properties`
  MODIFY `propertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `character_properties`
  ADD CONSTRAINT `character_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
