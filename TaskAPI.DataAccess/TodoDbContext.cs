using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Get DbContext
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    // DbContext used for to tell this class is database context
    public class TodoDbContext : DbContext
    {
        // DbSet<Todo> - DbSet - table, Todo - table type
        // Add table to the DB
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        // Connect to the Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=DESKTOP-VRF2530\\MSSQL2022;Initial Catalog=MyTodoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            optionsBuilder.UseSqlServer(connectionString);
            // UseSqlServer option is coming from Microsoft.EntityFrameworkCore.SqlServer

        }

        // Add data to the todo table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] 
            { 
                new Author {Id=1, Name="Nimal Ehan", AddressNo="52", Street="Street 1", City="Colombo 1", JobRole="Developer"},
                new Author {Id=2, Name="Kamal Gamage", AddressNo="42", Street="Street 3", City="Colombo 5", JobRole="System Engineer"},
                new Author {Id=3, Name="AB Dev", AddressNo="66", Street="Street 2", City="Colombo 3", JobRole="Developer"},
                new Author {Id=4, Name="Root Jo", AddressNo="34", Street="Street 5", City="Colombo 2", JobRole="QA"}
            });
            
            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo {
                    Id = 1,
                    Title = "Test1 - DB",
                    Description = "Test Description 1",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo {
                    Id = 2,
                    Title = "Test2 - DB",
                    Description = "Test Description 2",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(3),
                    Status = TodoStatus.Complete,
                    AuthorId = 4
                },
                new Todo {
                    Id = 3,
                    Title = "Test3 - DB",
                    Description = "Test Description 3",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(8),
                    Status = TodoStatus.Inprogress,
                    AuthorId = 3
                },
                new Todo {
                    Id = 4,
                    Title = "Test4 - DB",
                    Description = "Test Description 4",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(15),
                    Status = TodoStatus.New,
                    AuthorId = 2
                }
            });
        }
        // When we do changes to the DB, we must create migration and update the DB
    }
}
