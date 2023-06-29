using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    public partial class JobRoleAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "System Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 25, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3642), new DateTime(2023, 6, 30, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 25, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3655), new DateTime(2023, 6, 28, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 25, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3656), new DateTime(2023, 7, 3, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 25, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3658), new DateTime(2023, 7, 10, 8, 43, 25, 118, DateTimeKind.Local).AddTicks(3658) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 22, 8, 40, 31, 642, DateTimeKind.Local).AddTicks(7145), new DateTime(2023, 6, 27, 8, 40, 31, 642, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 22, 8, 40, 31, 642, DateTimeKind.Local).AddTicks(7159), new DateTime(2023, 6, 25, 8, 40, 31, 642, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 22, 8, 40, 31, 642, DateTimeKind.Local).AddTicks(7161), new DateTime(2023, 6, 30, 8, 40, 31, 642, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 22, 8, 40, 31, 642, DateTimeKind.Local).AddTicks(7162), new DateTime(2023, 7, 7, 8, 40, 31, 642, DateTimeKind.Local).AddTicks(7163) });
        }
    }
}
