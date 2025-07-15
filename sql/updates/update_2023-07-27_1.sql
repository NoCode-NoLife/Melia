START TRANSACTION;

TRUNCATE `friends`;

ALTER TABLE `friends` DROP FOREIGN KEY `friends_ibfk_1`;
ALTER TABLE `friends` DROP FOREIGN KEY `friends_ibfk_2`;

ALTER TABLE `friends` CHANGE `accountId` `userId` BIGINT(20) NOT NULL;
ALTER TABLE `friends` CHANGE `friendAccountId` `friendUserId` BIGINT(20) NOT NULL;

CREATE TABLE `chat_members` (
  `memberId` bigint(20) NOT NULL,
  `roomId` bigint(20) NOT NULL,
  `userId` bigint(20) NOT NULL,
  `teamName` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

CREATE TABLE `chat_messages` (
  `messageId` bigint(20) NOT NULL,
  `roomId` bigint(20) NOT NULL,
  `userId` bigint(20) NOT NULL,
  `teamName` varchar(64) NOT NULL,
  `message` varchar(2048) NOT NULL,
  `sentTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

CREATE TABLE `chat_rooms` (
  `roomId` bigint(20) NOT NULL,
  `type` int(11) NOT NULL,
  `creatorId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `social_users` (
  `userId` bigint(20) NOT NULL,
  `teamName` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


ALTER TABLE `chat_members`
  ADD PRIMARY KEY (`memberId`),
  ADD KEY `roomId` (`roomId`),
  ADD KEY `userId` (`userId`);

ALTER TABLE `chat_messages`
  ADD PRIMARY KEY (`messageId`),
  ADD KEY `roomId` (`roomId`),
  ADD KEY `userId` (`userId`);

ALTER TABLE `chat_rooms`
  ADD PRIMARY KEY (`roomId`);

ALTER TABLE `social_users`
  ADD PRIMARY KEY (`userId`);


ALTER TABLE `chat_members`
  MODIFY `memberId` bigint(20) NOT NULL AUTO_INCREMENT;
ALTER TABLE `chat_messages`
  MODIFY `messageId` bigint(20) NOT NULL AUTO_INCREMENT;
ALTER TABLE `chat_rooms`
  MODIFY `roomId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `chat_members`
  ADD CONSTRAINT `chat_members_ibfk_1` FOREIGN KEY (`roomId`) REFERENCES `chat_rooms` (`roomId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `chat_members_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `social_users` (`userId`) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE `chat_messages`
  ADD CONSTRAINT `chat_messages_ibfk_1` FOREIGN KEY (`roomId`) REFERENCES `chat_rooms` (`roomId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `chat_messages_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `social_users` (`userId`) ON DELETE NO ACTION ON UPDATE NO ACTION;

COMMIT;
