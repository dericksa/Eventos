CREATE TABLE [dbo].[Horario]
(
	[Identificacao] INT NOT NULL PRIMARY KEY, 
    [Horario] DATE NOT NULL, 
    CONSTRAINT [Identificacao] FOREIGN KEY ([Identificacao]) REFERENCES [Pessoa]([Identificacao]) 
)
