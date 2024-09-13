DELETE FROM `character_properties` WHERE `characterId` NOT IN (SELECT `characterId` FROM `characters`);
DELETE FROM `skills` WHERE `characterId` NOT IN (SELECT `characterId` FROM `characters`);

ALTER TABLE `character_properties` ADD FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE `chatmacros` ADD FOREIGN KEY (`accountId`) REFERENCES `accounts`(`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE `revealedmaps` ADD FOREIGN KEY (`accountId`) REFERENCES `accounts`(`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE `session_objects_properties` ADD FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE `skills` ADD FOREIGN KEY (`characterId`) REFERENCES `characters`(`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
