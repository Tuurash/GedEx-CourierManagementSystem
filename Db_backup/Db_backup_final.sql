USE [CourierServiceDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/23/2019 12:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(2001,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[Password] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee1]    Script Date: 4/23/2019 12:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee1](
	[EmpId] [int] IDENTITY(1001,1) NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[JoiningDate] [date] NULL,
	[Password] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Position] [varchar](50) NULL,
 CONSTRAINT [PK_Employee1] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductDb]    Script Date: 4/23/2019 12:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductDb](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Condition] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[RecieverNumber] [varchar](50) NOT NULL,
	[SenderNumber] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerId], [Name], [Address], [PhoneNumber], [Password]) VALUES (2006, N'Dipto', N'boshundhora', 12345, N'1234')
INSERT [dbo].[Customer] ([CustomerId], [Name], [Address], [PhoneNumber], [Password]) VALUES (2005, N'Monir', N'motijheel', 12344, N'123')
INSERT [dbo].[Customer] ([CustomerId], [Name], [Address], [PhoneNumber], [Password]) VALUES (2009, N'rakib', N'Banasree', 123456, N'123')
INSERT [dbo].[Customer] ([CustomerId], [Name], [Address], [PhoneNumber], [Password]) VALUES (2010, N'Tushar', N'Badda', 1234567, N'123')
INSERT [dbo].[Customer] ([CustomerId], [Name], [Address], [PhoneNumber], [Password]) VALUES (2012, N'', N'', 0, N'')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Employee1] ON 

INSERT [dbo].[Employee1] ([EmpId], [EmpName], [PhoneNumber], [JoiningDate], [Password], [Address], [Position]) VALUES (1001, N'turash', 2341234, CAST(N'2012-09-12' AS Date), N'12345', N'Uttara', N'Deliveryman')
INSERT [dbo].[Employee1] ([EmpId], [EmpName], [PhoneNumber], [JoiningDate], [Password], [Address], [Position]) VALUES (1003, N'Turab', 123456, CAST(N'2019-04-22' AS Date), N'123', N'Gabtoli', N'Deliveryman')
INSERT [dbo].[Employee1] ([EmpId], [EmpName], [PhoneNumber], [JoiningDate], [Password], [Address], [Position]) VALUES (1004, N'jahid', 12356, CAST(N'2019-04-23' AS Date), N'2405', N'moddhobadda', N'Deliveryman')
INSERT [dbo].[Employee1] ([EmpId], [EmpName], [PhoneNumber], [JoiningDate], [Password], [Address], [Position]) VALUES (1005, N'bali', 1237, CAST(N'2019-04-23' AS Date), N'4768', N'kushtia', N'Deliveryman')
INSERT [dbo].[Employee1] ([EmpId], [EmpName], [PhoneNumber], [JoiningDate], [Password], [Address], [Position]) VALUES (1008, N'Mohaimanul', 1234456, CAST(N'2019-04-23' AS Date), N'2923', N'mohakhali', N'Deliveryman')
INSERT [dbo].[Employee1] ([EmpId], [EmpName], [PhoneNumber], [JoiningDate], [Password], [Address], [Position]) VALUES (1009, N'romjan', 1234444444, CAST(N'2019-04-23' AS Date), N'5971', N'kushtia', N'Deliveryman')
INSERT [dbo].[Employee1] ([EmpId], [EmpName], [PhoneNumber], [JoiningDate], [Password], [Address], [Position]) VALUES (1010, N'Hasibullah', 12345546, CAST(N'2019-04-23' AS Date), N'3507', N'nator', N'Deliveryman')
SET IDENTITY_INSERT [dbo].[Employee1] OFF
SET IDENTITY_INSERT [dbo].[ProductDb] ON 

INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (1, N'Yellow', N'Delivered', N'boshundhora', N'12345', N'12344')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (2, N'green', N'Delivered', N'dhanmondi', N'4321', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (3, N'red', N'Delivered', N'motijheel', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (13, N'Offwhite', N'Delivered', N'chittagong', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (5, N'pink', N'Delivered', N'Uganda', N'4321', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (6, N'magenda', N'Delivered', N'pabna', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (8, N'black', N'Delivered', N'boshundhora', N'12345', N'12344')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (11, N'Blue', N'Pending', N'Kuakata', N'12345', N'12344')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (16, N'Skyblue', N'Pending', N'motijheel', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (9, N'Gray', N'Delivered', N'motijheel', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (10, N'Rubi', N'Pending', N'India', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (12, N'Purple', N'Pending', N'coxsBazar', N'12345', N'12344')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (17, N'steelblue', N'Pending', N'motijheel', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (15, N'Cream', N'Pending', N'Bhutan', N'12344', N'12344')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (18, N'dark-gray', N'Pending', N'motijheel', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (20, N'Carbon-white', N'Pending', N'boshundhora', N'12345', N'12344')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (21, N'dark-yellow', N'Pending', N'boshundhora', N'12345', N'12344')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (24, N'Coral-green', N'Pending', N'motijheel', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (25, N'Dark-green', N'Pending', N'motijheel', N'12344', N'12367')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (26, N'steel-green', N'Pending', N'motijheel', N'12345', N'12367')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (27, N'Coral-yellow', N'Pending', N'motijheel', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (19, N'coralblue', N'Delivered', N'motijheel', N'12344', N'12345')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (22, N'Dark-orange', N'Pending', N'boshundhora', N'12345', N'12344')
INSERT [dbo].[ProductDb] ([ProductId], [ProductName], [Condition], [Address], [RecieverNumber], [SenderNumber]) VALUES (23, N'Ligh-blue', N'Pending', N'boshundhora', N'12345', N'12344')
SET IDENTITY_INSERT [dbo].[ProductDb] OFF
