﻿// <auto-generated />
using System;
using Adnc.Infr.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adnc.Maint.Migrations.Migrations
{
    [DbContext(typeof(AdncDbContext))]
    [Migration("20210208053358_2021020801")]
    partial class _2021020801
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysCfg", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<string>("Value")
                        .HasColumnName("Value")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("SysCfg");
                });

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysDict", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(16) CHARACTER SET utf8mb4")
                        .HasMaxLength(16);

                    b.Property<int>("Ordinal")
                        .HasColumnType("int");

                    b.Property<long>("Pid")
                        .HasColumnType("bigint");

                    b.Property<string>("Tips")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("SysDict");
                });

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysNotice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnName("Content")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<int?>("Type")
                        .HasColumnName("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SysNotice");
                });
#pragma warning restore 612, 618
        }
    }
}
