USE [master]
GO
/****** Object:  Database [Clubx]    Script Date: 5/1/2022 2:54:30 PM ******/
CREATE DATABASE [Clubx]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clubx', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Clubx.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clubx_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Clubx_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Clubx] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clubx].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clubx] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clubx] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clubx] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clubx] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clubx] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clubx] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Clubx] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clubx] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clubx] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clubx] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clubx] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clubx] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clubx] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clubx] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clubx] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Clubx] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clubx] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clubx] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clubx] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clubx] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clubx] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Clubx] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clubx] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Clubx] SET  MULTI_USER 
GO
ALTER DATABASE [Clubx] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clubx] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clubx] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clubx] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clubx] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Clubx] SET QUERY_STORE = OFF
GO
USE [Clubx]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppLookups]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppLookups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[ValueText] [nvarchar](50) NOT NULL,
	[Group] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AppLookups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClubPayments]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClubPayments](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClubId] [uniqueidentifier] NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[PaymentType] [int] NULL,
	[Amount] [float] NOT NULL,
	[Description] [nvarchar](450) NULL,
	[PaymentMethod] [int] NULL,
	[PaymentExpiration] [date] NULL,
 CONSTRAINT [PK_ClubPayments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clubs]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clubs](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[ImageUrl] [nvarchar](250) NULL,
	[HasMembershipFee] [bit] NOT NULL,
	[Amount] [float] NULL,
 CONSTRAINT [PK_Clubs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClubSchedules]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClubSchedules](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[LocationId] [bigint] NULL,
	[ClubId] [uniqueidentifier] NOT NULL,
	[ClubDay] [int] NOT NULL,
	[ClubStartTime] [int] NOT NULL,
	[ClubEndTime] [int] NOT NULL,
	[SessionTitle] [nvarchar](150) NOT NULL,
	[ExpirationDate] [date] NOT NULL,
	[Capacity] [int] NOT NULL,
	[Virtual] [bit] NOT NULL,
	[VirtualLink] [nvarchar](450) NULL,
	[CreatedAt] [date] NULL,
 CONSTRAINT [PK_ClubSchedules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LnkClubScheduleUsers]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LnkClubScheduleUsers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClubScheduleId] [bigint] NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[CreatedAt] [date] NOT NULL,
 CONSTRAINT [PK_LnkClubScheduleUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LnkClubUser]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LnkClubUser](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClubId] [uniqueidentifier] NOT NULL,
	[HasClubAdminRole] [bit] NOT NULL,
 CONSTRAINT [PK_LnkClubUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[Address] [nvarchar](250) NULL,
 CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 5/1/2022 2:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SenderId] [nvarchar](450) NOT NULL,
	[RecipientId] [nvarchar](450) NOT NULL,
	[MessageBody] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220429160547_Initial Migration', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220501011416_custom-user-data', N'5.0.16')
GO
SET IDENTITY_INSERT [dbo].[AppLookups] ON 

INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (2, N'days', N'Monday', N'days')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (3, N'days', N'Tuesday', N'days')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (4, N'days', N'Wednesday', N'days')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (5, N'days', N'Thursday', N'days')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (6, N'days', N'Friday', N'days')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (7, N'days', N'Saturday', N'days')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (8, N'days', N'Sunday', N'days')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (9, N'times', N'00:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (10, N'times', N'00:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (11, N'times', N'01:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (12, N'times', N'01:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (13, N'times', N'02:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (14, N'times', N'02:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (15, N'times', N'03:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (16, N'times', N'03:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (17, N'times', N'04:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (18, N'times', N'04:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (19, N'times', N'05:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (20, N'times', N'05:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (21, N'times', N'06:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (22, N'times', N'06:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (23, N'times', N'07:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (24, N'times', N'07:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (25, N'times', N'08:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (26, N'times', N'08:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (27, N'times', N'09:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (28, N'times', N'09:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (29, N'times', N'10:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (30, N'times', N'10:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (31, N'times', N'11:00', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (32, N'times', N'11:30', N'AM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (33, N'times', N'12:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (34, N'times', N'12:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (35, N'times', N'13:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (36, N'times', N'13:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (37, N'times', N'14:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (38, N'times', N'14:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (39, N'times', N'15:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (40, N'times', N'15:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (41, N'times', N'16:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (42, N'times', N'16:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (43, N'times', N'17:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (44, N'times', N'17:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (45, N'times', N'18:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (46, N'times', N'18:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (47, N'times', N'19:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (48, N'times', N'19:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (49, N'times', N'20:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (50, N'times', N'20:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (51, N'times', N'21:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (52, N'times', N'21:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (53, N'times', N'22:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (54, N'times', N'22:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (55, N'times', N'23:00', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (56, N'times', N'23:30', N'PM')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (57, N'payment_method', N'Card', N'payment_method')
INSERT [dbo].[AppLookups] ([Id], [Category], [ValueText], [Group]) VALUES (58, N'payment_type', N'Club Membership', N'payment_type')
SET IDENTITY_INSERT [dbo].[AppLookups] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a36a215f-c975-4d16-869b-6d430a405c24', N'admin', N'admin', NULL)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7bd2dc5e-3c0c-42a8-9a2b-7466205f2b17', N'a36a215f-c975-4d16-869b-6d430a405c24')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'6c9697ab-2c6a-48d8-98df-e81670954d14', N'chimanwadike@gmail.com', N'CHIMANWADIKE@GMAIL.COM', N'chimanwadike@gmail.com', N'CHIMANWADIKE@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAED2W551YiOKbr5BKc2ZTC9LQJs+uVVKFJU9DOb+nwoARxkX2U64xt9TS7zQpI7z9QA==', N'SYXF72ZSAB44SSGNXNYX5INEL236MVBL', N'2c7a7862-5ba3-4aca-a935-33bf7bbb7161', NULL, 0, 0, NULL, 1, 0, N'Chima', N'Nwadike')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'6c9dccd0-9f7f-4241-a83f-36ff20c91ae2', N'tims@gmail.com', N'TIMS@GMAIL.COM', N'tims@gmail.com', N'TIMS@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMzXzdjzdlyHOWld4Ec7wOQuuuZWu8o1bxpmU37LSG6z1PXkoyZYfPYn7D5t8v+YUQ==', N'YTKRBCW7BWUIHGRXFC3ELH5YQTS7EGM6', N'5b8fdf99-6609-481f-a9c3-2e315b1acf6b', NULL, 0, 0, NULL, 1, 0, N'Timfon', N'Bassey')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'7bd2dc5e-3c0c-42a8-9a2b-7466205f2b17', N'superadministrator@app.com', N'SUPERADMINISTRATOR@APP.COM', N'superadministrator@app.com', N'SUPERADMINISTRATOR@APP.COM', 1, N'AQAAAAEAACcQAAAAEGM7nD8taN21KeYnr+TbQwRJF3c2Qn0WNrtXa9Oh86vFlB7kVT6z9OQuZ92LqWxUOw==', N'GD7OLJKOU3KWBWNBPYCUP66PTLYWFPJ4', N'3c8e4ce6-2619-43e1-afda-5dc7dcc7f28c', NULL, 0, 0, NULL, 1, 0, N'System', N'Admin')
GO
INSERT [dbo].[Clubs] ([Id], [Name], [Description], [ImageUrl], [HasMembershipFee], [Amount]) VALUES (N'b1750518-8650-44f3-b841-e28267c2627d', N'Music Club', N'Music club for everyone', N'https://images.unsplash.com/photo-1544785316-6e58aed68a50?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80', 1, 50)
GO
SET IDENTITY_INSERT [dbo].[ClubSchedules] ON 

INSERT [dbo].[ClubSchedules] ([Id], [LocationId], [ClubId], [ClubDay], [ClubStartTime], [ClubEndTime], [SessionTitle], [ExpirationDate], [Capacity], [Virtual], [VirtualLink], [CreatedAt]) VALUES (1, 1, N'b1750518-8650-44f3-b841-e28267c2627d', 4, 17, 19, N'Alte Music Training', CAST(N'2022-05-30' AS Date), 20, 0, N'https://www.google.com/', CAST(N'2022-04-30' AS Date))
SET IDENTITY_INSERT [dbo].[ClubSchedules] OFF
GO
SET IDENTITY_INSERT [dbo].[LnkClubScheduleUsers] ON 

INSERT [dbo].[LnkClubScheduleUsers] ([Id], [ClubScheduleId], [UserId], [CreatedAt]) VALUES (0, 1, N'7bd2dc5e-3c0c-42a8-9a2b-7466205f2b17', CAST(N'2022-04-30' AS Date))
INSERT [dbo].[LnkClubScheduleUsers] ([Id], [ClubScheduleId], [UserId], [CreatedAt]) VALUES (1, 1, N'6c9697ab-2c6a-48d8-98df-e81670954d14', CAST(N'2022-05-01' AS Date))
SET IDENTITY_INSERT [dbo].[LnkClubScheduleUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[LnkClubUser] ON 

INSERT [dbo].[LnkClubUser] ([Id], [UserId], [ClubId], [HasClubAdminRole]) VALUES (1, N'7bd2dc5e-3c0c-42a8-9a2b-7466205f2b17', N'b1750518-8650-44f3-b841-e28267c2627d', 1)
INSERT [dbo].[LnkClubUser] ([Id], [UserId], [ClubId], [HasClubAdminRole]) VALUES (2, N'6c9697ab-2c6a-48d8-98df-e81670954d14', N'b1750518-8650-44f3-b841-e28267c2627d', 0)
SET IDENTITY_INSERT [dbo].[LnkClubUser] OFF
GO
SET IDENTITY_INSERT [dbo].[Locations] ON 

INSERT [dbo].[Locations] ([Id], [Name], [Description], [Address]) VALUES (1, N'Theatre A', N'Faculty of Technology Theatre A', N'Faculty of Technology Theatre A')
SET IDENTITY_INSERT [dbo].[Locations] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 5/1/2022 2:54:30 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/1/2022 2:54:30 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 5/1/2022 2:54:30 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 5/1/2022 2:54:30 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 5/1/2022 2:54:30 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 5/1/2022 2:54:30 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/1/2022 2:54:30 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clubs] ADD  CONSTRAINT [DF_Clubs_HasMembershipFee]  DEFAULT ((0)) FOR [HasMembershipFee]
GO
ALTER TABLE [dbo].[ClubSchedules] ADD  CONSTRAINT [DF_ClubSchedules_Virtual]  DEFAULT ((0)) FOR [Virtual]
GO
ALTER TABLE [dbo].[LnkClubUser] ADD  CONSTRAINT [DF_LnkClubUser_HasClubAdminRole]  DEFAULT ((0)) FOR [HasClubAdminRole]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ClubPayments]  WITH CHECK ADD  CONSTRAINT [FK_ClubPayments_AspNetUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ClubPayments] CHECK CONSTRAINT [FK_ClubPayments_AspNetUsers]
GO
ALTER TABLE [dbo].[ClubPayments]  WITH CHECK ADD  CONSTRAINT [FK_ClubPayments_Clubs] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Clubs] ([Id])
GO
ALTER TABLE [dbo].[ClubPayments] CHECK CONSTRAINT [FK_ClubPayments_Clubs]
GO
ALTER TABLE [dbo].[ClubSchedules]  WITH CHECK ADD  CONSTRAINT [FK_ClubSchedules_Clubs] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Clubs] ([Id])
GO
ALTER TABLE [dbo].[ClubSchedules] CHECK CONSTRAINT [FK_ClubSchedules_Clubs]
GO
ALTER TABLE [dbo].[ClubSchedules]  WITH CHECK ADD  CONSTRAINT [FK_ClubSchedules_Locations] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Locations] ([Id])
GO
ALTER TABLE [dbo].[ClubSchedules] CHECK CONSTRAINT [FK_ClubSchedules_Locations]
GO
ALTER TABLE [dbo].[LnkClubScheduleUsers]  WITH CHECK ADD  CONSTRAINT [FK_LnkClubScheduleUsers_AspNetUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LnkClubScheduleUsers] CHECK CONSTRAINT [FK_LnkClubScheduleUsers_AspNetUsers]
GO
ALTER TABLE [dbo].[LnkClubScheduleUsers]  WITH CHECK ADD  CONSTRAINT [FK_LnkClubScheduleUsers_LnkClubScheduleUsers] FOREIGN KEY([ClubScheduleId])
REFERENCES [dbo].[ClubSchedules] ([Id])
GO
ALTER TABLE [dbo].[LnkClubScheduleUsers] CHECK CONSTRAINT [FK_LnkClubScheduleUsers_LnkClubScheduleUsers]
GO
ALTER TABLE [dbo].[LnkClubUser]  WITH CHECK ADD  CONSTRAINT [FK_LnkClubUser_AspNetUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LnkClubUser] CHECK CONSTRAINT [FK_LnkClubUser_AspNetUsers]
GO
ALTER TABLE [dbo].[LnkClubUser]  WITH CHECK ADD  CONSTRAINT [FK_LnkClubUser_Clubs] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Clubs] ([Id])
GO
ALTER TABLE [dbo].[LnkClubUser] CHECK CONSTRAINT [FK_LnkClubUser_Clubs]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_AspNetUsers] FOREIGN KEY([RecipientId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_AspNetUsers]
GO
USE [master]
GO
ALTER DATABASE [Clubx] SET  READ_WRITE 
GO
