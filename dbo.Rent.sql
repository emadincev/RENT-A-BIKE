CREATE TABLE [dbo].[Rent]
(
	[ID] INT IDENTITY NOT NULL, 
    [UserID] INT NOT NULL, 
    [ProductID] INT NOT NULL, 
    [Rental_price] DECIMAL(18, 2) NULL, 
    [Rental_date] DATETIME NULL, 
    [Rental_time] DATETIME NULL,
	PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT [UserID_fk] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID]),
	CONSTRAINT [ProductID_fk] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ProductID])
);
