﻿CREATE TABLE [dbo].[Pessoa]
(
	[Identificacao] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Senha] VARCHAR(50) NOT NULL, 
    [Grupo] VARCHAR(50) NULL, 
    [Curso] VARCHAR(50) NULL, 
    [Departamento] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Adm] BIT NULL, 
    [Palestrante] BIT NULL, 
    [Organizador] BIT NULL 
)
