CREATE TABLE [dbo].[tblPriority] (
    [tblPriorityID] INT        IDENTITY (1, 1) NOT NULL,
    [Name]          NCHAR (10) NOT NULL,
    CONSTRAINT [PK_tblPriority] PRIMARY KEY CLUSTERED ([tblPriorityID] ASC)
);

