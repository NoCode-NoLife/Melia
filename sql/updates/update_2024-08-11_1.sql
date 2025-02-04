CREATE TABLE IF NOT EXISTS `character_etc_properties` (
  `propertyId` bigint(20) NOT NULL AUTO_INCREMENT,
  `characterId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL,
  PRIMARY KEY (`propertyId`),
  KEY `characterId` (`characterId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- Drop the foreign key if it exists
-- ALTER TABLE `character_etc_properties`
-- DROP FOREIGN KEY `character_etc_properties_ibfk_1`;

-- Add the foreign key constraint again
ALTER TABLE `character_etc_properties`
ADD CONSTRAINT `character_etc_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
