using Microsoft.EntityFrameworkCore.Migrations;

namespace FranchiseePortal.Migrations
{
    public partial class Remove_ResourceLink_COVID_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlScript = @"
                DELETE FROM [dbo].[ResourceLinks]
                WHERE [Text] = 'Covid-19 Resources'";
            migrationBuilder.Sql(sqlScript);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sqlScript = @"
                INSERT INTO [dbo].[ResourceLinks]
                ([Text], [Url], [Icon], [IsExternal], [CreationTime], [IsDeleted])
                VALUES
                ('Covid-19 Resources', '/', 'Color-Covid', 1, GETUTCDATE(), 0)";
            migrationBuilder.Sql(sqlScript);
        }
    }
}
