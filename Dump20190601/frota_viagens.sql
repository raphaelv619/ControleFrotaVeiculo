-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: frota
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `viagens`
--

DROP TABLE IF EXISTS `viagens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `viagens` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cpfmotorista` varchar(20) NOT NULL,
  `nomemotorista` varchar(45) DEFAULT NULL,
  `placacarro` varchar(20) NOT NULL,
  `dateviagem` date NOT NULL,
  `dateviagemfeita` date NOT NULL,
  `motivo` tinytext,
  `situacao` varchar(20) DEFAULT NULL,
  `kminicial` varchar(15) DEFAULT NULL,
  `kmfinal` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `viagens`
--

LOCK TABLES `viagens` WRITE;
/*!40000 ALTER TABLE `viagens` DISABLE KEYS */;
INSERT INTO `viagens` VALUES (1,'398.729.178-84','Raphael Villadouro dos Santos','KNB-6364','2019-05-20','2019-05-20','Filmagem na Av.Presidente Vargas','Realizada','185.000','185.500'),(4,'398.729.178-84','Raphael Villadouro dos Santos','KNB-6364','2019-05-11','0001-01-01','','Realizada','',''),(5,'123456','Junior Seila','XXX-1111','2019-05-17','0001-01-01','zxzx','Pendente','',''),(6,'123456','Junior Seila','ABC-1234','2018-08-20','0001-01-01','asasas','Pendente',NULL,NULL),(7,'398.729.178-84','Raphael Villadouro dos Santos','KNB-6364','2019-04-22','0001-01-01','','Pendente',NULL,NULL),(8,'398.729.178-84','Raphael Villadouro dos Santos','KNB-6364','2019-05-24','0001-01-01','Viagem para Ribeirao Preto','Pendente','',''),(9,'398.729.178-84','Raphael Villadouro dos Santos','KNB-6364','1990-05-12','1900-12-20','voage','Concluída','60.000','70.000');
/*!40000 ALTER TABLE `viagens` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-01 16:14:37
