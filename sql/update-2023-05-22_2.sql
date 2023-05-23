ALTER TABLE `session_objects_properties` ADD `name` VARCHAR(64) NOT NULL AFTER `propertyId`;
ALTER TABLE `session_objects_properties` ADD `type` VARCHAR(1) NOT NULL AFTER `name`;
UPDATE `session_objects_properties` SET `name` = CAST(`propertyId` AS CHAR(64));
ALTER TABLE `session_objects_properties` DROP `propertyId`;
