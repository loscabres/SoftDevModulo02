CREATE DATABASE  IF NOT EXISTS `stock` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `stock`;
-- MySQL dump 10.16  Distrib 10.1.18-MariaDB, for Win64 (AMD64)
--
-- Host: 192.168.109.129    Database: stock
-- ------------------------------------------------------
-- Server version	10.1.14-MariaDB

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
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `Id_Clientes` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(200) NOT NULL,
  `Direccion` varchar(200) DEFAULT NULL,
  `Telefono` varchar(100) DEFAULT NULL,
  `Cedula` varchar(100) DEFAULT NULL,
  `Ruc` varchar(100) DEFAULT NULL,
  `Nacimiento` date DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `CantidadHijos` int(11) unsigned NOT NULL DEFAULT '0',
  `Salario` decimal(10,2) NOT NULL DEFAULT '0.00',
  `Foto` mediumblob,
  `Genero` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`Id_Clientes`),
  UNIQUE KEY `Id_ClientesUnique` (`Id_Clientes`),
  KEY `Id_ClientesKey` (`Id_Clientes`),
  KEY `NombreKey` (`Nombre`),
  KEY `CedulaKey` (`Cedula`),
  KEY `RucKey` (`Ruc`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COMMENT='Tabla con los datos de los clientes';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'LEONARDO TESTA','CIUDAD DEL ESTE','0973608296','30386479','30386479','1983-08-20','leonardodiegotesta@hotmail.com',1,1000.55,NULL,0),(2,'JUAN','MINGA GUAZU','(0994) 951753','987412','147896','2016-06-18','pedro@pedro.com',5,7000.00,'',0),(3,'PABLO','ASUNCION','0973 789654','7859654','35847896','1984-10-03','pablo@pablo.com',0,7000.00,'',0);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `colores`
--

DROP TABLE IF EXISTS `colores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `colores` (
  `Id_Colores` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) NOT NULL,
  PRIMARY KEY (`Id_Colores`),
  UNIQUE KEY `Id_Colores` (`Id_Colores`),
  UNIQUE KEY `Descripcion` (`Descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `colores`
--

LOCK TABLES `colores` WRITE;
/*!40000 ALTER TABLE `colores` DISABLE KEYS */;
INSERT INTO `colores` VALUES (1,'AZUL');
/*!40000 ALTER TABLE `colores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'stock'
--

--
-- Dumping routines for database 'stock'
--
/*!50003 DROP PROCEDURE IF EXISTS `Pa_ConsultarClientes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pa_ConsultarClientes`(IN `ParOpcion` INT, IN `ParId` INT)
BEGIN

	IF ParOpcion=1 THEN
		SELECT
			Id_Clientes,
			Nombre
		FROM
			clientes
		ORDER BY
			Id_Clientes;	
	ELSEIF ParOpcion=2 THEN
		SELECT
			Id_Clientes,
			Nombre,
			Direccion,
			Telefono,
			Cedula,
			Ruc,
			Nacimiento,
			Email,
			CantidadHijos,
			Salario,
			Foto,
			Genero
		FROM
			clientes
		WHERE
			Id_Clientes=ParId;		
	END IF;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Pa_ConsultarColores` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pa_ConsultarColores`(
        IN `ParOpcion` INTEGER,
        IN `ParId` INTEGER
    )
BEGIN
	IF ParOpcion=1 THEN
		SELECT
			Id_Colores,
			Descripcion
		FROM
			colores
		ORDER BY
			Descripcion;	
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Pa_EditarClientes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pa_EditarClientes`(IN `ParOpcion` INT, IN `ParNombre` VARCHAR(200), IN `ParDireccion` VARCHAR(200), IN `ParTelefono` VARCHAR(100), IN `ParCedula` VARCHAR(100), IN `ParRuc` VARCHAR(100), IN `ParNacimiento` DATE, IN `ParEmail` VARCHAR(100), IN `ParCantidadHijos` INT, IN `ParSalario` DECIMAL(10,2), IN `ParFoto` MEDIUMBLOB, IN `ParGenero` TINYINT, IN `ParId` INT)
BEGIN
	IF ParOpcion=1 THEN
		UPDATE
			clientes
		SET
			Nombre=ParNombre,
			Direccion=ParDireccion,
			Telefono=ParTelefono,
			Cedula=ParCedula,
			Ruc=ParRuc,
			Nacimiento=ParNacimiento,
			Email=ParEmail,
			CantidadHijos=ParCantidadHijos,
			Salario=ParSalario,
			Foto=ParFoto,
			Genero=ParGenero
		WHERE
			Id_Clientes=ParId;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Pa_EditarColores` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pa_EditarColores`(
        IN `ParOpcion` INTEGER(11),
        IN `ParDescripcion` VARCHAR(100),
        IN `ParId` INTEGER(10)
    )
BEGIN
	IF ParOpcion=1 THEN
    	UPDATE
        	colores
        SET
        	Descripcion=ParDescripcion
        WHERE
        	Id_Colores=ParId;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Pa_EliminarClientes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pa_EliminarClientes`(IN `ParOpcion` INT, IN `ParId` INT)
BEGIN
	IF ParOpcion=1 THEN
		DELETE FROM
			clientes
		WHERE 
			Id_Clientes=ParId;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Pa_EliminarColores` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pa_EliminarColores`(
        IN `ParOpcion` INTEGER(11),
        IN `ParId` INTEGER(10)
    )
BEGIN
	IF ParOpcion=1 THEN
    	DELETE FROM
        	colores
        WHERE
        	Id_Colores=ParId;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Pa_InsertarClientes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pa_InsertarClientes`(IN `ParOpcion` INT, IN `ParNombre` VARCHAR(200), IN `ParDireccion` VARCHAR(200), IN `ParTelefono` VARCHAR(100), IN `ParCedula` VARCHAR(100), IN `ParRuc` VARCHAR(100), IN `ParNacimiento` DATE, IN `ParEmail` VARCHAR(100), IN `ParCantidadHijos` INT, IN `ParSalario` DECIMAL(10,2), IN `ParFoto` MEDIUMBLOB, IN `ParGenero` TINYINT)
BEGIN

	IF ParOpcion=1 THEN
		
		INSERT INTO
			clientes
		(
			Nombre,
			Direccion,
			Telefono,
			Cedula,
			Ruc,
			Nacimiento,
			Email,
			CantidadHijos,
			Salario,
			Foto,
			Genero
		)
		VALUES
		(
			ParNombre,
			ParDireccion,
			ParTelefono,
			ParCedula,
			ParRuc,
			ParNacimiento,
			ParEmail,
			ParCantidadHijos,
			ParSalario,
			ParFoto,
			ParGenero
		);
		
		SELECT LAST_INSERT_ID();
		
		
	END IF;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Pa_InsertarColores` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pa_InsertarColores`(
        IN `ParOpcion` INTEGER(11),
        IN `ParDescripcion` VARCHAR(100)
    )
BEGIN
	IF ParOpcion=1 THEN
    	INSERT INTO
        	colores
        (
        	Descripcion
        )
        VALUES
        (
        	ParDescripcion
        );
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-29 19:21:01