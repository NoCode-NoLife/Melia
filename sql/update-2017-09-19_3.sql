CREATE TABLE `skills` (
  `skillId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `id` int(11) NOT NULL,
  `level` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


ALTER TABLE `skills`
  ADD PRIMARY KEY (`skillId`),
  ADD KEY `characterId` (`characterId`);


ALTER TABLE `skills`
  MODIFY `skillId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `skills`
  ADD CONSTRAINT `skills_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE;
