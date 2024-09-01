ALTER TABLE `buffs` ADD `duration` TIME NOT NULL AFTER `numArg2`, ADD `runTime` TIME NOT NULL AFTER `duration`;
UPDATE `buffs` SET `duration` = `remainingDuration`, `runTime` = SEC_TO_TIME(TIME_TO_SEC(`remainingDuration`) / 2);
ALTER TABLE `buffs` DROP `remainingDuration`;
