CREATE TABLE [dbo].[items] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [ItemName]    NVARCHAR (50) NOT NULL,
    [Price]       MONEY         NOT NULL,
    [DateInStore] DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

