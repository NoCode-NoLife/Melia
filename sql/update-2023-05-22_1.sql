ALTER TABLE `character_properties` ADD `name` VARCHAR(64) NOT NULL AFTER `id`;
UPDATE `character_properties` SET `name` = CAST(`id` AS CHAR(64));
ALTER TABLE `character_properties` DROP `id`;
