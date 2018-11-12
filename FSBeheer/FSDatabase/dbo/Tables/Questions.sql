CREATE TABLE [dbo].[Questions] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Content]         NTEXT          NOT NULL,
    [Comments]        NVARCHAR (MAX) NULL,
    [Options]         NVARCHAR (MAX) NULL,
    [Columns]         NVARCHAR (MAX) NULL,
    [QuestionnaireId] INT            NOT NULL,
    [QuestionTypeId]  INT            NULL,
    CONSTRAINT [PK_dbo.Questions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Questions_dbo.Questionnaires_QuestionnaireId] FOREIGN KEY ([QuestionnaireId]) REFERENCES [dbo].[Questionnaires] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Questions_dbo.QuestionTypes_QuestionTypeId] FOREIGN KEY ([QuestionTypeId]) REFERENCES [dbo].[QuestionTypes] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_QuestionnaireId]
    ON [dbo].[Questions]([QuestionnaireId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_QuestionTypeId]
    ON [dbo].[Questions]([QuestionTypeId] ASC);

