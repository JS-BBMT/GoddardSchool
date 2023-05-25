# ASP.NET ZERO - ASP.NET Core Version
* Start from here: https://www.aspnetzero.com/Documents/Development-Guide-Core
* Want to port your existing MVC 5.x application? See this post: http://volosoft.com/migrating-from-asp-net-mvc-5x-to-asp-net-core/

## Requirements
Requirements in addition what's documented by ASP.NET Zero
* .NET 5.0 SDK: https://dotnet.microsoft.com/download

## Configuration
If user-specific configuration (ex. `ConnectionStrings:Default`) is required for your local development environment
use .NET Core [user secrets](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=windows#secret-manager)

## Local Docker Notes

Running `FranchiseePortal.Web.Host` in local Docker environment requires:
- Update "ConnectionStrings:Default" in user secrets to point to the SQL DB.  On Windows machine the host is referred to by `host.docker.internal` from a container.  Refer to StackOverflow [answer](https://stackoverflow.com/a/43541732/541456) for more info.
- Docker launch settings are configured to run under `Local-Docker` environment name.  Therefore `appsettings.Local-Docker.json` is the override file.
- There should be a private key SSL cert file at `%USERPROFILE%\AppData\Roaming\ASP.NET\Https\FranchiseePortal.Web.Host.pfx`.  This may be auto setup by VS2019.  If you don't have it then follow [Hosting ASP.NET Core images with Docker over HTTPS](https://docs.microsoft.com/en-us/aspnet/core/security/docker-https?view=aspnetcore-5.0) guide to create it and then update "Kestrel:Certificates:Development:Password" and "Kestrel:Certificates:Development:Path" in user secrets accordingly.