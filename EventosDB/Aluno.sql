CREATE TABLE [dbo].[Aluno]
(
	[RA] INT NOT NULL PRIMARY KEY, 
    [Senha] VARCHAR(50) NOT NULL, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Curso] VARCHAR(50) NOT NULL, 
    CONSTRAINT [RA] FOREIGN KEY ([RA]) REFERENCES [Pessoa]([Identificacao])
)
