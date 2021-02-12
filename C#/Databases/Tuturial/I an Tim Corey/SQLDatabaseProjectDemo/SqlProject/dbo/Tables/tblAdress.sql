CREATE TABLE [dbo].[tblAdress]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonID] INT NULL, 
    [StreetAdress] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [State] NVARCHAR(50) NULL, 
    [ZipCode] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_tblAdress_tblPerson] FOREIGN KEY ([PersonID]) REFERENCES [tblPerson](id)
)
