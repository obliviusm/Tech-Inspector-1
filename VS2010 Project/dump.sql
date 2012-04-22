-- phpMyAdmin SQL Dump
-- version 3.2.3
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 22, 2012 at 06:37 AM
-- Server version: 5.5.22
-- PHP Version: 5.3.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- Database: `tech_inspector`
--

-- --------------------------------------------------------

--
-- Table structure for table `action_types`
--

CREATE TABLE IF NOT EXISTS `action_types` (
  `action_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `action_type_name` varchar(45) NOT NULL,
  PRIMARY KEY (`action_type_id`),
  UNIQUE KEY `action_type_id_UNIQUE` (`action_type_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `action_types`
--

INSERT INTO `action_types` (`action_type_id`, `action_type_name`) VALUES
(1, 'Передано на ремонт'),
(2, 'Завершення ремонту'),
(3, 'Вихід з ладу'),
(4, 'Часткова несправність'),
(5, 'Відновлення роботи'),
(6, 'Тимчасове перенесення'),
(7, 'Повернення на постійне місце');

-- --------------------------------------------------------

--
-- Table structure for table `attributes`
--

CREATE TABLE IF NOT EXISTS `attributes` (
  `attribute_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_id` int(11) NOT NULL,
  `attribute_name` varchar(45) NOT NULL,
  `required` tinyint(1) NOT NULL,
  PRIMARY KEY (`attribute_id`),
  UNIQUE KEY `attribute_id_UNIQUE` (`attribute_id`),
  KEY `fk_Attributes_Types1` (`type_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=21 ;

--
-- Dumping data for table `attributes`
--

INSERT INTO `attributes` (`attribute_id`, `type_id`, `attribute_name`, `required`) VALUES
(1, 1, 'Монітор', 1),
(2, 1, 'Клавіатура', 1),
(3, 1, 'Миш', 1),
(4, 1, 'Процесор', 1),
(5, 1, 'Відеокарта', 1),
(6, 1, 'HDD', 1),
(7, 1, 'RAM', 1),
(8, 1, 'Привід', 1),
(9, 1, 'USB', 0),
(10, 1, 'Bluetooth', 0),
(11, 1, 'Wi-fi', 0),
(12, 2, 'Виробник', 1),
(13, 2, 'Модель', 1),
(14, 2, 'Срок експлуатації', 0),
(15, 3, 'Виробник', 1),
(16, 3, 'Модель', 1),
(17, 3, 'Тип (1 - струйний, 2 - лазерний)', 0),
(18, 9, 'Тип обладнання', 1),
(19, 6, 'Виробник', 1),
(20, 6, 'Модель', 1);

-- --------------------------------------------------------

--
-- Table structure for table `equipments`
--

CREATE TABLE IF NOT EXISTS `equipments` (
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
  KEY `fk_Equipments_States1` (`state_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `equipments`
--

INSERT INTO `equipments` (`equipment_id`, `type_id`, `location_id`, `state_id`, `price`, `purchase_date`, `placement_date`, `warranty_end_date`, `repairing`, `moved`, `temp_location`) VALUES
(10258576, 2, 10, 1, 0, '2008-08-18 22:20:08', NULL, NULL, NULL, NULL, NULL),
(10258756, 2, 2, 2, 0, '2008-08-18 22:20:08', NULL, NULL, NULL, NULL, NULL),
(10300234, 1, 9, 1, 0, '2009-09-09 21:19:28', '2009-09-09 21:19:28', '2011-04-16 21:19:28', NULL, NULL, NULL),
(10300254, 1, 9, 1, 0, '2009-09-09 21:51:48', '2009-09-09 21:51:48', '2009-04-16 21:51:48', NULL, NULL, NULL),
(10302345, 1, 9, 1, 0, '2009-09-09 21:41:11', '2009-09-08 21:41:11', '2011-04-16 21:41:11', NULL, NULL, NULL),
(10302453, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10302454, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10312453, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10312455, 1, 9, 3, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10312544, 1, 9, 3, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10312554, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10312555, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10313544, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10313554, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10335443, 1, 14, 1, 0, '2012-02-01 21:56:37', NULL, NULL, NULL, NULL, NULL),
(10335454, 1, 14, 1, 0, '2012-02-01 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10342534, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10342544, 1, 9, 1, 0, '2009-09-09 21:56:37', '2009-09-09 21:56:37', '2011-04-16 21:56:37', NULL, NULL, NULL),
(10346443, 1, 14, 1, 0, '2012-02-01 21:56:37', NULL, NULL, NULL, NULL, NULL),
(10347643, 1, 14, 1, 0, '2012-02-01 21:56:37', NULL, NULL, NULL, NULL, NULL),
(10347653, 1, 14, 1, 0, '2012-02-01 21:56:37', NULL, NULL, NULL, NULL, NULL),
(10347843, 1, 14, 1, 0, '2012-02-01 21:56:37', NULL, NULL, NULL, NULL, NULL),
(10365843, 1, 14, 1, 0, '2012-02-01 21:56:37', NULL, NULL, NULL, NULL, NULL),
(10368343, 1, 14, 1, 0, '2012-02-01 21:56:37', NULL, NULL, NULL, NULL, NULL),
(10368743, 1, 14, 1, 0, '2012-02-01 21:56:37', NULL, NULL, NULL, NULL, NULL),
(10453353, 3, 6, 3, 0, '2007-04-16 22:16:35', NULL, NULL, NULL, NULL, NULL),
(10453453, 3, 8, 2, 0, '2007-04-16 22:16:35', NULL, NULL, NULL, NULL, NULL),
(10453553, 3, 6, 1, 0, '2007-04-16 22:16:35', NULL, NULL, NULL, NULL, NULL),
(10453563, 3, 7, 1, 0, '2007-04-16 22:16:35', NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `equipments_has_attributes`
--

CREATE TABLE IF NOT EXISTS `equipments_has_attributes` (
  `equipment_id` int(11) NOT NULL,
  `attribute_id` int(11) NOT NULL,
  `attribute_value` varchar(45) DEFAULT NULL,
  KEY `fk_Equipments_has_Attributes_Attributes1` (`attribute_id`),
  KEY `fk_Equipments_has_Attributes_Equipments1` (`equipment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `equipments_has_attributes`
--

INSERT INTO `equipments_has_attributes` (`equipment_id`, `attribute_id`, `attribute_value`) VALUES
(10300234, 1, 'Samsung 17'),
(10300234, 2, 'Logitech'),
(10300234, 3, 'Logitech'),
(10300234, 4, 'Intel Core i5 2.4 GHz'),
(10300234, 5, 'Radeon X1200'),
(10300234, 6, '200 GB'),
(10300234, 7, '1 GB'),
(10300234, 8, 'Hitachi DVD Super Multi'),
(10300234, 9, ''),
(10300234, 10, ''),
(10300234, 11, ''),
(10302345, 1, 'Samsung 17'),
(10302345, 2, 'Logitech'),
(10302345, 3, 'Logitech'),
(10302345, 4, 'Intel Core i5 2.4 GHz'),
(10302345, 5, 'Radeon X1200'),
(10302345, 6, '200 GB'),
(10302345, 7, '1 GB'),
(10302345, 8, 'Hitachi DVD Super Multi'),
(10302345, 9, ''),
(10302345, 10, ''),
(10302345, 11, ''),
(10300254, 1, 'Samsung 17'),
(10300254, 2, 'Logitech'),
(10300254, 3, 'Logitech'),
(10300254, 4, 'Intel Core i5 2.4 GHz'),
(10300254, 5, 'Radeon X1200'),
(10300254, 6, '200 GB'),
(10300254, 7, '1 GB'),
(10300254, 8, 'Hitachi DVD Super Multi'),
(10300254, 9, ''),
(10300254, 10, ''),
(10300254, 11, ''),
(10302454, 1, 'Samsung 17'),
(10302454, 2, 'Logitech'),
(10302454, 3, 'Logitech'),
(10302454, 4, 'Intel Core i5 2.4 GHz'),
(10302454, 5, 'Radeon X1200'),
(10302454, 6, '200 GB'),
(10302454, 7, '1 GB'),
(10302454, 8, 'Hitachi DVD Super Multi'),
(10302454, 9, ''),
(10302454, 10, ''),
(10302454, 11, ''),
(10302453, 1, 'Samsung 17'),
(10302453, 2, 'Logitech'),
(10302453, 3, 'Logitech'),
(10302453, 4, 'Intel Core i5 2.4 GHz'),
(10302453, 5, 'Radeon X1200'),
(10302453, 6, '200 GB'),
(10302453, 7, '1 GB'),
(10302453, 8, 'Hitachi DVD Super Multi'),
(10302453, 9, ''),
(10302453, 10, ''),
(10302453, 11, ''),
(10312453, 1, 'Samsung 17'),
(10312453, 2, 'Logitech'),
(10312453, 3, 'Logitech'),
(10312453, 4, 'Intel Core i5 2.4 GHz'),
(10312453, 5, 'Radeon X1200'),
(10312453, 6, '200 GB'),
(10312453, 7, '1 GB'),
(10312453, 8, 'Hitachi DVD Super Multi'),
(10312453, 9, ''),
(10312453, 10, ''),
(10312453, 11, ''),
(10312455, 1, 'Samsung 17'),
(10312455, 2, 'Logitech'),
(10312455, 3, 'Logitech'),
(10312455, 4, 'Intel Core i5 2.4 GHz'),
(10312455, 5, 'Radeon X1200'),
(10312455, 6, '200 GB'),
(10312455, 7, '1 GB'),
(10312455, 8, 'Hitachi DVD Super Multi'),
(10312455, 9, ''),
(10312455, 10, ''),
(10312455, 11, ''),
(10312555, 1, 'Samsung 17'),
(10312555, 2, 'Logitech'),
(10312555, 3, 'Logitech'),
(10312555, 4, 'Intel Core i5 2.4 GHz'),
(10312555, 5, 'Radeon X1200'),
(10312555, 6, '200 GB'),
(10312555, 7, '1 GB'),
(10312555, 8, 'Hitachi DVD Super Multi'),
(10312555, 9, ''),
(10312555, 10, ''),
(10312555, 11, ''),
(10312554, 1, 'Samsung 17'),
(10312554, 2, 'Logitech'),
(10312554, 3, 'Logitech'),
(10312554, 4, 'Intel Core i5 2.4 GHz'),
(10312554, 5, 'Radeon X1200'),
(10312554, 6, '200 GB'),
(10312554, 7, '1 GB'),
(10312554, 8, 'Hitachi DVD Super Multi'),
(10312554, 9, ''),
(10312554, 10, ''),
(10312554, 11, ''),
(10313554, 1, 'Samsung 17'),
(10313554, 2, 'Logitech'),
(10313554, 3, 'Logitech'),
(10313554, 4, 'Intel Core i5 2.4 GHz'),
(10313554, 5, 'Radeon X1200'),
(10313554, 6, '200 GB'),
(10313554, 7, '1 GB'),
(10313554, 8, 'Hitachi DVD Super Multi'),
(10313554, 9, ''),
(10313554, 10, ''),
(10313554, 11, ''),
(10313544, 1, 'Samsung 17'),
(10313544, 2, 'Logitech'),
(10313544, 3, 'Logitech'),
(10313544, 4, 'Intel Core i5 2.4 GHz'),
(10313544, 5, 'Radeon X1200'),
(10313544, 6, '200 GB'),
(10313544, 7, '1 GB'),
(10313544, 8, 'Hitachi DVD Super Multi'),
(10313544, 9, ''),
(10313544, 10, ''),
(10313544, 11, ''),
(10312544, 1, 'Samsung 17'),
(10312544, 2, 'Logitech'),
(10312544, 3, 'Logitech'),
(10312544, 4, 'Intel Core i5 2.4 GHz'),
(10312544, 5, 'Radeon X1200'),
(10312544, 6, '200 GB'),
(10312544, 7, '1 GB'),
(10312544, 8, 'Hitachi DVD Super Multi'),
(10312544, 9, ''),
(10312544, 10, ''),
(10312544, 11, ''),
(10342544, 1, 'Samsung 17'),
(10342544, 2, 'Logitech'),
(10342544, 3, 'Logitech'),
(10342544, 4, 'Intel Core i5 2.4 GHz'),
(10342544, 5, 'Radeon X1200'),
(10342544, 6, '200 GB'),
(10342544, 7, '1 GB'),
(10342544, 8, 'Hitachi DVD Super Multi'),
(10342544, 9, ''),
(10342544, 10, ''),
(10342544, 11, ''),
(10342534, 1, 'Samsung 17'),
(10342534, 2, 'Logitech'),
(10342534, 3, 'Logitech'),
(10342534, 4, 'Intel Core i5 2.4 GHz'),
(10342534, 5, 'Radeon X1200'),
(10342534, 6, '200 GB'),
(10342534, 7, '1 GB'),
(10342534, 8, 'Hitachi DVD Super Multi'),
(10342534, 9, ''),
(10342534, 10, ''),
(10342534, 11, ''),
(10335454, 1, 'Samsung 23'),
(10335454, 2, 'Logitech'),
(10335454, 3, 'Microsoft'),
(10335454, 4, 'Intel Core i5 2.7 GHz'),
(10335454, 5, 'NVidia GeForce GTX 680'),
(10335454, 6, '1 TB'),
(10335454, 7, '4 GB'),
(10335454, 8, 'Hitachi DVD Super Multi DL'),
(10335454, 9, ''),
(10335454, 10, ''),
(10335454, 11, ''),
(10335443, 1, 'Samsung 23'),
(10335443, 2, 'Logitech'),
(10335443, 3, 'Microsoft'),
(10335443, 4, 'Intel Core i5 2.7 GHz'),
(10335443, 5, 'NVidia GeForce GTX 680'),
(10335443, 6, '1 TB'),
(10335443, 7, '4 GB'),
(10335443, 8, 'Hitachi DVD Super Multi DL'),
(10335443, 9, ''),
(10335443, 10, ''),
(10335443, 11, ''),
(10346443, 1, 'Samsung 23'),
(10346443, 2, 'Logitech'),
(10346443, 3, 'Microsoft'),
(10346443, 4, 'Intel Core i5 2.7 GHz'),
(10346443, 5, 'NVidia GeForce GTX 680'),
(10346443, 6, '1 TB'),
(10346443, 7, '4 GB'),
(10346443, 8, 'Hitachi DVD Super Multi DL'),
(10346443, 9, ''),
(10346443, 10, ''),
(10346443, 11, ''),
(10347643, 1, 'Samsung 23'),
(10347643, 2, 'Logitech'),
(10347643, 3, 'Microsoft'),
(10347643, 4, 'Intel Core i5 2.7 GHz'),
(10347643, 5, 'NVidia GeForce GTX 680'),
(10347643, 6, '1 TB'),
(10347643, 7, '4 GB'),
(10347643, 8, 'Hitachi DVD Super Multi DL'),
(10347643, 9, ''),
(10347643, 10, ''),
(10347643, 11, ''),
(10347653, 1, 'Samsung 23'),
(10347653, 2, 'Logitech'),
(10347653, 3, 'Microsoft'),
(10347653, 4, 'Intel Core i5 2.7 GHz'),
(10347653, 5, 'NVidia GeForce GTX 680'),
(10347653, 6, '1 TB'),
(10347653, 7, '4 GB'),
(10347653, 8, 'Hitachi DVD Super Multi DL'),
(10347653, 9, ''),
(10347653, 10, ''),
(10347653, 11, ''),
(10347843, 1, 'Samsung 23'),
(10347843, 2, 'Logitech'),
(10347843, 3, 'Microsoft'),
(10347843, 4, 'Intel Core i5 2.7 GHz'),
(10347843, 5, 'NVidia GeForce GTX 680'),
(10347843, 6, '1 TB'),
(10347843, 7, '4 GB'),
(10347843, 8, 'Hitachi DVD Super Multi DL'),
(10347843, 9, ''),
(10347843, 10, ''),
(10347843, 11, ''),
(10365843, 1, 'Samsung 23'),
(10365843, 2, 'Logitech'),
(10365843, 3, 'Microsoft'),
(10365843, 4, 'Intel Core i5 2.7 GHz'),
(10365843, 5, 'NVidia GeForce GTX 680'),
(10365843, 6, '1 TB'),
(10365843, 7, '4 GB'),
(10365843, 8, 'Hitachi DVD Super Multi DL'),
(10365843, 9, ''),
(10365843, 10, ''),
(10365843, 11, ''),
(10368743, 1, 'Samsung 23'),
(10368743, 2, 'Logitech'),
(10368743, 3, 'Microsoft'),
(10368743, 4, 'Intel Core i5 2.7 GHz'),
(10368743, 5, 'NVidia GeForce GTX 680'),
(10368743, 6, '1 TB'),
(10368743, 7, '4 GB'),
(10368743, 8, 'Hitachi DVD Super Multi DL'),
(10368743, 9, ''),
(10368743, 10, ''),
(10368743, 11, ''),
(10368343, 1, 'Samsung 23'),
(10368343, 2, 'Logitech'),
(10368343, 3, 'Microsoft'),
(10368343, 4, 'Intel Core i5 2.7 GHz'),
(10368343, 5, 'NVidia GeForce GTX 680'),
(10368343, 6, '1 TB'),
(10368343, 7, '4 GB'),
(10368343, 8, 'Hitachi DVD Super Multi DL'),
(10368343, 9, ''),
(10368343, 10, ''),
(10368343, 11, ''),
(10453563, 15, 'Epson'),
(10453563, 16, 'L800 (C11CB57301)'),
(10453563, 17, '2'),
(10453453, 15, 'Samsung'),
(10453453, 16, 'SCX-4824FN'),
(10453453, 17, '1'),
(10453553, 15, 'Samsung'),
(10453553, 16, 'SCX-4824FN'),
(10453553, 17, '1'),
(10453353, 15, 'Samsung'),
(10453353, 16, 'SCX-4824FN'),
(10453353, 17, '1'),
(10258576, 12, 'Optoma'),
(10258576, 13, 'EX536'),
(10258576, 14, ''),
(10258756, 12, 'Optoma'),
(10258756, 13, 'EX536'),
(10258756, 14, '');

-- --------------------------------------------------------

--
-- Table structure for table `history`
--

CREATE TABLE IF NOT EXISTS `history` (
  `history_id` int(11) NOT NULL AUTO_INCREMENT,
  `equipment_id` int(11) NOT NULL,
  `action_type_id` int(11) NOT NULL,
  `date` datetime DEFAULT NULL,
  `notice` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`history_id`),
  UNIQUE KEY `history_id_UNIQUE` (`history_id`),
  KEY `fk_history_Equipments1` (`equipment_id`),
  KEY `fk_history_action_types1` (`action_type_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=29 ;

--
-- Dumping data for table `history`
--

INSERT INTO `history` (`history_id`, `equipment_id`, `action_type_id`, `date`, `notice`) VALUES
(1, 10300254, 4, '2012-04-21 17:21:50', ' '),
(2, 10300254, 2, '2012-04-21 17:26:52', ' '),
(3, 10300254, 5, '2012-04-21 17:27:05', ' '),
(4, 10300234, 4, '2012-04-21 17:43:19', ' '),
(5, 10302454, 4, '2012-04-21 18:16:17', ' '),
(6, 10300234, 5, '2012-04-21 18:16:48', ' '),
(7, 10302454, 5, '2012-04-21 18:16:57', ' '),
(8, 10302345, 4, '2012-04-21 18:22:00', ' '),
(9, 10300254, 4, '2012-04-21 18:22:23', ' '),
(10, 10312544, 4, '2012-04-21 18:25:01', ' '),
(11, 10300254, 5, '2012-04-21 19:26:14', ' '),
(12, 10302345, 5, '2012-04-21 19:26:23', ' '),
(13, 10312544, 5, '2012-04-21 19:26:29', ' '),
(14, 10342534, 4, '2012-04-21 19:29:19', ' '),
(15, 10342544, 4, '2012-04-21 19:29:26', ' '),
(16, 10342534, 5, '2012-04-21 21:11:50', ' '),
(17, 10342544, 5, '2012-04-21 21:11:59', ' '),
(18, 10342534, 3, '2012-04-22 01:44:43', ' '),
(19, 10312544, 3, '2012-04-22 01:46:23', ' '),
(20, 10302454, 3, '2012-04-22 01:46:33', ' '),
(21, 10312455, 3, '2012-04-22 01:47:31', ' '),
(22, 10302453, 3, '2012-04-22 01:47:45', ' '),
(23, 10312554, 3, '2012-04-22 01:52:17', ' '),
(24, 10302453, 2, '2012-04-22 04:29:45', ' '),
(25, 10302453, 5, '2012-04-22 04:29:58', ' '),
(26, 10302454, 5, '2012-04-22 04:30:07', ' '),
(27, 10312554, 5, '2012-04-22 04:30:16', ' '),
(28, 10342534, 5, '2012-04-22 04:30:22', ' ');

-- --------------------------------------------------------

--
-- Table structure for table `locations`
--

CREATE TABLE IF NOT EXISTS `locations` (
  `location_id` int(11) NOT NULL AUTO_INCREMENT,
  `location_name` varchar(32) NOT NULL,
  `responsible_admin` varchar(20) DEFAULT NULL,
  `prophylaxis_day_index` int(8) NOT NULL DEFAULT '7',
  `prophylaxis_lesson_index` int(8) NOT NULL DEFAULT '0',
  `last_prophylaxis` datetime DEFAULT NULL,
  PRIMARY KEY (`location_id`),
  UNIQUE KEY `idLocations_UNIQUE` (`location_id`),
  UNIQUE KEY `location_name_UNIQUE` (`location_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `locations`
--

INSERT INTO `locations` (`location_id`, `location_name`, `responsible_admin`, `prophylaxis_day_index`, `prophylaxis_lesson_index`, `last_prophylaxis`) VALUES
(1, '430', 'Иванов', 4, 6, NULL),
(2, '433', 'Петров', 3, 0, NULL),
(3, '429/1', 'Сидоров', 2, 0, NULL),
(4, '429/2', 'Ололоев', 1, 0, NULL),
(5, '428', 'Кузнецов', 7, 0, NULL),
(6, '426', 'Орлов', 7, 0, NULL),
(7, '416/1', '', 7, 0, NULL),
(8, '416/2', '', 5, 0, NULL),
(9, '417', '', 7, 0, NULL),
(10, '229/1', '', 7, 0, NULL),
(11, '229/2', NULL, 7, 0, NULL),
(12, '229/3', NULL, 7, 0, NULL),
(13, '323', '', 7, 0, NULL),
(14, '422', '', 7, 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `states`
--

CREATE TABLE IF NOT EXISTS `states` (
  `state_id` int(11) NOT NULL AUTO_INCREMENT,
  `state_name` varchar(45) NOT NULL,
  PRIMARY KEY (`state_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `states`
--

INSERT INTO `states` (`state_id`, `state_name`) VALUES
(1, 'Справний'),
(2, 'Частково несправний'),
(3, 'Повністю несправний');

-- --------------------------------------------------------

--
-- Table structure for table `types`
--

CREATE TABLE IF NOT EXISTS `types` (
  `type_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_name` varchar(32) NOT NULL,
  PRIMARY KEY (`type_id`),
  UNIQUE KEY `type_id_UNIQUE` (`type_id`),
  UNIQUE KEY `type_name_UNIQUE` (`type_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `types`
--

INSERT INTO `types` (`type_id`, `type_name`) VALUES
(7, 'KVM'),
(8, 'UPS'),
(6, 'WiFi'),
(9, 'Інше'),
(1, 'Комп''ютер'),
(5, 'Комутатор'),
(3, 'Принтер'),
(2, 'Проектор'),
(4, 'Сервер');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attributes`
--
ALTER TABLE `attributes`
  ADD CONSTRAINT `fk_Attributes_Types1` FOREIGN KEY (`type_id`) REFERENCES `types` (`type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `equipments`
--
ALTER TABLE `equipments`
  ADD CONSTRAINT `fk_Equipments_Locations1` FOREIGN KEY (`location_id`) REFERENCES `locations` (`location_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Equipments_States1` FOREIGN KEY (`state_id`) REFERENCES `states` (`state_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Equipments_Types` FOREIGN KEY (`type_id`) REFERENCES `types` (`type_id`) ON DELETE CASCADE ON UPDATE NO ACTION;

--
-- Constraints for table `equipments_has_attributes`
--
ALTER TABLE `equipments_has_attributes`
  ADD CONSTRAINT `fk_Equipments_has_Attributes_Attributes1` FOREIGN KEY (`attribute_id`) REFERENCES `attributes` (`attribute_id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Equipments_has_Attributes_Equipments1` FOREIGN KEY (`equipment_id`) REFERENCES `equipments` (`equipment_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `history`
--
ALTER TABLE `history`
  ADD CONSTRAINT `fk_history_action_types1` FOREIGN KEY (`action_type_id`) REFERENCES `action_types` (`action_type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_history_Equipments1` FOREIGN KEY (`equipment_id`) REFERENCES `equipments` (`equipment_id`) ON DELETE CASCADE ON UPDATE CASCADE;
