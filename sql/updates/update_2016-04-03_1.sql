CREATE TABLE IF NOT EXISTS `updates` (
  `path` varchar(255) NOT NULL,
  PRIMARY KEY (`path`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `updates` (`path`) VALUES
('main.sql'),
('update_2015-08-17_1.sql'),
('update_2015-08-17_2.sql'),
('update_2015-08-17_3.sql'),
('update_2015-08-20_1.sql'),
('update_2015-08-20_2.sql'),
('update_2015-08-27_1.sql'),
('update_2015-09-03_1.sql'),
('update_2015-09-16_1.sql'),
('update_2015-12-12_1.sql'),
('update_2016-04-01_1.sql'),
('update_2016-04-02_1.sql'),
('update_2016-04-03_1.sql');
