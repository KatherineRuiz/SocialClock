CREATE DATABASE SocialClock
GO
USE SocialClock;
GO


CREATE TABLE Seccion (
    idSeccion      INT IDENTITY(1,1) PRIMARY KEY,
    nombreSeccion  VARCHAR(10) NOT NULL
);
GO

CREATE TABLE TipoUsuario (
    idTipoUsuario  INT IDENTITY(1,1) PRIMARY KEY,
    nombreTipo     VARCHAR(25) NOT NULL
);
GO

CREATE TABLE NivelAcademico (
    idNivelAcademico INT IDENTITY(1,1) PRIMARY KEY,
    nombreNivel      VARCHAR(30),
    idSeccion        INT,
    FOREIGN KEY (idSeccion) REFERENCES Seccion(idSeccion)
);
GO

CREATE TABLE Especialidad (
    idEspecialidad     INT IDENTITY(1,1) PRIMARY KEY,
    nombreEspecialidad NVARCHAR(50),
    idNivelAcademico   INT,
    FOREIGN KEY (idNivelAcademico) REFERENCES NivelAcademico(idNivelAcademico)
);
GO

CREATE TABLE Proyecto (
    idProyecto     INT IDENTITY(1,1) PRIMARY KEY,
    nombreProyecto NVARCHAR(100) NOT NULL,
    estado         VARCHAR(20) NOT NULL CHECK (estado IN ('Finalizado', 'Activo'))
);
GO

CREATE TABLE Usuario (
    idUsuario      INT IDENTITY(1,1) PRIMARY KEY,
    nombreUsuario  VARCHAR(25) NOT NULL UNIQUE,
    clave    NVARCHAR(20) NOT NULL UNIQUE,
    idTipoUsuario  INT NOT NULL,
    FOREIGN KEY (idTipoUsuario) REFERENCES TipoUsuario(idTipoUsuario)
);
GO

CREATE TABLE Estudiante (
    idEstudiante      INT IDENTITY(1,1) PRIMARY KEY,
    nombreEstudiante  NVARCHAR(70) NOT NULL,
    carnet            INT NOT NULL UNIQUE,
    Nie               INT NOT NULL UNIQUE,
    idEspecialidad    INT NOT NULL,
    idSeccion         INT NOT NULL,
    idNivelAcademico  INT NOT NULL,
    idProyecto        INT,
    estado            VARCHAR(25) NOT NULL CHECK (estado IN ('Finalizado', 'En proceso')),
    FOREIGN KEY (idEspecialidad)   REFERENCES Especialidad(idEspecialidad),
    FOREIGN KEY (idSeccion)        REFERENCES Seccion(idSeccion),
    FOREIGN KEY (idNivelAcademico) REFERENCES NivelAcademico(idNivelAcademico),
    FOREIGN KEY (idProyecto)       REFERENCES Proyecto(idProyecto)
);
GO

CREATE TABLE Evento (
    idEvento          INT IDENTITY(1,1) PRIMARY KEY,
    nombreEvento      NVARCHAR(50) NOT NULL,
    descripcionEvento NVARCHAR(200) NOT NULL,
    fechaEvento       DATETIME NOT NULL,
    fechaPublicacion  DATETIME NOT NULL,
    horaEvento        DATETIME NOT NULL,
    idUsuario         INT NOT NULL,
    FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)
);
GO

CREATE TABLE BitacoraSocial (
    idBitacoraSocial INT IDENTITY(1,1) PRIMARY KEY,
    registroHoras    INT NOT NULL,
    descripcion      NVARCHAR(50) NOT NULL,
    idEstudiante     INT NOT NULL,
    idUsuario        INT NOT NULL,
    FOREIGN KEY (idEstudiante) REFERENCES Estudiante(idEstudiante),
    FOREIGN KEY (idUsuario)    REFERENCES Usuario(idUsuario)
);
GO

SELECT * FROM Seccion;
SELECT * FROM TipoUsuario;
SELECT * FROM NivelAcademico;
SELECT * FROM Especialidad;
SELECT * FROM Proyecto;
SELECT * FROM Usuario;
SELECT * FROM Estudiante;
SELECT * FROM Evento;
SELECT * FROM BitacoraSocial;

insert into Estudiante values ('Katherine',20250409, 123456, 1, 4, 2, 3)