ALTER TABLE `characters` ADD `bd` FLOAT NOT NULL AFTER `bz`;
UPDATE `characters` SET `bd` = FLOOR(RAND() * 180);
