using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hms.DataAccess.Migrations
{
    public partial class tablemodify2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ROLE_ID",
                table: "US_USER_ROLE",
                newName: "US_ROLE_ID");

            migrationBuilder.RenameColumn(
                name: "USER_ID",
                table: "US_USER_ROLE",
                newName: "US_USER_ID");

            migrationBuilder.CreateTable(
                name: "US_ROLE_MENU",
                columns: table => new
                {
                    US_ROLE_ID = table.Column<int>(type: "int", nullable: false),
                    US_CHILD_MENU_ID = table.Column<int>(type: "int", nullable: false),
                    IS_ACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATE_BY = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CREATE_DEVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UPDATE_DEVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_US_ROLE_MENU_ID", x => new { x.US_ROLE_ID, x.US_CHILD_MENU_ID });
                    table.ForeignKey(
                        name: "FK_US_ROLE_MENU_US_CHILD_MENU_US_CHILD_MENU_ID",
                        column: x => x.US_CHILD_MENU_ID,
                        principalTable: "US_CHILD_MENU",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_ROLE_MENU_US_ROLE_US_ROLE_ID",
                        column: x => x.US_ROLE_ID,
                        principalTable: "US_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_ROLE_US_ROLE_ID",
                table: "US_USER_ROLE",
                column: "US_ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_ROLE_MENU_US_CHILD_MENU_ID",
                table: "US_ROLE_MENU",
                column: "US_CHILD_MENU_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_US_USER_ROLE_US_ROLE_US_ROLE_ID",
                table: "US_USER_ROLE",
                column: "US_ROLE_ID",
                principalTable: "US_ROLE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_US_USER_ROLE_US_USER_US_USER_ID",
                table: "US_USER_ROLE",
                column: "US_USER_ID",
                principalTable: "US_USER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_US_USER_ROLE_US_ROLE_US_ROLE_ID",
                table: "US_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_US_USER_ROLE_US_USER_US_USER_ID",
                table: "US_USER_ROLE");

            migrationBuilder.DropTable(
                name: "US_ROLE_MENU");

            migrationBuilder.DropIndex(
                name: "IX_US_USER_ROLE_US_ROLE_ID",
                table: "US_USER_ROLE");

            migrationBuilder.RenameColumn(
                name: "US_ROLE_ID",
                table: "US_USER_ROLE",
                newName: "ROLE_ID");

            migrationBuilder.RenameColumn(
                name: "US_USER_ID",
                table: "US_USER_ROLE",
                newName: "USER_ID");
        }
    }
}
