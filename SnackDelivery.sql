USE [master]
GO
/****** Object:  Database [SnackDelivery]    Script Date: 6/22/2023 4:01:01 PM ******/
CREATE DATABASE [SnackDelivery]
GO
ALTER DATABASE [SnackDelivery] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SnackDelivery] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SnackDelivery] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SnackDelivery] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SnackDelivery] SET ARITHABORT OFF 
GO
ALTER DATABASE [SnackDelivery] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SnackDelivery] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SnackDelivery] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SnackDelivery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SnackDelivery] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SnackDelivery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SnackDelivery] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SnackDelivery] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SnackDelivery] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SnackDelivery] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SnackDelivery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SnackDelivery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SnackDelivery] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SnackDelivery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SnackDelivery] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SnackDelivery] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SnackDelivery] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SnackDelivery] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SnackDelivery] SET  MULTI_USER 
GO
ALTER DATABASE [SnackDelivery] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SnackDelivery] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SnackDelivery] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SnackDelivery] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SnackDelivery] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SnackDelivery] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SnackDelivery] SET QUERY_STORE = OFF
GO
USE [SnackDelivery]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/22/2023 4:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[password] [varchar](50) NULL,
	[phoneNumber] [varchar](50) NULL,
	[isAdmin] [bit] NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 6/22/2023 4:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orderDate] [datetime] NULL,
	[staffId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 6/22/2023 4:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orderId] [int] NULL,
	[productId] [int] NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/22/2023 4:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[price] [float] NULL,
	[discount] [float] NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (1, N'John Doe', N'123456', N'1234567890', 1, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (2, N'Jane Smith', N'123456', N'9876543210', 1, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (3, N'Alice Johnson', N'123456', N'5555555555', 1, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (4, N'Bob Thompson', N'123456', N'9999999999', 0, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (5, N'Emma Davis', N'123456', N'4444444444', 0, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (6, N'Michael Wilson', N'123456', N'2222222222', 0, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (7, N'Olivia Lee', N'123456', N'7777777777', 0, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (8, N'William Harris', N'123456', N'8888888888', 0, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (9, N'Sophia Clark', N'123456', N'6666666666', 0, 0)
INSERT [dbo].[Account] ([id], [name], [password], [phoneNumber], [isAdmin], [deleted]) VALUES (10, N'Daniel Anderson', N'123456', N'3333333333', 0, 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (1, CAST(N'2023-06-15T09:00:00.000' AS DateTime), 4)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (2, CAST(N'2023-06-15T09:30:00.000' AS DateTime), 4)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (3, CAST(N'2023-06-15T13:45:00.000' AS DateTime), 5)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (4, CAST(N'2023-06-15T14:15:00.000' AS DateTime), 5)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (5, CAST(N'2023-06-16T08:30:00.000' AS DateTime), 6)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (6, CAST(N'2023-06-16T09:00:00.000' AS DateTime), 6)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (7, CAST(N'2023-06-16T15:30:00.000' AS DateTime), 7)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (8, CAST(N'2023-06-17T08:45:00.000' AS DateTime), 8)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (9, CAST(N'2023-06-18T16:00:00.000' AS DateTime), 9)
INSERT [dbo].[Order] ([id], [orderDate], [staffId]) VALUES (10, CAST(N'2023-06-19T13:15:00.000' AS DateTime), 10)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (1, 1, 1, 2)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (2, 1, 3, 1)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (3, 2, 2, 3)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (4, 2, 4, 2)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (5, 3, 5, 4)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (6, 3, 1, 1)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (7, 4, 3, 2)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (8, 4, 2, 1)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (9, 5, 5, 3)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (10, 5, 4, 1)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (11, 6, 1, 2)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (12, 6, 2, 2)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (13, 7, 3, 1)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (14, 7, 4, 1)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (15, 8, 5, 4)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (16, 8, 1, 2)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (17, 9, 2, 3)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (18, 9, 3, 1)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (19, 10, 5, 2)
INSERT [dbo].[OrderDetails] ([id], [orderId], [productId], [quantity]) VALUES (20, 10, 4, 1)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (1, N'Mac and Cheese', 5.99, 10, 0)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (2, N'Popcorn', 3.49, 0, 0)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (3, N'Pizza', 9.99, 0.25, 0)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (4, N'Soda', 1.99, 5, 0)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (5, N'Water', 0.99, 0, 0)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (6, N'Nachos', 4.99, 0, 0)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (7, N'Ice Cream', 3.99, 20, 0)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (8, N'Candy', 0.99, 0, 1)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (9, N'Pretzels', 2.99, 5, 0)
INSERT [dbo].[Product] ([id], [name], [price], [discount], [deleted]) VALUES (10, N'Chips', 1.49, 0, 0)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([orderId])
REFERENCES [dbo].[Order] ([id])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([productId])
REFERENCES [dbo].[Product] ([id])
GO
USE [master]
GO
ALTER DATABASE [SnackDelivery] SET  READ_WRITE 
GO
