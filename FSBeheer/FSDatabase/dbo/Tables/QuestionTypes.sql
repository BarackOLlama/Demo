CREATE TABLE [dbo].[QuestionTypes] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_dbo.QuestionTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

