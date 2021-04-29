/*
 Navicat Premium Data Transfer

 Source Server         : SQL SERVER
 Source Server Type    : SQL Server
 Source Server Version : 15002080
 Source Host           : localhost:1433
 Source Catalog        : test
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002080
 File Encoding         : 65001

 Date: 29/04/2021 22:20:06
*/


-- ----------------------------
-- Table structure for EmployeeInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[EmployeeInfo]
GO

CREATE TABLE [dbo].[EmployeeInfo] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [FirstName] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MiddleName] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [LastName] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[EmployeeInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of EmployeeInfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[EmployeeInfo] ON
GO

INSERT INTO [dbo].[EmployeeInfo] ([Id], [FirstName], [MiddleName], [LastName]) VALUES (N'2', N'asdaasdsd', N'asdasd', N'aasdasd')
GO

SET IDENTITY_INSERT [dbo].[EmployeeInfo] OFF
GO


-- ----------------------------
-- Auto increment value for EmployeeInfo
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[EmployeeInfo]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table EmployeeInfo
-- ----------------------------
ALTER TABLE [dbo].[EmployeeInfo] ADD CONSTRAINT [PK__Employee__3214EC07C3AB4905] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

