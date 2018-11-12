CREATE TABLE [dbo].[Inspectors] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (MAX) NOT NULL,
    [Address]           NVARCHAR (MAX) NULL,
    [City]              NVARCHAR (MAX) NULL,
    [Zipcode]           NVARCHAR (MAX) NULL,
    [Email]             NVARCHAR (MAX) NULL,
    [PhoneNumber]       NVARCHAR (MAX) NULL,
    [CertificationDate] DATETIME       NOT NULL,
    [InvalidDate]       DATETIME       NOT NULL,
    [BankNumber]        NVARCHAR (MAX) NULL,
    [AccountId]         INT            NULL,
    CONSTRAINT [PK_dbo.Inspectors] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Inspectors_dbo.Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Accounts] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_AccountId]
    ON [dbo].[Inspectors]([AccountId] ASC);

