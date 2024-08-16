ALTER TABLE `characters` ADD `statByLevel` FLOAT NOT NULL DEFAULT '0' ;
ALTER TABLE `characters` ADD `usedStat` FLOAT NOT NULL DEFAULT '0' ;
ALTER TABLE `characters` ADD `statByBonus` FLOAT NOT NULL DEFAULT '0' AFTER `statByLevel`;
