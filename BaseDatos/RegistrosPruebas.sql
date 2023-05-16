USE ProyectoTiendaZapatos
GO

INSERT INTO rol VALUES ('Administrador', DEFAULT), 
					   ('Vendedor', DEFAULT),
					   ('Auxiliar', DEFAULT),
					   ('Bodega', DEFAULT)
GO

INSERT INTO usuario VALUES ('el_Admin', 'b221d9dbb083a7f33428d7c2a3c3198ae925614d70210e28716ccaa7cd4ddb79', 1, DEFAULT),
						   ('el_Auxi', 'b221d9dbb083a7f33428d7c2a3c3198ae925614d70210e28716ccaa7cd4ddb79', 2, DEFAULT),
						   ('el_Vende', 'b221d9dbb083a7f33428d7c2a3c3198ae925614d70210e28716ccaa7cd4ddb79', 3, DEFAULT),
						   ('el_Bodes', 'b221d9dbb083a7f33428d7c2a3c3198ae925614d70210e28716ccaa7cd4ddb79', 4, DEFAULT)
GO

INSERT INTO tipoDocumento VALUES ('Cedula', DEFAULT), 
								 ('Cedula extranjeria', DEFAULT),
								 ('NIT', DEFAULT)
GO

INSERT INTO iva VALUES ('12%', DEFAULT),
			           ('17%', DEFAULT), 
					   ('19%', DEFAULT),
					   ('No aplica', DEFAULT)
GO

INSERT INTO tallas VALUES ('12', DEFAULT)