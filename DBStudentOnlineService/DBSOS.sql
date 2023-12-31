USE [StudentOnlineServiceSystem]
GO
/****** Object:  User [DBAdminuser]    Script Date: 11/12/2023 20:34:31 ******/
CREATE USER [DBAdminuser] FOR LOGIN [DBAdminuser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[AccountBalance]    Script Date: 11/12/2023 20:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountBalance](
	[BalanceID] [int] NOT NULL,
	[UserID] [int] NULL,
	[CurrentBalance] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BalanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InformationChangeServiceDetail]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformationChangeServiceDetail](
	[ChangeID] [int] NOT NULL,
	[ServiceID] [int] NULL,
	[ChangType] [varchar](50) NOT NULL,
	[Fee] [decimal](12, 2) NOT NULL,
	[RegistrationDate] [date] NOT NULL,
	[Major] [varchar](25) NULL,
	[Description] [varchar](255) NULL,
	[FileAttached] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ChangeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegistrationDepartments]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistrationDepartments](
	[DepartmentID] [int] NOT NULL,
	[DepartmentName] [varchar](100) NOT NULL,
	[ContactEmail] [varchar](255) NOT NULL,
	[ContactPhone] [varchar](15) NULL,
	[Location] [varchar](255) NULL,
	[Responsibilities] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleList]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleList](
	[RoleID] [int] NOT NULL,
	[UserID] [int] NULL,
	[RoleTypeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleType]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleType](
	[RoleTypeID] [int] NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[Description] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] NOT NULL,
	[UserID] [int] NULL,
	[ServiceTypeID] [int] NULL,
	[DepartmentID] [int] NULL,
	[TotalAmount] [decimal](12, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ServiceFormStatus] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceType](
	[ServiceTypeID] [int] NOT NULL,
	[ServiceName] [varchar](50) NOT NULL,
	[Description] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentConfirmationServiceDetails]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentConfirmationServiceDetails](
	[ConfirmationID] [int] NOT NULL,
	[ServiceID] [int] NULL,
	[Fee] [decimal](12, 2) NOT NULL,
	[Major] [varchar](25) NULL,
	[ConfirmationType] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](15) NULL,
	[FileAttached] [varchar](255) NULL,
	[RegistrationDate] [date] NOT NULL,
	[Description] [varchar](255) NULL,
	[DeliveryMethod] [varchar](50) NULL,
	[ResuiltDeliveryMethod] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ConfirmationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuitionReductionServiceDetails]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuitionReductionServiceDetails](
	[ReductionID] [int] NOT NULL,
	[ServiceID] [int] NULL,
	[Course] [varchar](100) NOT NULL,
	[Fee] [decimal](12, 2) NOT NULL,
	[Certificate] [varchar](255) NULL,
	[Major] [varchar](25) NULL,
	[RegistrationDate] [date] NOT NULL,
	[PhoneNumber] [varchar](15) NULL,
	[DeliveryMethod] [varchar](50) NULL,
	[ResuiltDeliveryMethod] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ReductionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/12/2023 20:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[RoleTypeID] [int] NULL,
	[Name] [varchar](15) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[PhoneNumber] [varchar](15) NULL,
	[Gmail] [varchar](255) NULL,
	[StudentStatus] [varchar](50) NULL,
	[Major] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (1, 1, CAST(4732.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (2, 2, CAST(1188.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (3, 3, CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (4, 4, CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (5, 5, CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (6, 6, CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (7, 7, CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (8, 8, CAST(290.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (9, 9, CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (10, 10, CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (11, 11, CAST(20.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (13, 13, CAST(95.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (14, 14, CAST(100.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (15, 15, CAST(93.00 AS Decimal(12, 2)))
INSERT [dbo].[AccountBalance] ([BalanceID], [UserID], [CurrentBalance]) VALUES (16, 16, CAST(100.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[InformationChangeServiceDetail] ([ChangeID], [ServiceID], [ChangType], [Fee], [RegistrationDate], [Major], [Description], [FileAttached]) VALUES (1, 1, N'Name', CAST(50.00 AS Decimal(12, 2)), CAST(N'2023-12-04' AS Date), N'Computer Science', N'i wanna change name', N'BC00288_HieuTT_Assignment1.1.docx')
INSERT [dbo].[InformationChangeServiceDetail] ([ChangeID], [ServiceID], [ChangType], [Fee], [RegistrationDate], [Major], [Description], [FileAttached]) VALUES (2, 4, N'Class', CAST(10.00 AS Decimal(12, 2)), CAST(N'2023-12-04' AS Date), N'Computer Science', N'New change', N'BC00288_HieuTT_Assignment1.1.docx')
INSERT [dbo].[InformationChangeServiceDetail] ([ChangeID], [ServiceID], [ChangType], [Fee], [RegistrationDate], [Major], [Description], [FileAttached]) VALUES (3, 5, N'Class', CAST(5.00 AS Decimal(12, 2)), CAST(N'2023-12-05' AS Date), N'Computer Science', N'I wanna change class', N'BC00288_HieuTT_Assignment1.1.docx')
GO
INSERT [dbo].[RegistrationDepartments] ([DepartmentID], [DepartmentName], [ContactEmail], [ContactPhone], [Location], [Responsibilities]) VALUES (1, N'Admissions', N'admissions@fpt.edu.vn', N'0123456789', N'Job Placement Center', N'Admitting new students')
INSERT [dbo].[RegistrationDepartments] ([DepartmentID], [DepartmentName], [ContactEmail], [ContactPhone], [Location], [Responsibilities]) VALUES (2, N'Finance', N'finance@fpt.edu.vn', N'0987654321', N'Job Placement Center', N'Handling financial')
INSERT [dbo].[RegistrationDepartments] ([DepartmentID], [DepartmentName], [ContactEmail], [ContactPhone], [Location], [Responsibilities]) VALUES (3, N'Academic Affairs', N'academic@fpt.edu.vn', N'0123456789', N'Job Placement Center', N'Managing academic programs')
GO
INSERT [dbo].[RoleList] ([RoleID], [UserID], [RoleTypeID]) VALUES (1, 1, 1)
INSERT [dbo].[RoleList] ([RoleID], [UserID], [RoleTypeID]) VALUES (2, 2, 2)
INSERT [dbo].[RoleList] ([RoleID], [UserID], [RoleTypeID]) VALUES (3, 3, 2)
GO
INSERT [dbo].[RoleType] ([RoleTypeID], [RoleName], [Description]) VALUES (1, N'Admin', N'Administrator role with full access')
INSERT [dbo].[RoleType] ([RoleTypeID], [RoleName], [Description]) VALUES (2, N'Student', N'Regular user role with limited access')
GO
INSERT [dbo].[Service] ([ServiceID], [UserID], [ServiceTypeID], [DepartmentID], [TotalAmount], [Quantity], [ServiceFormStatus]) VALUES (1, 1, 1, 3, CAST(50.00 AS Decimal(12, 2)), 10, N'Approved')
INSERT [dbo].[Service] ([ServiceID], [UserID], [ServiceTypeID], [DepartmentID], [TotalAmount], [Quantity], [ServiceFormStatus]) VALUES (2, 1, 2, 1, CAST(70.00 AS Decimal(12, 2)), 10, N'Pending')
INSERT [dbo].[Service] ([ServiceID], [UserID], [ServiceTypeID], [DepartmentID], [TotalAmount], [Quantity], [ServiceFormStatus]) VALUES (3, 1, 3, 2, CAST(120.00 AS Decimal(12, 2)), 20, N'Pending')
INSERT [dbo].[Service] ([ServiceID], [UserID], [ServiceTypeID], [DepartmentID], [TotalAmount], [Quantity], [ServiceFormStatus]) VALUES (4, 8, 1, 3, CAST(10.00 AS Decimal(12, 2)), 2, N'Pending')
INSERT [dbo].[Service] ([ServiceID], [UserID], [ServiceTypeID], [DepartmentID], [TotalAmount], [Quantity], [ServiceFormStatus]) VALUES (5, 13, 1, 3, CAST(5.00 AS Decimal(12, 2)), 1, N'Pending')
INSERT [dbo].[Service] ([ServiceID], [UserID], [ServiceTypeID], [DepartmentID], [TotalAmount], [Quantity], [ServiceFormStatus]) VALUES (6, 15, 2, 1, CAST(7.00 AS Decimal(12, 2)), 1, N'Pending')
INSERT [dbo].[Service] ([ServiceID], [UserID], [ServiceTypeID], [DepartmentID], [TotalAmount], [Quantity], [ServiceFormStatus]) VALUES (7, 2, 3, 2, CAST(6.00 AS Decimal(12, 2)), 1, N'Pending')
GO
INSERT [dbo].[ServiceType] ([ServiceTypeID], [ServiceName], [Description]) VALUES (1, N'Information Change', N'Update personal information')
INSERT [dbo].[ServiceType] ([ServiceTypeID], [ServiceName], [Description]) VALUES (2, N'Tuition Reduction', N'Request reduction in tuition fees')
INSERT [dbo].[ServiceType] ([ServiceTypeID], [ServiceName], [Description]) VALUES (3, N'Student Confirmation', N'Confirm student status')
GO
INSERT [dbo].[StudentConfirmationServiceDetails] ([ConfirmationID], [ServiceID], [Fee], [Major], [ConfirmationType], [PhoneNumber], [FileAttached], [RegistrationDate], [Description], [DeliveryMethod], [ResuiltDeliveryMethod]) VALUES (1, 3, CAST(120.00 AS Decimal(12, 2)), N'Computer Science', N'My Form', N'0365914056', N'BC00288_HieuTT_Assignment1.1.docx', CAST(N'2023-12-04' AS Date), N'I wanna join military', N'A', N'A')
INSERT [dbo].[StudentConfirmationServiceDetails] ([ConfirmationID], [ServiceID], [Fee], [Major], [ConfirmationType], [PhoneNumber], [FileAttached], [RegistrationDate], [Description], [DeliveryMethod], [ResuiltDeliveryMethod]) VALUES (2, 7, CAST(6.00 AS Decimal(12, 2)), N'Engineering', N'My Form', N'0373923313', N'form.1.docx', CAST(N'2023-11-01' AS Date), N'i wanna confirm my study', N'CTSV', N'CTSV')
GO
INSERT [dbo].[TuitionReductionServiceDetails] ([ReductionID], [ServiceID], [Course], [Fee], [Certificate], [Major], [RegistrationDate], [PhoneNumber], [DeliveryMethod], [ResuiltDeliveryMethod]) VALUES (1, 2, N'K7', CAST(70.00 AS Decimal(12, 2)), N'BC00288_HieuTT_Assignment1.3docx.docx', N'Computer Science', CAST(N'2023-12-04' AS Date), N'0365914056', N'A', N'A')
INSERT [dbo].[TuitionReductionServiceDetails] ([ReductionID], [ServiceID], [Course], [Fee], [Certificate], [Major], [RegistrationDate], [PhoneNumber], [DeliveryMethod], [ResuiltDeliveryMethod]) VALUES (2, 6, N'', CAST(7.00 AS Decimal(12, 2)), N'toeic.docx', N'Computer Science', CAST(N'2023-12-06' AS Date), N'0365914056', N'CTSV', N'CTSV')
GO
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (1, 2, N'Admin', N'ee3a563bdfd38c74b20d771172a5c4c5ba11f80bb7477772a30124c9b8b63e5d', N'0123456789', N'admin@fpt.edu.vn', N'Active', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (2, 2, N'Zuka', N'30ae4f895bb8457daf465215f47d746bb282cceaa0dddbae75e24ef50c34796a', N'0373923313', N'zukagom@fpt.edu.vn', N'Active', N'Engineering')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (3, 2, N'Regular User 2', N'user2password', N'0123456789', N'user2@gmail.com', N'Inactive', N'Engineering')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (4, 2, N'Regular User 1', N'user1password', N'0987654321', N'user1@fpt.edu.vn', N'Inactive', N'Business')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (5, 2, N'Regular User 1', N'user1password', N'0987654321', N'user1@gmail.com', N'Inactive', N'Business')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (6, 1, N'PoPi', N'ee3a563bdfd38c74b20d771172a5c4c5ba11f80bb7477772a30124c9b8b63e5d', N'0365914056', N'popixworkspace@fpt.edu.vn', N'Active', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (7, 2, N'Anonymous ', N'123457a', N'0365914057', N'anonymous1@gmail.com', N'Inactive', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (8, 2, N'Ly Thai Cuong', N'f99c17e5acabb30261e23707f340c7db5689cb30436eb8b563c1dd9b78f11608', N'0365914058', N'cuonglt@fpt.edu.vn', N'Active', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (9, 2, N'Truong Vu Trieu', N'f99c17e5acabb30261e23707f340c7db5689cb30436eb8b563c1dd9b78f11608', N'0365914059', N'trieutv@fpt.edu.vn', N'Active', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (10, 2, N'Pham Quoc Tien', N'ee3a563bdfd38c74b20d771172a5c4c5ba11f80bb7477772a30124c9b8b63e5d', N'0365914050', N'tienpq@fpt.edu.vn', N'Active', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (11, 2, N'Phan Thanh Tan', N'f99c17e5acabb30261e23707f340c7db5689cb30436eb8b563c1dd9b78f11608', N'0365914056', N'tanpt@fpt.edu.vn', N'Active', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (13, 2, N'PoPi2', N'f99c17e5acabb30261e23707f340c7db5689cb30436eb8b563c1dd9b78f11608', N'0365914450', N'popi@fpt.edu.vn', N'Active', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (14, 2, N'Truong Vu Trieu', N'f99c17e5acabb30261e23707f340c7db5689cb30436eb8b563c1dd9b78f11608', N'0365914056', N'trieu@fpt.edu.vn', N'Active', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (15, 2, N'To Trung Hieu', N'Hh123457a', N'0365914056', N'Hieuttbc00288@fpt.edu.vn', N'Inactive', N'Computer Science')
INSERT [dbo].[Users] ([UserID], [RoleTypeID], [Name], [Password], [PhoneNumber], [Gmail], [StudentStatus], [Major]) VALUES (16, 2, N'To Trung Hieu', N'ee3a563bdfd38c74b20d771172a5c4c5ba11f80bb7477772a30124c9b8b63e5d', N'0365914056', N'hieutt@fpt.edu.vn', N'Active', N'Computer Science')
GO
ALTER TABLE [dbo].[AccountBalance]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[InformationChangeServiceDetail]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[RoleList]  WITH CHECK ADD FOREIGN KEY([RoleTypeID])
REFERENCES [dbo].[RoleType] ([RoleTypeID])
GO
ALTER TABLE [dbo].[RoleList]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[RegistrationDepartments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD FOREIGN KEY([ServiceTypeID])
REFERENCES [dbo].[ServiceType] ([ServiceTypeID])
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[StudentConfirmationServiceDetails]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[TuitionReductionServiceDetails]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[RegistrationDepartments]  WITH CHECK ADD CHECK  (([ContactEmail] like '%@%.%'))
GO
ALTER TABLE [dbo].[StudentConfirmationServiceDetails]  WITH CHECK ADD CHECK  (([FileAttached] like '%.docx' OR [FileAttached] like '%.doc'))
GO
ALTER TABLE [dbo].[TuitionReductionServiceDetails]  WITH CHECK ADD CHECK  (([Certificate] like '%.docx' OR [Certificate] like '%.doc'))
GO
