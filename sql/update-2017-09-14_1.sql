CREATE TABLE `jobs` (
  `characterId` bigint(20) NOT NULL,
  `jobId` int(11) NOT NULL,
  `circle` int(11) NOT NULL DEFAULT '1',
  `skillPoints` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


ALTER TABLE `jobs`
  ADD PRIMARY KEY (`characterId`,`jobId`);


ALTER TABLE `jobs`
  ADD CONSTRAINT `jobs_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
