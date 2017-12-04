CREATE TABLE [dbo].[Evento]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Criador] INT NOT NULL, 
    [Cancelado] BIT NOT NULL, 
    [Local] VARCHAR(50) NOT NULL, 
    [Data] DATE NOT NULL, 
    [Descricao] VARCHAR(MAX) NOT NULL, 
    [Palestra] BIT NOT NULL, 
    [Reuniao] BIT NOT NULL, 
    [Privado] BIT NOT NULL, 
    [Tempo] INT NOT NULL, 
    [Aprovada] BIT NOT NULL, 
    CONSTRAINT [Criador] FOREIGN KEY ([Criador]) REFERENCES [Pessoa]([Identificacao])
)
