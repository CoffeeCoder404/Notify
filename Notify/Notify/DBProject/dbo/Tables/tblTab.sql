CREATE TABLE [dbo].[tblTab] (
    [tblTabID] INT          IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [Priority] INT          NOT NULL,
    [IsActive] BIT          NOT NULL,
    CONSTRAINT [PK_tblTab] PRIMARY KEY CLUSTERED ([tblTabID] ASC)
);

