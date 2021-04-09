using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hms.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HB_BILL_MASTER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BILL_NO = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BILL_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BRANCH_ID = table.Column<int>(type: "int", nullable: false),
                    PATIENT_ID = table.Column<long>(type: "bigint", nullable: false),
                    PAYMENT_METHOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOTAL_AMOUNT = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BILL_NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IS_PAID = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HB_BILL_MASTER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HP_CHECKUP",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRESCRIPTION_NUMBER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "HP_SHOW_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "HS_DEPARTMENT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPARTMENT_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_HS_DEPARTMENT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_DOCTOR_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOCTOR_TYPE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_HS_DOCTOR_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_EMPLOYEE_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPLOYEE_TYPE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_HS_EMPLOYEE_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_HOSPITAL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HOSPITAL_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HOSPITAL_ADDRESS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    HOSPITAL_MOBILE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    HOSPITAL_PHONE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    HOSPITAL_HOTLINE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    HOSPITAL_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HOSPITAL_BIN_NO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    HOSPITAL_IMAGE = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
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
                name: "HS_PARTNERSHIP",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARTNERSHIP_NAME = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTACT_PERSON_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTACT_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACCOUNT_NUMBER = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ACCOUNT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BANK_BRANCH_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HS_PARTNERSHIP", x => x.ID);
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
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "US_PAYMENT_METHOD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    PAYMENT_METHOD_NAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    table.PrimaryKey("PK_US_PAYMENT_METHOD", x => x.ID);
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
                name: "US_UNIT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    UNIT_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    table.PrimaryKey("PK_US_UNIT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HS_BRANCH",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HOSPITAL_ID = table.Column<int>(type: "int", nullable: false),
                    BRANCH_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BRANCH_NAME_BANGLA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BRANCH_ADDRESS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BRANCH_ADDRESS_BANGLA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BRANCH_MOBILE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BRANCH_PHONE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BRANCH_HOTLINE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BRANCH_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BRANCH_BIN_NO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BRANCH_IMAGE = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
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
                    table.PrimaryKey("PK_HS_BRANCH", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HS_BRANCH_HS_HOSPITAL_HOSPITAL_ID",
                        column: x => x.HOSPITAL_ID,
                        principalTable: "HS_HOSPITAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    MODULE_ID = table.Column<int>(type: "int", nullable: false),
                    PARENT_MENU_ID = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_US_CHILD_MENU_US_MODULE_MODULE_ID",
                        column: x => x.MODULE_ID,
                        principalTable: "US_MODULE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_CHILD_MENU_US_PARENT_MENU_PARENT_MENU_ID",
                        column: x => x.PARENT_MENU_ID,
                        principalTable: "US_PARENT_MENU",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HS_DOCTOR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    HOSPITAL_ID = table.Column<int>(type: "int", nullable: false),
                    DOCTOR_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOCTOR_NAME_BANGLA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DOCTOR_DEGREE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DOCTOR_DEGREE_BANGLA = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DOCTOR_SPECIALITY = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DOCTOR_SPECIALITY_BANGLA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DOCTOR_OTHERS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DOCTOR_OTHERS_BANGLA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DOCTOR_REG_NO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DOCTOR_REG_NO_BANGLA = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    US_GENDER_ID = table.Column<int>(type: "int", nullable: false),
                    US_BLOOD_GROUP_ID = table.Column<int>(type: "int", nullable: false),
                    HS_DOCTOR_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    US_RELIGION_ID = table.Column<int>(type: "int", nullable: false),
                    US_MARITAIL_STATUS_ID = table.Column<int>(type: "int", nullable: false),
                    DOCTOR_NATIONAL_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    table.ForeignKey(
                        name: "FK_HS_DOCTOR_HS_DOCTOR_TYPE_HS_DOCTOR_TYPE_ID",
                        column: x => x.HS_DOCTOR_TYPE_ID,
                        principalTable: "HS_DOCTOR_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_DOCTOR_HS_HOSPITAL_HOSPITAL_ID",
                        column: x => x.HOSPITAL_ID,
                        principalTable: "HS_HOSPITAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_DOCTOR_US_BLOOD_GROUP_US_BLOOD_GROUP_ID",
                        column: x => x.US_BLOOD_GROUP_ID,
                        principalTable: "US_BLOOD_GROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_DOCTOR_US_GENDER_US_GENDER_ID",
                        column: x => x.US_GENDER_ID,
                        principalTable: "US_GENDER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_DOCTOR_US_MARITAIL_STATUS_US_MARITAIL_STATUS_ID",
                        column: x => x.US_MARITAIL_STATUS_ID,
                        principalTable: "US_MARITAIL_STATUS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_DOCTOR_US_RELIGION_US_RELIGION_ID",
                        column: x => x.US_RELIGION_ID,
                        principalTable: "US_RELIGION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HS_EMPLOYEE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    HOSPITAL_ID = table.Column<int>(type: "int", nullable: false),
                    EMPLOYEE_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PRESENT_ADDRESS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PERMANENT_ADDRESS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EMPLOYEE_DEGREE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EMPLOYEE_SPECIALITY = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EMPLOYEE_REG_NO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GENDER_ID = table.Column<int>(type: "int", nullable: false),
                    MARITAIL_STATUS_ID = table.Column<int>(type: "int", nullable: false),
                    BLOOD_GROUP_ID = table.Column<int>(type: "int", nullable: false),
                    EMPLOYEE_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    RELIGION_ID = table.Column<int>(type: "int", nullable: false),
                    EMPLOYEE_NATIONAL_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    table.PrimaryKey("PK_HS_EMPLOYEE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HS_EMPLOYEE_HS_EMPLOYEE_TYPE_EMPLOYEE_TYPE_ID",
                        column: x => x.EMPLOYEE_TYPE_ID,
                        principalTable: "HS_EMPLOYEE_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_EMPLOYEE_HS_HOSPITAL_HOSPITAL_ID",
                        column: x => x.HOSPITAL_ID,
                        principalTable: "HS_HOSPITAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_EMPLOYEE_US_BLOOD_GROUP_BLOOD_GROUP_ID",
                        column: x => x.BLOOD_GROUP_ID,
                        principalTable: "US_BLOOD_GROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_EMPLOYEE_US_GENDER_GENDER_ID",
                        column: x => x.GENDER_ID,
                        principalTable: "US_GENDER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_EMPLOYEE_US_MARITAIL_STATUS_MARITAIL_STATUS_ID",
                        column: x => x.MARITAIL_STATUS_ID,
                        principalTable: "US_MARITAIL_STATUS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_EMPLOYEE_US_RELIGION_RELIGION_ID",
                        column: x => x.RELIGION_ID,
                        principalTable: "US_RELIGION",
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
                    GENDER_ID = table.Column<int>(type: "int", nullable: false),
                    RELIGION_ID = table.Column<int>(type: "int", nullable: false),
                    BLOOD_GROUP_ID = table.Column<int>(type: "int", nullable: false),
                    MARITAIL_STATUS_ID = table.Column<int>(type: "int", nullable: false),
                    TYPE_ID = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_US_USER_US_BLOOD_GROUP_BLOOD_GROUP_ID",
                        column: x => x.BLOOD_GROUP_ID,
                        principalTable: "US_BLOOD_GROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_US_GENDER_GENDER_ID",
                        column: x => x.GENDER_ID,
                        principalTable: "US_GENDER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_US_MARITAIL_STATUS_MARITAIL_STATUS_ID",
                        column: x => x.MARITAIL_STATUS_ID,
                        principalTable: "US_MARITAIL_STATUS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_US_RELIGION_RELIGION_ID",
                        column: x => x.RELIGION_ID,
                        principalTable: "US_RELIGION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_US_TYPE_TYPE_ID",
                        column: x => x.TYPE_ID,
                        principalTable: "US_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HS_ITEM",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    ITEM_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UNIT_ID = table.Column<int>(type: "int", nullable: false),
                    DP_RATE = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    MRP_RATE = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
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
                    table.ForeignKey(
                        name: "FK_HS_ITEM_US_UNIT_UNIT_ID",
                        column: x => x.UNIT_ID,
                        principalTable: "US_UNIT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HS_DEPARTMENT_ASSIGN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BRANCH_ID = table.Column<int>(type: "int", nullable: false),
                    DEPARTMENT_ID = table.Column<int>(type: "int", nullable: false),
                    REMARKS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                    table.PrimaryKey("PK_HS_DEPARTMENT_ASSIGN", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HS_DEPARTMENT_ASSIGN_HS_BRANCH_BRANCH_ID",
                        column: x => x.BRANCH_ID,
                        principalTable: "HS_BRANCH",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HS_DEPARTMENT_ASSIGN_HS_DEPARTMENT_DEPARTMENT_ID",
                        column: x => x.DEPARTMENT_ID,
                        principalTable: "HS_DEPARTMENT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "US_ROLE_MENU",
                columns: table => new
                {
                    ROLE_ID = table.Column<int>(type: "int", nullable: false),
                    CHILD_MENU_ID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_US_ROLE_MENU_ID", x => new { x.ROLE_ID, x.CHILD_MENU_ID });
                    table.ForeignKey(
                        name: "FK_US_ROLE_MENU_US_CHILD_MENU_CHILD_MENU_ID",
                        column: x => x.CHILD_MENU_ID,
                        principalTable: "US_CHILD_MENU",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_ROLE_MENU_US_ROLE_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "US_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HP_TOKEN",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERIAL_NO = table.Column<int>(type: "int", nullable: false),
                    TOKEN_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOCTOR_ID = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_HP_TOKEN_HS_DOCTOR_DOCTOR_ID",
                        column: x => x.DOCTOR_ID,
                        principalTable: "HS_DOCTOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "US_USER_ROLE",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    ROLE_ID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_US_USER_ROLE_ID", x => new { x.USER_ID, x.ROLE_ID });
                    table.ForeignKey(
                        name: "FK_US_USER_ROLE_US_ROLE_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "US_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_US_USER_ROLE_US_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "US_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HP_INVESTIGATION",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRESCRIPTION_NUMBER = table.Column<long>(type: "bigint", nullable: false),
                    ITEM_ID = table.Column<long>(type: "bigint", nullable: false),
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
                        name: "FK_HP_INVESTIGATION_HS_ITEM_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "HS_ITEM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HP_MEDICINE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRESCRIPTION_NUMBER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ITEM_ID = table.Column<long>(type: "bigint", nullable: false),
                    ITEM_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOSAGE_DURATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_HP_MEDICINE_HS_ITEM_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "HS_ITEM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HP_PRESCRIPTION",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRESCRIPTION_NUMBER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PRESCRIPTION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HOSPITAL_ID = table.Column<int>(type: "int", nullable: false),
                    DOCTOR_ID = table.Column<int>(type: "int", nullable: false),
                    PATIENT_ID = table.Column<long>(type: "bigint", nullable: false),
                    SHOW_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    TOKEN_ID = table.Column<long>(type: "bigint", nullable: false),
                    REFER_FOR_ADMIT = table.Column<int>(type: "int", nullable: false),
                    PREVIOUS_PRESCRIPTION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
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
                    table.PrimaryKey("PK_HP_PRESCRIPTION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HP_PRESCRIPTION_HP_SHOW_TYPE_SHOW_TYPE_ID",
                        column: x => x.SHOW_TYPE_ID,
                        principalTable: "HP_SHOW_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HP_PRESCRIPTION_HP_TOKEN_TOKEN_ID",
                        column: x => x.TOKEN_ID,
                        principalTable: "HP_TOKEN",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HP_PRESCRIPTION_HS_DOCTOR_DOCTOR_ID",
                        column: x => x.DOCTOR_ID,
                        principalTable: "HS_DOCTOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HP_PRESCRIPTION_HS_HOSPITAL_HOSPITAL_ID",
                        column: x => x.HOSPITAL_ID,
                        principalTable: "HS_HOSPITAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HP_PRESCRIPTION_HS_PATIENT_PATIENT_ID",
                        column: x => x.PATIENT_ID,
                        principalTable: "HS_PATIENT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BILL_MASTER_NCI",
                table: "HB_BILL_MASTER",
                columns: new[] { "BILL_NO", "BILL_DATE" });

            migrationBuilder.CreateIndex(
                name: "IX_HP_INVESTIGATION_ITEM_ID",
                table: "HP_INVESTIGATION",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HP_MEDICINE_ITEM_ID",
                table: "HP_MEDICINE",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HP_PRESCRIPTION_DOCTOR_ID",
                table: "HP_PRESCRIPTION",
                column: "DOCTOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HP_PRESCRIPTION_HOSPITAL_ID",
                table: "HP_PRESCRIPTION",
                column: "HOSPITAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HP_PRESCRIPTION_PATIENT_ID",
                table: "HP_PRESCRIPTION",
                column: "PATIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HP_PRESCRIPTION_SHOW_TYPE_ID",
                table: "HP_PRESCRIPTION",
                column: "SHOW_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HP_PRESCRIPTION_TOKEN_ID",
                table: "HP_PRESCRIPTION",
                column: "TOKEN_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRESCRIPTION_NCI",
                table: "HP_PRESCRIPTION",
                columns: new[] { "PRESCRIPTION_NUMBER", "PRESCRIPTION_DATE" });

            migrationBuilder.CreateIndex(
                name: "IX_HP_TOKEN_DOCTOR_ID",
                table: "HP_TOKEN",
                column: "DOCTOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_BRANCH_HOSPITAL_ID",
                table: "HS_BRANCH",
                column: "HOSPITAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_DEPARTMENT_ASSIGN_BRANCH_ID",
                table: "HS_DEPARTMENT_ASSIGN",
                column: "BRANCH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_DEPARTMENT_ASSIGN_DEPARTMENT_ID",
                table: "HS_DEPARTMENT_ASSIGN",
                column: "DEPARTMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_DOCTOR_HOSPITAL_ID",
                table: "HS_DOCTOR",
                column: "HOSPITAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_DOCTOR_HS_DOCTOR_TYPE_ID",
                table: "HS_DOCTOR",
                column: "HS_DOCTOR_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_DOCTOR_US_BLOOD_GROUP_ID",
                table: "HS_DOCTOR",
                column: "US_BLOOD_GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_DOCTOR_US_GENDER_ID",
                table: "HS_DOCTOR",
                column: "US_GENDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_DOCTOR_US_MARITAIL_STATUS_ID",
                table: "HS_DOCTOR",
                column: "US_MARITAIL_STATUS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_DOCTOR_US_RELIGION_ID",
                table: "HS_DOCTOR",
                column: "US_RELIGION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_NCI",
                table: "HS_EMPLOYEE",
                columns: new[] { "EMPLOYEE_NAME", "EMPLOYEE_REG_NO" });

            migrationBuilder.CreateIndex(
                name: "IX_HS_EMPLOYEE_BLOOD_GROUP_ID",
                table: "HS_EMPLOYEE",
                column: "BLOOD_GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_EMPLOYEE_EMPLOYEE_TYPE_ID",
                table: "HS_EMPLOYEE",
                column: "EMPLOYEE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_EMPLOYEE_GENDER_ID",
                table: "HS_EMPLOYEE",
                column: "GENDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_EMPLOYEE_HOSPITAL_ID",
                table: "HS_EMPLOYEE",
                column: "HOSPITAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_EMPLOYEE_MARITAIL_STATUS_ID",
                table: "HS_EMPLOYEE",
                column: "MARITAIL_STATUS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_EMPLOYEE_RELIGION_ID",
                table: "HS_EMPLOYEE",
                column: "RELIGION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HS_ITEM_UNIT_ID",
                table: "HS_ITEM",
                column: "UNIT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_NCI",
                table: "HS_ITEM",
                column: "ITEM_NAME");

            migrationBuilder.CreateIndex(
                name: "IX_PARTNERSHIP_NCI",
                table: "HS_PARTNERSHIP",
                columns: new[] { "PARTNERSHIP_NAME", "ACCOUNT_NUMBER" });

            migrationBuilder.CreateIndex(
                name: "IX_PATIENT_NCI",
                table: "HS_PATIENT",
                columns: new[] { "PATIENT_NAME", "DATE_OF_BIRTH" });

            migrationBuilder.CreateIndex(
                name: "IX_TESTS_NCI",
                table: "HS_TESTS",
                column: "TESTS_NAME");

            migrationBuilder.CreateIndex(
                name: "IX_US_CHILD_MENU_MODULE_ID",
                table: "US_CHILD_MENU",
                column: "MODULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_CHILD_MENU_PARENT_MENU_ID",
                table: "US_CHILD_MENU",
                column: "PARENT_MENU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PAYMENT_METHOD_NCI",
                table: "US_PAYMENT_METHOD",
                column: "PAYMENT_METHOD_NAME");

            migrationBuilder.CreateIndex(
                name: "IX_US_ROLE_MENU_CHILD_MENU_ID",
                table: "US_ROLE_MENU",
                column: "CHILD_MENU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_BLOOD_GROUP_ID",
                table: "US_USER",
                column: "BLOOD_GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_GENDER_ID",
                table: "US_USER",
                column: "GENDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_MARITAIL_STATUS_ID",
                table: "US_USER",
                column: "MARITAIL_STATUS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_RELIGION_ID",
                table: "US_USER",
                column: "RELIGION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_TYPE_ID",
                table: "US_USER",
                column: "TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_US_USER_ROLE_ROLE_ID",
                table: "US_USER_ROLE",
                column: "ROLE_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HB_BILL_MASTER");

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
                name: "HP_SUGGESSION");

            migrationBuilder.DropTable(
                name: "HS_DEPARTMENT_ASSIGN");

            migrationBuilder.DropTable(
                name: "HS_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "HS_PARTNERSHIP");

            migrationBuilder.DropTable(
                name: "HS_TESTS");

            migrationBuilder.DropTable(
                name: "US_PAYMENT_METHOD");

            migrationBuilder.DropTable(
                name: "US_ROLE_MENU");

            migrationBuilder.DropTable(
                name: "US_USER_ROLE");

            migrationBuilder.DropTable(
                name: "HS_ITEM");

            migrationBuilder.DropTable(
                name: "HP_SHOW_TYPE");

            migrationBuilder.DropTable(
                name: "HP_TOKEN");

            migrationBuilder.DropTable(
                name: "HS_PATIENT");

            migrationBuilder.DropTable(
                name: "HS_BRANCH");

            migrationBuilder.DropTable(
                name: "HS_DEPARTMENT");

            migrationBuilder.DropTable(
                name: "HS_EMPLOYEE_TYPE");

            migrationBuilder.DropTable(
                name: "US_CHILD_MENU");

            migrationBuilder.DropTable(
                name: "US_ROLE");

            migrationBuilder.DropTable(
                name: "US_USER");

            migrationBuilder.DropTable(
                name: "US_UNIT");

            migrationBuilder.DropTable(
                name: "HS_DOCTOR");

            migrationBuilder.DropTable(
                name: "US_MODULE");

            migrationBuilder.DropTable(
                name: "US_PARENT_MENU");

            migrationBuilder.DropTable(
                name: "US_TYPE");

            migrationBuilder.DropTable(
                name: "HS_DOCTOR_TYPE");

            migrationBuilder.DropTable(
                name: "HS_HOSPITAL");

            migrationBuilder.DropTable(
                name: "US_BLOOD_GROUP");

            migrationBuilder.DropTable(
                name: "US_GENDER");

            migrationBuilder.DropTable(
                name: "US_MARITAIL_STATUS");

            migrationBuilder.DropTable(
                name: "US_RELIGION");
        }
    }
}
