-- https://stackoverflow.com/a/27633153/541456
CREATE USER [gsi-franchisee-portal-app] FROM LOGIN [gsi-franchisee-portal-app];

ALTER USER [gsi-franchisee-portal-app]
 WITH DEFAULT_SCHEMA = [dbo]


EXEC sp_addrolemember N'db_owner', N'gsi-franchisee-portal-app'
GO