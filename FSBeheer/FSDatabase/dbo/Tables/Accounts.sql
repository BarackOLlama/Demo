CREATE TABLE [dbo].[Accounts] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (32) NULL,
    [Password] NVARCHAR (64) NULL,
    [RoleId]   INT           NULL,
    CONSTRAINT [PK_dbo.Accounts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Accounts_dbo.Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_RoleId]
    ON [dbo].[Accounts]([RoleId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Username]
    ON [dbo].[Accounts]([Username] ASC);

