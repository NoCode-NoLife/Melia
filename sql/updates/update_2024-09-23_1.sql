CREATE TABLE `likes` (
  `likeId` bigint(20) NOT NULL,
  `receiverId` bigint(20) NOT NULL,
  `receiverName` varchar(128) NOT NULL,
  `senderId` bigint(20) NOT NULL,
  `senderName` varchar(128) NOT NULL,
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

ALTER TABLE `likes`
  ADD PRIMARY KEY (`likeId`);

ALTER TABLE `likes`
  MODIFY `likeId` bigint(20) NOT NULL AUTO_INCREMENT;
COMMIT;
