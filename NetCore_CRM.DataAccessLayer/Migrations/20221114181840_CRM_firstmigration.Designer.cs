﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCore_CRM.DataAccessLayer.Concrete;

namespace NetCore_CRM.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221114181840_CRM_firstmigration")]
    partial class CRM_firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCore_CRM.EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDecription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NetCore_CRM.EntityLayer.Concrete.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("NetCore_CRM.EntityLayer.Concrete.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmployeeStatus")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("NetCore_CRM.EntityLayer.Concrete.EmployeeTask", b =>
                {
                    b.Property<int>("EmployeeTaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeTaskID");

                    b.ToTable("EmployeeTasks");
                });

            modelBuilder.Entity("NetCore_CRM.EntityLayer.Concrete.EmployeeTaskDetail", b =>
                {
                    b.Property<int>("EmployeeTaskDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeTaskID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeTaskDetailID");

                    b.HasIndex("EmployeeTaskID");

                    b.ToTable("EmployeeTaskDetails");
                });

            modelBuilder.Entity("NetCore_CRM.EntityLayer.Concrete.Employee", b =>
                {
                    b.HasOne("NetCore_CRM.EntityLayer.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NetCore_CRM.EntityLayer.Concrete.EmployeeTaskDetail", b =>
                {
                    b.HasOne("NetCore_CRM.EntityLayer.Concrete.EmployeeTask", "EmployeeTask")
                        .WithMany()
                        .HasForeignKey("EmployeeTaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeTask");
                });
#pragma warning restore 612, 618
        }
    }
}