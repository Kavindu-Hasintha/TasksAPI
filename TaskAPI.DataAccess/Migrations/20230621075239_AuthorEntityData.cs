using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    public partial class AuthorEntityData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nimal Ehan" },
                    { 2, "Kamal Gamage" },
                    { 3, "AB Dev" },
                    { 4, "Root Jo" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2023, 6, 21, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7302), new DateTime(2023, 6, 26, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 4, new DateTime(2023, 6, 21, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7315), "Test Description 2", new DateTime(2023, 6, 24, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7316), 2, "Test2 - DB" },
                    { 3, 3, new DateTime(2023, 6, 21, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7317), "Test Description 3", new DateTime(2023, 6, 29, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7317), 1, "Test3 - DB" },
                    { 4, 2, new DateTime(2023, 6, 21, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7318), "Test Description 4", new DateTime(2023, 7, 6, 13, 22, 39, 704, DateTimeKind.Local).AddTicks(7318), 0, "Test4 - DB" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 20, 12, 52, 10, 893, DateTimeKind.Local).AddTicks(623), new DateTime(2023, 6, 25, 12, 52, 10, 893, DateTimeKind.Local).AddTicks(631) });
        }
    }
}
