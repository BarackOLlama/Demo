CREATE TABLE [dbo].[Roles] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Content] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Roles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

