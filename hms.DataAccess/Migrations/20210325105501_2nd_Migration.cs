using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hms.DataAccess.Migrations
{
    public partial class _2nd_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BLOOD_GROUP_ID",
                table: "US_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GENDER_ID",
                table: "US_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MARITAIL_STATUS_ID",
                table: "US_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RELIGION_ID",
                table: "US_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TYPE_ID",
                table: "US_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "US_CHILD_MENU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MODULE_ID = table.Column<int>(type: "int", nullable: false),
                    CHILD_ID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_US_CHILD_MENU", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_GENDER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GENDER_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    table.PrimaryKey("PK_US_GENDER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_MARITAIL_STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MARITAIL_STATUS_NAME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
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
                    table.PrimaryKey("PK_US_MARITAIL_STATUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_MODULE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MODULE_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MODULE_BN_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ICON_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIEW_ORDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTROLLER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    METHOD_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_US_MODULE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_RELIGION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RELIGION_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    table.PrimaryKey("PK_US_RELIGION", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "US_CHILD_MENU");

            migrationBuilder.DropTable(
                name: "US_GENDER");

            migrationBuilder.DropTable(
                name: "US_MARITAIL_STATUS");

            migrationBuilder.DropTable(
                name: "US_MODULE");

            migrationBuilder.DropTable(
                name: "US_RELIGION");

            migrationBuilder.DropColumn(
                name: "BLOOD_GROUP_ID",
                table: "US_USER");

            migrationBuilder.DropColumn(
                name: "GENDER_ID",
                table: "US_USER");

            migrationBuilder.DropColumn(
                name: "MARITAIL_STATUS_ID",
                table: "US_USER");

            migrationBuilder.DropColumn(
                name: "RELIGION_ID",
                table: "US_USER");

            migrationBuilder.DropColumn(
                name: "TYPE_ID",
                table: "US_USER");
        }
    }
}
