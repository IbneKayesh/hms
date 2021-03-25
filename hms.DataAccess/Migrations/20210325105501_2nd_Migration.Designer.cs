﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hms.DataAccess;

namespace hms.DataAccess.Migrations
{
    [DbContext(typeof(hmsDbContext))]
    [Migration("20210325105501_2nd_Migration")]
    partial class _2nd_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hms.DataModel.US_CHILD_MENU", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CHILD_ID")
                        .HasColumnType("int");

                    b.Property<string>("CREATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CREATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IS_ACTIVE")
                        .HasColumnType("bit");

                    b.Property<int>("MODULE_ID")
                        .HasColumnType("int");

                    b.Property<byte>("ROWVERSION")
                        .HasColumnType("tinyint");

                    b.Property<string>("UPDATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UPDATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("US_CHILD_MENU");
                });

            modelBuilder.Entity("hms.DataModel.US_GENDER", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CREATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GENDER_NAME")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IS_ACTIVE")
                        .HasColumnType("bit");

                    b.Property<byte>("ROWVERSION")
                        .HasColumnType("tinyint");

                    b.Property<string>("UPDATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UPDATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("US_GENDER");
                });

            modelBuilder.Entity("hms.DataModel.US_MARITAIL_STATUS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CREATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IS_ACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("MARITAIL_STATUS_NAME")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<byte>("ROWVERSION")
                        .HasColumnType("tinyint");

                    b.Property<string>("UPDATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UPDATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("US_MARITAIL_STATUS");
                });

            modelBuilder.Entity("hms.DataModel.US_MODULE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CONTROLLER_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CREATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CREATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ICON_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IS_ACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("METHOD_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MODULE_BN_NAME")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MODULE_NAME")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte>("ROWVERSION")
                        .HasColumnType("tinyint");

                    b.Property<string>("UPDATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UPDATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VIEW_ORDER")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("US_MODULE");
                });

            modelBuilder.Entity("hms.DataModel.US_RELIGION", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CREATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IS_ACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("RELIGION_NAME")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte>("ROWVERSION")
                        .HasColumnType("tinyint");

                    b.Property<string>("UPDATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UPDATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("US_RELIGION");
                });

            modelBuilder.Entity("hms.DataModel.US_USER", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BLOOD_GROUP_ID")
                        .HasColumnType("int");

                    b.Property<string>("CREATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CREATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DATE_OF_BIRTH")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMAIL_ID")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GENDER_ID")
                        .HasColumnType("int");

                    b.Property<bool>("IS_ACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("LOGIN_ID")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("MARITAIL_STATUS_ID")
                        .HasColumnType("int");

                    b.Property<string>("MOBILE_NO")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PASSWORD")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PROFILE_IMAGE")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("RELIGION_ID")
                        .HasColumnType("int");

                    b.Property<byte>("ROWVERSION")
                        .HasColumnType("tinyint");

                    b.Property<int>("TYPE_ID")
                        .HasColumnType("int");

                    b.Property<string>("UPDATE_BY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UPDATE_DEVICE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("USER_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("US_USER");
                });
#pragma warning restore 612, 618
        }
    }
}
