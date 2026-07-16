USE [master]
CREATE LOGIN [tester2] WITH PASSWORD=N'1111', DEFAULT_DATABASE=[test], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO

USE [test]
CREATE USER [usern] FOR LOGIN [tester2] WITH DEFAULT_SCHEMA=[dbo]
GO

EXEC sp_addrolemember N'db_datareader', N'usern'

EXEC sp_droprolemember N'db_datawriter', N'usern'