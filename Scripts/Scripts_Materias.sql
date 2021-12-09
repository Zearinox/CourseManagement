CREATE TABLE Profesor
(
Id int NOT NULL IDENTITY(1,1),
Nombre varchar(200) NULL,
Apellido varchar(200) NULL,
CONSTRAINT PK_Profesor_Id PRIMARY KEY(Id)
);

CREATE TABLE Anios
(
Id int NOT NULL IDENTITY(1,1),
Nombre varchar(200) NULL,
CONSTRAINT PK_Anios_Id PRIMARY KEY(Id)
);

CREATE TABLE Cuatrimestre
(
Id int NOT NULL IDENTITY(1,1),
Nombre varchar(200) NULL,
CONSTRAINT PK_Cuatrimestre_Id PRIMARY KEY(Id)
);

CREATE TABLE Materia
(
Id int NOT NULL IDENTITY(1,1),
NombreMateria varchar(200) NULL,
DiaCursada varchar(200) NULL,
Cursada bit NULL,
Aprobada bit NULL,
IdAnio int NULL,
IdCuatrimestre int NULL,
IdProfesor int NULL,
CONSTRAINT PK_Materia_Id PRIMARY KEY(Id),
CONSTRAINT FK_Materia_IdProfesor FOREIGN KEY (IdProfesor) REFERENCES Profesor(Id),
CONSTRAINT FK_Materia_IdAnio FOREIGN KEY (IdAnio) REFERENCES Anios(Id),
CONSTRAINT FK_Materia_IdCuatrimestre FOREIGN KEY (IdCuatrimestre) REFERENCES Cuatrimestre(Id),
);


insert into Profesor (Nombre, Apellido) values ('Daniel Gino', 'Corti');
insert into Profesor (Nombre, Apellido) values ('Miguel Angel', 'Lombardi');
insert into Profesor (Nombre, Apellido) values ('Mariano', 'Sabala');

insert into Anios (Nombre) values ('Primer Año');
insert into Anios (Nombre) values ('Segundo Año');
insert into Anios (Nombre) values ('Tercer Año');

insert into Cuatrimestre (Nombre) values ('Primero');
insert into Cuatrimestre (Nombre) values ('Segundo');
insert into Cuatrimestre (Nombre) values ('Anual');