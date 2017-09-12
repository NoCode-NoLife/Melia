CREATE TABLE `session_objects_properties` (
  `sessionObjectPropertyId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `sessionObjectId` int(11) NOT NULL,
  `propertyId` int(11) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `session_objects_properties`
  ADD PRIMARY KEY (`sessionObjectPropertyId`),
  ADD KEY `characterId` (`characterId`);

ALTER TABLE `session_objects_properties`
  MODIFY `sessionObjectPropertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `session_objects_properties`
  ADD CONSTRAINT `session_object_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
