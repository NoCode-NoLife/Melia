CREATE TABLE `vars_buffs` (
  `varId` bigint(20) NOT NULL,
  `buffId` bigint(20) NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

ALTER TABLE `vars_buffs`
  ADD PRIMARY KEY (`varId`),
  ADD KEY `characterId` (`buffId`);

ALTER TABLE `vars_buffs`
  MODIFY `varId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `vars_buffs`
  ADD CONSTRAINT `vars_buffs_ibfk_1` FOREIGN KEY (`buffId`) REFERENCES `buffs` (`buffId`) ON DELETE CASCADE ON UPDATE CASCADE;
