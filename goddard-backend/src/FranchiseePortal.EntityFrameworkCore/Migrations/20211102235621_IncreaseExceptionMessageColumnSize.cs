using Microsoft.EntityFrameworkCore.Migrations;

namespace FranchiseePortal.Migrations
{
    public partial class IncreaseExceptionMessageColumnSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExceptionMessage",
                table: "AbpAuditLogs",
                nullable: true,
                maxLength: 4096);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name:"ExceptionMessage",
                table: "AbpAuditLogs",
                nullable: true,
                maxLength: 2048);
        }
    }
}
