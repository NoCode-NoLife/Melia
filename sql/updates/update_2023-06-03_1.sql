START TRANSACTION;


-- Add new character vars table
CREATE TABLE `vars_characters` (
  `varId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

ALTER TABLE `vars_characters`
  ADD PRIMARY KEY (`varId`),
  ADD KEY `characterId` (`characterId`);

ALTER TABLE `vars_characters`
  MODIFY `varId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `vars_characters`
  ADD CONSTRAINT `vars_characters_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

-- Remove variables of characters that don't exist anymore
DELETE FROM `vars` WHERE `owner` LIKE "character:%" AND SUBSTRING(`owner`, 11) NOT IN (SELECT `characterId` FROM `characters`);

-- Move remaining variables to new table
INSERT INTO `vars_characters` (`characterId`, `name`, `type`, `value`) SELECT SUBSTRING(`owner`, 11) AS `characterId`, `name`, `type`, `value` FROM `vars` WHERE `owner` LIKE "character:%";

-- Remove old vars
DELETE FROM `vars` WHERE `owner` LIKE "character:%";


-- Add new account vars table
CREATE TABLE `vars_accounts` (
  `varId` bigint(20) NOT NULL,
  `accountId` bigint(20) NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

ALTER TABLE `vars_accounts`
  ADD PRIMARY KEY (`varId`),
  ADD KEY `accountId` (`accountId`);

ALTER TABLE `vars_accounts`
  MODIFY `varId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `vars_accounts`
  ADD CONSTRAINT `vars_accounts_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts`(`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;

-- Remove variables of characters that don't exist anymore
DELETE FROM `vars` WHERE `owner` LIKE "account:%" AND SUBSTRING(`owner`, 9) NOT IN (SELECT `accountId` FROM `characters`);

-- Move remaining variables to new table
INSERT INTO `vars_accounts` (`accountId`, `name`, `type`, `value`) SELECT SUBSTRING(`owner`, 9) AS `accountId`, `name`, `type`, `value` FROM `vars` WHERE `owner` LIKE "account:%";

-- Remove old vars
DELETE FROM `vars` WHERE `owner` LIKE "account:%";


-- Turn vars table in global vars
RENAME TABLE `vars` TO `vars_global`;
ALTER TABLE `vars_global` DROP `owner`;


COMMIT;
