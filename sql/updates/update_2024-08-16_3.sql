CREATE TABLE `ip_bans` (
  `ipBanId` bigint(20) NOT NULL,
  `ip` varchar(16) NOT NULL,
  `fromDate` datetime NOT NULL,
  `toDate` datetime NOT NULL,
  `reason` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

ALTER TABLE `ip_bans`
  ADD PRIMARY KEY (`ipBanId`);

ALTER TABLE `ip_bans`
  MODIFY `ipBanId` bigint(20) NOT NULL AUTO_INCREMENT;
