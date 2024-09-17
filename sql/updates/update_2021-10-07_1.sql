ALTER TABLE `accounts` ADD `additionalSlotCount` INT NOT NULL DEFAULT '0' AFTER `premiumMedals`;
ALTER TABLE `accounts` ADD `teamExp` INT NOT NULL DEFAULT '0' AFTER `additionalSlotCount`;
