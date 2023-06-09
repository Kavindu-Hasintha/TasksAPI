﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20230625031325_JobRoleAdd")]
    partial class JobRoleAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "52",
                            City = "Colombo 1",
                            JobRole = "Developer",
                            Name = "Nimal Ehan",
                            Street = "Street 1"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "42",
                            City = "Colombo 5",
                            JobRole = "System Engineer",
                            Name = "Kamal Gamage",
                            Street = "Street 3"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "66",
                            City = "Colombo 3",
                            JobRole = "Developer",
                            Name = "AB Dev",
                            Street = "Street 2"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "34",
                            City = "Colombo 2",
                            JobRole = "QA",
                            Name = "Root Jo",
                            Street = "Street 5"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2023, 6, 25, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3642),
                            Description = "Test Description 1",
                            Due = new DateTime(2023, 6, 30, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3651),
                            Status = 0,
                            Title = "Test1 - DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 4,
                            Created = new DateTime(2023, 6, 25, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3655),
                            Description = "Test Description 2",
                            Due = new DateTime(2023, 6, 28, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3655),
                            Status = 2,
                            Title = "Test2 - DB"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Created = new DateTime(2023, 6, 25, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3656),
                            Description = "Test Description 3",
                            Due = new DateTime(2023, 7, 3, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3657),
                            Status = 1,
                            Title = "Test3 - DB"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Created = new DateTime(2023, 6, 25, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3658),
                            Description = "Test Description 4",
                            Due = new DateTime(2023, 7, 10, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3658),
                            Status = 0,
                            Title = "Test4 - DB"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
