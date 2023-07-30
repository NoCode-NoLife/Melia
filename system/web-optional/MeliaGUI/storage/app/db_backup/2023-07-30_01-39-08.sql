-- MySQL dump 10.13  Distrib 8.1.0, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: melia
-- ------------------------------------------------------
-- Server version	8.1.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `abilities`
--

DROP TABLE IF EXISTS `abilities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `abilities` (
  `abilityId` bigint NOT NULL AUTO_INCREMENT,
  `characterId` bigint NOT NULL,
  `id` int NOT NULL,
  `level` int NOT NULL,
  `active` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`abilityId`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `abilities_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `abilities_ibfk_2` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=126 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `abilities`
--

LOCK TABLES `abilities` WRITE;
/*!40000 ALTER TABLE `abilities` DISABLE KEYS */;
INSERT INTO `abilities` VALUES (18,3,10012,1,1),(19,3,10013,1,1),(20,3,10014,1,1),(21,3,10000,1,1),(22,3,10001,1,1),(23,3,10007,1,1),(24,3,10009,1,1),(25,3,10008,1,1),(26,4,10012,1,1),(27,4,10013,1,1),(28,4,10014,1,1),(29,4,10000,1,1),(30,4,10001,1,1),(31,4,10007,1,1),(32,4,10009,1,1),(48,2,10012,1,1),(49,2,10013,1,1),(50,2,10014,1,1),(51,2,10000,1,1),(52,2,10001,1,1),(59,5,10012,1,1),(60,5,10013,1,1),(61,5,10014,1,1),(62,5,10000,1,1),(63,5,10001,1,1),(64,5,10007,1,1),(65,5,10009,1,1),(120,1,10012,1,1),(121,1,10013,1,1),(122,1,10014,1,1),(123,1,10000,1,1),(124,1,10005,1,1),(125,1,10006,1,1);
/*!40000 ALTER TABLE `abilities` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `account_properties`
--

DROP TABLE IF EXISTS `account_properties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account_properties` (
  `propertyId` bigint NOT NULL AUTO_INCREMENT,
  `accountId` bigint NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL,
  PRIMARY KEY (`propertyId`),
  KEY `accountId` (`accountId`),
  CONSTRAINT `account_properties_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account_properties`
--

LOCK TABLES `account_properties` WRITE;
/*!40000 ALTER TABLE `account_properties` DISABLE KEYS */;
/*!40000 ALTER TABLE `account_properties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounts` (
  `accountId` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(32) NOT NULL,
  `password` varchar(64) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `teamName` varchar(64) DEFAULT NULL,
  `authority` int NOT NULL DEFAULT '0',
  `settings` varchar(2048) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL DEFAULT '',
  `medals` int NOT NULL DEFAULT '0',
  `giftMedals` int NOT NULL DEFAULT '0',
  `premiumMedals` int NOT NULL DEFAULT '0',
  `additionalSlotCount` int NOT NULL DEFAULT '0',
  `teamExp` int NOT NULL DEFAULT '0',
  `barracksThema` int NOT NULL DEFAULT '11',
  `themas` varchar(128) NOT NULL DEFAULT '11',
  `selectedSlot` tinyint NOT NULL DEFAULT '0',
  `loginState` tinyint NOT NULL DEFAULT '0',
  `loginCharacter` bigint NOT NULL DEFAULT '0',
  PRIMARY KEY (`accountId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (1,'ckto','$2a$10$UW9JZk4KVuBRf4vxC68P9O27RALQgPha7Y4A436YsvH7oqeWB0iL2','Return',99,'44 0 98 1 15 1 63 1 46 1 66 1 71 1 68 1 84 1 85 1 86 1 163 1 164 1 155 1 157 1 99 1 133 1 145 1 150 1 151 1 82 1 91 1 83 1 23 1 33 1 48 1 54 1 53 1 61 1 73 1 24 1 45 1 52 1 55 1 60 1 67 1 96 1 141 0 143 1 136 0 138 0 142 1 130 1 131 1 132 1 17 1 34 1 59 1 58 1 50 500 51 230 100 1 101 1 102 1 103 1 104 1 105 1 166 1 106 1 107 1 108 1 110 1 109 1 111 1 126 1 112 1 113 1 115 1 116 1 117 1 118 1 119 1 120 1 121 1 122 1 123 1 124 1 125 1 167 1 168 1 169 1 170 1 144 0 43 3',0,0,0,0,0,11,'11',1,0,0),(2,'ckto2','$2a$10$dW9C2Qo/tVhulP8FFEYLF.dwL73vqZVMB7DsrKDO2xNcq5I.ruNNi','ckto2',99,'44 0 98 1 15 1 63 1 46 1 66 1 71 1 68 1 84 1 85 1 86 1 163 1 164 1 155 1 157 1 99 1 133 1 145 1 150 1 151 1 82 1 91 1 83 1 23 1 33 1 48 1 54 1 53 1 61 1 73 1 24 1 45 1 52 1 55 1 60 1 67 1 96 1 141 1 143 1 136 0 138 0 142 1 130 1 131 1 132 1 17 1 34 1 59 1 58 1 50 500 51 230',0,0,0,0,0,11,'11',2,0,0),(3,'exec','$2a$10$O.AjwUjqe6mSnj.NeUP8nOJDrexLpjFUgloka6X69nfUS0mroacJq','Exec',99,'44 0 98 1 15 1 63 1 46 1 66 1 71 1 68 1 84 1 85 1 86 1 163 1 164 1 155 1 157 1 99 1 133 1 145 1 150 1 151 1 82 1 91 1 83 1 23 1 33 1 48 1 54 1 53 1 61 1 73 1 24 1 45 1 52 1 55 1 60 1 67 1 96 1 141 1 143 1 136 0 138 0 142 1 130 1 131 1 132 1 17 1 34 1 59 1 58 1 50 500 51 230 100 1 101 1 102 1 103 1 104 1 105 1 166 1 106 1 107 1 108 1 110 1 109 1 111 1 126 1 112 1 113 1 115 1 116 1 117 1 118 1 119 1 120 1 121 1 122 1 123 1 124 1 125 1 167 1 168 1 169 1 170 1',0,0,0,0,0,11,'11',1,0,0),(4,'flpcarv','$2a$10$WeQeWwIllD58B6kE1R0deuWqlcmtwm1wO.IulK5CXCdJyYW.C0JtO',NULL,0,'',0,0,0,0,0,11,'11',0,0,0);
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `buffs`
--

DROP TABLE IF EXISTS `buffs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `buffs` (
  `buffId` bigint NOT NULL AUTO_INCREMENT,
  `characterId` bigint NOT NULL,
  `classId` int NOT NULL,
  `numArg1` int NOT NULL,
  `numArg2` int NOT NULL,
  `remainingDuration` time NOT NULL,
  PRIMARY KEY (`buffId`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `buffs_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `buffs`
--

LOCK TABLES `buffs` WRITE;
/*!40000 ALTER TABLE `buffs` DISABLE KEYS */;
/*!40000 ALTER TABLE `buffs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `character_properties`
--

DROP TABLE IF EXISTS `character_properties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `character_properties` (
  `propertyId` bigint NOT NULL AUTO_INCREMENT,
  `characterId` bigint NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL,
  PRIMARY KEY (`propertyId`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `character_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `character_properties_ibfk_2` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2563 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `character_properties`
--

LOCK TABLES `character_properties` WRITE;
/*!40000 ALTER TABLE `character_properties` DISABLE KEYS */;
INSERT INTO `character_properties` VALUES (367,3,'Lv','f','1'),(368,3,'STR_JOB','f','2'),(369,3,'CON_JOB','f','3'),(370,3,'INT_JOB','f','9'),(371,3,'MNA_JOB','f','8'),(372,3,'DEX_JOB','f','3'),(373,3,'STR_ADD','f','0'),(374,3,'CON_ADD','f','0'),(375,3,'INT_ADD','f','0'),(376,3,'MNA_ADD','f','0'),(377,3,'DEX_ADD','f','0'),(378,3,'STR','f','2'),(379,3,'CON','f','3'),(380,3,'INT','f','9'),(381,3,'MNA','f','8'),(382,3,'DEX','f','3'),(383,3,'MaxSta','f','25000'),(384,3,'Sta_RunStart','f','0'),(385,3,'Sta_Run','f','0'),(386,3,'Sta_Recover','f','400'),(387,3,'Sta_R_Delay','f','1000'),(388,3,'Sta_Runable','f','250'),(389,3,'Sta_Jump','f','0'),(390,3,'Sta_Step','f','2500'),(391,3,'MHP','f','343'),(392,3,'MSP','f','207'),(393,3,'HP','f','343'),(394,3,'SP','f','207'),(395,3,'RHP','f','3'),(396,3,'RSP','f','6'),(397,3,'RHPTIME','f','20000'),(398,3,'RSPTIME','f','20000'),(399,3,'StatByLevel','f','0'),(400,3,'StatByBonus','f','0'),(401,3,'UsedStat','f','0'),(402,3,'StatPoint','f','0'),(403,3,'AbilityPoint','s','0'),(404,3,'MAXPATK','f','25'),(405,3,'MINPATK','f','25'),(406,3,'MAXMATK','f','76'),(407,3,'MINMATK','f','76'),(408,3,'MAXPATK_SUB','f','24'),(409,3,'MINPATK_SUB','f','24'),(410,3,'DEF','f','59'),(411,3,'MDEF','f','59'),(412,3,'CRTATK','f','12'),(413,3,'CRTHR','f','0'),(414,3,'CRTDR','f','0'),(415,3,'HR','f','1'),(416,3,'DR','f','1'),(417,3,'BLK','f','0'),(418,3,'BLK_BREAK','f','1'),(419,3,'SR','f','3'),(420,3,'SDR','f','1'),(421,3,'MaxWeight','f','8025'),(422,3,'NowWeight','f','293'),(423,3,'MSPD','f','30'),(424,3,'JumpPower','f','350'),(425,3,'CastingSpeed','f','100'),(426,3,'MovingShotable','f','0'),(427,3,'MovingShot','f','0'),(428,3,'SkillRange','f','0'),(429,3,'HPDrain','f','2'),(430,3,'BOOST','f','1'),(431,3,'Const','f','1.909859'),(432,3,'CAST','f','1'),(433,3,'STR_STAT','f','0'),(434,3,'CON_STAT','f','0'),(435,3,'INT_STAT','f','0'),(436,3,'MNA_STAT','f','0'),(437,3,'DEX_STAT','f','0'),(438,3,'MHP_BM','f','0'),(439,3,'MHP_Bonus','f','0'),(440,3,'MSP_BM','f','0'),(441,3,'MSP_Bonus','f','0'),(442,3,'MSPD_BM','f','22'),(443,3,'MSPD_Bonus','f','0'),(444,3,'CastingSpeed_BM','f','0'),(445,3,'DEF_BM','f','0'),(446,3,'DEF_RATE_BM','f','0'),(447,3,'MDEF_BM','f','0'),(448,3,'MDEF_RATE_BM','f','0'),(449,3,'CRTATK_BM','f','0'),(450,3,'CRTHR_BM','f','0'),(451,3,'CRTDR_BM','f','0'),(452,3,'HR_BM','f','0'),(453,3,'HR_RATE_BM','f','0'),(454,3,'DR_BM','f','0'),(455,3,'DR_RATE_BM','f','0'),(456,3,'BLK_BM','f','0'),(457,3,'BLK_RATE_BM','f','0'),(458,3,'BLK_BREAK_BM','f','0'),(459,3,'BLK_BREAK_RATE_BM','f','0'),(460,3,'SR_BM','f','0'),(461,3,'FixedMinSDR_BM','f','0'),(462,3,'SDR_BM','f','0'),(463,3,'MAXSTA_Bonus','f','0'),(464,3,'MaxSta_BM','f','0'),(465,3,'DashRun','f','0'),(466,3,'REST_BM','f','0'),(467,3,'RSta_BM','f','0'),(468,3,'PATK_BM','f','0'),(469,3,'MINPATK_BM','f','0'),(470,3,'PATK_MAIN_BM','f','0'),(471,3,'MINPATK_MAIN_BM','f','0'),(472,3,'PATK_RATE_BM','f','0'),(473,3,'MINPATK_RATE_BM','f','0'),(474,3,'PATK_MAIN_RATE_BM','f','0'),(475,3,'MINPATK_MAIN_RATE_BM','f','0'),(476,3,'MAXPATK_BM','f','0'),(477,3,'MAXPATK_MAIN_BM','f','0'),(478,3,'MAXPATK_RATE_BM','f','0'),(479,3,'MAXPATK_MAIN_RATE_BM','f','0'),(480,3,'MATK_BM','f','0'),(481,3,'MINMATK_BM','f','0'),(482,3,'MATK_RATE_BM','f','0'),(483,3,'MINMATK_RATE_BM','f','0'),(484,3,'MAXMATK_BM','f','0'),(485,3,'MAXMATK_RATE_BM','f','0'),(486,3,'MaxWeight_BM','f','0'),(487,3,'MaxWeight_Bonus','f','0'),(488,3,'MovingShot_BM','f','0'),(489,4,'Lv','f','1'),(490,4,'STR_JOB','f','7'),(491,4,'CON_JOB','f','7'),(492,4,'INT_JOB','f','2'),(493,4,'MNA_JOB','f','3'),(494,4,'DEX_JOB','f','6'),(495,4,'STR_ADD','f','0'),(496,4,'CON_ADD','f','0'),(497,4,'INT_ADD','f','0'),(498,4,'MNA_ADD','f','0'),(499,4,'DEX_ADD','f','0'),(500,4,'STR','f','7'),(501,4,'CON','f','7'),(502,4,'INT','f','2'),(503,4,'MNA','f','3'),(504,4,'DEX','f','6'),(505,4,'MaxSta','f','25000'),(506,4,'Sta_RunStart','f','0'),(507,4,'Sta_Run','f','0'),(508,4,'Sta_Recover','f','400'),(509,4,'Sta_R_Delay','f','1000'),(510,4,'Sta_Runable','f','250'),(511,4,'Sta_Jump','f','0'),(512,4,'Sta_Step','f','2500'),(513,4,'MHP','f','408'),(514,4,'MSP','f','202'),(515,4,'HP','f','408'),(516,4,'SP','f','202'),(517,4,'RHP','f','4'),(518,4,'RSP','f','6'),(519,4,'RHPTIME','f','20000'),(520,4,'RSPTIME','f','20000'),(521,4,'StatByLevel','f','0'),(522,4,'StatByBonus','f','0'),(523,4,'UsedStat','f','0'),(524,4,'StatPoint','f','0'),(525,4,'AbilityPoint','s','0'),(526,4,'MAXPATK','f','73'),(527,4,'MINPATK','f','71'),(528,4,'MAXMATK','f','25'),(529,4,'MINMATK','f','25'),(530,4,'MAXPATK_SUB','f','34'),(531,4,'MINPATK_SUB','f','34'),(532,4,'DEF','f','59'),(533,4,'MDEF','f','59'),(534,4,'CRTATK','f','24'),(535,4,'CRTHR','f','0'),(536,4,'CRTDR','f','0'),(537,4,'HR','f','3'),(538,4,'DR','f','3'),(539,4,'BLK','f','0'),(540,4,'BLK_BREAK','f','3'),(541,4,'SR','f','4'),(542,4,'SDR','f','1'),(543,4,'MaxWeight','f','8070'),(544,4,'NowWeight','f','293'),(545,4,'MSPD','f','30'),(546,4,'JumpPower','f','350'),(547,4,'CastingSpeed','f','100'),(548,4,'MovingShotable','f','0'),(549,4,'MovingShot','f','0'),(550,4,'SkillRange','f','0'),(551,4,'HPDrain','f','2'),(552,4,'BOOST','f','1'),(553,4,'Const','f','1.909859'),(554,4,'CAST','f','1'),(555,4,'STR_STAT','f','0'),(556,4,'CON_STAT','f','0'),(557,4,'INT_STAT','f','0'),(558,4,'MNA_STAT','f','0'),(559,4,'DEX_STAT','f','0'),(560,4,'MHP_BM','f','0'),(561,4,'MHP_Bonus','f','0'),(562,4,'MSP_BM','f','0'),(563,4,'MSP_Bonus','f','0'),(564,4,'MSPD_BM','f','22'),(565,4,'MSPD_Bonus','f','0'),(566,4,'CastingSpeed_BM','f','0'),(567,4,'DEF_BM','f','0'),(568,4,'DEF_RATE_BM','f','0'),(569,4,'MDEF_BM','f','0'),(570,4,'MDEF_RATE_BM','f','0'),(571,4,'CRTATK_BM','f','0'),(572,4,'CRTHR_BM','f','0'),(573,4,'CRTDR_BM','f','0'),(574,4,'HR_BM','f','0'),(575,4,'HR_RATE_BM','f','0'),(576,4,'DR_BM','f','0'),(577,4,'DR_RATE_BM','f','0'),(578,4,'BLK_BM','f','0'),(579,4,'BLK_RATE_BM','f','0'),(580,4,'BLK_BREAK_BM','f','0'),(581,4,'BLK_BREAK_RATE_BM','f','0'),(582,4,'SR_BM','f','0'),(583,4,'FixedMinSDR_BM','f','0'),(584,4,'SDR_BM','f','0'),(585,4,'MAXSTA_Bonus','f','0'),(586,4,'MaxSta_BM','f','0'),(587,4,'DashRun','f','0'),(588,4,'REST_BM','f','0'),(589,4,'RSta_BM','f','0'),(590,4,'PATK_BM','f','0'),(591,4,'MINPATK_BM','f','0'),(592,4,'PATK_MAIN_BM','f','0'),(593,4,'MINPATK_MAIN_BM','f','0'),(594,4,'PATK_RATE_BM','f','0'),(595,4,'MINPATK_RATE_BM','f','0'),(596,4,'PATK_MAIN_RATE_BM','f','0'),(597,4,'MINPATK_MAIN_RATE_BM','f','0'),(598,4,'MAXPATK_BM','f','0'),(599,4,'MAXPATK_MAIN_BM','f','0'),(600,4,'MAXPATK_RATE_BM','f','0'),(601,4,'MAXPATK_MAIN_RATE_BM','f','0'),(602,4,'MATK_BM','f','0'),(603,4,'MINMATK_BM','f','0'),(604,4,'MATK_RATE_BM','f','0'),(605,4,'MINMATK_RATE_BM','f','0'),(606,4,'MAXMATK_BM','f','0'),(607,4,'MAXMATK_RATE_BM','f','0'),(608,4,'MaxWeight_BM','f','0'),(609,4,'MaxWeight_Bonus','f','0'),(610,4,'MovingShot_BM','f','0'),(977,2,'Lv','f','1'),(978,2,'STR_JOB','f','6'),(979,2,'CON_JOB','f','5'),(980,2,'INT_JOB','f','2'),(981,2,'MNA_JOB','f','3'),(982,2,'DEX_JOB','f','9'),(983,2,'STR_ADD','f','0'),(984,2,'CON_ADD','f','0'),(985,2,'INT_ADD','f','0'),(986,2,'MNA_ADD','f','0'),(987,2,'DEX_ADD','f','0'),(988,2,'STR','f','6'),(989,2,'CON','f','5'),(990,2,'INT','f','2'),(991,2,'MNA','f','3'),(992,2,'DEX','f','9'),(993,2,'MaxSta','f','25000'),(994,2,'Sta_RunStart','f','0'),(995,2,'Sta_Run','f','0'),(996,2,'Sta_Recover','f','400'),(997,2,'Sta_R_Delay','f','1000'),(998,2,'Sta_Runable','f','250'),(999,2,'Sta_Jump','f','0'),(1000,2,'Sta_Step','f','2500'),(1001,2,'MHP','f','365'),(1002,2,'MSP','f','202'),(1003,2,'HP','f','365'),(1004,2,'SP','f','202'),(1005,2,'RHP','f','3'),(1006,2,'RSP','f','6'),(1007,2,'RHPTIME','f','20000'),(1008,2,'RSPTIME','f','20000'),(1009,2,'StatByLevel','f','0'),(1010,2,'StatByBonus','f','0'),(1011,2,'UsedStat','f','0'),(1012,2,'StatPoint','f','0'),(1013,2,'AbilityPoint','s','0'),(1014,2,'MAXPATK','f','73'),(1015,2,'MINPATK','f','67'),(1016,2,'MAXMATK','f','25'),(1017,2,'MINMATK','f','25'),(1018,2,'MAXPATK_SUB','f','32'),(1019,2,'MINPATK_SUB','f','32'),(1020,2,'DEF','f','59'),(1021,2,'MDEF','f','59'),(1022,2,'CRTATK','f','36'),(1023,2,'CRTHR','f','0'),(1024,2,'CRTDR','f','0'),(1025,2,'HR','f','3'),(1026,2,'DR','f','4'),(1027,2,'BLK','f','0'),(1028,2,'BLK_BREAK','f','4'),(1029,2,'SR','f','3'),(1030,2,'SDR','f','1'),(1031,2,'MaxWeight','f','8055'),(1032,2,'NowWeight','f','433'),(1033,2,'MSPD','f','30'),(1034,2,'JumpPower','f','350'),(1035,2,'CastingSpeed','f','100'),(1036,2,'MovingShotable','f','0'),(1037,2,'MovingShot','f','0'),(1038,2,'SkillRange','f','0'),(1039,2,'HPDrain','f','2'),(1040,2,'BOOST','f','1'),(1041,2,'Const','f','1.909859'),(1042,2,'CAST','f','1'),(1043,2,'STR_STAT','f','0'),(1044,2,'CON_STAT','f','0'),(1045,2,'INT_STAT','f','0'),(1046,2,'MNA_STAT','f','0'),(1047,2,'DEX_STAT','f','0'),(1048,2,'MHP_BM','f','0'),(1049,2,'MHP_Bonus','f','0'),(1050,2,'MSP_BM','f','0'),(1051,2,'MSP_Bonus','f','0'),(1052,2,'MSPD_BM','f','0'),(1053,2,'MSPD_Bonus','f','0'),(1054,2,'CastingSpeed_BM','f','0'),(1055,2,'DEF_BM','f','0'),(1056,2,'DEF_RATE_BM','f','0'),(1057,2,'MDEF_BM','f','0'),(1058,2,'MDEF_RATE_BM','f','0'),(1059,2,'CRTATK_BM','f','0'),(1060,2,'CRTHR_BM','f','0'),(1061,2,'CRTDR_BM','f','0'),(1062,2,'HR_BM','f','0'),(1063,2,'HR_RATE_BM','f','0'),(1064,2,'DR_BM','f','0'),(1065,2,'DR_RATE_BM','f','0'),(1066,2,'BLK_BM','f','0'),(1067,2,'BLK_RATE_BM','f','0'),(1068,2,'BLK_BREAK_BM','f','0'),(1069,2,'BLK_BREAK_RATE_BM','f','0'),(1070,2,'SR_BM','f','0'),(1071,2,'FixedMinSDR_BM','f','0'),(1072,2,'SDR_BM','f','0'),(1073,2,'MAXSTA_Bonus','f','0'),(1074,2,'MaxSta_BM','f','0'),(1075,2,'DashRun','f','0'),(1076,2,'REST_BM','f','0'),(1077,2,'RSta_BM','f','0'),(1078,2,'PATK_BM','f','0'),(1079,2,'MINPATK_BM','f','0'),(1080,2,'PATK_MAIN_BM','f','0'),(1081,2,'MINPATK_MAIN_BM','f','0'),(1082,2,'PATK_RATE_BM','f','0'),(1083,2,'MINPATK_RATE_BM','f','0'),(1084,2,'PATK_MAIN_RATE_BM','f','0'),(1085,2,'MINPATK_MAIN_RATE_BM','f','0'),(1086,2,'MAXPATK_BM','f','0'),(1087,2,'MAXPATK_MAIN_BM','f','0'),(1088,2,'MAXPATK_RATE_BM','f','0'),(1089,2,'MAXPATK_MAIN_RATE_BM','f','0'),(1090,2,'MATK_BM','f','0'),(1091,2,'MINMATK_BM','f','0'),(1092,2,'MATK_RATE_BM','f','0'),(1093,2,'MINMATK_RATE_BM','f','0'),(1094,2,'MAXMATK_BM','f','0'),(1095,2,'MAXMATK_RATE_BM','f','0'),(1096,2,'MaxWeight_BM','f','0'),(1097,2,'MaxWeight_Bonus','f','0'),(1098,2,'MovingShot_BM','f','0'),(1221,5,'Lv','f','1'),(1222,5,'STR_JOB','f','7'),(1223,5,'CON_JOB','f','7'),(1224,5,'INT_JOB','f','2'),(1225,5,'MNA_JOB','f','3'),(1226,5,'DEX_JOB','f','6'),(1227,5,'STR_ADD','f','0'),(1228,5,'CON_ADD','f','0'),(1229,5,'INT_ADD','f','0'),(1230,5,'MNA_ADD','f','0'),(1231,5,'DEX_ADD','f','0'),(1232,5,'STR','f','7'),(1233,5,'CON','f','7'),(1234,5,'INT','f','2'),(1235,5,'MNA','f','3'),(1236,5,'DEX','f','6'),(1237,5,'MaxSta','f','25000'),(1238,5,'Sta_RunStart','f','0'),(1239,5,'Sta_Run','f','0'),(1240,5,'Sta_Recover','f','400'),(1241,5,'Sta_R_Delay','f','1000'),(1242,5,'Sta_Runable','f','250'),(1243,5,'Sta_Jump','f','0'),(1244,5,'Sta_Step','f','2500'),(1245,5,'MHP','f','408'),(1246,5,'MSP','f','202'),(1247,5,'HP','f','408'),(1248,5,'SP','f','202'),(1249,5,'RHP','f','4'),(1250,5,'RSP','f','6'),(1251,5,'RHPTIME','f','20000'),(1252,5,'RSPTIME','f','20000'),(1253,5,'StatByLevel','f','0'),(1254,5,'StatByBonus','f','0'),(1255,5,'UsedStat','f','0'),(1256,5,'StatPoint','f','0'),(1257,5,'AbilityPoint','s','0'),(1258,5,'MAXPATK','f','73'),(1259,5,'MINPATK','f','71'),(1260,5,'MAXMATK','f','25'),(1261,5,'MINMATK','f','25'),(1262,5,'MAXPATK_SUB','f','34'),(1263,5,'MINPATK_SUB','f','34'),(1264,5,'DEF','f','59'),(1265,5,'MDEF','f','59'),(1266,5,'CRTATK','f','24'),(1267,5,'CRTHR','f','0'),(1268,5,'CRTDR','f','0'),(1269,5,'HR','f','3'),(1270,5,'DR','f','3'),(1271,5,'BLK','f','0'),(1272,5,'BLK_BREAK','f','3'),(1273,5,'SR','f','4'),(1274,5,'SDR','f','1'),(1275,5,'MaxWeight','f','8070'),(1276,5,'NowWeight','f','293'),(1277,5,'MSPD','f','30'),(1278,5,'JumpPower','f','350'),(1279,5,'CastingSpeed','f','100'),(1280,5,'MovingShotable','f','0'),(1281,5,'MovingShot','f','0'),(1282,5,'SkillRange','f','0'),(1283,5,'HPDrain','f','2'),(1284,5,'BOOST','f','1'),(1285,5,'Const','f','1.909859'),(1286,5,'CAST','f','1'),(1287,5,'STR_STAT','f','0'),(1288,5,'CON_STAT','f','0'),(1289,5,'INT_STAT','f','0'),(1290,5,'MNA_STAT','f','0'),(1291,5,'DEX_STAT','f','0'),(1292,5,'MHP_BM','f','0'),(1293,5,'MHP_Bonus','f','0'),(1294,5,'MSP_BM','f','0'),(1295,5,'MSP_Bonus','f','0'),(1296,5,'MSPD_BM','f','0'),(1297,5,'MSPD_Bonus','f','0'),(1298,5,'CastingSpeed_BM','f','0'),(1299,5,'DEF_BM','f','0'),(1300,5,'DEF_RATE_BM','f','0'),(1301,5,'MDEF_BM','f','0'),(1302,5,'MDEF_RATE_BM','f','0'),(1303,5,'CRTATK_BM','f','0'),(1304,5,'CRTHR_BM','f','0'),(1305,5,'CRTDR_BM','f','0'),(1306,5,'HR_BM','f','0'),(1307,5,'HR_RATE_BM','f','0'),(1308,5,'DR_BM','f','0'),(1309,5,'DR_RATE_BM','f','0'),(1310,5,'BLK_BM','f','0'),(1311,5,'BLK_RATE_BM','f','0'),(1312,5,'BLK_BREAK_BM','f','0'),(1313,5,'BLK_BREAK_RATE_BM','f','0'),(1314,5,'SR_BM','f','0'),(1315,5,'FixedMinSDR_BM','f','0'),(1316,5,'SDR_BM','f','0'),(1317,5,'MAXSTA_Bonus','f','0'),(1318,5,'MaxSta_BM','f','0'),(1319,5,'DashRun','f','0'),(1320,5,'REST_BM','f','0'),(1321,5,'RSta_BM','f','0'),(1322,5,'PATK_BM','f','0'),(1323,5,'MINPATK_BM','f','0'),(1324,5,'PATK_MAIN_BM','f','0'),(1325,5,'MINPATK_MAIN_BM','f','0'),(1326,5,'PATK_RATE_BM','f','0'),(1327,5,'MINPATK_RATE_BM','f','0'),(1328,5,'PATK_MAIN_RATE_BM','f','0'),(1329,5,'MINPATK_MAIN_RATE_BM','f','0'),(1330,5,'MAXPATK_BM','f','0'),(1331,5,'MAXPATK_MAIN_BM','f','0'),(1332,5,'MAXPATK_RATE_BM','f','0'),(1333,5,'MAXPATK_MAIN_RATE_BM','f','0'),(1334,5,'MATK_BM','f','0'),(1335,5,'MINMATK_BM','f','0'),(1336,5,'MATK_RATE_BM','f','0'),(1337,5,'MINMATK_RATE_BM','f','0'),(1338,5,'MAXMATK_BM','f','0'),(1339,5,'MAXMATK_RATE_BM','f','0'),(1340,5,'MaxWeight_BM','f','0'),(1341,5,'MaxWeight_Bonus','f','0'),(1342,5,'MovingShot_BM','f','0'),(2441,1,'Lv','f','106'),(2442,1,'STR_JOB','f','99'),(2443,1,'CON_JOB','f','56'),(2444,1,'INT_JOB','f','2'),(2445,1,'MNA_JOB','f','3'),(2446,1,'DEX_JOB','f','73'),(2447,1,'STR_ADD','f','0'),(2448,1,'CON_ADD','f','0'),(2449,1,'INT_ADD','f','0'),(2450,1,'MNA_ADD','f','0'),(2451,1,'DEX_ADD','f','0'),(2452,1,'STR','f','99'),(2453,1,'CON','f','56'),(2454,1,'INT','f','2'),(2455,1,'MNA','f','3'),(2456,1,'DEX','f','73'),(2457,1,'MaxSta','f','27000'),(2458,1,'Sta_RunStart','f','0'),(2459,1,'Sta_Run','f','0'),(2460,1,'Sta_Recover','f','400'),(2461,1,'Sta_R_Delay','f','1000'),(2462,1,'Sta_Runable','f','250'),(2463,1,'Sta_Jump','f','0'),(2464,1,'Sta_Step','f','2500'),(2465,1,'MHP','f','9646'),(2466,1,'MSP','f','2121'),(2467,1,'HP','f','9646'),(2468,1,'SP','f','2121'),(2469,1,'RHP','f','96'),(2470,1,'RSP','f','63'),(2471,1,'RHPTIME','f','20000'),(2472,1,'RSPTIME','f','20000'),(2473,1,'StatByLevel','f','105'),(2474,1,'StatByBonus','f','0'),(2475,1,'UsedStat','f','0'),(2476,1,'StatPoint','f','0'),(2477,1,'AbilityPoint','s','0'),(2478,1,'MAXPATK','f','371.7'),(2479,1,'MINPATK','f','371.7'),(2480,1,'MAXMATK','f','130'),(2481,1,'MINMATK','f','130'),(2482,1,'MAXPATK_SUB','f','316'),(2483,1,'MINPATK_SUB','f','316'),(2484,1,'DEF','f','126'),(2485,1,'MDEF','f','126'),(2486,1,'CRTATK','f','362'),(2487,1,'CRTHR','f','53'),(2488,1,'CRTDR','f','53'),(2489,1,'HR','f','94'),(2490,1,'DR','f','75'),(2491,1,'BLK','f','0'),(2492,1,'BLK_BREAK','f','75'),(2493,1,'SR','f','0'),(2494,1,'SDR','f','1'),(2495,1,'MaxWeight','f','8775'),(2496,1,'NowWeight','f','0'),(2497,1,'MSPD','f','30'),(2498,1,'JumpPower','f','350'),(2499,1,'CastingSpeed','f','100'),(2500,1,'MovingShotable','f','1'),(2501,1,'MovingShot','f','0.8'),(2502,1,'SkillRange','f','0'),(2503,1,'HPDrain','f','2'),(2504,1,'BOOST','f','1'),(2505,1,'Const','f','1.909859'),(2506,1,'CAST','f','1'),(2507,1,'STR_STAT','f','0'),(2508,1,'CON_STAT','f','0'),(2509,1,'INT_STAT','f','0'),(2510,1,'MNA_STAT','f','0'),(2511,1,'DEX_STAT','f','0'),(2512,1,'MHP_BM','f','0'),(2513,1,'MHP_Bonus','f','0'),(2514,1,'MSP_BM','f','0'),(2515,1,'MSP_Bonus','f','0'),(2516,1,'MSPD_BM','f','0'),(2517,1,'MSPD_Bonus','f','0'),(2518,1,'CastingSpeed_BM','f','0'),(2519,1,'DEF_BM','f','0'),(2520,1,'DEF_RATE_BM','f','0'),(2521,1,'MDEF_BM','f','0'),(2522,1,'MDEF_RATE_BM','f','0'),(2523,1,'CRTATK_BM','f','0'),(2524,1,'CRTHR_BM','f','0'),(2525,1,'CRTDR_BM','f','0'),(2526,1,'HR_BM','f','0'),(2527,1,'HR_RATE_BM','f','0'),(2528,1,'DR_BM','f','0'),(2529,1,'DR_RATE_BM','f','0'),(2530,1,'BLK_BM','f','0'),(2531,1,'BLK_RATE_BM','f','0'),(2532,1,'BLK_BREAK_BM','f','0'),(2533,1,'BLK_BREAK_RATE_BM','f','0'),(2534,1,'SR_BM','f','0'),(2535,1,'FixedMinSDR_BM','f','0'),(2536,1,'SDR_BM','f','0'),(2537,1,'MAXSTA_Bonus','f','0'),(2538,1,'MaxSta_BM','f','0'),(2539,1,'DashRun','f','0'),(2540,1,'REST_BM','f','0'),(2541,1,'RSta_BM','f','0'),(2542,1,'PATK_BM','f','0'),(2543,1,'MINPATK_BM','f','0'),(2544,1,'PATK_MAIN_BM','f','0'),(2545,1,'MINPATK_MAIN_BM','f','0'),(2546,1,'PATK_RATE_BM','f','0'),(2547,1,'MINPATK_RATE_BM','f','0'),(2548,1,'PATK_MAIN_RATE_BM','f','0'),(2549,1,'MINPATK_MAIN_RATE_BM','f','0'),(2550,1,'MAXPATK_BM','f','0'),(2551,1,'MAXPATK_MAIN_BM','f','0'),(2552,1,'MAXPATK_RATE_BM','f','0'),(2553,1,'MAXPATK_MAIN_RATE_BM','f','0'),(2554,1,'MATK_BM','f','0'),(2555,1,'MINMATK_BM','f','0'),(2556,1,'MATK_RATE_BM','f','0'),(2557,1,'MINMATK_RATE_BM','f','0'),(2558,1,'MAXMATK_BM','f','0'),(2559,1,'MAXMATK_RATE_BM','f','0'),(2560,1,'MaxWeight_BM','f','0'),(2561,1,'MaxWeight_Bonus','f','0'),(2562,1,'MovingShot_BM','f','0');
/*!40000 ALTER TABLE `character_properties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `characters`
--

DROP TABLE IF EXISTS `characters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `characters` (
  `characterId` bigint NOT NULL AUTO_INCREMENT,
  `accountId` bigint NOT NULL,
  `name` varchar(64) NOT NULL,
  `teamName` varchar(32) DEFAULT NULL,
  `job` smallint NOT NULL,
  `gender` tinyint NOT NULL,
  `hair` int NOT NULL,
  `level` int NOT NULL DEFAULT '1',
  `slot` int NOT NULL,
  `barrackLayer` int NOT NULL DEFAULT '1',
  `bx` float NOT NULL,
  `by` float NOT NULL,
  `bz` float NOT NULL,
  `bd` float NOT NULL,
  `zone` int NOT NULL,
  `x` float NOT NULL,
  `y` float NOT NULL,
  `z` float NOT NULL,
  `exp` bigint NOT NULL DEFAULT '0',
  `maxExp` bigint NOT NULL DEFAULT '1000',
  `totalExp` bigint NOT NULL DEFAULT '0',
  `hp` int NOT NULL DEFAULT '100',
  `hpRate` float NOT NULL DEFAULT '1',
  `maxHp` int NOT NULL DEFAULT '100',
  `sp` int NOT NULL DEFAULT '50',
  `spRate` float NOT NULL DEFAULT '1',
  `maxSp` int NOT NULL DEFAULT '50',
  `stamina` int NOT NULL DEFAULT '25000',
  `staminaByJob` int NOT NULL DEFAULT '0',
  `maxStamina` int NOT NULL DEFAULT '25000',
  `str` int NOT NULL DEFAULT '0',
  `strByJob` int NOT NULL DEFAULT '0',
  `con` int NOT NULL DEFAULT '0',
  `conByJob` int NOT NULL DEFAULT '0',
  `int` int NOT NULL DEFAULT '0',
  `intByJob` int NOT NULL DEFAULT '0',
  `spr` int NOT NULL DEFAULT '0',
  `sprByJob` int NOT NULL DEFAULT '0',
  `dex` int NOT NULL DEFAULT '0',
  `dexByJob` int NOT NULL DEFAULT '0',
  `statByLevel` int NOT NULL DEFAULT '0',
  `statByBonus` int NOT NULL DEFAULT '0',
  `usedStat` int NOT NULL DEFAULT '0',
  `abilityPoints` int NOT NULL DEFAULT '0',
  `silver` bigint NOT NULL DEFAULT '0',
  `equipVisibility` int NOT NULL DEFAULT '65535',
  PRIMARY KEY (`characterId`),
  KEY `accountId` (`accountId`),
  CONSTRAINT `characters_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `characters`
--

LOCK TABLES `characters` WRITE;
/*!40000 ALTER TABLE `characters` DISABLE KEYS */;
INSERT INTO `characters` VALUES (1,1,'Arrow','Return',3006,1,6,106,1,1,44.2936,18.0487,-1.76421,80.5292,1021,770.017,209.69,-866.547,212208,511290,16000761,0,0,100,0,0,50,27000,0,25000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,65535),(2,1,'Scout','Return',5001,1,21,1,2,1,65.4274,19.8831,38.8981,337.119,1021,-632.263,260.925,-980.134,0,8,0,0,0,100,0,0,50,25000,0,25000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,23135785,65535),(3,2,'Mage','ckto2',2001,2,21,1,1,1,-1520,1054.81,721,103.323,1021,-628,260.925,-1025,0,8,0,0,0,100,0,0,50,25000,0,25000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,99923234,65535),(4,2,'Swordman','ckto2',1001,1,1,1,2,1,49,22.0001,3,90,1021,-628,260.925,-1025,0,8,0,0,0,100,0,0,50,25000,0,25000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,5632832,65535),(5,3,'TheGuy','Exec',1001,1,1,1,1,1,25,27.7655,30,90,1021,-628,260.925,-1025,0,8,0,0,0,100,0,0,50,25000,0,25000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,123039023,65535);
/*!40000 ALTER TABLE `characters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chatmacros`
--

DROP TABLE IF EXISTS `chatmacros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chatmacros` (
  `chatMacroId` bigint NOT NULL AUTO_INCREMENT,
  `accountId` bigint NOT NULL,
  `index` tinyint NOT NULL,
  `message` varchar(128) NOT NULL,
  `pose` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`chatMacroId`),
  UNIQUE KEY `UQ_ChatMacro_index` (`accountId`,`index`),
  CONSTRAINT `chatmacros_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_ChatMacro_accountId` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=211 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatmacros`
--

LOCK TABLES `chatmacros` WRITE;
/*!40000 ALTER TABLE `chatmacros` DISABLE KEYS */;
INSERT INTO `chatmacros` VALUES (41,2,1,'{img emoticon_0022 30 30} I\'m sorry',8),(42,2,2,'{img emoticon_0001 30 30} Thanks',9),(43,2,3,'{img emoticon_0002 30 30} Good',10),(44,2,4,'{img emoticon_0010 30 30} Surprised',16),(45,2,5,'{img emoticon_0016 30 30} Crying',17),(46,2,6,'{img emoticon_0007 30 30} Love',1),(47,2,7,'{img emoticon_0006 30 30} Hello',6),(48,2,8,'',0),(49,2,9,'',0),(50,2,10,'',0),(101,3,1,'{img emoticon_0022 30 30} I\'m sorry',8),(102,3,2,'{img emoticon_0001 30 30} Thanks',9),(103,3,3,'{img emoticon_0002 30 30} Good',10),(104,3,4,'{img emoticon_0010 30 30} Surprised',16),(105,3,5,'{img emoticon_0016 30 30} Crying',17),(106,3,6,'{img emoticon_0007 30 30} Love',1),(107,3,7,'{img emoticon_0006 30 30} Hello',6),(108,3,8,'',0),(109,3,9,'',0),(110,3,10,'',0),(201,1,1,'{img emoticon_0022 30 30} I\'m sorry',8),(202,1,2,'{img emoticon_0001 30 30} Thanks',9),(203,1,3,'{img emoticon_0002 30 30} Good',10),(204,1,4,'{img emoticon_0010 30 30} Surprised',16),(205,1,5,'{img emoticon_0016 30 30} Crying',17),(206,1,6,'{img emoticon_0007 30 30} Love',1),(207,1,7,'{img emoticon_0006 30 30} Hello',6),(208,1,8,'',0),(209,1,9,'',0),(210,1,10,'',0);
/*!40000 ALTER TABLE `chatmacros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cooldowns`
--

DROP TABLE IF EXISTS `cooldowns`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cooldowns` (
  `cooldownId` bigint NOT NULL AUTO_INCREMENT,
  `characterId` bigint NOT NULL,
  `classId` int NOT NULL,
  `remaining` time NOT NULL,
  `duration` time NOT NULL,
  `startTime` datetime NOT NULL,
  PRIMARY KEY (`cooldownId`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `cooldowns_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cooldowns`
--

LOCK TABLES `cooldowns` WRITE;
/*!40000 ALTER TABLE `cooldowns` DISABLE KEYS */;
/*!40000 ALTER TABLE `cooldowns` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `failed_jobs`
--

DROP TABLE IF EXISTS `failed_jobs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `failed_jobs` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `uuid` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `connection` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `queue` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `payload` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `exception` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `failed_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `failed_jobs_uuid_unique` (`uuid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `failed_jobs`
--

LOCK TABLES `failed_jobs` WRITE;
/*!40000 ALTER TABLE `failed_jobs` DISABLE KEYS */;
/*!40000 ALTER TABLE `failed_jobs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory` (
  `characterId` bigint NOT NULL,
  `itemId` bigint NOT NULL,
  `sort` int NOT NULL,
  `equipSlot` tinyint NOT NULL DEFAULT '127',
  PRIMARY KEY (`characterId`,`itemId`),
  KEY `itemId` (`itemId`),
  CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemUniqueId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,183,0,127),(3,29,0,127),(3,33,4,127),(3,34,5,127),(3,35,0,3),(3,36,0,8),(3,37,0,14),(4,38,0,127),(4,39,1,127),(4,40,2,127),(4,41,3,127),(4,42,4,127),(4,43,5,127),(4,44,0,3),(4,45,0,8),(4,46,0,14);
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `items` (
  `itemUniqueId` bigint NOT NULL AUTO_INCREMENT,
  `itemId` int NOT NULL,
  `amount` int NOT NULL,
  PRIMARY KEY (`itemUniqueId`)
) ENGINE=InnoDB AUTO_INCREMENT=184 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` VALUES (1,900011,1),(2,640091,20),(3,640094,20),(4,640097,20),(5,650012,1),(6,661221,1),(7,531101,1),(8,161101,1),(9,521101,1),(10,900011,1000001),(11,640091,20),(12,640094,20),(13,640097,20),(14,650012,1),(15,661221,1),(16,531101,1),(17,161101,1),(18,521101,1),(19,900011,1201232),(20,301111,1),(21,640091,20),(22,640094,20),(23,640097,20),(24,650012,1),(25,661221,1),(26,531101,1),(27,111013,1),(28,521101,1),(29,900011,9000000),(33,650012,1),(34,661221,1),(35,531101,1),(36,141101,1),(37,521101,1),(38,900011,5632832),(39,640091,20),(40,640094,20),(41,640097,20),(42,650012,1),(43,661221,1),(44,531101,1),(45,101101,1),(46,521101,1),(47,900011,20735785),(48,301111,1),(49,640091,20),(50,640094,20),(51,640097,20),(52,650012,1),(53,661221,1),(54,531101,1),(55,111013,1),(56,521101,1),(57,900011,20735785),(58,301111,1),(59,640091,20),(60,640094,20),(61,640097,20),(62,650012,1),(63,661221,1),(64,531101,1),(65,111013,1),(66,521101,1),(67,900011,23135785),(68,301111,1),(69,640091,20),(70,640094,20),(71,640097,20),(72,650012,1),(73,661221,1),(74,531101,1),(75,111013,1),(76,521101,1),(77,900011,3000000),(79,640091,20),(80,640094,20),(81,640097,20),(82,650012,1),(83,661221,1),(84,531101,1),(85,111013,1),(86,521101,1),(87,900011,44000001),(88,640091,20),(89,640094,20),(90,640097,20),(91,650012,1),(92,661221,1),(93,531101,1),(94,161101,1),(95,521101,1),(96,900011,123039023),(97,640091,20),(98,640094,20),(99,640097,20),(101,661221,1),(102,531101,1),(103,101101,1),(104,521101,1),(105,900011,44000023),(106,640091,20),(107,640094,20),(108,640097,20),(109,645117,2),(110,650012,1),(111,661221,1),(112,531101,1),(113,161101,1),(114,521101,1),(115,900011,44000023),(116,640091,20),(117,640094,20),(118,640097,20),(119,645117,2),(120,650012,1),(121,661221,1),(122,531101,1),(123,161101,1),(124,521101,1),(125,900011,44000023),(128,640097,20),(129,645117,2),(130,650012,1),(131,661221,1),(132,531101,1),(133,161101,1),(134,622105,1),(135,521101,1),(136,900011,44000023),(137,640094,8),(138,640097,20),(139,645117,2),(140,650012,1),(141,661221,1),(142,531101,1),(143,161101,1),(144,622105,1),(145,521101,1),(146,900011,44000023),(148,640097,15),(149,645117,2),(150,650012,1),(151,661221,1),(152,531101,1),(153,161101,1),(154,622105,1),(155,521101,1),(156,900011,44000023),(157,640097,1),(158,645117,2),(159,650012,1),(160,661221,1),(161,531101,1),(162,161101,1),(163,622105,1),(164,521101,1),(165,900011,34000000),(167,645117,1),(168,650012,1),(169,661221,1),(170,531101,1),(171,161101,1),(172,622105,1),(173,521101,1),(174,900011,29000000),(176,650012,1),(177,661221,1),(178,531101,1),(179,161101,1),(180,622105,1),(181,521101,1),(182,900011,1),(183,900011,1);
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobs`
--

DROP TABLE IF EXISTS `jobs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jobs` (
  `characterId` bigint NOT NULL,
  `jobId` int NOT NULL,
  `circle` int NOT NULL DEFAULT '1',
  `skillPoints` int NOT NULL DEFAULT '0',
  `totalExp` bigint NOT NULL DEFAULT '0',
  PRIMARY KEY (`characterId`,`jobId`),
  CONSTRAINT `jobs_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `jobs_ibfk_2` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobs`
--

LOCK TABLES `jobs` WRITE;
/*!40000 ALTER TABLE `jobs` DISABLE KEYS */;
INSERT INTO `jobs` VALUES (1,3001,1,14,22292),(1,3006,1,1,307),(2,5001,1,0,0),(3,2001,1,0,0),(4,1001,1,0,0),(5,1001,1,0,0);
/*!40000 ALTER TABLE `jobs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `migrations`
--

DROP TABLE IF EXISTS `migrations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `migrations` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `migration` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `migrations`
--

LOCK TABLES `migrations` WRITE;
/*!40000 ALTER TABLE `migrations` DISABLE KEYS */;
INSERT INTO `migrations` VALUES (1,'2014_10_12_000000_create_users_table',1),(2,'2014_10_12_100000_create_password_reset_tokens_table',1),(3,'2019_08_19_000000_create_failed_jobs_table',1),(4,'2019_12_14_000001_create_personal_access_tokens_table',1);
/*!40000 ALTER TABLE `migrations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `password_reset_tokens`
--

DROP TABLE IF EXISTS `password_reset_tokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `password_reset_tokens` (
  `email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `password_reset_tokens`
--

LOCK TABLES `password_reset_tokens` WRITE;
/*!40000 ALTER TABLE `password_reset_tokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `password_reset_tokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personal_access_tokens`
--

DROP TABLE IF EXISTS `personal_access_tokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personal_access_tokens` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `tokenable_type` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `tokenable_id` bigint unsigned NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `abilities` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
  `last_used_at` timestamp NULL DEFAULT NULL,
  `expires_at` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `personal_access_tokens_token_unique` (`token`),
  KEY `personal_access_tokens_tokenable_type_tokenable_id_index` (`tokenable_type`,`tokenable_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personal_access_tokens`
--

LOCK TABLES `personal_access_tokens` WRITE;
/*!40000 ALTER TABLE `personal_access_tokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `personal_access_tokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quests`
--

DROP TABLE IF EXISTS `quests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `quests` (
  `questId` bigint NOT NULL AUTO_INCREMENT,
  `characterId` bigint NOT NULL,
  `classId` int NOT NULL,
  `status` int NOT NULL,
  `startTime` datetime NOT NULL,
  `completeTime` datetime NOT NULL,
  PRIMARY KEY (`questId`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `quests_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quests`
--

LOCK TABLES `quests` WRITE;
/*!40000 ALTER TABLE `quests` DISABLE KEYS */;
INSERT INTO `quests` VALUES (10,1,1000001,1,'2023-07-23 00:02:44','0001-01-01 00:00:00');
/*!40000 ALTER TABLE `quests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quests_progress`
--

DROP TABLE IF EXISTS `quests_progress`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `quests_progress` (
  `questId` bigint NOT NULL,
  `characterId` bigint NOT NULL,
  `ident` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `count` int NOT NULL,
  `done` tinyint(1) NOT NULL,
  `unlocked` tinyint(1) NOT NULL,
  PRIMARY KEY (`questId`,`ident`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `quests_progress_ibfk_1` FOREIGN KEY (`questId`) REFERENCES `quests` (`questId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 ROW_FORMAT=COMPACT;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quests_progress`
--

LOCK TABLES `quests_progress` WRITE;
/*!40000 ALTER TABLE `quests_progress` DISABLE KEYS */;
INSERT INTO `quests_progress` VALUES (10,1,'kill1',0,0,1),(10,1,'kill2',0,0,0);
/*!40000 ALTER TABLE `quests_progress` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `revealedmaps`
--

DROP TABLE IF EXISTS `revealedmaps`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `revealedmaps` (
  `revealedMapId` bigint NOT NULL AUTO_INCREMENT,
  `accountId` bigint NOT NULL,
  `map` int NOT NULL,
  `explored` varbinary(128) NOT NULL,
  `percentage` float(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`revealedMapId`),
  UNIQUE KEY `UQ_revealedMaps_map` (`accountId`,`map`),
  CONSTRAINT `FK_revealedMaps_accountId` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE,
  CONSTRAINT `revealedmaps_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `revealedmaps`
--

LOCK TABLES `revealedmaps` WRITE;
/*!40000 ALTER TABLE `revealedmaps` DISABLE KEYS */;
INSERT INTO `revealedmaps` VALUES (5,2,1021,_binary '\0À`\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0',0.00),(11,3,1021,_binary '\0À`\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0',0.00),(21,1,1021,_binary '\0Àp\Ãp\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0',0.00);
/*!40000 ALTER TABLE `revealedmaps` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `session_objects_properties`
--

DROP TABLE IF EXISTS `session_objects_properties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `session_objects_properties` (
  `sessionObjectPropertyId` bigint NOT NULL AUTO_INCREMENT,
  `characterId` bigint NOT NULL,
  `sessionObjectId` int NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL,
  PRIMARY KEY (`sessionObjectPropertyId`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `session_object_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `session_objects_properties_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `session_objects_properties`
--

LOCK TABLES `session_objects_properties` WRITE;
/*!40000 ALTER TABLE `session_objects_properties` DISABLE KEYS */;
/*!40000 ALTER TABLE `session_objects_properties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `skills`
--

DROP TABLE IF EXISTS `skills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `skills` (
  `skillId` bigint NOT NULL AUTO_INCREMENT,
  `characterId` bigint NOT NULL,
  `id` int NOT NULL,
  `level` int NOT NULL,
  PRIMARY KEY (`skillId`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `skills_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `skills_ibfk_2` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=293 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `skills`
--

LOCK TABLES `skills` WRITE;
/*!40000 ALTER TABLE `skills` DISABLE KEYS */;
INSERT INTO `skills` VALUES (44,3,100,1),(45,3,103,1),(46,3,108,1),(47,3,105,1),(48,3,101,1),(49,3,106,1),(50,3,110,1),(51,3,4,1),(52,3,6,1),(53,3,20,1),(54,3,54,1),(55,4,100,1),(56,4,103,1),(57,4,108,1),(58,4,105,1),(59,4,101,1),(60,4,106,1),(61,4,110,1),(62,4,1,1),(63,4,5,1),(64,4,1535,1),(65,4,53,1),(66,4,20,1),(112,2,100,1),(113,2,103,1),(114,2,108,1),(115,2,105,1),(116,2,101,1),(117,2,106,1),(118,2,110,1),(119,2,1,1),(120,2,5,1),(121,2,1535,1),(122,2,11,1),(123,2,10,1),(124,2,59,1),(125,2,53,1),(126,2,20,1),(141,5,100,1),(142,5,103,1),(143,5,108,1),(144,5,105,1),(145,5,101,1),(146,5,106,1),(147,5,110,1),(148,5,1,1),(149,5,5,1),(150,5,1535,1),(151,5,53,1),(152,5,20,1),(279,1,100,1),(280,1,103,1),(281,1,108,1),(282,1,105,1),(283,1,101,1),(284,1,106,1),(285,1,110,1),(286,1,2,1),(287,1,52,1),(288,1,20,1),(289,1,53,1),(290,1,55,1),(291,1,56,1),(292,1,70,1);
/*!40000 ALTER TABLE `skills` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `updates`
--

DROP TABLE IF EXISTS `updates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `updates` (
  `path` varchar(255) NOT NULL,
  PRIMARY KEY (`path`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `updates`
--

LOCK TABLES `updates` WRITE;
/*!40000 ALTER TABLE `updates` DISABLE KEYS */;
INSERT INTO `updates` VALUES ('main.sql'),('update-2017-09-01_1.sql'),('update-2017-09-02_1.sql'),('update-2017-09-04_1.sql'),('update-2017-09-12_1.sql'),('update-2017-09-14_1.sql'),('update-2017-09-19_1.sql'),('update-2017-09-19_2.sql'),('update-2017-09-19_3.sql'),('update-2017-09-25_1.sql'),('update-2017-09-26_1.sql'),('update-2017-09-28_1.sql'),('update-2017-09-29_1.sql'),('update-2017-10-31_1.sql'),('update-2021-09-08_1.sql'),('update-2021-09-14_1.sql'),('update-2021-09-28_1.sql'),('update-2021-10-07_1.sql'),('update-2021-10-07_2.sql'),('update-2021-10-13_1.sql'),('update-2023-05-10_1.sql'),('update-2023-05-11_1.sql'),('update-2023-05-21_1.sql'),('update-2023-05-22_1.sql'),('update-2023-05-22_2.sql'),('update-2023-05-23_1.sql'),('update-2023-05-25_1.sql'),('update-2023-05-25_2.sql'),('update-2023-05-29_1.sql'),('update-2023-05-31_1.sql'),('update-2023-05-31_2.sql'),('update-2023-06-01_1.sql'),('update-2023-06-02_1.sql'),('update-2023-06-03_1.sql'),('update-2023-06-03_2.sql'),('update-2023-06-26_1.sql'),('update-2023-06-27_1.sql'),('update-2023-06-30_1.sql'),('update-2023-07-03_1.sql'),('update-2023-07-03_2.sql'),('update-2023-07-12_1.sql'),('update-2023-07-15_1.sql'),('update_2015-08-17_1.sql'),('update_2015-08-17_2.sql'),('update_2015-08-17_3.sql'),('update_2015-08-20_1.sql'),('update_2015-08-20_2.sql'),('update_2015-08-27_1.sql'),('update_2015-09-03_1.sql'),('update_2015-09-16_1.sql'),('update_2015-12-12_1.sql'),('update_2016-04-01_1.sql'),('update_2016-04-02_1.sql'),('update_2016-04-03_1.sql'),('update_2016-04-11_1.sql'),('update_2016-04-23_1.sql'),('update_2017-09-03_1.sql');
/*!40000 ALTER TABLE `updates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `account_id` bigint NOT NULL,
  `email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `users_email_unique` (`email`),
  KEY `users_account_id_foreign` (`account_id`),
  CONSTRAINT `users_account_id_foreign` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`accountId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,1,'catagnarodecarvalho@gmail.com',NULL,'zMwK4NLSQDR6fnkBMBkSxn6eiTNCHpIljgb3nyQnlFE9FdoCiL50TC1zmXt9','2023-07-22 19:47:01','2023-07-22 19:47:01'),(2,2,'ckto2@gmal.com',NULL,NULL,'2023-07-23 02:51:24','2023-07-23 02:51:24'),(3,3,'exec@gmail.com',NULL,NULL,'2023-07-23 05:42:04','2023-07-23 05:42:04'),(4,4,'castagnarofelipe@gmail.com',NULL,NULL,'2023-07-25 07:13:22','2023-07-25 07:13:22');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vars_accounts`
--

DROP TABLE IF EXISTS `vars_accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vars_accounts` (
  `varId` bigint NOT NULL AUTO_INCREMENT,
  `accountId` bigint NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL,
  PRIMARY KEY (`varId`),
  KEY `accountId` (`accountId`),
  CONSTRAINT `vars_accounts_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `characters` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 ROW_FORMAT=COMPACT;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vars_accounts`
--

LOCK TABLES `vars_accounts` WRITE;
/*!40000 ALTER TABLE `vars_accounts` DISABLE KEYS */;
/*!40000 ALTER TABLE `vars_accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vars_buffs`
--

DROP TABLE IF EXISTS `vars_buffs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vars_buffs` (
  `varId` bigint NOT NULL AUTO_INCREMENT,
  `buffId` bigint NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL,
  PRIMARY KEY (`varId`),
  KEY `characterId` (`buffId`),
  CONSTRAINT `vars_buffs_ibfk_1` FOREIGN KEY (`buffId`) REFERENCES `buffs` (`buffId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 ROW_FORMAT=COMPACT;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vars_buffs`
--

LOCK TABLES `vars_buffs` WRITE;
/*!40000 ALTER TABLE `vars_buffs` DISABLE KEYS */;
/*!40000 ALTER TABLE `vars_buffs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vars_characters`
--

DROP TABLE IF EXISTS `vars_characters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vars_characters` (
  `varId` bigint NOT NULL AUTO_INCREMENT,
  `characterId` bigint NOT NULL,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL,
  PRIMARY KEY (`varId`),
  KEY `characterId` (`characterId`),
  CONSTRAINT `vars_characters_ibfk_1` FOREIGN KEY (`characterId`) REFERENCES `characters` (`characterId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb3 ROW_FORMAT=COMPACT;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vars_characters`
--

LOCK TABLES `vars_characters` WRITE;
/*!40000 ALTER TABLE `vars_characters` DISABLE KEYS */;
INSERT INTO `vars_characters` VALUES (10,3,'Melia.PropertiesInitialized','b','True'),(11,3,'Melia.EverLoggedIn','b','True'),(12,3,'Melia.QuickSlotList','s','#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,1,0#None,2,0#None,3,0#'),(13,4,'Melia.PropertiesInitialized','b','True'),(14,4,'Melia.EverLoggedIn','b','True'),(15,4,'Melia.QuickSlotList','s','#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,1,0#None,2,0#None,3,0#'),(25,2,'Melia.PropertiesInitialized','b','True'),(26,2,'Melia.EverLoggedIn','b','True'),(27,2,'Melia.QuickSlotList','s','#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,1,0#None,2,0#None,3,0#'),(31,5,'Melia.PropertiesInitialized','b','True'),(32,5,'Melia.EverLoggedIn','b','True'),(33,5,'Melia.QuickSlotList','s','#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,1,0#None,2,0#None,3,0#'),(61,1,'Melia.PropertiesInitialized','b','True'),(62,1,'Melia.EverLoggedIn','b','True'),(63,1,'Melia.QuickSlotList','s','#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#Item,640097,360287970189639721#Item,640094,360287970189639721#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,0,0#None,1,0#None,2,0#None,3,0#');
/*!40000 ALTER TABLE `vars_characters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vars_global`
--

DROP TABLE IF EXISTS `vars_global`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vars_global` (
  `varId` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(128) NOT NULL,
  `type` char(2) NOT NULL,
  `value` mediumtext NOT NULL,
  PRIMARY KEY (`varId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vars_global`
--

LOCK TABLES `vars_global` WRITE;
/*!40000 ALTER TABLE `vars_global` DISABLE KEYS */;
/*!40000 ALTER TABLE `vars_global` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-29 22:39:09
