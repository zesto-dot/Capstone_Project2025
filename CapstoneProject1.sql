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
  `ContactNumber` varchar(45) NOT NULL,
  `SpecializationID` int NOT NULL,
  `Created_At` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  KEY `fk_doctors_SpecializationID_idx` (`SpecializationID`),
  CONSTRAINT `fk_doctors_SpecializationID` FOREIGN KEY (`SpecializationID`) REFERENCES `specialization` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctors`
--

LOCK TABLES `doctors` WRITE;
/*!40000 ALTER TABLE `doctors` DISABLE KEYS */;
INSERT INTO `doctors` VALUES (2,'Doe','John','Avel','Male','09061860895',6,'2025-08-14 00:00:00');
/*!40000 ALTER TABLE `doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `household`
--

DROP TABLE IF EXISTS `household`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `household` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Familyserialnumber` varchar(45) DEFAULT NULL,
  `PatientID` int DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `household`
--

LOCK TABLES `household` WRITE;
/*!40000 ALTER TABLE `household` DISABLE KEYS */;
/*!40000 ALTER TABLE `household` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patientrecord`
--

DROP TABLE IF EXISTS `patientrecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patientrecord` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `PatientID` int NOT NULL,
  `NatureOfVisit` varchar(45) NOT NULL,
  `ServiceID` int NOT NULL,
  `Bloodpressure` varchar(45) NOT NULL,
  `Temperature` varchar(45) NOT NULL,
  `Height` varchar(45) NOT NULL,
  `Weight` varchar(45) NOT NULL,
  `Chiefcomplaint` varchar(45) NOT NULL,
  `Diagnosis` varchar(45) NOT NULL,
  `Medicationtreatment` varchar(45) NOT NULL,
  `LaboratoryFindings` varchar(45) NOT NULL,
  `DoctorID` int NOT NULL,
  `Created_At` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  KEY `fk_patientrecord_PatientID_idx` (`PatientID`),
  KEY `fk_patientrecord_ServiceID_idx` (`ServiceID`),
  KEY `fk_patientrecord_DoctorID_idx` (`DoctorID`),
  CONSTRAINT `fk_patientrecord_DoctorID` FOREIGN KEY (`DoctorID`) REFERENCES `doctors` (`ID`),
  CONSTRAINT `fk_patientrecord_PatientID` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_patientrecord_ServiceID` FOREIGN KEY (`ServiceID`) REFERENCES `services` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patientrecord`
--

LOCK TABLES `patientrecord` WRITE;
/*!40000 ALTER TABLE `patientrecord` DISABLE KEYS */;
INSERT INTO `patientrecord` VALUES (7,3,'New Consultation/Case',3,'120/80','36','155','58','Headache','Headache','','',2,'2025-08-14 00:00:00');
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
  `Birthdate` date NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (3,'Salviejo','Hadji','Avena','Jr','Male','2002-11-30','CVMC','O+','15 Cusipag St. Caggay','09061860895','Single','N/A','Ryalyn Salviejo','College','Student','Son',0,'',0,'',0,'','','',0,'2025-08-14 00:00:00',NULL);
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
  `Name` varchar(45) NOT NULL,
  `Description` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (3,'General','Primary care, general consultations.'),(4,'Prenatal','Health check-up and monitoring for pregnant women before delivery.'),(5,'Dental Care','Oral and dental examinations, cleanings, and treatment.');
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
  `Description` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specialization`
--

LOCK TABLES `specialization` WRITE;
/*!40000 ALTER TABLE `specialization` DISABLE KEYS */;
INSERT INTO `specialization` VALUES (6,'Pediatrician'),(7,'Obstetrics and Gynecology');
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
 1 AS `ContactNumber`,
 1 AS `Specialization`,
 1 AS `Created_At`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v.patientrecord`
--

DROP TABLE IF EXISTS `v.patientrecord`;
/*!50001 DROP VIEW IF EXISTS `v.patientrecord`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v.patientrecord` AS SELECT 
 1 AS `ID`,
 1 AS `PatientID`,
 1 AS `NatureOfVisit`,
 1 AS `PurposeOfVisit`,
 1 AS `Bloodpressure`,
 1 AS `Temperature`,
 1 AS `Height`,
 1 AS `Weight`,
 1 AS `Chiefcomplaint`,
 1 AS `Diagnosis`,
 1 AS `Medicationtreatment`,
 1 AS `LaboratoryFindings`,
 1 AS `AttendedBy`,
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
/*!50001 VIEW `v.doctors` AS select `doctors`.`ID` AS `ID`,concat(upper(left(`doctors`.`Fname`,1)),lower(substr(`doctors`.`Fname`,2)),' ',upper(left(`doctors`.`Mname`,1)),'. ',upper(left(`doctors`.`Lname`,1)),lower(substr(`doctors`.`Lname`,2)),' ') AS `FullName`,`doctors`.`Sex` AS `Sex`,`doctors`.`ContactNumber` AS `ContactNumber`,`specialization`.`Description` AS `Specialization`,`doctors`.`Created_At` AS `Created_At` from (`doctors` join `specialization` on((`doctors`.`SpecializationID` = `specialization`.`ID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v.patientrecord`
--

/*!50001 DROP VIEW IF EXISTS `v.patientrecord`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v.patientrecord` AS select `patientrecord`.`ID` AS `ID`,`patientrecord`.`PatientID` AS `PatientID`,`patientrecord`.`NatureOfVisit` AS `NatureOfVisit`,`services`.`Name` AS `PurposeOfVisit`,`patientrecord`.`Bloodpressure` AS `Bloodpressure`,`patientrecord`.`Temperature` AS `Temperature`,`patientrecord`.`Height` AS `Height`,`patientrecord`.`Weight` AS `Weight`,`patientrecord`.`Chiefcomplaint` AS `Chiefcomplaint`,`patientrecord`.`Diagnosis` AS `Diagnosis`,`patientrecord`.`Medicationtreatment` AS `Medicationtreatment`,`patientrecord`.`LaboratoryFindings` AS `LaboratoryFindings`,concat(`doctors`.`Fname`,' ',left(`doctors`.`Mname`,1),'. ',`doctors`.`Lname`,' / ',`specialization`.`Description`) AS `AttendedBy`,`patientrecord`.`Created_At` AS `Created_At` from (((`patientrecord` join `services` on((`patientrecord`.`ServiceID` = `services`.`ID`))) join `doctors` on((`patientrecord`.`DoctorID` = `doctors`.`ID`))) join `specialization` on((`doctors`.`SpecializationID` = `specialization`.`ID`))) */;
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

-- Dump completed on 2025-08-14  2:31:27
