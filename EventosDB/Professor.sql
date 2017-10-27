CREATE TABLE [dbo].[Professor]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Departamento] VARCHAR(50) NOT NULL 
	CONSTRAINT [Id] FOREIGN KEY ([Id]) REFERENCES [Pessoa]([Identificacao])
)