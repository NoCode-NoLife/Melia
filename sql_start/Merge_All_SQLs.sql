CREATE DATABASE IF NOT EXISTS `melia` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

USE `melia`;

CREATE TABLE IF NOT EXISTS `accounts` (
  `accountId` bigint(20) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL,
  `teamName` varchar(64) DEFAULT NULL,
  `authority` int(11) NOT NULL DEFAULT '0',
  `settings` varchar(512) NOT NULL DEFAULT '',
  PRIMARY KEY (`accountId`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8 AUTO_INCREMENT = 1;

CREATE TABLE IF NOT EXISTS `characters` (
  `characterId` bigint(20) NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `teamName` varchar(32) DEFAULT NULL,
  `job` smallint(6) NOT NULL,
  `gender` tinyint(4) NOT NULL,
  `hair` tinyint(4) NOT NULL,
  `level` int(11) NOT NULL DEFAULT '1',
  `bx` float NOT NULL,
  `by` float NOT NULL,
  `bz` float NOT NULL,
  `zone` int(11) NOT NULL,
  `x` float NOT NULL,
  `y` float NOT NULL,
  `z` float NOT NULL,
  `exp` int(11) NOT NULL DEFAULT '0',
  `maxExp` int(11) NOT NULL DEFAULT '1000',
  `hp` int(11) NOT NULL DEFAULT '100',
  `maxHp` int(11) NOT NULL DEFAULT '100',
  `sp` int(11) NOT NULL DEFAULT '50',
  `maxSp` int(11) NOT NULL DEFAULT '50',
  `stamina` int(11) NOT NULL DEFAULT '25000',
  `maxStamina` int(11) NOT NULL DEFAULT '25000',
  `str` float NOT NULL DEFAULT '1',
  `con` float NOT NULL DEFAULT '1',
  `int` float NOT NULL DEFAULT '1',
  `spr` float NOT NULL DEFAULT '1',
  `dex` float NOT NULL DEFAULT '1',
  `statByLevel` float NOT NULL DEFAULT '0',
  `statByBonus` float NOT NULL DEFAULT '0',
  `usedStat` float NOT NULL DEFAULT '0',
  PRIMARY KEY (`characterId`),
  KEY `accountId` (`accountId`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8 AUTO_INCREMENT = 1;

CREATE TABLE IF NOT EXISTS `items` (
  `itemUniqueId` bigint(20) NOT NULL AUTO_INCREMENT,
  `characterId` bigint(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `sort` int(11) NOT NULL,
  `equipSlot` tinyint(4) NOT NULL DEFAULT '127',
  PRIMARY KEY (`itemUniqueId`),
  KEY `characterId` (`characterId`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8 AUTO_INCREMENT = 1;

CREATE TABLE IF NOT EXISTS `updates` (
  `path` varchar(255) NOT NULL,
  PRIMARY KEY (`path`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

INSERT INTO
  `updates` (`path`)
VALUES
  ('main.sql'),
  ('update-2017-09-01_1.sql'),
  ('update-2017-09-02_1.sql'),
  ('update-2017-09-04_1.sql'),
  ('update-2017-09-12_1.sql'),
  ('update-2017-09-14_1.sql'),
  ('update-2017-09-19_1.sql'),
  ('update-2017-09-19_2.sql'),
  ('update-2017-09-19_3.sql'),
  ('update-2017-09-25_1.sql'),
  ('update-2017-09-26_1.sql'),
  ('update-2017-09-28_1.sql'),
  ('update-2017-09-29_1.sql'),
  ('update-2017-10-31_1.sql'),
  ('update-2021-09-08_1.sql'),
  ('update-2021-09-14_1.sql'),
  ('update-2021-09-28_1.sql'),
  ('update-2021-10-07_1.sql'),
  ('update-2021-10-07_2.sql'),
  ('update-2021-10-13_1.sql'),
  ('update-2023-05-10_1.sql'),
  ('update-2023-05-11_1.sql'),
  ('update-2023-05-21_1.sql'),
  ('update-2023-05-22_1.sql'),
  ('update-2023-05-22_2.sql'),
  ('update-2023-05-23_1.sql'),
  ('update-2023-05-25_1.sql'),
  ('update-2023-05-25_2.sql'),
  ('update-2023-05-29_1.sql'),
  ('update-2023-05-31_1.sql'),
  ('update-2023-05-31_2.sql'),
  ('update-2023-06-01_1.sql'),
  ('update-2023-06-02_1.sql'),
  ('update-2023-06-03_1.sql'),
  ('update-2023-06-03_2.sql'),
  ('update-2023-06-26_1.sql'),
  ('update-2023-06-27_1.sql'),
  ('update-2023-06-30_1.sql'),
  ('update-2023-07-03_1.sql'),
  ('update-2023-07-03_2.sql'),
  ('update-2023-07-12_1.sql'),
  ('update-2023-07-15_1.sql'),
  ('update-2024-03-11_1.sql'),
  ('update_2015-08-17_1.sql'),
  ('update_2015-08-17_2.sql'),
  ('update_2015-08-17_3.sql'),
  ('update_2015-08-20_1.sql'),
  ('update_2015-08-20_2.sql'),
  ('update_2015-08-27_1.sql'),
  ('update_2015-09-03_1.sql'),
  ('update_2015-09-16_1.sql'),
  ('update_2015-12-12_1.sql'),
  ('update_2016-04-01_1.sql'),
  ('update_2016-04-02_1.sql'),
  ('update_2016-04-03_1.sql'),
  ('update_2016-04-11_1.sql'),
  ('update_2016-04-23_1.sql'),
  ('update_2017-09-03_1.sql');

ALTER TABLE
  `characters`
ADD
  CONSTRAINT `characters_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE IF NOT EXISTS `items` (
  `characterId` bigint(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `sort` int(11) NOT NULL,
  KEY `characterId` (`characterId`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `items`
ADD
  CONSTRAINT `items_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

UPDATE
  `characters`
SET
  `stamina` = 25000
WHERE
  `stamina` = 50000;

ALTER TABLE
  `characters` CHANGE `stamina` `stamina` INT(11) NOT NULL DEFAULT '25000';

ALTER TABLE
  `accounts`
MODIFY
  COLUMN `teamName` varchar(64) NULL;

ALTER TABLE
  `characters`
MODIFY
  COLUMN `teamName` varchar(32) NULL;

CREATE TABLE IF NOT EXISTS `updates` (
  `path` varchar(255) NOT NULL,
  PRIMARY KEY (`path`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

CREATE TABLE IF NOT EXISTS `vars` (
  `varId` bigint(20) NOT NULL AUTO_INCREMENT,
  `owner` varchar(128) NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL,
  PRIMARY KEY (`varId`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8 AUTO_INCREMENT = 1;

ALTER TABLE
  `accounts` CHANGE `password` `password` VARCHAR(64) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL;

ALTER TABLE
  `characters`
ADD
  COLUMN `barrackLayer` INT NOT NULL DEFAULT 1;

CREATE TABLE IF NOT EXISTS `chatmacros` (
  `chatMacroId` bigint(20) NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `index` tinyint(4) NOT NULL,
  `message` varchar(128) NOT NULL,
  `pose` tinyint(4) NOT NULL DEFAULT 0,
  PRIMARY KEY (`chatMacroId`),
  CONSTRAINT `FK_ChatMacro_accountId` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE,
  CONSTRAINT `UQ_ChatMacro_index` UNIQUE (`accountId`, `index`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8 AUTO_INCREMENT = 1;

CREATE TABLE IF NOT EXISTS `revealedmaps` (
  `revealedMapId` bigint(20) NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `map` int(11) NOT NULL,
  `explored` varbinary(128) NOT NULL,
  `percentage` FLOAT(10, 2) NOT NULL DEFAULT 0,
  PRIMARY KEY (`revealedMapId`),
  CONSTRAINT `FK_revealedMaps_accountId` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE,
  CONSTRAINT `UQ_revealedMaps_map` UNIQUE (`accountId`, `map`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8 AUTO_INCREMENT = 1;

ALTER TABLE
  `accounts`
ADD
  `medals` INT NOT NULL DEFAULT 0;

ALTER TABLE
  `accounts`
ADD
  `giftMedals` INT NOT NULL DEFAULT 0;

ALTER TABLE
  `accounts`
ADD
  `premiumMedals` INT NOT NULL DEFAULT 0;

CREATE TABLE `session_objects_properties` (
  `sessionObjectPropertyId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `sessionObjectId` int(11) NOT NULL,
  `propertyId` int(11) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `session_objects_properties`
ADD
  PRIMARY KEY (`sessionObjectPropertyId`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `session_objects_properties`
MODIFY
  `sessionObjectPropertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `session_objects_properties`
ADD
  CONSTRAINT `session_object_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE `jobs` (
  `characterId` bigint(20) NOT NULL,
  `jobId` int(11) NOT NULL,
  `circle` int(11) NOT NULL DEFAULT '1',
  `skillPoints` int(11) NOT NULL DEFAULT '0'
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `jobs`
ADD
  PRIMARY KEY (`characterId`, `jobId`);

ALTER TABLE
  `jobs`
ADD
  CONSTRAINT `jobs_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `characters` CHANGE `str` `str` INT NOT NULL DEFAULT '1',
  CHANGE `con` `con` INT NOT NULL DEFAULT '1',
  CHANGE `int` `int` INT NOT NULL DEFAULT '1',
  CHANGE `spr` `spr` INT NOT NULL DEFAULT '1',
  CHANGE `dex` `dex` INT NOT NULL DEFAULT '1',
  CHANGE `statByLevel` `statByLevel` INT NOT NULL DEFAULT '0',
  CHANGE `statByBonus` `statByBonus` INT NOT NULL DEFAULT '0',
  CHANGE `usedStat` `usedStat` INT NOT NULL DEFAULT '0';

ALTER TABLE
  `characters` CHANGE `barrackLayer` `barrackLayer` INT(11) NOT NULL DEFAULT '1'
AFTER
  `level`;

ALTER TABLE
  `characters`
ADD
  `abilityPoints` INT NOT NULL DEFAULT '0'
AFTER
  `usedStat`;

CREATE TABLE `skills` (
  `skillId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `id` int(11) NOT NULL,
  `level` int(11) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `skills`
ADD
  PRIMARY KEY (`skillId`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `skills`
MODIFY
  `skillId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `skills`
ADD
  CONSTRAINT `skills_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE `abilities` (
  `abilityId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `id` int(11) NOT NULL,
  `level` int(11) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `abilities`
ADD
  PRIMARY KEY (`abilityId`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `abilities`
MODIFY
  `abilityId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `abilities`
ADD
  FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `characters`
ADD
  `totalExp` INT NOT NULL DEFAULT '0'
AFTER
  `maxExp`;

ALTER TABLE
  `jobs`
ADD
  `totalExp` INT NOT NULL DEFAULT '0'
AFTER
  `skillPoints`;

ALTER TABLE
  `characters`
ADD
  `hpRate` FLOAT NOT NULL DEFAULT '1'
AFTER
  `hp`,
ADD
  `spRate` FLOAT NOT NULL DEFAULT '1'
AFTER
  `sp`,
ADD
  `strByJob` INT NOT NULL DEFAULT '0'
AFTER
  `str`,
ADD
  `conByJob` INT NOT NULL DEFAULT '0'
AFTER
  `con`,
ADD
  `intByJob` INT NOT NULL DEFAULT '0'
AFTER
  `int`,
ADD
  `sprByJob` INT NOT NULL DEFAULT '0'
AFTER
  `spr`,
ADD
  `dexByJob` INT NOT NULL DEFAULT '0'
AFTER
  `dex`,
ADD
  `staminaByJob` INT NOT NULL DEFAULT '0'
AFTER
  `stamina`,
  CHANGE `str` `str` INT NOT NULL DEFAULT '0',
  CHANGE `con` `con` INT NOT NULL DEFAULT '0',
  CHANGE `int` `int` INT NOT NULL DEFAULT '0',
  CHANGE `spr` `spr` INT NOT NULL DEFAULT '0',
  CHANGE `dex` `dex` INT NOT NULL DEFAULT '0';

ALTER TABLE
  `characters` CHANGE `hair` `hair` INT NOT NULL;

ALTER TABLE
  `characters`
ADD
  `slot` INT NOT NULL
AFTER
  `level`;

CREATE TABLE `character_properties` (
  `propertyId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `id` int(11) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `character_properties`
ADD
  PRIMARY KEY (`propertyId`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `character_properties`
MODIFY
  `propertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `character_properties`
ADD
  CONSTRAINT `character_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `accounts`
ADD
  `additionalSlotCount` INT NOT NULL DEFAULT '0'
AFTER
  `premiumMedals`;

ALTER TABLE
  `accounts`
ADD
  `teamExp` INT NOT NULL DEFAULT '0'
AFTER
  `additionalSlotCount`;

ALTER TABLE
  `characters`
ADD
  `silver` BIGINT NOT NULL DEFAULT '0'
AFTER
  `abilityPoints`;

CREATE TABLE `inventory` (
  `characterId` bigint(20) NOT NULL,
  `itemId` bigint(20) NOT NULL,
  `sort` int(11) NOT NULL,
  `equipSlot` tinyint(4) NOT NULL DEFAULT '127'
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

CREATE TRIGGER `cascadeDeleteItem`
AFTER
  DELETE ON `inventory` FOR EACH ROW
DELETE FROM
  `items`
WHERE
  `itemUniqueId` = OLD.`itemId`;

ALTER TABLE
  `inventory`
ADD
  PRIMARY KEY (`characterId`, `itemId`),
ADD
  KEY `itemId` (`itemId`);

ALTER TABLE
  `inventory`
ADD
  CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD
  CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE;

INSERT INTO
  `inventory` (
    SELECT
      `characterId`,
      `itemUniqueId` AS `itemId`,
      `sort`,
      `equipSlot`
    FROM
      `items`
  );

ALTER TABLE
  `items` DROP FOREIGN KEY `items_ibfk_1`;

ALTER TABLE
  `items` DROP `characterId`;

ALTER TABLE
  `items` DROP `sort`;

ALTER TABLE
  `items` DROP `equipSlot`;

ALTER TABLE
  `accounts` CHANGE `settings` `settings` VARCHAR(2048) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '';

ALTER TABLE
  `jobs`
ADD
  FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

DELETE FROM
  `character_properties`
WHERE
  `characterId` NOT IN (
    SELECT
      `characterId`
    FROM
      `characters`
  );

DELETE FROM
  `skills`
WHERE
  `characterId` NOT IN (
    SELECT
      `characterId`
    FROM
      `characters`
  );

ALTER TABLE
  `character_properties`
ADD
  FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `chatmacros`
ADD
  FOREIGN KEY (`accountId`) REFERENCES `accounts`(`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `revealedmaps`
ADD
  FOREIGN KEY (`accountId`) REFERENCES `accounts`(`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `session_objects_properties`
ADD
  FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `skills`
ADD
  FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `character_properties`
ADD
  `name` VARCHAR(64) NOT NULL
AFTER
  `id`;

UPDATE
  `character_properties`
SET
  `name` = CAST(`id` AS CHAR(64));

ALTER TABLE
  `character_properties` DROP `id`;

ALTER TABLE
  `session_objects_properties`
ADD
  `name` VARCHAR(64) NOT NULL
AFTER
  `propertyId`;

ALTER TABLE
  `session_objects_properties`
ADD
  `type` VARCHAR(1) NOT NULL
AFTER
  `name`;

UPDATE
  `session_objects_properties`
SET
  `name` = CAST(`propertyId` AS CHAR(64));

ALTER TABLE
  `session_objects_properties` DROP `propertyId`;

ALTER TABLE
  `characters`
ADD
  `bd` FLOAT NOT NULL
AFTER
  `bz`;

UPDATE
  `characters`
SET
  `bd` = FLOOR(RAND() * 180);

ALTER TABLE
  `accounts`
ADD
  `barracksThema` INT NOT NULL DEFAULT '11'
AFTER
  `teamExp`;

ALTER TABLE
  `accounts`
ADD
  `themas` VARCHAR(128) NOT NULL DEFAULT '11'
AFTER
  `barracksThema`;

ALTER TABLE
  `characters` CHANGE `exp` `exp` BIGINT NOT NULL DEFAULT '0',
  CHANGE `maxExp` `maxExp` BIGINT NOT NULL DEFAULT '1000',
  CHANGE `totalExp` `totalExp` BIGINT NOT NULL DEFAULT '0';

ALTER TABLE
  `jobs` CHANGE `totalExp` `totalExp` BIGINT NOT NULL DEFAULT '0';

UPDATE
  `vars`
SET
  `name` = "Melia.PropertiesInitialized"
WHERE
  `name` = "PropertiesInitialized";

UPDATE
  `vars`
SET
  `name` = "Melia.QuickSlotList"
WHERE
  `name` = "_QuickSlotList";

DELETE FROM
  `vars`
WHERE
  `name` = "Melia.QuickSlotList";

ALTER TABLE
  `accounts`
ADD
  `selectedSlot` TINYINT NOT NULL DEFAULT '0'
AFTER
  `themas`;

ALTER TABLE
  `characters`
ADD
  `equipVisibility` INT NOT NULL DEFAULT 0xFFFF
AFTER
  `silver`;

START TRANSACTION;

-- Add new character vars table
CREATE TABLE `vars_characters` (
  `varId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8 ROW_FORMAT = COMPACT;

ALTER TABLE
  `vars_characters`
ADD
  PRIMARY KEY (`varId`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `vars_characters`
MODIFY
  `varId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `vars_characters`
ADD
  CONSTRAINT `vars_characters_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

-- Remove variables of characters that don't exist anymore
DELETE FROM
  `vars`
WHERE
  `owner` LIKE "character:%"
  AND SUBSTRING(`owner`, 11) NOT IN (
    SELECT
      `characterId`
    FROM
      `characters`
  );

-- Move remaining variables to new table
INSERT INTO
  `vars_characters` (`characterId`, `name`, `type`, `value`)
SELECT
  SUBSTRING(`owner`, 11) AS `characterId`,
  `name`,
  `type`,
  `value`
FROM
  `vars`
WHERE
  `owner` LIKE "character:%";

-- Remove old vars
DELETE FROM
  `vars`
WHERE
  `owner` LIKE "character:%";

-- Add new account vars table
CREATE TABLE `vars_accounts` (
  `varId` bigint(20) NOT NULL,
  `accountId` bigint(20) NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8 ROW_FORMAT = COMPACT;

ALTER TABLE
  `vars_accounts`
ADD
  PRIMARY KEY (`varId`),
ADD
  KEY `accountId` (`accountId`);

ALTER TABLE
  `vars_accounts`
MODIFY
  `varId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `vars_accounts`
ADD
  CONSTRAINT `vars_accounts_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `characters` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

-- Remove variables of characters that don't exist anymore
DELETE FROM
  `vars`
WHERE
  `owner` LIKE "account:%"
  AND SUBSTRING(`owner`, 9) NOT IN (
    SELECT
      `accountId`
    FROM
      `characters`
  );

-- Move remaining variables to new table
INSERT INTO
  `vars_accounts` (`accountId`, `name`, `type`, `value`)
SELECT
  SUBSTRING(`owner`, 9) AS `accountId`,
  `name`,
  `type`,
  `value`
FROM
  `vars`
WHERE
  `owner` LIKE "account:%";

-- Remove old vars
DELETE FROM
  `vars`
WHERE
  `owner` LIKE "account:%";

-- Turn vars table in global vars
RENAME TABLE `vars` TO `vars_global`;

ALTER TABLE
  `vars_global` DROP `owner`;

COMMIT;

CREATE TABLE `buffs` (
  `buffId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `classId` int(11) NOT NULL,
  `numArg1` int(11) NOT NULL,
  `numArg2` int(11) NOT NULL,
  `remainingDuration` time NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `buffs`
ADD
  PRIMARY KEY (`buffId`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `buffs`
MODIFY
  `buffId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `buffs`
ADD
  CONSTRAINT `buffs_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE `cooldowns` (
  `cooldownId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `classId` int(11) NOT NULL,
  `remaining` time NOT NULL,
  `duration` time NOT NULL,
  `startTime` datetime NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `cooldowns`
ADD
  PRIMARY KEY (`cooldownId`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `cooldowns`
MODIFY
  `cooldownId` bigint(20) NOT NULL AUTO_INCREMENT,
  AUTO_INCREMENT = 13;

ALTER TABLE
  `cooldowns`
ADD
  CONSTRAINT `cooldowns_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE `vars_buffs` (
  `varId` bigint(20) NOT NULL,
  `buffId` bigint(20) NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8 ROW_FORMAT = COMPACT;

ALTER TABLE
  `vars_buffs`
ADD
  PRIMARY KEY (`varId`),
ADD
  KEY `characterId` (`buffId`);

ALTER TABLE
  `vars_buffs`
MODIFY
  `varId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `vars_buffs`
ADD
  CONSTRAINT `vars_buffs_ibfk_1` FOREIGN KEY (`buffId`) REFERENCES `buffs` (`buffId`) ON DELETE CASCADE ON UPDATE CASCADE;

CREATE TABLE `quests` (
  `questId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `classId` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `startTime` datetime NOT NULL,
  `completeTime` datetime NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

CREATE TABLE `quests_progress` (
  `questId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `ident` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
  `count` int(11) NOT NULL,
  `done` tinyint(1) NOT NULL,
  `unlocked` tinyint(1) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8 ROW_FORMAT = COMPACT;

ALTER TABLE
  `quests`
ADD
  PRIMARY KEY (`questId`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `quests_progress`
ADD
  PRIMARY KEY (`questId`, `ident`),
ADD
  KEY `characterId` (`characterId`);

ALTER TABLE
  `quests`
MODIFY
  `questId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `quests`
ADD
  CONSTRAINT `quests_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `quests_progress`
ADD
  CONSTRAINT `quests_progress_ibfk_1` FOREIGN KEY (`questId`) REFERENCES `quests` (`questId`) ON DELETE CASCADE ON UPDATE CASCADE;

START TRANSACTION;

DELETE FROM
  `abilities`
WHERE
  `characterId` NOT IN (
    SELECT
      `characterId`
    FROM
      `characters`
  );

ALTER TABLE
  `abilities`
ADD
  FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

COMMIT;

ALTER TABLE
  `abilities`
ADD
  `active` BOOLEAN NOT NULL DEFAULT TRUE
AFTER
  `level`;

ALTER TABLE
  `accounts`
ADD
  `loginState` TINYINT NOT NULL DEFAULT '0'
AFTER
  `selectedSlot`,
ADD
  `loginCharacter` BIGINT NOT NULL DEFAULT '0'
AFTER
  `loginState`;

CREATE TABLE `account_properties` (
  `propertyId` bigint(20) NOT NULL,
  `accountId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

ALTER TABLE
  `account_properties`
ADD
  PRIMARY KEY (`propertyId`),
ADD
  KEY `accountId` (`accountId`);

ALTER TABLE
  `account_properties`
MODIFY
  `propertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE
  `account_properties`
ADD
  CONSTRAINT `account_properties_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE
  `characters`
ADD
  `skinColor` INT UNSIGNED NOT NULL DEFAULT 0xFF808080
AFTER
  `hair`;