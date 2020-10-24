CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL , 
    [Name] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [Nid] INT NOT NULL IDENTITY, 
    PRIMARY KEY ([Id])
)
