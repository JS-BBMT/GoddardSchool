using Microsoft.EntityFrameworkCore.Migrations;

namespace FranchiseePortal.Migrations
{
    public partial class Upgraded_To_Abp_6_4_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Delete duplicated rows in AbpUserLogins before creating UNIQUE Index
            //This data was created in QA and DEV when developing the SSO login and the old users have been subsequently deleted
            var sqlScript = @"
                ;WITH CTE AS (
	                SELECT
		                [ProviderKey]
		                , [TenantId]
		                , count(1) as Dups
	                FROM [dbo].[AbpUserLogins]
	                GROUP BY [ProviderKey], [TenantId]
	                HAVING count(1) > 1
                )
                DELETE [dbo].[AbpUserLogins]
                FROM [dbo].[AbpUserLogins]
	                JOIN CTE ON [AbpUserLogins].ProviderKey = CTE.ProviderKey AND [AbpUserLogins].TenantId = CTE.TenantId
	                JOIN [dbo].[AbpUsers] ON [dbo].[AbpUsers].Id = [AbpUserLogins].UserId
                WHERE [AbpUsers].IsDeleted = 1";
            migrationBuilder.Sql(sqlScript);

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_ProviderKey_TenantId",
                table: "AbpUserLogins",
                columns: new[] { "ProviderKey", "TenantId" },
                unique: true,
                filter: "[TenantId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AbpUserLogins_ProviderKey_TenantId",
                table: "AbpUserLogins");
        }
    }
}
