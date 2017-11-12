CREATE TABLE [dbo].[Pessoa]
(
	[Identificacao] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Senha] VARCHAR(50) NOT NULL, 
    [Grupo] VARCHAR(50) NOT NULL, 
    [Curso] VARCHAR(50) NOT NULL, 
    [Departamento] VARCHAR(50) NOT NULL
)