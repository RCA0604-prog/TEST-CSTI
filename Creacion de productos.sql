CREATE DATABASE Productos_DEV
GO

USE Productos_DEV
GO

DROP TABLE Productos
GO
CREATE TABLE Productos 
(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	Descripcion VARCHAR(500) NOT NULL,
	Codigo VARCHAR(50) NOT NULL,
	Precio DECIMAL NOT NULL,
	FechaCreacion DATETIME NOT NULL
)
GO

/* Solo para pruebas, crear productos  */

INSERT INTO Productos (Nombre, Codigo, Descripcion, Precio, FechaCreacion)
VALUES 
('Laptop Dell Inspiron', 'LAP-DELL-001', 'Laptop 15.6 pulgadas, Intel Core i5, 8GB RAM, 256GB SSD', 8500.00, GETDATE()),
('Mouse Logitech M185', 'MOU-LOG-002', 'Mouse inalámbrico 2.4 GHz, 3 botones, 1 año de batería', 180.50, GETDATE()),
('Teclado Redragon Kumara', 'TEC-RED-003', 'Teclado mecánico RGB, switches Outemu azules, diseño compacto', 650.00, GETDATE()),
('Monitor Samsung 24"', 'MON-SAM-004', 'Monitor LED 24 pulgadas, Full HD, 75Hz, HDMI/VGA', 2200.00, GETDATE()),
('Disco SSD Kingston 480GB', 'SSD-KIN-005', 'Disco sólido SATA III, velocidad 500MB/s lectura', 550.00, GETDATE()),
('Audífonos HyperX Cloud II', 'AUD-HYP-006', 'Audífonos gaming con sonido 7.1 virtual, micrófono extraíble', 890.00, GETDATE()),
('Webcam Logitech C270', 'WEB-LOG-007', 'Cámara web HD 720p, micrófono integrado, enfoque fijo', 420.00, GETDATE()),
('USB Kingston 64GB', 'USB-KIN-008', 'Memoria USB 3.0, 64GB, velocidad de lectura 100MB/s', 85.00, GETDATE()),
('Silla Gamer Corsair T3', 'SIL-COR-009', 'Silla gaming con soporte lumbar, reposabrazos 4D, reclinable', 3850.00, GETDATE()),
('Router TP-Link AC1200', 'ROU-TPL-010', 'Router doble banda 2.4GHz/5GHz, 4 antenas externas', 520.00, GETDATE());
GO
