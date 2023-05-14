CREATE DATABASE ProyectoTiendaZapatos
GO

USE ProyectoTiendaZapatos
GO

ALTER AUTHORIZATION ON DATABASE::ProyectoTiendaZapatos TO sa
GO
	-- Tablas

CREATE TABLE rol (
	id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	nombre VARCHAR (20) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE usuario (
	id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	usuario VARCHAR (50) NOT NULL UNIQUE,
	contrasenia VARCHAR (100) NOT NULL,
	id_Rol INT NOT NULL FOREIGN KEY REFERENCES rol (id) ON UPDATE CASCADE CHECK (id_Rol > 0),
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE tipoDocumento (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (50) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE iva (
	id INT IDENTITY (1,1) PRIMARY KEY,
	iva VARCHAR (5) NOT NULL CHECK (ISNUMERIC(iva) = 1),
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE categoriaCliente (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (5) NOT NULL,
	descripcion VARCHAR (100),
	descuento INT NOT NULL CHECK (descuento > 0),
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE tipoCliente (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (50) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE departamento (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE municipio (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	id_Departamento INT NOT NULL FOREIGN KEY REFERENCES departamento (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_Departamento > 0),
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE color (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE tallas (
	id INT IDENTITY (1,1) PRIMARY KEY,
	talla VARCHAR (2) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE coleccion (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	epoca VARCHAR (50) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE material (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE tipoCalzado (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE tipoPago (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE cliente (
	numID VARCHAR (20) PRIMARY KEY,
	id_TipoDocumento INT NOT NULL FOREIGN KEY REFERENCES tipoDocumento (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_TipoDocumento > 0),
	nombres VARCHAR (100) NOT NULL,
	apellidos VARCHAR (100) NOT NULL,
	fchNac DATE NOT NULL CHECK(fchNac < CONVERT(DATE, GETDATE())),
	direccion VARCHAR (100) NOT NULL,
	telefono VARCHAR (10) NOT NULL CHECK (ISNUMERIC(telefono) = 1),
	correoElectronico VARCHAR (100) UNIQUE NOT NULL,
	contrasenia VARCHAR (100) NOT NULL,
	id_TipoCliente INT NOT NULL FOREIGN KEY REFERENCES tipoCliente (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	id_Municipio INT NOT NULL FOREIGN KEY REFERENCES municipio (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_Municipio > 0),
	id_Categoria INT NOT NULL FOREIGN KEY REFERENCES categoria (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_Categoria > 0),
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE empresa (
	numID_Cliente VARCHAR (20) NOT NULL FOREIGN KEY REFERENCES cliente (numID) ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE CHECK (ISNUMERIC(numID_Cliente) = 1),
	NIT VARCHAR (20) NOT NULL UNIQUE CHECK (ISNUMERIC(NIT) = 1),
	PRIMARY KEY (numID_Cliente, NIT),
	nombreEmpresa VARCHAR (100) NOT NULL,
	dirBodega VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE producto (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombreProducto VARCHAR (100) NOT NULL,
	id_Color INT NOT NULL FOREIGN KEY REFERENCES color (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_Color > 0),
	id_Coleccion INT NOT NULL FOREIGN KEY REFERENCES coleccion (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_Coleccion > 0),
	id_Material INT NOT NULL FOREIGN KEY REFERENCES material (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_Material > 0),
	id_TipoCalzado INT NOT NULL FOREIGN KEY REFERENCES tipoCalzado (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_TipoCalzado > 0),
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE producto_talla (
	id INT IDENTITY (1,1) PRIMARY KEY,
	id_Producto INT NOT NULL FOREIGN KEY REFERENCES producto (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	id_Talla INT NOT NULL FOREIGN KEY REFERENCES tallas (id) ON DELETE NO ACTION ON UPDATE CASCADE,	
	valUnitario INT NOT NULL CHECK (valUnitario > 0),
	stock SMALLINT NOT NULL CHECK (stock > 0),
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE pedido (
	id INT IDENTITY (1,1) PRIMARY KEY,
	id_Producto_talla INT NOT NULL FOREIGN KEY REFERENCES producto_talla (id) ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE CHECK (id_Producto_talla > 0),
	cantidadPedido SMALLINT NOT NULL CHECK (cantidadPedido > 0),
	estado BIT NOT NULL DEFAULT 1 CHECK (estado IN ( 0 , 1))
);
GO

CREATE TABLE detallesFactura (
	id INT IDENTITY (1,1) PRIMARY KEY,
	id_Pedido INT NOT NULL FOREIGN KEY REFERENCES pedido (id) ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE CHECK (id_Pedido > 0),
	descripcion VARCHAR (100),
	id_TipoPago INT NOT NULL FOREIGN KEY REFERENCES tipoPago (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_TipoPago > 0),
	id_Iva INT NOT NULL FOREIGN KEY REFERENCES iva (id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (id_Iva > 0),
	subtotal INT NOT NULL CHECK (subtotal > 0),
	total INT NOT NULL CHECK (total > 0)
);
GO

CREATE TABLE factura (
	id INT IDENTITY (1,1) PRIMARY KEY,
	fchExpedicion DATETIME NOT NULL CHECK (fchExpedicion >= CONVERT(DATE, GETDATE())),
	id_Cliente VARCHAR (20) NOT NULL FOREIGN KEY REFERENCES cliente (numID) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (ISNUMERIC(id_Cliente) = 1),
	id_DetallesFactura INT NOT NULL FOREIGN KEY REFERENCES detallesFactura (id)  ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE CHECK (id_DetallesFactura > 0),
	id_Municipio INT NOT NULL FOREIGN KEY REFERENCES municipio (id) CHECK (id_Municipio > 0)
);
GO



CREATE PROCEDURE SP_CONSULTAR
    @CONSULTA NVARCHAR(MAX),
    @TABLA NVARCHAR(MAX),
    @CONDICION NVARCHAR(MAX)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)

	IF (@CONSULTA != '*')
		BEGIN -- Construir la consulta SQL completa
			SET @sql = N'SELECT ' + QUOTENAME(@CONSULTA) + ' FROM ' + @TABLA + ' WHERE ' + @CONDICION
			-- Ejecutar la consulta
			EXEC sp_executesql @sql
		END
	ELSE
		BEGIN
			SET @sql = N'SELECT ' + @CONSULTA + ' FROM ' + @TABLA + ' WHERE ' + @CONDICION
			-- Ejecutar la consulta
			EXEC sp_executesql @sql
		END    
END
GO

CREATE PROCEDURE SP_CONSULTAR
    @CONSULTA NVARCHAR(MAX),
    @TABLA NVARCHAR(MAX),
    @CONDICION NVARCHAR(MAX)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)

    -- Validar que el nombre de la tabla sea un identificador v�lido
    IF OBJECT_ID(@TABLA) IS NULL
    BEGIN
        RAISERROR('La tabla especificada no existe.', 16, 1)
        RETURN
    END

    -- Escapar el nombre de las columnas para evitar la inyecci�n SQL
    SET @CONSULTA = REPLACE(REPLACE(@CONSULTA, '[', ''), ']', '')
    SET @CONSULTA = REPLACE(@CONSULTA, ',', '],[')
    SET @CONSULTA = '[' + @CONSULTA + ']'

    -- Escapar la condici�n de filtrado para evitar la inyecci�n SQL
    SET @CONDICION = REPLACE(@CONDICION, '''', '''''')
    SET @CONDICION = REPLACE(@CONDICION, '--', '')
    SET @CONDICION = REPLACE(@CONDICION, ';', '')

    -- Construir la consulta SQL completa
    SET @sql = N'SELECT ' + @CONSULTA + ' FROM ' + QUOTENAME(@TABLA) + ' WHERE ' + @CONDICION 

    -- Ejecutar la consulta
    EXEC sp_executesql @sql
END

