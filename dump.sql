-- MySQL dump 10.13  Distrib 5.5.22, for Win32 (x86)
--
-- Host: localhost    Database: tech_inspector
-- ------------------------------------------------------
-- Server version	5.5.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `action_types`
--

DROP TABLE IF EXISTS `action_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `action_types` (
  `action_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `action_type_name` varchar(45) NOT NULL,
  PRIMARY KEY (`action_type_id`),
  UNIQUE KEY `action_type_id_UNIQUE` (`action_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `action_types`
--

LOCK TABLES `action_types` WRITE;
/*!40000 ALTER TABLE `action_types` DISABLE KEYS */;
INSERT INTO `action_types` VALUES (1,'Передано на ремонт'),(2,'Завершення ремонту'),(3,'Вихід з ладу'),(4,'Часткова несправність'),(5,'Відновлення роботи'),(6,'Тимчасове перенесення'),(7,'Повернення на постійне місце'),(8,'Заміна комплектуючих');
/*!40000 ALTER TABLE `action_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `attributes`
--

DROP TABLE IF EXISTS `attributes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `attributes` (
  `attribute_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_id` int(11) NOT NULL,
  `attribute_name` varchar(45) NOT NULL,
  `required` tinyint(1) NOT NULL,
  PRIMARY KEY (`attribute_id`),
  UNIQUE KEY `attribute_id_UNIQUE` (`attribute_id`),
  KEY `fk_Attributes_Types1` (`type_id`),
  CONSTRAINT `fk_Attributes_Types1` FOREIGN KEY (`type_id`) REFERENCES `types` (`type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attributes`
--

LOCK TABLES `attributes` WRITE;
/*!40000 ALTER TABLE `attributes` DISABLE KEYS */;
INSERT INTO `attributes` VALUES (1,1,'Монітор',1),(2,1,'Клавіатура',1),(3,1,'Миш',1),(4,1,'Процесор',1),(5,1,'Відеокарта',1),(6,1,'HDD',1),(7,1,'RAM',1),(8,1,'Привід',1),(9,1,'USB',0),(10,1,'Bluetooth',0),(11,1,'Wi-fi',0),(12,2,'Виробник',1),(13,2,'Модель',1),(14,2,'Срок експлуатації',0),(15,3,'Виробник',1),(16,3,'Модель',1),(17,3,'Тип (1 - струйний, 2 - лазерний)',0),(18,9,'Тип обладнання',1),(19,6,'Виробник',1),(20,6,'Модель',1);
/*!40000 ALTER TABLE `attributes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipments`
--

DROP TABLE IF EXISTS `equipments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipments` (
  `equipment_id` int(11) NOT NULL,
  `type_id` int(11) NOT NULL,
  `location_id` int(11) NOT NULL,
  `state_id` int(11) NOT NULL,
  `price` float DEFAULT NULL,
  `purchase_date` datetime DEFAULT NULL,
  `placement_date` datetime DEFAULT NULL,
  `warranty_end_date` datetime DEFAULT NULL,
  `repairing` tinyint(1) DEFAULT NULL,
  `moved` tinyint(1) DEFAULT NULL,
  `temp_location` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`equipment_id`),
  UNIQUE KEY `equipments_id_UNIQUE` (`equipment_id`),
  KEY `fk_Equipments_Types` (`type_id`),
  KEY `fk_Equipments_Locations1` (`location_id`),
  KEY `fk_Equipments_States1` (`state_id`),
  CONSTRAINT `fk_Equipments_Locations1` FOREIGN KEY (`location_id`) REFERENCES `locations` (`location_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Equipments_States1` FOREIGN KEY (`state_id`) REFERENCES `states` (`state_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Equipments_Types` FOREIGN KEY (`type_id`) REFERENCES `types` (`type_id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipments`
--

LOCK TABLES `equipments` WRITE;
/*!40000 ALTER TABLE `equipments` DISABLE KEYS */;
INSERT INTO `equipments` VALUES (10258576,2,10,1,0,'2008-08-18 22:20:08',NULL,NULL,NULL,NULL,NULL),(10258756,2,2,2,0,'2008-08-18 22:20:08',NULL,NULL,NULL,NULL,NULL),(10300234,1,9,1,0,'2009-09-09 21:19:28','2009-09-09 21:19:28','2011-04-16 21:19:28',NULL,NULL,NULL),(10300254,1,9,1,0,'2009-09-09 21:51:48','2009-09-09 21:51:48','2009-04-16 21:51:48',NULL,NULL,NULL),(10302345,1,9,1,0,'2009-09-09 21:41:11','2009-09-08 21:41:11','2011-04-16 21:41:11',NULL,NULL,NULL),(10302453,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10302454,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,1,'523'),(10312453,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10312455,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10312544,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',0,1,'444'),(10312554,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10312555,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10313544,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10313554,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10335443,1,14,1,0,'2012-02-01 21:56:37',NULL,NULL,NULL,NULL,NULL),(10335454,1,14,1,0,'2012-02-01 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10342534,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10342544,1,9,1,0,'2009-09-09 21:56:37','2009-09-09 21:56:37','2011-04-16 21:56:37',NULL,NULL,NULL),(10346443,1,14,1,0,'2012-02-01 21:56:37',NULL,NULL,NULL,NULL,NULL),(10347643,1,14,1,0,'2012-02-01 21:56:37',NULL,NULL,NULL,NULL,NULL),(10347653,1,14,1,0,'2012-02-01 21:56:37',NULL,NULL,NULL,NULL,NULL),(10347843,1,14,1,0,'2012-02-01 21:56:37',NULL,NULL,NULL,NULL,NULL),(10365843,1,14,1,0,'2012-02-01 21:56:37',NULL,NULL,NULL,NULL,NULL),(10368343,1,14,1,0,'2012-02-01 21:56:37',NULL,NULL,NULL,NULL,NULL),(10368743,1,14,1,0,'2012-02-01 21:56:37',NULL,NULL,NULL,NULL,NULL),(10453353,3,6,3,0,'2007-04-16 22:16:35',NULL,NULL,NULL,NULL,NULL),(10453453,3,8,2,0,'2007-04-16 22:16:35',NULL,NULL,1,NULL,NULL),(10453553,3,6,1,0,'2007-04-16 22:16:35',NULL,NULL,NULL,NULL,NULL),(10453563,3,7,1,0,'2007-04-16 22:16:35',NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `equipments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipments_has_attributes`
--

DROP TABLE IF EXISTS `equipments_has_attributes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipments_has_attributes` (
  `equipment_id` int(11) NOT NULL,
  `attribute_id` int(11) NOT NULL,
  `attribute_value` varchar(45) DEFAULT NULL,
  KEY `fk_Equipments_has_Attributes_Attributes1` (`attribute_id`),
  KEY `fk_Equipments_has_Attributes_Equipments1` (`equipment_id`),
  CONSTRAINT `fk_Equipments_has_Attributes_Attributes1` FOREIGN KEY (`attribute_id`) REFERENCES `attributes` (`attribute_id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_Equipments_has_Attributes_Equipments1` FOREIGN KEY (`equipment_id`) REFERENCES `equipments` (`equipment_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipments_has_attributes`
--

LOCK TABLES `equipments_has_attributes` WRITE;
/*!40000 ALTER TABLE `equipments_has_attributes` DISABLE KEYS */;
INSERT INTO `equipments_has_attributes` VALUES (10300234,1,'Samsung 17'),(10300234,2,'Logitech'),(10300234,3,'Logitech'),(10300234,4,'Intel Core i5 2.4 GHz'),(10300234,5,'Radeon X1200'),(10300234,6,'200 GB'),(10300234,7,'1 GB'),(10300234,8,'Hitachi DVD Super Multi'),(10300234,9,''),(10300234,10,''),(10300234,11,''),(10302345,1,'Samsung 17'),(10302345,2,'Logitech'),(10302345,3,'Logitech'),(10302345,4,'Intel Core i5 2.4 GHz'),(10302345,5,'Radeon X1200'),(10302345,6,'200 GB'),(10302345,7,'1 GB'),(10302345,8,'Hitachi DVD Super Multi'),(10302345,9,''),(10302345,10,''),(10302345,11,''),(10300254,1,'Samsung 17'),(10300254,2,'Logitech'),(10300254,3,'Logitech'),(10300254,4,'Intel Core i5 2.4 GHz'),(10300254,5,'Radeon X1200'),(10300254,6,'200 GB'),(10300254,7,'1 GB'),(10300254,8,'Hitachi DVD Super Multi'),(10300254,9,''),(10300254,10,''),(10300254,11,''),(10302454,1,'Samsung 17'),(10302454,2,'Logitech'),(10302454,3,'Logitech'),(10302454,4,'Intel Core i5 2.4 GHz'),(10302454,5,'Radeon X1200'),(10302454,6,'200 GB'),(10302454,7,'1 GB'),(10302454,8,'Hitachi DVD Super Multi'),(10302454,9,''),(10302454,10,''),(10302454,11,''),(10302453,1,'Samsung 17'),(10302453,2,'Logitech'),(10302453,3,'Logitech'),(10302453,4,'Intel Core i5 2.4 GHz'),(10302453,5,'Radeon X1200'),(10302453,6,'200 GB'),(10302453,7,'1 GB'),(10302453,8,'Hitachi DVD Super Multi'),(10302453,9,''),(10302453,10,''),(10302453,11,''),(10312453,1,'Samsung 17'),(10312453,2,'Logitech'),(10312453,3,'Logitech'),(10312453,4,'Intel Core i5 2.4 GHz'),(10312453,5,'Radeon X1200'),(10312453,6,'200 GB'),(10312453,7,'1 GB'),(10312453,8,'Hitachi DVD Super Multi'),(10312453,9,''),(10312453,10,''),(10312453,11,''),(10312455,1,'Samsung 17'),(10312455,2,'Logitech'),(10312455,3,'Logitech'),(10312455,4,'Intel Core i5 2.4 GHz'),(10312455,5,'Radeon X1200'),(10312455,6,'200 GB'),(10312455,7,'1 GB'),(10312455,8,'Hitachi DVD Super Multi'),(10312455,9,''),(10312455,10,''),(10312455,11,''),(10312555,1,'Samsung 17'),(10312555,2,'Logitech'),(10312555,3,'Logitech'),(10312555,4,'Intel Core i5 2.4 GHz'),(10312555,5,'Radeon X1200'),(10312555,6,'200 GB'),(10312555,7,'1 GB'),(10312555,8,'Hitachi DVD Super Multi'),(10312555,9,''),(10312555,10,''),(10312555,11,''),(10312554,1,'Samsung 17'),(10312554,2,'Logitech'),(10312554,3,'Logitech'),(10312554,4,'Intel Core i5 2.4 GHz'),(10312554,5,'Radeon X1200'),(10312554,6,'200 GB'),(10312554,7,'1 GB'),(10312554,8,'Hitachi DVD Super Multi'),(10312554,9,''),(10312554,10,''),(10312554,11,''),(10313554,1,'Samsung 17'),(10313554,2,'Logitech'),(10313554,3,'Logitech'),(10313554,4,'Intel Core i5 2.4 GHz'),(10313554,5,'Radeon X1200'),(10313554,6,'200 GB'),(10313554,7,'1 GB'),(10313554,8,'Hitachi DVD Super Multi'),(10313554,9,''),(10313554,10,''),(10313554,11,''),(10313544,1,'Samsung 17'),(10313544,2,'Logitech'),(10313544,3,'Logitech'),(10313544,4,'Intel Core i5 2.4 GHz'),(10313544,5,'Radeon X1200'),(10313544,6,'200 GB'),(10313544,7,'1 GB'),(10313544,8,'Hitachi DVD Super Multi'),(10313544,9,''),(10313544,10,''),(10313544,11,''),(10312544,1,'Samsung 17'),(10312544,2,'Logitech'),(10312544,3,'Logitech'),(10312544,4,'Intel Core i5 2.4 GHz'),(10312544,5,'Radeon X1200'),(10312544,6,'200 GB'),(10312544,7,'1 GB'),(10312544,8,'Hitachi DVD Super Multi'),(10312544,9,''),(10312544,10,''),(10312544,11,''),(10342544,1,'Samsung 17'),(10342544,2,'Logitech'),(10342544,3,'Logitech'),(10342544,4,'Intel Core i5 2.4 GHz'),(10342544,5,'Radeon X1200'),(10342544,6,'200 GB'),(10342544,7,'1 GB'),(10342544,8,'Hitachi DVD Super Multi'),(10342544,9,''),(10342544,10,''),(10342544,11,''),(10342534,1,'Samsung 17'),(10342534,2,'Logitech'),(10342534,3,'Logitech'),(10342534,4,'Intel Core i5 2.4 GHz'),(10342534,5,'Radeon X1200'),(10342534,6,'200 GB'),(10342534,7,'1 GB'),(10342534,8,'Hitachi DVD Super Multi'),(10342534,9,''),(10342534,10,''),(10342534,11,''),(10335454,1,'Samsung 23'),(10335454,2,'Logitech'),(10335454,3,'Microsoft'),(10335454,4,'Intel Core i5 2.7 GHz'),(10335454,5,'NVidia GeForce GTX 680'),(10335454,6,'1 TB'),(10335454,7,'4 GB'),(10335454,8,'Hitachi DVD Super Multi DL'),(10335454,9,''),(10335454,10,''),(10335454,11,''),(10335443,1,'Samsung 23'),(10335443,2,'Logitech'),(10335443,3,'Microsoft'),(10335443,4,'Intel Core i5 2.7 GHz'),(10335443,5,'NVidia GeForce GTX 680'),(10335443,6,'1 TB'),(10335443,7,'4 GB'),(10335443,8,'Hitachi DVD Super Multi DL'),(10335443,9,''),(10335443,10,''),(10335443,11,''),(10346443,1,'Samsung 23'),(10346443,2,'Logitech'),(10346443,3,'Microsoft'),(10346443,4,'Intel Core i5 2.7 GHz'),(10346443,5,'NVidia GeForce GTX 680'),(10346443,6,'1 TB'),(10346443,7,'4 GB'),(10346443,8,'Hitachi DVD Super Multi DL'),(10346443,9,''),(10346443,10,''),(10346443,11,''),(10347643,1,'Samsung 23'),(10347643,2,'Logitech'),(10347643,3,'Microsoft'),(10347643,4,'Intel Core i5 2.7 GHz'),(10347643,5,'NVidia GeForce GTX 680'),(10347643,6,'1 TB'),(10347643,7,'4 GB'),(10347643,8,'Hitachi DVD Super Multi DL'),(10347643,9,''),(10347643,10,''),(10347643,11,''),(10347653,1,'Samsung 23'),(10347653,2,'Logitech'),(10347653,3,'Microsoft'),(10347653,4,'Intel Core i5 2.7 GHz'),(10347653,5,'NVidia GeForce GTX 680'),(10347653,6,'1 TB'),(10347653,7,'4 GB'),(10347653,8,'Hitachi DVD Super Multi DL'),(10347653,9,''),(10347653,10,''),(10347653,11,''),(10347843,1,'Samsung 23'),(10347843,2,'Logitech'),(10347843,3,'Microsoft'),(10347843,4,'Intel Core i5 2.7 GHz'),(10347843,5,'NVidia GeForce GTX 680'),(10347843,6,'1 TB'),(10347843,7,'4 GB'),(10347843,8,'Hitachi DVD Super Multi DL'),(10347843,9,''),(10347843,10,''),(10347843,11,''),(10365843,1,'Samsung 23'),(10365843,2,'Logitech'),(10365843,3,'Microsoft'),(10365843,4,'Intel Core i5 2.7 GHz'),(10365843,5,'NVidia GeForce GTX 680'),(10365843,6,'1 TB'),(10365843,7,'4 GB'),(10365843,8,'Hitachi DVD Super Multi DL'),(10365843,9,''),(10365843,10,''),(10365843,11,''),(10368743,1,'Samsung 23'),(10368743,2,'Logitech'),(10368743,3,'Microsoft'),(10368743,4,'Intel Core i5 2.7 GHz'),(10368743,5,'NVidia GeForce GTX 680'),(10368743,6,'1 TB'),(10368743,7,'4 GB'),(10368743,8,'Hitachi DVD Super Multi DL'),(10368743,9,''),(10368743,10,''),(10368743,11,''),(10368343,1,'Samsung 23'),(10368343,2,'Logitech'),(10368343,3,'Microsoft'),(10368343,4,'Intel Core i5 2.7 GHz'),(10368343,5,'NVidia GeForce GTX 680'),(10368343,6,'1 TB'),(10368343,7,'4 GB'),(10368343,8,'Hitachi DVD Super Multi DL'),(10368343,9,''),(10368343,10,''),(10368343,11,''),(10453563,15,'Epson'),(10453563,16,'L800 (C11CB57301)'),(10453563,17,'2'),(10453453,15,'Samsung'),(10453453,16,'SCX-4824FN'),(10453453,17,'1'),(10453553,15,'Samsung'),(10453553,16,'SCX-4824FN'),(10453553,17,'1'),(10453353,15,'Samsung'),(10453353,16,'SCX-4824FN'),(10453353,17,'1'),(10258576,12,'Optoma'),(10258576,13,'EX536'),(10258576,14,''),(10258756,12,'Optoma'),(10258756,13,'EX536'),(10258756,14,'');
/*!40000 ALTER TABLE `equipments_has_attributes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `history`
--

DROP TABLE IF EXISTS `history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `history` (
  `history_id` int(11) NOT NULL AUTO_INCREMENT,
  `equipment_id` int(11) NOT NULL,
  `action_type_id` int(11) NOT NULL,
  `date` datetime DEFAULT NULL,
  `notice` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`history_id`),
  UNIQUE KEY `history_id_UNIQUE` (`history_id`),
  KEY `fk_history_Equipments1` (`equipment_id`),
  KEY `fk_history_action_types1` (`action_type_id`),
  CONSTRAINT `fk_history_action_types1` FOREIGN KEY (`action_type_id`) REFERENCES `action_types` (`action_type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_history_Equipments1` FOREIGN KEY (`equipment_id`) REFERENCES `equipments` (`equipment_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `history`
--

LOCK TABLES `history` WRITE;
/*!40000 ALTER TABLE `history` DISABLE KEYS */;
INSERT INTO `history` VALUES (1,10453453,1,'2012-04-17 10:27:41',' Компанія: \"Розетка\", тел.0983892354'),(2,10453353,3,'2012-04-18 10:30:13',' Не працює'),(3,10302454,6,'2012-04-16 10:31:37',' На KPI-OPEN 2012'),(4,10302454,8,'2012-04-17 11:28:22',' Замінили Мишу'),(5,10312544,6,'2012-04-19 12:12:47',' олимп'),(6,10312544,1,'2012-04-17 12:13:55',' '),(7,10312544,2,'2012-04-17 12:14:36',' ');
/*!40000 ALTER TABLE `history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locations`
--

DROP TABLE IF EXISTS `locations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `locations` (
  `location_id` int(11) NOT NULL AUTO_INCREMENT,
  `location_name` varchar(32) NOT NULL,
  PRIMARY KEY (`location_id`),
  UNIQUE KEY `idLocations_UNIQUE` (`location_id`),
  UNIQUE KEY `location_name_UNIQUE` (`location_name`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locations`
--

LOCK TABLES `locations` WRITE;
/*!40000 ALTER TABLE `locations` DISABLE KEYS */;
INSERT INTO `locations` VALUES (10,'229/1'),(11,'229/2'),(12,'229/3'),(13,'323'),(7,'416/1'),(8,'416/2'),(9,'417'),(14,'422'),(6,'426'),(5,'428'),(3,'429/1'),(4,'429/2'),(1,'430'),(2,'433');
/*!40000 ALTER TABLE `locations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `states`
--

DROP TABLE IF EXISTS `states`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `states` (
  `state_id` int(11) NOT NULL AUTO_INCREMENT,
  `state_name` varchar(45) NOT NULL,
  PRIMARY KEY (`state_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `states`
--

LOCK TABLES `states` WRITE;
/*!40000 ALTER TABLE `states` DISABLE KEYS */;
INSERT INTO `states` VALUES (1,'Справний'),(2,'Частково несправний'),(3,'Повністю несправний');
/*!40000 ALTER TABLE `states` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `types`
--

DROP TABLE IF EXISTS `types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `types` (
  `type_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_name` varchar(32) NOT NULL,
  PRIMARY KEY (`type_id`),
  UNIQUE KEY `type_id_UNIQUE` (`type_id`),
  UNIQUE KEY `type_name_UNIQUE` (`type_name`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `types`
--

LOCK TABLES `types` WRITE;
/*!40000 ALTER TABLE `types` DISABLE KEYS */;
INSERT INTO `types` VALUES (7,'KVM'),(8,'UPS'),(6,'WiFi'),(9,'Інше'),(1,'Комп\'ютер'),(5,'Комутатор'),(3,'Принтер'),(2,'Проектор'),(4,'Сервер');
/*!40000 ALTER TABLE `types` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-04-17 16:22:41
