CREATE DATABASE SocialClock
GO
USE SocialClock;
GO


Create table Rol (
idRol int identity (1,1) primary key,
nombreRol varchar (25) not null
);
Go

Create table Proyecto (
idProyecto int identity (1,1) primary key,
nombreProyecto varchar (40) not null,
estadoProyecto int default 0 not null
);
Go

Create table Especialidad (
idEspecialidad int identity (1,1) primary key,
nombreEspecialidad varchar (40) not null 
);
Go

Create table NivelAcademico (
idNivelAcademico int identity (1,1) primary key,
nombreNivel varchar (30) not null
);
Go

Create table Seccion(
idSeccion int identity (1,1) primary key,
nombreSeccion varchar(20) not null
);
Go

-- Aqui terminan las tablas padre --

Create table Esp_Niv_Sec(
idEsp_Niv_Sec int identity (1,1) primary key,
id_Especialidad int not null,
id_NivelAcademico int not null,
id_Seccion int not null
constraint fkEspecialidad foreign key (id_Especialidad)
references Especialidad (idEspecialidad) on delete cascade,
constraint fkSeccion foreign key (id_Seccion)
references Seccion (idSeccion) on delete cascade,
constraint fkNivelAcademico foreign key (id_NivelAcademico)
references NivelAcademico (idNivelAcademico) on delete cascade
);
Go

Create table Usuario (
idUsuario int identity (1,1) primary key,
nombreUsuario varchar (30) unique not null,
clave varchar (10) unique not null,
estadoUsuario int default 0 not null,
id_Rol int not null,
constraint fkRol foreign key (id_Rol)
references Rol(idRol) on delete cascade,
);
Go


create table Evento (
idEvento int identity (1,1) primary key,
nombreEvento varchar(40) not null,
descripcionEvento varchar(200) not null,
fechaEvento date not null,
fechaHoraPublicacion datetime not null,
idUsuario int not null,
constraint fkUsuario foreign key (idUsuario)
references Usuario(idUsuario) on delete cascade,
);
Go

Create table Estudiante (
idEstudiante int identity (1,1) primary key,
nombreEstudiante varchar (70) not null,
carnet int unique not null,
nie int unique not null ,
estadoEstudiante int default 0 not null,
id_Proyecto int not null,
id_EspNivSec int not null,
constraint fkProyecto foreign key (id_Proyecto)
references Proyecto(idProyecto) on delete cascade,
constraint fkEspNivSec foreign key (id_EspNivSec)
references Esp_Niv_Sec(idEsp_Niv_Sec) on delete cascade,
);
Go
ALTER TABLE Estudiante
ADD CONSTRAINT DF_Nie DEFAULT 0 FOR nie;

Create table BitacoraSocial (
idBitacora int identity (1,1) primary key,
registroHoras int not null,
descripcion nvarchar(100) not null,
idEstudiante int not null,
constraint fkEstudiante foreign key(idEstudiante)
references Estudiante(idEstudiante) on delete cascade,
);
Go

--Insersiones
insert into Rol values
('Administrador'),
('Colaborador');

insert into Proyecto values
('Stant Cultural',0),
('Psicología',0);

insert into Especialidad values
('Desarrollo de software'),
('Diseño gráfico'),
('Electromecánica'),
('Arquitectura'),
('Administración contable'),
('Electrónica'),
('Energías renovables');

insert into Seccion values 
('A-1'),
('A-2'),
('A-3'),
('A-4'),
('A-5'),
('B-1'),
('B-2'),
('B-3'),
('B-4');

insert into NivelAcademico values
('Primer año'),
('Segundo año'),
('Tercer año');

insert into Esp_Niv_Sec values 
(1,1,1),
(1,1,2);


insert into Usuario values
('Ana Cecilia Ordoñez',544854,0,1),
('Mirna Espinoza Anzora',277423,0,2);

insert into Evento values 
('Día de la madre', 'Los estudiantes de cultural realizarán la decoración', '2025/5/5','2025/5/1 10:30:00', 1),
('Retiro de padres', 'Los estudiantes de protocolo ordenaran las sillas', '2025/7/19','2025/7/10 11:30:00', 2);

insert into Estudiante values
('Katherine Andrea Ruiz Bonilla',20250409,665464,0,1,2),
('Abraham Isaac Rodríguez Velasquez',20230129,1651653,0,2,1);

insert into BitacoraSocial values 
(50, 'Creación de stand cultural', 1),
(40, 'Participación en obra de teatro', 2);



--Primer Inner Join--

Select  Especialidad.nombreEspecialidad As [Especialidad], NivelAcademico.nombreNivel As [Nivel académico], Seccion.nombreSeccion As [Seccion]
from Esp_Niv_Sec
INNER JOIN
NivelAcademico on Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico
INNER JOIN
Seccion on Esp_Niv_Sec.id_Seccion = Seccion.idSeccion
INNER JOIN
Especialidad on Esp_Niv_Sec.id_Especialidad = Especialidad.idEspecialidad


--Segundo Inner Join--

select Usuario.idUsuario, Usuario.nombreUsuario As [Usuario], Rol.nombreRol As [Rol], clave As [Contraseña], estadoUsuario As [Estado]
from Usuario
inner join
Rol On Usuario.id_Rol = Rol.idRol

--Tercer Inner Join--

select idEvento, nombreEvento As [Evento], descripcionEvento As [Descripcion], fechaEvento As [Fecha del Evento],
fechaHoraPublicacion As [Hora de publicacion], Usuario.nombreUsuario As [Usuario]
from Evento
inner join
Usuario on Evento.idUsuario = Usuario.idUsuario

-- Cuarto inner join --

select  carnet As [Carnet], nombreEstudiante As [Nombre],Especialidad.nombreEspecialidad As [Especialidad],
NivelAcademico.nombreNivel As [Nivel académico], Seccion.nombreSeccion As [Seccion], nie As [NIE], estadoEstudiante As 
[Estado],  Proyecto.nombreProyecto As [Proyecto]
from Estudiante 
INNER JOIN
Proyecto on Estudiante.id_Proyecto = Proyecto.idProyecto
INNER JOIN
Esp_Niv_Sec on Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec
INNER JOIN
Especialidad on Esp_Niv_Sec.id_Especialidad = Especialidad.idEspecialidad
INNER JOIN 
NivelAcademico on Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico
INNER JOIN 
Seccion on Esp_Niv_Sec.id_Seccion = Seccion.idSeccion where NivelAcademico.idNivelAcademico = 1

 
select *from Seccion
select *from Rol
select *from NivelAcademico
select *from Especialidad
select *from Proyecto
select *from Usuario
select *from Estudiante
select *from Evento
select *from BitacoraSocial
select *from Esp_Niv_Sec
 
 SELECT idEsp_Niv_Sec FROM Esp_Niv_Sec WHERE id_Especialidad = 1 AND id_NivelAcademico = 1 AND id_Seccion = 1;