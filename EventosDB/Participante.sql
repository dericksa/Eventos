CREATE TABLE [dbo].[Participante]
(
	[Id_pessoa] INT NOT NULL , 
    [Id_reuniao] INT NOT NULL, 
    [confirmacao] BIT NOT NULL, 
    PRIMARY KEY ([Id_reuniao], [Id_pessoa]), 
    CONSTRAINT [Id_pessoa] FOREIGN KEY ([Id_pessoa]) REFERENCES [Pessoa]([Identificacao]),
	CONSTRAINT [Id_reuniao] FOREIGN KEY ([Id_reuniao]) REFERENCES [Reuniao]([Id])
)

