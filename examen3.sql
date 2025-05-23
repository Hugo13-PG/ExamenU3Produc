CREATE DATABASE Tienda;
go
USE Tienda;
go

CREATE TABLE Producto (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255),
    Precio varchar(100) NOT NULL,
    Stock varchar(100) NOT NULL ,
    FechaRegistro DATE
);
go
INSERT INTO Producto (Nombre, Descripcion, Precio, Stock, FechaRegistro)
VALUES 
    ('Smartphone', 'Teléfono inteligente con pantalla OLED y 128GB de almacenamiento', '15999.00', 15, '2025-05-23'),
    ('Teclado Mecánico', 'Teclado mecánico RGB con switches táctiles', '1299.00', 30, '2025-05-23');

	SELECT ID AS [ID Producto], 
       Nombre, Descripcion, Precio, Stock, FechaRegistro
FROM Producto;