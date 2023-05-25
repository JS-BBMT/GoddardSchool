-- Run in master DB

CREATE LOGIN [gsi-franchisee-portal-app] WITH PASSWORD = '{replace}';
GO

--https://stackoverflow.com/a/17631864/541456
CREATE USER [gsi-franchisee-portal-app] FROM LOGIN [gsi-franchisee-portal-app];