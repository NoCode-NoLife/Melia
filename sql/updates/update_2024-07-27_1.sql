ALTER TABLE `jobs` ADD `selectionDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP AFTER `totalExp`;

UPDATE `jobs` AS `j`
LEFT JOIN `characters` AS `c` ON `c`.`characterId` = `j`.`characterId`
SET `selectionDate` = DATE_ADD(DATE_ADD(DATE_SUB(CURRENT_TIMESTAMP(), INTERVAL 1 DAY), INTERVAL `jobId` % 1000 SECOND), INTERVAL IF(`j`.`jobId` = `c`.`job`, 3600, 0) SECOND)
