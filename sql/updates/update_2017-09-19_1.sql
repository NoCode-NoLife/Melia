ALTER TABLE `characters` CHANGE `str` `str` INT NOT NULL DEFAULT '1',
                         CHANGE `con` `con` INT NOT NULL DEFAULT '1',
                         CHANGE `int` `int` INT NOT NULL DEFAULT '1',
                         CHANGE `spr` `spr` INT NOT NULL DEFAULT '1',
                         CHANGE `dex` `dex` INT NOT NULL DEFAULT '1',
                         CHANGE `statByLevel` `statByLevel` INT NOT NULL DEFAULT '0',
                         CHANGE `statByBonus` `statByBonus` INT NOT NULL DEFAULT '0',
                         CHANGE `usedStat` `usedStat` INT NOT NULL DEFAULT '0';
