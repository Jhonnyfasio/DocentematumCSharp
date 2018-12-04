
DROP TABLE IF EXISTS `carrera`;
CREATE TABLE IF NOT EXISTS `carrera` (
  `idCarrera` char(4) NOT NULL,
  `idDivision` int(11) NOT NULL,
  `idNivel` int(11) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idCarrera`),
  KEY `idDivision` (`idDivision`),
  KEY `carrera_nivel` (`idNivel`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `carrera_profesor`;
CREATE TABLE IF NOT EXISTS `carrera_profesor` (
  `idCarrera` varchar(4) NOT NULL,
  `idProfesor` int(11) NOT NULL,
  PRIMARY KEY (`idCarrera`,`idProfesor`),
  KEY `carreraProfesor_profesor` (`idProfesor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `division`;
CREATE TABLE IF NOT EXISTS `division` (
  `idDivision` int(11) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idDivision`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `grado`;
CREATE TABLE IF NOT EXISTS `grado` (
  `idGrado` int(11) NOT NULL AUTO_INCREMENT,
  `idTipo` int(11) NOT NULL,
  `nombre` char(40) DEFAULT NULL,
  PRIMARY KEY (`idGrado`),
  KEY `idTipo` (`idTipo`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `grado_profesor`;
CREATE TABLE IF NOT EXISTS `grado_profesor` (
  `idGrado` int(11) NOT NULL,
  `idProfesor` int(11) NOT NULL,
  PRIMARY KEY (`idGrado`,`idProfesor`),
  KEY `idProfesor` (`idProfesor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `grado_tipo`;
CREATE TABLE IF NOT EXISTS `grado_tipo` (
  `idGradoTipo` int(11) NOT NULL,
  `tipo` varchar(15) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idGradoTipo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `nivel`;
CREATE TABLE IF NOT EXISTS `nivel` (
  `idNivel` int(11) NOT NULL,
  `tipo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idNivel`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `produccion`;
CREATE TABLE IF NOT EXISTS `produccion` (
  `idProduccion` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(30) DEFAULT NULL,
  `titulo` varchar(40) DEFAULT NULL,
  `fechaInicio` varchar(10) DEFAULT NULL,
  `fechaFinal` varchar(10) DEFAULT NULL,
  `numeroInstitucion` int(11) DEFAULT NULL,
  `proposito` varchar(150) DEFAULT NULL,
  `numeroRegistro` int(11) DEFAULT NULL,
  `status` varchar(11) DEFAULT NULL,
  `idProfesor` int(11) NOT NULL,
  PRIMARY KEY (`idProduccion`),
  KEY `profesor_produccionOwn` (`idProfesor`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `profesor`;
CREATE TABLE IF NOT EXISTS `profesor` (
  `codigoTrabajador` int(11) NOT NULL,
  `idTipoUsuario` int(11) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  `apellidoPaterno` varchar(25) DEFAULT NULL,
  `apellidoMaterno` varchar(25) DEFAULT NULL,
  `usuario` varchar(20) DEFAULT NULL,
  `contrasena` varchar(20) DEFAULT NULL,
  `fechaNacimiento` varchar(10) DEFAULT NULL,
  `correo` varchar(35) DEFAULT NULL,
  `telefono` char(10) DEFAULT NULL,
  `admision` varchar(10) DEFAULT NULL,
  `ultimoCiclo` varchar(10) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`codigoTrabajador`),
  KEY `idTipoUsuario` (`idTipoUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `tipo_usuario`;
CREATE TABLE IF NOT EXISTS `tipo_usuario` (
  `idTipoUsuario` int(11) NOT NULL,
  `tipo` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idTipoUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `carrera`
  ADD CONSTRAINT `carrera_division` FOREIGN KEY (`idDivision`) REFERENCES `division` (`idDivision`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `carrera_nivel` FOREIGN KEY (`idNivel`) REFERENCES `nivel` (`idNivel`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `carrera_profesor`
  ADD CONSTRAINT `carreraProfesor_carrera` FOREIGN KEY (`idCarrera`) REFERENCES `carrera` (`idCarrera`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `carreraProfesor_profesor` FOREIGN KEY (`idProfesor`) REFERENCES `profesor` (`codigoTrabajador`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `grado`
  ADD CONSTRAINT `tipo_gradoTipo` FOREIGN KEY (`idTipo`) REFERENCES `grado_tipo` (`idGradoTipo`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `grado_profesor`
  ADD CONSTRAINT `gradoProfesor_grado` FOREIGN KEY (`idGrado`) REFERENCES `grado` (`idGrado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `gradoProfesor_profesor` FOREIGN KEY (`idProfesor`) REFERENCES `profesor` (`codigoTrabajador`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `produccion`
  ADD CONSTRAINT `profesor_produccionOwn` FOREIGN KEY (`idProfesor`) REFERENCES `profesor` (`codigoTrabajador`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `profesor`
  ADD CONSTRAINT `profesor_tipoUsuario` FOREIGN KEY (`idTipoUsuario`) REFERENCES `tipo_usuario` (`idTipoUsuario`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;


INSERT INTO `division` (`idDivision`, `nombre`) VALUES
(43829, 'Ingenierías'),
(93821, 'Ciencias Básicas'),
(123456, 'DIVEC');

INSERT INTO `nivel` (`idNivel`, `tipo`) VALUES
(1, 'TSU'),
(2, 'Licenciatura');

INSERT INTO `carrera` (`idCarrera`, `idDivision`, `idNivel`, `nombre`) VALUES
('INCO', 123456, 2, 'Ingeniería en Computación'),
('INNI', 123456, 2, 'Ingeniería en Informática'),
('INQU', 43829, 2, 'Ingeniería Química');

INSERT INTO `tipo_usuario` (`idTipoUsuario`, `tipo`) VALUES
(1, 'Administrador'),
(2, 'Especial'),
(3, 'Estándar');

INSERT INTO `grado_tipo` (`idGradoTipo`, `tipo`, `nombre`) VALUES
(1, 'Licenciatura', 'Licenciatura'),
(2, 'Especialidad', 'Especialidad'),
(3, 'Maestría', 'Maestría'),
(4, 'Doctorado', 'Doctorado'),
(5, 'Postdoctorado', 'Postdoctorado');

INSERT INTO `grado` (`idGrado`, `idTipo`, `nombre`) VALUES
(1, 1, 'Ingeniería en Computación'),
(2, 1, 'Ingeniería en Informática'),
(3, 1, 'Ingeniería Química'),
(14, 1, 'Turismo');

INSERT INTO `profesor` (`codigoTrabajador`, `idTipoUsuario`, `nombre`, `apellidoPaterno`, `apellidoMaterno`, `usuario`, `contrasena`, `fechaNacimiento`, `correo`, `telefono`, `admision`, `ultimoCiclo`, `estado`) VALUES
(1234, 2, '1234', '1234', '234', '1234', '234', '2018-11-28', '', '', '2018-11-28', '2018-11-28', 'ACTIVO'),
(1234567, 1, 'asdf', 'sdf', 'sdf', 'asdf', 'sdf', '2018-11-28', '', '', '2018-11-28', '2018-11-28', 'ACTIVO'),
(2960879, 3, 'Juan Manuel', 'Balderrama', 'González', 'Jhonnyfasio', 'juan123', '2018-02-14', 'juan9_manuel@hotmail.com', '3333981257', '2016-08-15', '2018-08-13', 'ACTIVO');

INSERT INTO `produccion` (`idProduccion`, `tipo`, `titulo`, `fechaInicio`, `fechaFinal`, `numeroInstitucion`, `proposito`, `numeroRegistro`, `status`, `idProfesor`) VALUES
(5, 'Ambiental', 'Ambiente para todos', '2018-11-28', '2018-11-28', 32832, 'Ambientar', 3222, 'Pendiente', 2960879),
(6, 'Ecología2', 'Ecología para todos', '2018-11-28', '2018-11-28', 3282, 'Hacer un mundo mejor', 1942, 'Pendiente', 2960879);

INSERT INTO `carrera_profesor` (`idCarrera`, `idProfesor`) VALUES
('INNI', 2960879);

INSERT INTO `grado_profesor` (`idGrado`, `idProfesor`) VALUES
(1, 2960879),
(2, 2960879);