CREATE TABLE [dbo].[Inspections] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [State] NVARCHAR (MAX) NOT NULL,
    [Notes] NVARCHAR (MAX) NULL,
    [Name]  NVARCHAR (MAX) DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_dbo.Inspections] PRIMARY KEY CLUSTERED ([Id] ASC)
);

