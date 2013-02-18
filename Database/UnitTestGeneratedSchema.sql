
    if exists (select * from dbo.sysobjects where id = object_id(N'CardTemplates') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table CardTemplates

    create table CardTemplates (
        CardTemplateId INT IDENTITY NOT NULL,
       CardName NVARCHAR(255) null,
       primary key (CardTemplateId)
    )
