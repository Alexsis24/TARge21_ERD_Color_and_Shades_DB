CREATE TABLE [dbo].Shades
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PrimaryColorId] INT NOT NULL, 
    [ColorName] NVARCHAR(50) NOT NULL
	CONSTRAINT PrimaryColorIdFK FOREIGN KEY (PrimaryColorId) REFERENCES PrimaryColors(id) 
)
