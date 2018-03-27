CREATE TABLE [dbo].[tblEmployeeMessage] (
    [tblMessageID]  VARCHAR (50) NOT NULL,
    [tblEmployeeID] BIGINT       NOT NULL,
    CONSTRAINT [FK_tblEmployeeMessage_tblEmployee] FOREIGN KEY ([tblEmployeeID]) REFERENCES [dbo].[tblEmployee] ([tblEmployeeID]),
    CONSTRAINT [FK_tblEmployeeMessage_tblMessage] FOREIGN KEY ([tblMessageID]) REFERENCES [dbo].[tblMessage] ([tblMessageID])
);

