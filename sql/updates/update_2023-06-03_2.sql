CREATE TABLE `buffs` (
  `buffId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `classId` int(11) NOT NULL,
  `numArg1` int(11) NOT NULL,
  `numArg2` int(11) NOT NULL,
  `remainingDuration` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `buffs`
  ADD PRIMARY KEY (`buffId`),
  ADD KEY `characterId` (`characterId`);

ALTER TABLE `buffs`
  MODIFY `buffId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `buffs`
  ADD CONSTRAINT `buffs_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
