CREATE TABLE [dbo].[Certificado]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Tempo] INT NOT NULL, 
	FOREIGN KEY ([Id]) REFERENCES [Pessoa]([Identificacao])
	
)
