CREATE TABLE [dbo].[Users] (
    [UserID]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (20) NOT NULL,
    [Surname]   NVARCHAR (30) NOT NULL,
    [Address]   NVARCHAR (50) NOT NULL,
    [Telephone] NCHAR (15)    NOT NULL,
    [Email]     NVARCHAR (50) NULL,
    [Password]  NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

