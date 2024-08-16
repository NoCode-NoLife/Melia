ALTER TABLE `characters` CHANGE `barrackLayer` `barrackLayer` INT(11) NOT NULL DEFAULT '1' AFTER `level`;
ALTER TABLE `characters` ADD `abilityPoints` INT NOT NULL DEFAULT '0' AFTER `usedStat`;
