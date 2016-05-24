CREATE TABLE IF NOT EXISTS `skills` (
  `skillUniqueId` bigint(20) NOT NULL AUTO_INCREMENT,
  `characterId` bigint(11) NOT NULL,
  `skillId` int(11) NOT NULL,
  `level` int(11) NOT NULL,
  PRIMARY KEY (`skillUniqueId`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `char_jobs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `characterId` bigint(20) NOT NULL,
  `jobId` smallint(6) NOT NULL,
  `jobLevel` int(11) NOT NULL,
  `jobPoints` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;
