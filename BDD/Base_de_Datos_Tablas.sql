CREATE DATABASE SisGar
use SisGar

CREATE TABLE garajes(
	id_garaje INT PRIMARY KEY,
	nombre NVARCHAR(100),
	direccion NVARCHAR(150),
	localidad NVARCHAR(60),
	telefono NVARCHAR(30),
	precioxhora DECIMAL(5,2),
	plazas INT
)

CREATE TABLE tickets(
	id_garaje INT FOREIGN KEY REFERENCES garajes(id_garaje),
	id_ticket INT,
	patente NVARCHAR(30),
	entrada DATETIME,
	salida DATETIME,
	total DECIMAL(10,2),
	estado NVARCHAR(20),
	PRIMARY KEY (id_garaje, id_ticket)
)

CREATE TABLE usuarios(
	id_usuario INT PRIMARY KEY,
	usuario NVARCHAR(60),
	psw NVARCHAR(60)
)

CREATE PROCEDURE PrimerTicket 
@nroTicket INT,
@nroGaraje INT
AS
BEGIN
SELECT nombre, direccion, localidad, telefono, patente,
 CONCAT(REPLACE(CONVERT(VARCHAR,entrada,4),'.' ,'/'),' ', CONVERT(VARCHAR,entrada,8)) AS entrada,
 id_ticket FROM tickets
INNER JOIN garajes ON garajes.id_garaje = tickets.id_garaje WHERE id_ticket = @nroTicket AND tickets.id_garaje = @nroGaraje
END

CREATE PROCEDURE SegundoTicket 
@nroTicket INT,
@nroGaraje INT
AS
BEGIN
SELECT nombre, direccion, localidad, telefono, patente,
 CONCAT(REPLACE(CONVERT(VARCHAR,entrada,4),'.' ,'/'),' ', CONVERT(VARCHAR,entrada,8)) AS entrada,
 CONCAT(REPLACE(CONVERT(VARCHAR,salida,4),'.' ,'/'),' ', CONVERT(VARCHAR,salida,8)) AS salida,
 id_ticket, total FROM tickets
INNER JOIN garajes ON garajes.id_garaje = tickets.id_garaje WHERE id_ticket = @nroTicket AND tickets.id_garaje = @nroGaraje
END

SELECT SUM(total) from tickets WHERE id_garaje = 1 AND MONTH(entrada) = 10 AND YEAR(entrada) = 2022
SELECT SUM(total) from tickets WHERE id_garaje = 2