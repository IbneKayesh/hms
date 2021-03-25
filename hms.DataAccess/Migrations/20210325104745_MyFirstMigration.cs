using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hms.DataAccess.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "US_USER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN_ID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    USER_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MOBILE_NO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EMAIL_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROFILE_IMAGE = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IS_ACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATE_BY = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CREATE_DEVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UPDATE_DEVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ROWVERSION = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_US_USER", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "US_USER");
        }
    }
}
