﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    partial class TodoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nimal Ehan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kamal Gamage"
                        },
                        new
                        {
                            Id = 3,
                            Name = "AB Dev"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Root Jo"
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2023, 6, 21, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7302),
                            Description = "Test Description 1",
                            Due = new DateTime(2023, 6, 26, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7311),
                            Status = 0,
                            Title = "Test1 - DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 4,
                            Created = new DateTime(2023, 6, 21, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7315),
                            Description = "Test Description 2",
                            Due = new DateTime(2023, 6, 24, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7316),
                            Status = 2,
                            Title = "Test2 - DB"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Created = new DateTime(2023, 6, 21, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7317),
                            Description = "Test Description 3",
                            Due = new DateTime(2023, 6, 29, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7317),
                            Status = 1,
                            Title = "Test3 - DB"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Created = new DateTime(2023, 6, 21, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7318),
                            Description = "Test Description 4",
                            Due = new DateTime(2023, 7, 6, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7318),
                            Status = 0,
                            Title = "Test4 - DB"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
