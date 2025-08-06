CREATE DATABASE  IF NOT EXISTS `capstone_project` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `capstone_project`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: capstone_project
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `doctors`
--

DROP TABLE IF EXISTS `doctors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctors` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Lname` varchar(45) NOT NULL,
  `Fname` varchar(45) NOT NULL,
  `Mname` varchar(45) NOT NULL,
  `Sex` varchar(45) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `ContactNumber` varchar(45) NOT NULL,
  `SpecializationID` varchar(45) NOT NULL,
  `Created_At` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctors`
--

LOCK TABLES `doctors` WRITE;
/*!40000 ALTER TABLE `doctors` DISABLE KEYS */;
/*!40000 ALTER TABLE `doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patientrecord`
--

DROP TABLE IF EXISTS `patientrecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patientrecord` (
  `ID` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patientrecord`
--

LOCK TABLES `patientrecord` WRITE;
/*!40000 ALTER TABLE `patientrecord` DISABLE KEYS */;
/*!40000 ALTER TABLE `patientrecord` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Lname` varchar(45) NOT NULL,
  `Fname` varchar(45) NOT NULL,
  `Mname` varchar(45) NOT NULL,
  `Suffix` varchar(45) NOT NULL,
  `Sex` varchar(45) NOT NULL,
  `Birthdate` datetime NOT NULL,
  `Birthplace` varchar(45) NOT NULL,
  `Bloodtype` varchar(45) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `ContactNumber` varchar(45) NOT NULL,
  `CivilStatus` varchar(45) NOT NULL,
  `SpouseName` varchar(45) NOT NULL,
  `MotherName` varchar(45) NOT NULL,
  `EducationalAttainment` varchar(45) NOT NULL,
  `EmploymentStatus` varchar(45) NOT NULL,
  `FamilyPosition` varchar(45) NOT NULL,
  `Dswd_Nhts` tinyint(1) NOT NULL,
  `FacilityHouseHoldNo` varchar(45) NOT NULL,
  `FourPsMember` tinyint(1) NOT NULL,
  `HouseHoldNo` varchar(45) NOT NULL,
  `PhilHealthMember` tinyint(1) NOT NULL,
  `PhilHealthType` varchar(45) NOT NULL,
  `PhilHealthNo` varchar(45) NOT NULL,
  `IfMember` varchar(45) NOT NULL,
  `PcbMember` tinyint(1) NOT NULL,
  `Created_At` datetime DEFAULT CURRENT_TIMESTAMP,
  `Deleted_At` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (31,'salviejo','hadji','avena','jr','Male','2002-11-30 00:00:00','cvmc','O+','15 cusipag st caggay.\r\nbartolome\r\nasdasdsad','09061860895','Single','none','ryalyn','College','Student','Son',0,'',0,'',0,'Member','','',0,'2025-08-06 00:00:00',NULL),(33,'adfhdafh','dafh','dfha','','','2025-08-02 00:00:00','','','','','','','','','','',0,'',0,'',0,'','','',0,'2025-08-07 00:00:00',NULL);
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Servicename` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (1,'asd','asd'),(2,'asd','asd');
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specialization`
--

DROP TABLE IF EXISTS `specialization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `specialization` (
  `ID` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specialization`
--

LOCK TABLES `specialization` WRITE;
/*!40000 ALTER TABLE `specialization` DISABLE KEYS */;
/*!40000 ALTER TABLE `specialization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'hadji','yasu');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v.doctors`
--

DROP TABLE IF EXISTS `v.doctors`;
/*!50001 DROP VIEW IF EXISTS `v.doctors`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v.doctors` AS SELECT 
 1 AS `ID`,
 1 AS `FullName`,
 1 AS `Sex`,
 1 AS `Address`,
 1 AS `ContactNumber`,
 1 AS `Specialization`,
 1 AS `Created_At`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v.patients`
--

DROP TABLE IF EXISTS `v.patients`;
/*!50001 DROP VIEW IF EXISTS `v.patients`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v.patients` AS SELECT 
 1 AS `ID`,
 1 AS `FullName`,
 1 AS `Sex`,
 1 AS `Birthdate`,
 1 AS `Bloodtype`,
 1 AS `Address`,
 1 AS `ContactNumber`,
 1 AS `Created_At`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v.doctors`
--

/*!50001 DROP VIEW IF EXISTS `v.doctors`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v.doctors` AS select `doctors`.`ID` AS `ID`,concat(upper(left(`doctors`.`Fname`,1)),lower(substr(`doctors`.`Fname`,2)),' ',upper(left(`doctors`.`Mname`,1)),'. ',upper(left(`doctors`.`Lname`,1)),lower(substr(`doctors`.`Lname`,2)),' ') AS `FullName`,`doctors`.`Sex` AS `Sex`,`doctors`.`Address` AS `Address`,`doctors`.`ContactNumber` AS `ContactNumber`,`doctors`.`SpecializationID` AS `Specialization`,`doctors`.`Created_At` AS `Created_At` from `doctors` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v.patients`
--

/*!50001 DROP VIEW IF EXISTS `v.patients`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v.patients` AS select `patients`.`ID` AS `ID`,concat(upper(left(`patients`.`Fname`,1)),lower(substr(`patients`.`Fname`,2)),' ',upper(left(`patients`.`Mname`,1)),'. ',upper(left(`patients`.`Lname`,1)),lower(substr(`patients`.`Lname`,2)),' ',upper(left(`patients`.`Suffix`,1)),lower(substr(`patients`.`Suffix`,2))) AS `FullName`,`patients`.`Sex` AS `Sex`,`patients`.`Birthdate` AS `Birthdate`,`patients`.`Bloodtype` AS `Bloodtype`,`patients`.`Address` AS `Address`,`patients`.`ContactNumber` AS `ContactNumber`,`patients`.`Created_At` AS `Created_At` from `patients` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-08-07  2:55:28
