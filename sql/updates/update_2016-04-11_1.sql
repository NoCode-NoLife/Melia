CREATE TABLE IF NOT EXISTS `vars` (
  `varId` bigint(20) NOT NULL AUTO_INCREMENT,
  `owner` varchar(128) NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL,
  PRIMARY KEY (`varId`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;
