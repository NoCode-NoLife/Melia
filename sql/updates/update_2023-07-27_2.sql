ALTER TABLE `social_users` ADD `accountId` BIGINT NOT NULL AFTER `userId`, ADD `accountName` VARCHAR(32) NOT NULL AFTER `accountId`, ADD INDEX (`accountId`);
ALTER TABLE chat_messages DROP FOREIGN KEY chat_messages_ibfk_2;
ALTER TABLE chat_members DROP FOREIGN KEY chat_members_ibfk_2;
