CREATE TABLE `quests` (
  `questId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `classId` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `startTime` datetime NOT NULL,
  `completeTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `quests_progress` (
  `questId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `ident` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
  `count` int(11) NOT NULL,
  `done` tinyint(1) NOT NULL,
  `unlocked` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

ALTER TABLE `quests`
  ADD PRIMARY KEY (`questId`),
  ADD KEY `characterId` (`characterId`);

ALTER TABLE `quests_progress`
  ADD PRIMARY KEY (`questId`,`ident`),
  ADD KEY `characterId` (`characterId`);

ALTER TABLE `quests`
  MODIFY `questId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `quests`
  ADD CONSTRAINT `quests_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `quests_progress`
  ADD CONSTRAINT `quests_progress_ibfk_1` FOREIGN KEY (`questId`) REFERENCES `quests` (`questId`) ON DELETE CASCADE ON UPDATE CASCADE;
