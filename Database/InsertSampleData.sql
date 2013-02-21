INSERT INTO [SunCow].[dbo].[Categories]
           ([Name],[RouteName],[ImageDirectory])
     VALUES
           ('Birthdays', 'Birthdays', 'Birthdays'), 
           ('Christmas', 'Christmas', 'Christmas'), 
           ('Engagement', 'Engagement', 'Engagement'), 
           ('Thank You', 'ThankYou', 'ThankYou'), 
           ('Valentine''s', 'Valentines', 'Valentines')

DECLARE @categoryId INT
Set @categoryId = (Select CategoryId from [dbo].[Categories] Where Name = 'Christmas');

INSERT INTO [SunCow].[dbo].[Customers]
           ([FirstName]
           ,[LastName]
           ,[ImageDirectory])
     VALUES
           ('Bob'
           ,'Thornton'
           ,'Bob')

DECLARE @customerId INT
Set @customerId = (Select Top 1 CustomerId from [dbo].Customers);

INSERT INTO [SunCow].[dbo].[Cards]
           ([CardName]
           ,[Price]
           ,[Description]
           ,[ThumbnailImageName]
           ,[OutsideImageName]
           ,[InsideImageName]
           ,[HasOutsideMessage]
           ,[RouteName]
           ,[CategoryId]
           ,[CustomerId])
     VALUES
           ('Baubles'
           ,2.99
           ,'Personalise your own special Christmas bauble card'
           ,'bauble-tn.png'
           ,'bauble-outside.png'
           ,'bauble-inside.png'
           ,1
           ,'baubles'
           ,@categoryId
           ,@customerId),
           ('Santa'
           ,1.99
           ,'Personalise your own special Christmas santa card'
           ,'santa-tn.png'
           ,'santa-outside.png'
           ,'santa-inside.png'
           ,0
           ,'santa'
           ,@categoryId
           ,@customerId),
           ('Snowman'
           ,1.99
           ,'Personalise your own special Christmas snowman card'
           ,'snowman-tn.png'
           ,'snowman-outside.png'
           ,'snowman-inside.png'
           ,0
           ,'snowman'
           ,@categoryId
           ,@customerId)
GO


