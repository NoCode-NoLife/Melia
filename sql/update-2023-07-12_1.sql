ALTER TABLE `accounts`
ADD `loginState` TINYINT NOT NULL DEFAULT '0' AFTER `selectedSlot`,
ADD `loginCharacter` BIGINT NOT NULL DEFAULT '0' AFTER `loginState`;
