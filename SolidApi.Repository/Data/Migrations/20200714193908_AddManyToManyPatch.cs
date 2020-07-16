using Microsoft.EntityFrameworkCore.Migrations;

namespace SolidApi.Repository.Data.Migrations
{
    public partial class AddManyToManyPatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserToCompany_Companies_CompanyId",
                table: "UserToCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToCompany_Users_UserId",
                table: "UserToCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserToCompany",
                table: "UserToCompany");

            migrationBuilder.RenameTable(
                name: "UserToCompany",
                newName: "UserToCompanies");

            migrationBuilder.RenameIndex(
                name: "IX_UserToCompany_CompanyId",
                table: "UserToCompanies",
                newName: "IX_UserToCompanies_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserToCompanies",
                table: "UserToCompanies",
                columns: new[] { "UserId", "CompanyId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserToCompanies_Companies_CompanyId",
                table: "UserToCompanies",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToCompanies_Users_UserId",
                table: "UserToCompanies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserToCompanies_Companies_CompanyId",
                table: "UserToCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToCompanies_Users_UserId",
                table: "UserToCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserToCompanies",
                table: "UserToCompanies");

            migrationBuilder.RenameTable(
                name: "UserToCompanies",
                newName: "UserToCompany");

            migrationBuilder.RenameIndex(
                name: "IX_UserToCompanies_CompanyId",
                table: "UserToCompany",
                newName: "IX_UserToCompany_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserToCompany",
                table: "UserToCompany",
                columns: new[] { "UserId", "CompanyId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserToCompany_Companies_CompanyId",
                table: "UserToCompany",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToCompany_Users_UserId",
                table: "UserToCompany",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
