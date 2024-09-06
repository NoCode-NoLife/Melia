START TRANSACTION;

DELETE FROM `abilities` WHERE `characterId` NOT IN (SELECT `characterId` FROM `characters`);
ALTER TABLE `abilities` ADD FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

COMMIT;
