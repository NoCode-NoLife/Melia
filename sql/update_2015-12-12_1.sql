UPDATE `characters` SET `stamina` = 25000 WHERE `stamina` = 50000;
ALTER TABLE `characters` ADD `maxStamina` INT NOT NULL DEFAULT '25000' AFTER `stamina`;
ALTER TABLE `characters` CHANGE `stamina` `stamina` INT(11) NOT NULL DEFAULT '25000';
