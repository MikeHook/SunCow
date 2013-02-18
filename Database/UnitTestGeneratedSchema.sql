
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK4AC6D6323BD4363F]') AND parent_object_id = OBJECT_ID('Cards'))
alter table Cards  drop constraint FK4AC6D6323BD4363F


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK4AC6D63291C1FED9]') AND parent_object_id = OBJECT_ID('Cards'))
alter table Cards  drop constraint FK4AC6D63291C1FED9


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK4AC6D632F5A2E09E]') AND parent_object_id = OBJECT_ID('Cards'))
alter table Cards  drop constraint FK4AC6D632F5A2E09E


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK4AC6D6327EF1C1CD]') AND parent_object_id = OBJECT_ID('Cards'))
alter table Cards  drop constraint FK4AC6D6327EF1C1CD


    if exists (select * from dbo.sysobjects where id = object_id(N'Cards') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Cards

    if exists (select * from dbo.sysobjects where id = object_id(N'CardCategories') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table CardCategories

    if exists (select * from dbo.sysobjects where id = object_id(N'CardTemplates') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table CardTemplates

    if exists (select * from dbo.sysobjects where id = object_id(N'Customers') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Customers

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
       CardCategoryId INT null,
       primary key (CardId)
    )

    create table CardCategories (
        CardCategoryId INT IDENTITY NOT NULL,
       Name NVARCHAR(255) null,
       primary key (CardCategoryId)
    )

    create table CardTemplates (
        CardTemplateId INT IDENTITY NOT NULL,
       CardName NVARCHAR(255) null,
       ImagePath NVARCHAR(255) null,
       primary key (CardTemplateId)
    )

    create table Customers (
        CustomerId INT IDENTITY NOT NULL,
       FirstName NVARCHAR(255) null,
       LastName NVARCHAR(255) null,
       primary key (CustomerId)
    )

    alter table Cards 
        add constraint FK4AC6D6323BD4363F 
        foreign key (CardTemplateId) 
        references CardTemplates

    alter table Cards 
        add constraint FK4AC6D63291C1FED9 
        foreign key (CustomerId) 
        references Customers

    alter table Cards 
        add constraint FK4AC6D632F5A2E09E 
        foreign key (CategoryId) 
        references CardCategories

    alter table Cards 
        add constraint FK4AC6D6327EF1C1CD 
        foreign key (CardCategoryId) 
        references CardCategories
