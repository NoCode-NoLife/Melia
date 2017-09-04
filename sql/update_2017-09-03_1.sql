CREATE TABLE IF NOT EXISTS `revealedMaps` (
  `revealedMapId` bigint(20) NOT NULL AUTO_INCREMENT,
  `accountId` bigint(20) NOT NULL,
  `map` int(11) NOT NULL,
  `explored` varbinary(128) NOT NULL,
  `percentage` FLOAT(10,2) NOT NULL DEFAULT 0,
  PRIMARY KEY (`revealedMapId`),
  CONSTRAINT `FK_revealedMaps_accountId` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE,
  CONSTRAINT `UQ_revealedMaps_map` UNIQUE (`accountId`, `map`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;
