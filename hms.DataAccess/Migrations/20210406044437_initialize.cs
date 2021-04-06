using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hms.DataAccess.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HP_CHECKUP",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRESCRIPTION_NUMBER = table.Column<long>(type: "bigint", nullable: false),
                    PATIENT_AGE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PATIENT_SEX = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PATIENT_CONTACT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BODY_TEMPERATURE = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    BP_UP = table.Column<int>(type: "int", nullable: false),
                    BP_DOWN = table.Column<int>(type: "int", nullable: false),
                    WEIGHT = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    HEIGHT = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
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
                    table.PrimaryKey("PK_HP_CHECKUP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HP_DURATION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    DURATION_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    table.PrimaryKey("PK_HP_DURATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HP_FREQUENCY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FREQUENCY_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    table.PrimaryKey("PK_HP_FREQUENCY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HP_MEDICINE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRESCRIPTION_NUMBER = table.Column<long>(type: "bigint", nullable: false),
                    ITEM_ID = table.Column<long>(type: "bigint", nullable: false),
                    ITEM_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOSAGE_DURATION = table.Column<int>(type: "int", nullable: false),
                    DOSAGE_FREQUENCY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUGGESTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_HP_MEDICINE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HP_PRESCRIPTION",
                columns: table => new
                {
                    PRESCRIPTION_NUMBER = table.Column<long>(type: "bigint", nullable: false),
                    PRESCRIPTION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HOSPITAL_ID = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    DOCTOR_ID = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    PATIENT_ID = table.Column<long>(type: "bigint", nullable: false),
                    SHOW_TYPE_ID = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    TOKEN_ID = table.Column<long>(type: "bigint", nullable: false),
                    REFER_FOR_ADMIT = table.Column<int>(type: "int", nullable: false),
                    PREVIOUS_PRESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_HP_PRESCRIPTION", x => x.PRESCRIPTION_NUMBER);
                });

            migrationBuilder.CreateTable(
                name: "HP_SHOW_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    SHOW_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    table.PrimaryKey("PK_HP_SHOW_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HP_SUGGESSION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    SUGGESTION_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_HP_SUGGESSION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_DOCTOR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    DOCTOR_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_HS_DOCTOR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_HOSPITAL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    HOSPITAL_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_HS_HOSPITAL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_ITEM",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    ITEM_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_HS_ITEM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_PATIENT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    PATIENT_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_HS_PATIENT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_TESTS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    TESTS_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_HS_TESTS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_BLOOD_GROUP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    BLOOD_GROUP_NAME = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
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
                    table.PrimaryKey("PK_US_BLOOD_GROUP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_GENDER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    GENDER_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    table.PrimaryKey("PK_US_GENDER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_MARITAIL_STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    MARITAIL_STATUS_NAME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
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
                    table.PrimaryKey("PK_US_MARITAIL_STATUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_MODULE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    MODULE_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MODULE_BN_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MODULE_ICON = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VIEW_ORDER = table.Column<int>(type: "int", nullable: false),
                    CONTROLLER_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    METHOD_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
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
                    table.PrimaryKey("PK_US_MODULE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_PARENT_MENU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    PARENT_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PARENT_BN_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PARENT_ICON = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    table.PrimaryKey("PK_US_PARENT_MENU", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_RELIGION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    RELIGION_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    table.PrimaryKey("PK_US_RELIGION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_ROLE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ROLE_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    table.PrimaryKey("PK_US_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "US_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    TYPE_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    table.PrimaryKey("PK_US_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HP_TOKEN",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERIAL_NO = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    TOKEN_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOCTOR_ID = table.Column<int>(type: "int", nullable: false),
                    HS_DOCTOR_ID = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_HP_TOKEN", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HP_TOKEN_HS_DOCTOR_HS_DOCTOR_ID",
                        column: x => x.HS_DOCTOR_ID,
                        principalTable: "HS_DOCTOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HP_INVESTIGATION",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRESCRIPTION_NUMBER = table.Column<long>(type: "bigint", nullable: false),
                    ITEM_ID = table.Column<long>(type: "bigint", nullable: false),
                    HS_ITEM_ID = table.Column<long>(type: "bigint", nullable: true),
                    ITEM_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SUGGESTION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_HP_INVESTIGATION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HP_INVESTIGATION_HS_ITEM_HS_ITEM_ID",
                        column: x => x.HS_ITEM_ID,
                        principalTable: "HS_ITEM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "US_CHILD_MENU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CHILD_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CHILD_BN_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CHILD_ICON = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AREA_NAME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CONTROLLER_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ACTION_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    US_MODULE_ID = table.Column<int>(type: "int", nullable: false),
                    US_PARENT_MENU_ID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_US_CHILD_MENU", x => x.ID);
                    table.ForeignKey(
                        name: "FK_US_CHILD_MENU_US_MODULE_US_MODULE_ID",
                        column: x => x.US_MODULE_ID,
                        principalTable: "US_MODULE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_CHILD_MENU_US_PARENT_MENU_US_PARENT_MENU_ID",
                        column: x => x.US_PARENT_MENU_ID,
                        principalTable: "US_PARENT_MENU",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "US_USER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    LOGIN_ID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    USER_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MOBILE_NO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EMAIL_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROFILE_IMAGE = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    US_GENDER_ID = table.Column<int>(type: "int", nullable: false),
                    US_RELIGION_ID = table.Column<int>(type: "int", nullable: false),
                    US_BLOOD_GROUP_ID = table.Column<int>(type: "int", nullable: false),
                    US_MARITAIL_STATUS_ID = table.Column<int>(type: "int", nullable: false),
                    US_TYPE_ID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_US_USER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_US_USER_US_BLOOD_GROUP_US_BLOOD_GROUP_ID",
                        column: x => x.US_BLOOD_GROUP_ID,
                        principalTable: "US_BLOOD_GROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_US_GENDER_US_GENDER_ID",
                        column: x => x.US_GENDER_ID,
                        principalTable: "US_GENDER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_US_MARITAIL_STATUS_US_MARITAIL_STATUS_ID",
                        column: x => x.US_MARITAIL_STATUS_ID,
                        principalTable: "US_MARITAIL_STATUS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_US_RELIGION_US_RELIGION_ID",
                        column: x => x.US_RELIGION_ID,
                        principalTable: "US_RELIGION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_US_TYPE_US_TYPE_ID",
                        column: x => x.US_TYPE_ID,
                        principalTable: "US_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "US_USER_ROLE",
                columns: table => new
                {
                    US_USER_ID = table.Column<int>(type: "int", nullable: false),
                    US_ROLE_ID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_US_USER_ROLE_ID", x => new { x.US_USER_ID, x.US_ROLE_ID });
                    table.ForeignKey(
                        name: "FK_US_USER_ROLE_US_ROLE_US_ROLE_ID",
                        column: x => x.US_ROLE_ID,
                        principalTable: "US_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_ROLE_US_USER_US_USER_ID",
                        column: x => x.US_USER_ID,
                        principalTable: "US_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HP_INVESTIGATION_HS_ITEM_ID",
                table: "HP_INVESTIGATION",
                column: "HS_ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HP_TOKEN_HS_DOCTOR_ID",
                table: "HP_TOKEN",
                column: "HS_DOCTOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_CHILD_MENU_US_MODULE_ID",
                table: "US_CHILD_MENU",
                column: "US_MODULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_CHILD_MENU_US_PARENT_MENU_ID",
                table: "US_CHILD_MENU",
                column: "US_PARENT_MENU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_ROLE_MENU_US_CHILD_MENU_ID",
                table: "US_ROLE_MENU",
                column: "US_CHILD_MENU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_US_BLOOD_GROUP_ID",
                table: "US_USER",
                column: "US_BLOOD_GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_US_GENDER_ID",
                table: "US_USER",
                column: "US_GENDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_US_MARITAIL_STATUS_ID",
                table: "US_USER",
                column: "US_MARITAIL_STATUS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_US_RELIGION_ID",
                table: "US_USER",
                column: "US_RELIGION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_US_TYPE_ID",
                table: "US_USER",
                column: "US_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_ROLE_US_ROLE_ID",
                table: "US_USER_ROLE",
                column: "US_ROLE_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HP_CHECKUP");

            migrationBuilder.DropTable(
                name: "HP_DURATION");

            migrationBuilder.DropTable(
                name: "HP_FREQUENCY");

            migrationBuilder.DropTable(
                name: "HP_INVESTIGATION");

            migrationBuilder.DropTable(
                name: "HP_MEDICINE");

            migrationBuilder.DropTable(
                name: "HP_PRESCRIPTION");

            migrationBuilder.DropTable(
                name: "HP_SHOW_TYPE");

            migrationBuilder.DropTable(
                name: "HP_SUGGESSION");

            migrationBuilder.DropTable(
                name: "HP_TOKEN");

            migrationBuilder.DropTable(
                name: "HS_HOSPITAL");

            migrationBuilder.DropTable(
                name: "HS_PATIENT");

            migrationBuilder.DropTable(
                name: "HS_TESTS");

            migrationBuilder.DropTable(
                name: "US_ROLE_MENU");

            migrationBuilder.DropTable(
                name: "US_USER_ROLE");

            migrationBuilder.DropTable(
                name: "HS_ITEM");

            migrationBuilder.DropTable(
                name: "HS_DOCTOR");

            migrationBuilder.DropTable(
                name: "US_CHILD_MENU");

            migrationBuilder.DropTable(
                name: "US_ROLE");

            migrationBuilder.DropTable(
                name: "US_USER");

            migrationBuilder.DropTable(
                name: "US_MODULE");

            migrationBuilder.DropTable(
                name: "US_PARENT_MENU");

            migrationBuilder.DropTable(
                name: "US_BLOOD_GROUP");

            migrationBuilder.DropTable(
                name: "US_GENDER");

            migrationBuilder.DropTable(
                name: "US_MARITAIL_STATUS");

            migrationBuilder.DropTable(
                name: "US_RELIGION");

            migrationBuilder.DropTable(
                name: "US_TYPE");
        }
    }
}
