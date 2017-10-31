ALTER TABLE `characters` ADD `hpRate` FLOAT NOT NULL DEFAULT '1' AFTER `hp`, 
                         ADD `spRate` FLOAT NOT NULL DEFAULT '1' AFTER `sp`,
                         ADD `strByJob` INT NOT NULL DEFAULT '0' AFTER `str`,
                         ADD `conByJob` INT NOT NULL DEFAULT '0' AFTER `con`,
                         ADD `intByJob` INT NOT NULL DEFAULT '0' AFTER `int`,
                         ADD `sprByJob` INT NOT NULL DEFAULT '0' AFTER `spr`,
                         ADD `dexByJob` INT NOT NULL DEFAULT '0' AFTER `dex`,
                         ADD `staminaByJob` INT NOT NULL DEFAULT '0' AFTER `stamina`;