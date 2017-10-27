CREATE TABLE [dbo].[Reuniao]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Criador] INT NOT NULL, 
    [Cancelado] BIT NOT NULL, 
    [Local] VARCHAR(50) NOT NULL, 
    [Data] DATE NOT NULL, 
    CONSTRAINT [Criador] FOREIGN KEY ([Criador]) REFERENCES [Pessoa]([Identificacao])

)

