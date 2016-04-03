CREATE TABLE IF NOT EXISTS `skills` (
  `skillUniqueId` bigint(20) NOT NULL,
  `characterId` bigint(11) NOT NULL,
  `jobId` int(5) NOT NULL,
  `skillId` int(11) NOT NULL,
  `level` smallint(4) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

ALTER TABLE `skills`
  ADD CONSTRAINT `skills_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;