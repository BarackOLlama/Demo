CREATE TABLE [dbo].[Answers] (
    [Id]          INT   IDENTITY (1, 1) NOT NULL,
    [Content]     NTEXT NOT NULL,
    [QuestionId]  INT   NULL,
    [InspectorId] INT   NULL,
    CONSTRAINT [PK_dbo.Answers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Answers_dbo.Inspectors_InspectorId] FOREIGN KEY ([InspectorId]) REFERENCES [dbo].[Inspectors] ([Id]),
    CONSTRAINT [FK_dbo.Answers_dbo.Questions_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Questions] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_QuestionId]
    ON [dbo].[Answers]([QuestionId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_InspectorId]
    ON [dbo].[Answers]([InspectorId] ASC);

