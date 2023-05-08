USE PagWebPruebas
GO

INSERT INTO rol (nombre) VALUES ('Administrador'), 
							    ('Auxiliar'),
							    ('Vendedor'),
							    ('Bodega')
GO

INSERT INTO usuario VALUES ('elAdmin', 'B221D9DBB083A7F33428D7C2A3C3198AE925614D70210E28716CCAA7CD4DDB79', 1, DEFAULT),
						   ('elAuxi', 'B221D9DBB083A7F33428D7C2A3C3198AE925614D70210E28716CCAA7CD4DDB79', 2, DEFAULT),
						   ('elVende', 'B221D9DBB083A7F33428D7C2A3C3198AE925614D70210E28716CCAA7CD4DDB79', 3, DEFAULT),
						   ('elBodes', 'B221D9DBB083A7F33428D7C2A3C3198AE925614D70210E28716CCAA7CD4DDB79', 4, DEFAULT)
GO

INSERT INTO tipoDocumento VALUES ('Cedula'), 
								 ('Cedula extranjeria')
GO

INSERT INTO iva VALUES ('17%'), 
					   ('19%'),
					   ('No aplica')
GO