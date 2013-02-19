
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK4AC6D6323A90699]') AND parent_object_id = OBJECT_ID('Cards'))
alter table Cards  drop constraint FK4AC6D6323A90699


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK4AC6D63291C1FED9]') AND parent_object_id = OBJECT_ID('Cards'))
alter table Cards  drop constraint FK4AC6D63291C1FED9


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK4AC6D632211056E4]') AND parent_object_id = OBJECT_ID('Cards'))
alter table Cards  drop constraint FK4AC6D632211056E4


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK3A8DED65211056E4]') AND parent_object_id = OBJECT_ID('Templates'))
alter table Templates  drop constraint FK3A8DED65211056E4


    if exists (select * from dbo.sysobjects where id = object_id(N'Cards') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Cards

    if exists (select * from dbo.sysobjects where id = object_id(N'Categories') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Categories

    if exists (select * from dbo.sysobjects where id = object_id(N'Customers') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Customers

    if exists (select * from dbo.sysobjects where id = object_id(N'Templates') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Templates

    create table Cards (
        CardId INT IDENTITY NOT NULL,
       OutsideMessage NVARCHAR(255) null,
       Salutation NVARCHAR(255) null,
       InsideMessage NVARCHAR(255) null,
       SignOff NVARCHAR(255) null,
       Price DECIMAL(19,5) null,
       CardTemplateId INT null,
       CustomerId INT null,
       CategoryId INT null,
       primary key (CardId)
    )

    create table Categories (
        CategoryId INT IDENTITY NOT NULL,
       Name NVARCHAR(255) null,
       primary key (CategoryId)
    )

    create table Customers (
        CustomerId INT IDENTITY NOT NULL,
       FirstName NVARCHAR(255) null,
       LastName NVARCHAR(255) null,
       primary key (CustomerId)
    )

    create table Templates (
        TemplateId INT IDENTITY NOT NULL,
       CardName NVARCHAR(255) null,
       ThumbnailImageName NVARCHAR(255) null,
       OutsideImageName NVARCHAR(255) null,
       InsideImageName NVARCHAR(255) null,
       HasOutsideMessage BIT null,
       CategoryId INT null,
       primary key (TemplateId)
    )

    alter table Cards 
        add constraint FK4AC6D6323A90699 
        foreign key (CardTemplateId) 
        references Templates

    alter table Cards 
        add constraint FK4AC6D63291C1FED9 
        foreign key (CustomerId) 
        references Customers

    alter table Cards 
        add constraint FK4AC6D632211056E4 
        foreign key (CategoryId) 
        references Categories

    alter table Templates 
        add constraint FK3A8DED65211056E4 
        foreign key (CategoryId) 
        references Categories
