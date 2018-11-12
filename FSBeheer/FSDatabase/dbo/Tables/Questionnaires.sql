CREATE TABLE [dbo].[Questionnaires] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NULL,
    [Instructions] NVARCHAR (MAX) NULL,
    [Version]      INT            NOT NULL,
    [Comments]     NVARCHAR (MAX) NULL,
    [InspectionId] INT            NULL,
    CONSTRAINT [PK_dbo.Questionnaires] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Questionnaires_dbo.Inspections_InspectionId] FOREIGN KEY ([InspectionId]) REFERENCES [dbo].[Inspections] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_InspectionId]
    ON [dbo].[Questionnaires]([InspectionId] ASC);

