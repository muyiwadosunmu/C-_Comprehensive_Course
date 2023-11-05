CREATE TABLE [dbo].[Contacts]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY,
  [FirstName] VARCHAR(50) NOT NULL,
  [LastName] VARCHAR(50) NOT NULL,
)

-- NVARCHAR could be used to support unicode but they take up twice much space

