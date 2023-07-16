CREATE TABLE `cooldowns` (
  `cooldownId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `classId` int(11) NOT NULL,
  `remaining` time NOT NULL,
  `duration` time NOT NULL,
  `startTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `cooldowns`
  ADD PRIMARY KEY (`cooldownId`),
  ADD KEY `characterId` (`characterId`);

ALTER TABLE `cooldowns`
  MODIFY `cooldownId` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

ALTER TABLE `cooldowns`
  ADD CONSTRAINT `cooldowns_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
