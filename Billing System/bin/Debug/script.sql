USE [master]
GO

CREATE DATABASE [ZahidMedicine]
GO

USE [ZahidMedicine]
GO
/****** Object:  Table [dbo].[Amount]    Script Date: 05/04/2019 7:03:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Amount](
	[InvoiceNo] [numeric](18, 0) NOT NULL,
	[TotalAmount] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 05/04/2019 7:03:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[InvoiceNo] [numeric](18, 0) NOT NULL,
	[CustomerName] [nvarchar](15) NOT NULL,
	[Address] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 05/04/2019 7:03:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[User_Name] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](8) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicineStock]    Script Date: 05/04/2019 7:03:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicineStock](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[MedicineName] [nvarchar](50) NOT NULL,
	[BatchName] [nvarchar](50) NOT NULL,
	[Quantity] [nvarchar](50) NOT NULL,
	[Rate] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MedicineStock] PRIMARY KEY CLUSTERED 
(
	[MedicineName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopAmount]    Script Date: 05/04/2019 7:03:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopAmount](
	[InvoiceNo] [numeric](18, 0) NOT NULL,
	[TotalAmount] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ShopAmount] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopCustomer]    Script Date: 05/04/2019 7:03:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopCustomer](
	[InvoiceNo] [numeric](18, 0) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Mobile] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_ShopCustomer] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopInvoice]    Script Date: 05/04/2019 7:03:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopInvoice](
	[InvoiceNo] [numeric](18, 0) NOT NULL,
	[SerialNo] [varchar](50) NOT NULL,
	[Product] [varchar](50) NOT NULL,
	[Quantity] [varchar](50) NOT NULL,
	[BatchNo] [varchar](50) NOT NULL,
	[UnitPrice] [varchar](50) NOT NULL,
	[TotalPrice] [int] NOT NULL,
	[Date] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplyInvoice]    Script Date: 05/04/2019 7:03:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplyInvoice](
	[InvoiceNo] [numeric](18, 0) NOT NULL,
	[SerialNo] [nvarchar](2) NOT NULL,
	[Product] [nvarchar](50) NOT NULL,
	[Quantity] [nvarchar](3) NOT NULL,
	[BatchNo] [nvarchar](50) NOT NULL,
	[UnitPrice] [nvarchar](15) NOT NULL,
	[TotalPrice] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Login] ([User_Name], [Password]) VALUES (N'zahidjavaid21@gmail.com', N'12345678')
SET IDENTITY_INSERT [dbo].[MedicineStock] ON 

INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(2 AS Numeric(18, 0)), N'Bludol', N'bldl', N'70', N'45')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(3 AS Numeric(18, 0)), N'Medicine1', N'batch1', N'92', N'23')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(12 AS Numeric(18, 0)), N'Medicine10', N'batch10', N'90', N'61')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(15 AS Numeric(18, 0)), N'medicine11', N'batch11', N'60', N'26')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(16 AS Numeric(18, 0)), N'medicine13', N'batch13', N'36', N'89')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(13 AS Numeric(18, 0)), N'medicine15', N'batch15', N'50', N'38')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(14 AS Numeric(18, 0)), N'medicine16', N'batch16', N'84', N'86')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(4 AS Numeric(18, 0)), N'Medicine2', N'batch2', N'102', N'65')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(5 AS Numeric(18, 0)), N'Medicine3', N'batch3', N'84', N'34')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(6 AS Numeric(18, 0)), N'Medicine4', N'batch4', N'85', N'78')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(7 AS Numeric(18, 0)), N'Medicine5', N'batch5', N'305', N'78')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(8 AS Numeric(18, 0)), N'Medicine6', N'batch6', N'69', N'56')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(9 AS Numeric(18, 0)), N'Medicine7', N'batch7', N'39', N'47')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(10 AS Numeric(18, 0)), N'Medicine8', N'batch8', N'61', N'34')
INSERT [dbo].[MedicineStock] ([ID], [MedicineName], [BatchName], [Quantity], [Rate]) VALUES (CAST(11 AS Numeric(18, 0)), N'Medicine9', N'batch9', N'38', N'48')
SET IDENTITY_INSERT [dbo].[MedicineStock] OFF
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(1 AS Numeric(18, 0)), N'1471')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(2 AS Numeric(18, 0)), N'9026')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(3 AS Numeric(18, 0)), N'614')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(4 AS Numeric(18, 0)), N'6282')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(5 AS Numeric(18, 0)), N'686')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(6 AS Numeric(18, 0)), N'835')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(7 AS Numeric(18, 0)), N'967')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(8 AS Numeric(18, 0)), N'474')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(9 AS Numeric(18, 0)), N'288')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(10 AS Numeric(18, 0)), N'565')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(11 AS Numeric(18, 0)), N'336')
INSERT [dbo].[ShopAmount] ([InvoiceNo], [TotalAmount]) VALUES (CAST(12 AS Numeric(18, 0)), N'2196')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(1 AS Numeric(18, 0)), N'Tahir', N'03078185388')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(2 AS Numeric(18, 0)), N'Amir', N'03457860246')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(3 AS Numeric(18, 0)), N'ali', N'03456922565')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(4 AS Numeric(18, 0)), N'Aslam', N'03258963258')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(5 AS Numeric(18, 0)), N'Akram', N'03123456789')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(6 AS Numeric(18, 0)), N'Junaid', N'03012536478')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(7 AS Numeric(18, 0)), N'Shakeel Ali', N'03017169511')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(8 AS Numeric(18, 0)), N'Ibrar Ahmad', N'03006545580')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(9 AS Numeric(18, 0)), N'Khalid', N'031245796')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(10 AS Numeric(18, 0)), N'Usama', N'03019638527')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(11 AS Numeric(18, 0)), N'Talha', N'03154478964')
INSERT [dbo].[ShopCustomer] ([InvoiceNo], [CustomerName], [Mobile]) VALUES (CAST(12 AS Numeric(18, 0)), N'Ali', N'03216685965')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(1 AS Numeric(18, 0)), N'1', N'Bludol', N'20', N'bldl', N'45', 900, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(1 AS Numeric(18, 0)), N'2', N'Medicine7', N'5', N'batch7', N'47', 235, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(1 AS Numeric(18, 0)), N'3', N'Medicine9', N'9', N'batch9', N'48', 336, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'1', N'Bludol', N'15', N'bldl', N'45', 675, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'2', N'Medicine5', N'26', N'batch5', N'78', 2028, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'3', N'Medicine7', N'50', N'batch7', N'47', 2350, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'4', N'Medicine9', N'40', N'batch9', N'48', 1920, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'5', N'Medicine4', N'5', N'batch4', N'78', 390, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'6', N'Medicine6', N'6', N'batch6', N'56', 336, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'7', N'Medicine3', N'16', N'batch3', N'34', 204, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'8', N'Medicine1', N'8', N'batch1', N'23', 184, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'9', N'Panadol', N'10', N'pndl', N'15', 150, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'10', N'Medicine8', N'6', N'batch8', N'34', 204, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'11', N'Medicine2', N'9', N'batch2', N'65', 585, N'10/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(3 AS Numeric(18, 0)), N'1', N'Medicine4', N'10', N'batch4', N'78', 390, N'11/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(3 AS Numeric(18, 0)), N'2', N'Medicine6', N'4', N'batch6', N'56', 224, N'11/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(5 AS Numeric(18, 0)), N'1', N'Medicine6', N'11', N'batch6', N'56', 336, N'12/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(5 AS Numeric(18, 0)), N'3', N'Medicine8', N'5', N'batch8', N'34', 170, N'12/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(5 AS Numeric(18, 0)), N'4', N'Bludol', N'4', N'bldl', N'45', 180, N'12/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(6 AS Numeric(18, 0)), N'1', N'Bludol', N'5', N'bldl', N'45', 225, N'12/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(6 AS Numeric(18, 0)), N'2', N'Medicine10', N'10', N'batch10', N'61', 610, N'12/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(7 AS Numeric(18, 0)), N'1', N'Bludol', N'5', N'bldl', N'45', 225, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(7 AS Numeric(18, 0)), N'2', N'Medicine6', N'9', N'batch6', N'56', 504, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(7 AS Numeric(18, 0)), N'3', N'Medicine8', N'7', N'batch8', N'34', 238, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(8 AS Numeric(18, 0)), N'1', N'Bludol', N'6', N'bldl', N'45', 270, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(8 AS Numeric(18, 0)), N'2', N'Medicine8', N'6', N'batch8', N'34', 204, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(9 AS Numeric(18, 0)), N'1', N'Medicine9', N'6', N'batch9', N'48', 288, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(10 AS Numeric(18, 0)), N'1', N'Bludol', N'5', N'bldl', N'45', 225, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(10 AS Numeric(18, 0)), N'2', N'Medicine3', N'10', N'batch3', N'34', 340, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(12 AS Numeric(18, 0)), N'1', N'Bludol', N'5', N'bldl', N'45', 225, N'03/04/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(12 AS Numeric(18, 0)), N'2', N'Medicine2', N'3', N'batch2', N'65', 195, N'03/04/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(12 AS Numeric(18, 0)), N'3', N'Medicine4', N'5', N'batch4', N'78', 390, N'03/04/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(12 AS Numeric(18, 0)), N'4', N'Medicine9', N'9', N'batch9', N'48', 432, N'03/04/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(12 AS Numeric(18, 0)), N'5', N'Medicine5', N'2', N'batch5', N'78', 156, N'03/04/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(12 AS Numeric(18, 0)), N'6', N'medicine16', N'6', N'batch16', N'86', 516, N'03/04/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(12 AS Numeric(18, 0)), N'7', N'Medicine7', N'6', N'batch7', N'47', 282, N'03/04/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(11 AS Numeric(18, 0)), N'1', N'Medicine6', N'6', N'batch6', N'56', 336, N'26/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(4 AS Numeric(18, 0)), N'1', N'Medicine2', N'6', N'batch2', N'65', 390, N'12/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(4 AS Numeric(18, 0)), N'2', N'Medicine5', N'69', N'batch5', N'78', 5382, N'12/03/2019')
INSERT [dbo].[ShopInvoice] ([InvoiceNo], [SerialNo], [Product], [Quantity], [BatchNo], [UnitPrice], [TotalPrice], [Date]) VALUES (CAST(4 AS Numeric(18, 0)), N'3', N'Medicine8', N'15', N'batch8', N'34', 510, N'12/03/2019')
