CREATE VIEW [dbo].[FullPerson]
	AS 
	select [p].[Id] AS PersonID, [p].[FirstName ], [p].[LastName], [a].[Id] AS AddressId,  [a].[StreetAdress], [a].[City], [a].[State], [a].[ZipCode]
	from dbo.tblPerson p
	left join dbo.tblAdress a on p.Id = a.PersonID
