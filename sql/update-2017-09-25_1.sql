CREATE TABLE `abilities` (
  `abilityId` bigint(20) NOT NULL,
  `characterId` bigint(20) NOT NULL,
  `id` int(11) NOT NULL,
  `level` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


ALTER TABLE `abilities`
  ADD PRIMARY KEY (`abilityId`),
  ADD KEY `characterId` (`characterId`);


ALTER TABLE `abilities`
  MODIFY `abilityId` bigint(20) NOT NULL AUTO_INCREMENT;
