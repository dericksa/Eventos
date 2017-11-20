CREATE TABLE [dbo].[Participante]
(
	[Id_pessoa] INT NOT NULL , 
    [confirmacao] BIT NOT NULL, 
    [Id_eventos] INT NOT NULL, 
    PRIMARY KEY ([Id_pessoa], [Id_eventos]), 
    CONSTRAINT [Id_pessoa] FOREIGN KEY ([Id_pessoa]) REFERENCES [Pessoa]([Identificacao]) ,
	CONSTRAINT [Id_eventos] FOREIGN KEY ([Id_eventos]) REFERENCES [Eventos]([Id]) 
)

