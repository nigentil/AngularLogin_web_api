using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularLogin_web_api.Migrations
{
    public partial class company_WithComplexPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyUsers",
                table: "CompanyUsers");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUsers_CompanyID",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "CompanyUserID",
                table: "CompanyUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyUsers",
                table: "CompanyUsers",
                columns: new[] { "CompanyID", "UserID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyUsers",
                table: "CompanyUsers");

            migrationBuilder.AddColumn<int>(
                name: "CompanyUserID",
                table: "CompanyUsers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyUsers",
                table: "CompanyUsers",
                column: "CompanyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_CompanyID",
                table: "CompanyUsers",
                column: "CompanyID");
        }
    }
}
