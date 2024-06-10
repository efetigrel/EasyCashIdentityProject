using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_relation_customerAccount_appUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountAppUserID",
                table: "CustomerAccount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccount_CustomerAccountAppUserID",
                table: "CustomerAccount",
                column: "CustomerAccountAppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccount_AspNetUsers_CustomerAccountAppUserID",
                table: "CustomerAccount",
                column: "CustomerAccountAppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccount_AspNetUsers_CustomerAccountAppUserID",
                table: "CustomerAccount");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccount_CustomerAccountAppUserID",
                table: "CustomerAccount");

            migrationBuilder.DropColumn(
                name: "CustomerAccountAppUserID",
                table: "CustomerAccount");
        }
    }
}
