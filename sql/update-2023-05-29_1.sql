ALTER TABLE `characters` CHANGE `exp` `exp` BIGINT NOT NULL DEFAULT '0',
                         CHANGE `maxExp` `maxExp` BIGINT NOT NULL DEFAULT '1000',
						 CHANGE `totalExp` `totalExp` BIGINT NOT NULL DEFAULT '0';
ALTER TABLE `jobs` CHANGE `totalExp` `totalExp` BIGINT NOT NULL DEFAULT '0';
