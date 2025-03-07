USE [InfocomAssignment]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentName] [nvarchar](100) NULL,
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Name] [nvarchar](100) NOT NULL,
	[Salary] [decimal](18, 2) NOT NULL,
	[DateOfJoining] [datetime] NOT NULL,
	[DepartmentId] [int] NULL,
	[Department] [nvarchar](50) NOT NULL,
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DepartmentName], [DepartmentId]) VALUES (N'HR Department', 12)
INSERT [dbo].[Department] ([DepartmentName], [DepartmentId]) VALUES (N'Accountdepartment', 13)
INSERT [dbo].[Department] ([DepartmentName], [DepartmentId]) VALUES (N'Development', 14)
INSERT [dbo].[Department] ([DepartmentName], [DepartmentId]) VALUES (N'QA Department', 15)
INSERT [dbo].[Department] ([DepartmentName], [DepartmentId]) VALUES (N'Research Department', 16)
INSERT [dbo].[Department] ([DepartmentName], [DepartmentId]) VALUES (N'Entertainment Department', 17)
INSERT [dbo].[Department] ([DepartmentName], [DepartmentId]) VALUES (N'Head Department', 18)
INSERT [dbo].[Department] ([DepartmentName], [DepartmentId]) VALUES (N'Transportation Department', 19)
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Rabin sapkota', CAST(125500.00 AS Decimal(18, 2)), CAST(N'2025-01-28T00:00:00.000' AS DateTime), 13, N'Accountdepartment', 5)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Kevyn Tran', CAST(42.00 AS Decimal(18, 2)), CAST(N'2000-12-26T00:00:00.000' AS DateTime), 15, N'QA Department', 7)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Courtney Mccullough', CAST(86.00 AS Decimal(18, 2)), CAST(N'1993-03-19T00:00:00.000' AS DateTime), 19, N'Transportation Department', 8)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Baxter Aguirre', CAST(12.00 AS Decimal(18, 2)), CAST(N'2002-06-26T00:00:00.000' AS DateTime), 12, N'HR Department', 9)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Odessa Cochran', CAST(67.00 AS Decimal(18, 2)), CAST(N'1999-12-09T00:00:00.000' AS DateTime), 18, N'Head Department', 10)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Daryl Macdonald', CAST(56.00 AS Decimal(18, 2)), CAST(N'1979-06-05T00:00:00.000' AS DateTime), 13, N'Accountdepartment', 11)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Zia Hunter', CAST(85.00 AS Decimal(18, 2)), CAST(N'2002-02-03T00:00:00.000' AS DateTime), 18, N'Head Department', 12)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Claire Humphrey', CAST(23.00 AS Decimal(18, 2)), CAST(N'2003-03-29T00:00:00.000' AS DateTime), 16, N'Research Department', 13)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Caryn Walker', CAST(31.00 AS Decimal(18, 2)), CAST(N'2025-01-28T00:00:00.000' AS DateTime), 14, N'Development', 14)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Alyssa Johnston', CAST(90.00 AS Decimal(18, 2)), CAST(N'2003-05-01T00:00:00.000' AS DateTime), 15, N'QA Department', 15)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Ezra Walsh', CAST(43.00 AS Decimal(18, 2)), CAST(N'1975-06-22T00:00:00.000' AS DateTime), 15, N'QA Department', 16)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Rhona Castro', CAST(99.00 AS Decimal(18, 2)), CAST(N'2010-05-17T00:00:00.000' AS DateTime), 15, N'QA Department', 17)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Carolyn Owen', CAST(24.00 AS Decimal(18, 2)), CAST(N'1999-12-26T00:00:00.000' AS DateTime), 12, N'HR Department', 18)
INSERT [dbo].[Employee] ([Name], [Salary], [DateOfJoining], [DepartmentId], [Department], [EmployeeId]) VALUES (N'Alyssa Murphy', CAST(2.00 AS Decimal(18, 2)), CAST(N'1981-08-17T00:00:00.000' AS DateTime), 13, N'Accountdepartment', 19)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmentId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
/****** Object:  StoredProcedure [dbo].[sp_add_employee]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_add_employee]
    @name AS NVARCHAR(100),
    @salary AS DECIMAL(18, 2),
    @dateofjoin AS datetime,
    @departmentid AS INT,
    @department AS NVARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Employee (Name, Salary, DateOfJoining, DepartmentId, Department)
    VALUES (@name, @salary, @dateofjoin, @departmentid, @department);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_department]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_create_department](
@departmentName nvarchar(100)
)
as 
begin 
	insert into dbo.Department (DepartmentName)
	values (@departmentName)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_department]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delete_department](
@id int
)
as 
begin
	delete from dbo.Department where 
	DepartmentId=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_employee]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_delete_employee]
	@id as int

AS
BEGIN
	delete from dbo.Employee where EmployeeId=@id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getall_department]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getall_department]
AS
BEGIN
    SELECT 
        DepartmentId AS Id, -- Aliases column name to match model
        DepartmentName AS Name -- Aliases column name to match model
    FROM dbo.Department
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getall_employee]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getall_employee]

AS
BEGIN
	select EmployeeId,Name,Salary,DateOfJoining,DepartmentId,Department  from dbo.Employee
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getemp_bydepid]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getemp_bydepid](
@id int
)
as
begin 
select EmployeeId,Name,Salary,DateOfJoining,DepartmentId,Department  from dbo.Employee
where DepartmentId=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_update_department]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_update_department](
@id int,
@departmentname nvarchar(100)
)
as 
begin
	update dbo.Department set DepartmentName=@departmentname 
	where DepartmentId=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_update_employee]    Script Date: 1/28/2025 06:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_employee]
	@id as int,
    @name AS NVARCHAR(100),
    @salary AS DECIMAL(18, 2),
    @dateofjoin AS datetime,
    @departmentid AS INT,
    @department AS NVARCHAR(50)
AS
BEGIN
	update dbo.Employee set Name=@name,Salary=@salary,DateOfJoining=@dateofjoin,Department=@department,DepartmentId=@departmentid
	where EmployeeId=@id
END
GO
