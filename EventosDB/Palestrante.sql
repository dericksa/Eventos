CREATE TABLE [dbo].[Palestrante]
(
	[Id_pessoa] INT NOT NULL , 
    [confirmacao] BIT NOT NULL, 
    [Id_eventos] INT NOT NULL, 
    PRIMARY KEY ([Id_pessoa], [Id_eventos]), 
    CONSTRAINT [Id_palestrante] FOREIGN KEY ([Id_pessoa]) REFERENCES [Pessoa]([Identificacao]) ,
	CONSTRAINT [Id_evento] FOREIGN KEY ([Id_eventos]) REFERENCES [Evento]([Id]) 
)
