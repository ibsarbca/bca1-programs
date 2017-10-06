CREATE TABLE [dbo].[customer_order] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (100) NULL,
    [contact_no] VARCHAR (10)  NULL,
    [product_no] INT           NULL,
    [order_date] DATE          NULL,
    [amount]     INT           NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);



SET IDENTITY_INSERT [dbo].[customer_order] ON
INSERT INTO [dbo].[customer_order] ([id], [name], [contact_no], [product_no], [order_date], [amount]) VALUES (1, N'AAA', N'123456', 1, N'2017-01-01', 100)
INSERT INTO [dbo].[customer_order] ([id], [name], [contact_no], [product_no], [order_date], [amount]) VALUES (2, N'BBB', N'123456', 1, N'2017-01-01', 100)
INSERT INTO [dbo].[customer_order] ([id], [name], [contact_no], [product_no], [order_date], [amount]) VALUES (3, N'CCC', N'123456', 2, N'2017-12-12', 100)
INSERT INTO [dbo].[customer_order] ([id], [name], [contact_no], [product_no], [order_date], [amount]) VALUES (4, N'DDD', N'123456', 2, N'2017-12-23', 100)
SET IDENTITY_INSERT [dbo].[customer_order] OFF

