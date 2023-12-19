﻿// <auto-generated />
using System;
using FlexibleAutomationTool.DL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlexibleAutomationTool.DL.Migrations
{
    [DbContext(typeof(FlexibleAutomationToolContext))]
    [Migration("20231219193042_addContextFix")]
    partial class addContextFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateExecution")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Executed")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("History");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Key", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ScriptId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ScriptId");

                    b.ToTable("Key");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Mouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ScriptId")
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScriptId");

                    b.ToTable("Mouse");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ConditionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConditionMessanger")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RuleHistoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RuleHistoryId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("UserId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Script", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Scripts");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TelegramId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Key", b =>
                {
                    b.HasOne("FlexibleAutomationTool.DL.Models.Script", null)
                        .WithMany("Keys")
                        .HasForeignKey("ScriptId");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Mouse", b =>
                {
                    b.HasOne("FlexibleAutomationTool.DL.Models.Script", null)
                        .WithMany("Mouses")
                        .HasForeignKey("ScriptId");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Rule", b =>
                {
                    b.HasOne("FlexibleAutomationTool.DL.Models.History", "RuleHistory")
                        .WithMany()
                        .HasForeignKey("RuleHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlexibleAutomationTool.DL.Models.Schedule", null)
                        .WithMany("Rules")
                        .HasForeignKey("ScheduleId");

                    b.HasOne("FlexibleAutomationTool.DL.Models.User", null)
                        .WithMany("UserRules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RuleHistory");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Script", b =>
                {
                    b.HasOne("FlexibleAutomationTool.DL.Models.Schedule", null)
                        .WithMany("Scripts")
                        .HasForeignKey("ScheduleId");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Schedule", b =>
                {
                    b.Navigation("Rules");

                    b.Navigation("Scripts");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.Script", b =>
                {
                    b.Navigation("Keys");

                    b.Navigation("Mouses");
                });

            modelBuilder.Entity("FlexibleAutomationTool.DL.Models.User", b =>
                {
                    b.Navigation("UserRules");
                });
#pragma warning restore 612, 618
        }
    }
}
