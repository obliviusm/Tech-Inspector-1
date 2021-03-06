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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `action_types`
--

LOCK TABLES `action_types` WRITE;
/*!40000 ALTER TABLE `action_types` DISABLE KEYS */;
INSERT INTO `action_types` VALUES (1,'Передано на ремонт'),(2,'Завершення ремонту'),(3,'Вихід з ладу'),(4,'Часткова несправність'),(5,'Відновлення роботи'),(6,'Тимчасове перенесення'),(7,'Повернення на постійне місце');
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
  CONSTRAINT `fk_Equipments_Types` FOREIGN KEY (`type_id`) REFERENCES `types` (`type_id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_Equipments_Locations1` FOREIGN KEY (`location_id`) REFERENCES `locations` (`location_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Equipments_States1` FOREIGN KEY (`state_id`) REFERENCES `states` (`state_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipments`
--

LOCK TABLES `equipments` WRITE;
/*!40000 ALTER TABLE `equipments` DISABLE KEYS */;
INSERT INTO `equipments` VALUES (110530,3,6,1,115,'2012-04-10 11:21:24',NULL,NULL,1,NULL,''),(1000500,4,10,1,0,NULL,NULL,NULL,NULL,1,'в'),(13053454,9,7,1,100.57,'2012-04-12 00:00:00','2012-04-09 00:00:00','2012-04-09 00:00:00',NULL,NULL,'в');
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
INSERT INTO `equipments_has_attributes` VALUES (13053454,18,'test'),(110530,15,'Панасонии'),(110530,16,'СТОДЕ120ЕМ'),(110530,17,'1');
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
  CONSTRAINT `fk_history_Equipments1` FOREIGN KEY (`equipment_id`) REFERENCES `equipments` (`equipment_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_history_action_types1` FOREIGN KEY (`action_type_id`) REFERENCES `action_types` (`action_type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `history`
--

LOCK TABLES `history` WRITE;
/*!40000 ALTER TABLE `history` DISABLE KEYS */;
INSERT INTO `history` VALUES (1,110530,2,'2012-04-06 19:10:25','тест1'),(2,110530,3,'2012-04-03 19:10:25','тест2'),(3,110530,1,'2012-07-07 19:51:12','на ремонт'),(4,110530,2,NULL,'з ремонту'),(5,110530,3,NULL,'зламав'),(6,110530,4,'2012-04-11 19:51:54','частково зламав'),(7,110530,5,NULL,'працює'),(8,110530,6,NULL,'переніс'),(9,110530,7,NULL,'повернув'),(10,110530,1,NULL,NULL),(11,13053454,6,NULL,NULL),(12,13053454,1,NULL,'Перенесено'),(13,13053454,6,NULL,'пер'),(14,13053454,6,NULL,' '),(15,1000500,6,NULL,' в');
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

-- Dump completed on 2012-04-16 20:25:17
