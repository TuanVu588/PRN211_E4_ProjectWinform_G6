USE [master]
GO
/****** Object:  Database [BookStore]    Script Date: 11/10/2022 3:10:39 PM ******/
CREATE DATABASE [BookStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookStore', FILENAME = N'D:\CSDL\BookStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookStore_log', FILENAME = N'D:\CSDL\BookStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookStore] SET RECOVERY FULL 
GO
ALTER DATABASE [BookStore] SET  MULTI_USER 
GO
ALTER DATABASE [BookStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookStore] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BookStore', N'ON'
GO
ALTER DATABASE [BookStore] SET QUERY_STORE = OFF
GO
USE [BookStore]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 11/10/2022 3:10:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[id] [int] NOT NULL,
	[CartId] [varchar](50) NULL,
	[ProductId] [int] NULL,
	[Count] [int] NULL,
	[DateCreate] [datetime] NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/10/2022 3:10:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 11/10/2022 3:10:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id] [int] NOT NULL,
	[OrderDate] [date] NULL,
	[PromoCode] [nvarchar](50) NULL,
	[UserName] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Total] [nvarchar](max) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/10/2022 3:10:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[id] [int] NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [numeric](10, 2) NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/10/2022 3:10:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] NOT NULL,
	[Cid] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NULL,
	[ProductURL] [nvarchar](max) NULL,
	[Author] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/10/2022 3:10:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Cart] ([id], [CartId], [ProductId], [Count], [DateCreate]) VALUES (1, N'user', 1, 1, CAST(N'2022-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Cart] ([id], [CartId], [ProductId], [Count], [DateCreate]) VALUES (2, N'user', 1, 1, CAST(N'2022-11-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Category] ([id], [Name]) VALUES (1, N'Math')
INSERT [dbo].[Category] ([id], [Name]) VALUES (2, N'Literary')
INSERT [dbo].[Category] ([id], [Name]) VALUES (3, N'History')
INSERT [dbo].[Category] ([id], [Name]) VALUES (4, N'Faculty of Science')
INSERT [dbo].[Category] ([id], [Name]) VALUES (5, N'Comics')
INSERT [dbo].[Category] ([id], [Name]) VALUES (6, N'Fairy Tales')
INSERT [dbo].[Category] ([id], [Name]) VALUES (7, N'Physics')
INSERT [dbo].[Category] ([id], [Name]) VALUES (8, N'Chemistry')
GO
INSERT [dbo].[Order] ([id], [OrderDate], [PromoCode], [UserName], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (1, CAST(N'2022-11-01' AS Date), N'Free', N'admin', N'Ngo', N'Luan', N'Vinh Bao ', N'Hai Phong', N'Ly Hoc', N'Viet Nam', N'0984726329', N'ngoluan3752@gmail.com', N'0')
INSERT [dbo].[Order] ([id], [OrderDate], [PromoCode], [UserName], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (2, CAST(N'2022-11-01' AS Date), N'', N'user', N'Phung', N'Khoan', N'Bat Xat', N'Lao Cai', N'Muong Ke', N'Viet Nam', N'0923643789', N'khoanphung123@gmail.com', N'40')
GO
INSERT [dbo].[OrderDetail] ([id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES (1, 1, 1, 1, CAST(10.00 AS Numeric(10, 2)))
INSERT [dbo].[OrderDetail] ([id], [OrderId], [ProductId], [Quantity], [UnitPrice]) VALUES (2, 1, 2, 2, CAST(20.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (1, 1, N'Big Ideas Simply Explained', CAST(10 AS Decimal(18, 0)), N'image1.jpg', N'D.K. Publishing')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (2, 1, N'Division Facts Practice Book: Improve Your Math Fluency Series', CAST(10 AS Decimal(18, 0)), N'image2.jpg', N'Chris McMullen')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (3, 1, N'Essential Calculus Skills Practice Workbook with Full Solutions', CAST(19 AS Decimal(18, 0)), N'image3.jpg', N'Chris McMullen')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (4, 1, N'The Joy of Abstraction: An Exploration of Math, Category Theory, and Life', CAST(24 AS Decimal(18, 0)), N'image4.jpg', N'Eugenia Cheng')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (5, 1, N'The Math Book: From Pythagoras to the 57th Dimension, 250 Milestones in the History of Mathematics (Union Square & Co. Milestones)', CAST(20 AS Decimal(18, 0)), N'image5.jpg', N'Clifford A. Pickover')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (6, 2, N'Best Literary Fiction Of All Time', CAST(22 AS Decimal(18, 0)), N'image6.jpg', N'The Kite Runner')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (7, 2, N'The Vanishing Half', CAST(17 AS Decimal(18, 0)), N'image7.jpg', N'BRIT BENNETT')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (8, 2, N'The Secret History', CAST(15 AS Decimal(18, 0)), N'image8.jpg', N'DONNA TARTT')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (9, 2, N'The Remains of the Day', CAST(11 AS Decimal(18, 0)), N'image9.jpg', N'KAZUO ISHIGURO')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (10, 2, N'The Shadow of the Wind', CAST(23 AS Decimal(18, 0)), N'image10.jpg', N'CARLOS RUIZ ZAFON')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (11, 3, N'1491 by Charles C. Mann', CAST(15 AS Decimal(18, 0)), N'image11.jpg', N'Charles C. Mann')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (12, 3, N'Precolonial Black Africa by Cheikh Anta Diop
', CAST(17 AS Decimal(18, 0)), N'image12.jpg', N'Cheikh Anta Diop')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (13, 3, N'The Guns of August by Barbara Tuchman
', CAST(19 AS Decimal(18, 0)), N'image13.jpg', N'Mass Market Paperback')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (14, 3, N'Parallel Lives by Plutarch', CAST(26 AS Decimal(18, 0)), N'image14.jpg', N' Plutarchus')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (15, 3, N'The Battle for Spain by Antony Beevor', CAST(24 AS Decimal(18, 0)), N'image15.jpg', N'Antony Beevor')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (16, 4, N'The Transmutations of Chymistry: Wilhelm Homberg and the Académie Royale des Sciences', CAST(20 AS Decimal(18, 0)), N'image16.jpg', N'Lawrence M. Principe')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (17, 4, N'Beyond Bakelite: Leo Baekeland and the Business of Science and Invention', CAST(21 AS Decimal(18, 0)), N'image17.jpg', N'Joris Mercelis')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (18, 4, N'The Spanish Disquiet: The Biblical Natural Philosophy of Benito Arias Montano', CAST(25 AS Decimal(18, 0)), N'image18.jpg', N'Maria M. Portuondo')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (19, 4, N'Making Time: Astronomical Time Measurement in Tokugawa Japan', CAST(22 AS Decimal(18, 0)), N'image19.jpg', N'Yulia Frumer')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (20, 4, N'World’s Fairs on the Eve of War', CAST(21 AS Decimal(18, 0)), N'image20.jpg', N'Robert Hugh Kargon')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (21, 5, N'Invincible Compendium Volume 1', CAST(34 AS Decimal(18, 0)), N'image21.jpg', N'Robert Kirkman')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (22, 5, N'Blank Comic Book For Kids : Create Your Own Comics With This Comic Book Journal Notebook: Over 100 Pages Large Big 8.5" x 11" Cartoon / Comic Book With Lots of Templates (Blank Comic Books)', CAST(7 AS Decimal(18, 0)), N'image22.jpg', N'
Blank Books ''N'' Journals')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (23, 5, N'Halloween Team #1', CAST(4 AS Decimal(18, 0)), N'image23.jpg', N'
Danny Baram')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (24, 5, N'I Survived Hurricane Katrina, 2005: A Graphic Novel (I Survived Graphic Novel #6) (I Survived Graphix)', CAST(4 AS Decimal(18, 0)), N'image24.jpg', N' Lauren Tarshis')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (25, 5, N'Marvel Encyclopedia, New Edition', CAST(22 AS Decimal(18, 0)), N'image25.jpg', N'Stephen Wiacek')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (26, 6, N'365 Bedtime Stories and Rhymes', CAST(13 AS Decimal(18, 0)), N'image26.jpg', N'365 Bedtime Stories and Rhymes')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (27, 6, N'The Golden Book of Fairy Tales (Classic Golden Book)', CAST(17 AS Decimal(18, 0)), N'image27.jpg', N'Adrienne Segur')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (28, 6, N'Fairy Tale', CAST(11 AS Decimal(18, 0)), N'image28.jpg', N'Audible Audiobook')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (29, 6, N'The Golden Book of Fairy Tales (Classic Golden Book)', CAST(17 AS Decimal(18, 0)), N'image29.jpg', N'Adrienne Segur')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (30, 6, N'Grimm''s Complete Fairy Tales', CAST(14 AS Decimal(18, 0)), N'image30.jpg', N' Wilhelm Carl Grimm, Jacob Ludwig Carl Grimm')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (31, 7, N'Solutions for Calculus: Early Transcendentals 8th', CAST(15 AS Decimal(18, 0)), N'image31.jpg', N'James Stewart')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (32, 7, N'Solutions for University Physics with Modern Physics 14th', CAST(12 AS Decimal(18, 0)), N'image32.jpg', N'Hugh D. Young')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (33, 7, N'Solutions for Chemistry: Structure and Properties 2nd', CAST(14 AS Decimal(18, 0)), N'image33.jpg', N'Nivaldo Tro')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (34, 7, N'Physics', CAST(10 AS Decimal(18, 0)), N'image34.jpg', N'John D. Cutnell, Kenneth W. Johnson')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (35, 7, N'Solutions for Physics for Scientists and Engineers with Modern Physics 4th', CAST(9 AS Decimal(18, 0)), N'image35.jpg', N'Douglas C. Giancoli')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (36, 8, N'The Chemistry Book: Big Ideas Simply Explained', CAST(10 AS Decimal(18, 0)), N'image36.jpg', N'
DK')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (37, 8, N'Solutions for Chemistry 10th', CAST(11 AS Decimal(18, 0)), N'image37.jpg', N'Raymond Chang')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (38, 8, N'The Science Book (Big Ideas)', CAST(10 AS Decimal(18, 0)), N'image38.jpg', N'DK')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (39, 8, N'Solutions for Chemistry A Molecular Approach 4th', CAST(12 AS Decimal(18, 0)), N'image39.jpg', N'Nivaldo J. Tro')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (40, 8, N'Solutions for Chemistry Matter and Change 2008', CAST(11 AS Decimal(18, 0)), N'image40.jpg', N'Buthelezi ,Dingrando,Wistrom,Zike')
GO
INSERT [dbo].[User] ([id], [UserName], [Password], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Role]) VALUES (1, N'admin', N'admin', N'Ngo', N'Luan', N'Vinh Bao ', N'Hai Phong', N'Ly Hoc', N'Viet Nam', N'0984726329', N'ngluan3752@gmail.com', 1)
INSERT [dbo].[User] ([id], [UserName], [Password], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Role]) VALUES (2, N'user', N'12345', N'Phung', N'Khoan', N'Bat Xat', N'Lao Cai', N'Muong Ke', N'Viet Nam', N'0923643789', N'khoanphung123@gmail.com', 2)
INSERT [dbo].[User] ([id], [UserName], [Password], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Role]) VALUES (3, N'guest', N'guest', N'Diep', N'Thien', N'De Do', N'Ninh Binh', N'Hoa Lu', N'Viet Nam', N'0963472362', N'diepthan321@gmail.com', 3)
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Product]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([Cid])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [BookStore] SET  READ_WRITE 
GO
