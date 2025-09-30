using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOsEditionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "os_edition",
                columns: table => new
                {
                    os_edition_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    os_edition_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    os_edition_description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_os_edition", x => x.os_edition_id);
                });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 754, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 51,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 52,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 53,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 54,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 55,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 56,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 57,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 58,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 59,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 60,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 61,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 62,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 63,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 64,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 65,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 66,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 67,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 68,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 69,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 70,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 71,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 72,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 73,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 74,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 75,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 76,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 77,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 78,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 79,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 80,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 81,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 82,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 83,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 84,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 85,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 86,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 87,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 88,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 89,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 90,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 91,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 92,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 93,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 94,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 95,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 96,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 97,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 98,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 99,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 100,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 101,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 102,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 103,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 104,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 105,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 106,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 107,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 108,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 109,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 110,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 111,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 112,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 113,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 114,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 115,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 116,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 117,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 118,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 119,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 120,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 121,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 122,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 123,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 124,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 125,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 126,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 127,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 128,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 129,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 130,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 131,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 132,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 133,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 134,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 135,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 136,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 137,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 138,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 139,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 140,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 141,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 142,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 143,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 144,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 145,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 146,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 147,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 148,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 149,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 150,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 151,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 152,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 153,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 154,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 155,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 156,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 157,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 158,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 159,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 160,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 161,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 162,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 163,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 164,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 165,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 166,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 167,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 168,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 169,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 170,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 171,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 172,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 173,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 174,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 175,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 176,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 177,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 178,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 179,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 180,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 755, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "os_edition",
                columns: new[] { "os_edition_id", "created_at", "created_by", "modified_at", "modified_by", "os_edition_description", "os_edition_name", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Consumer-focused edition with basic features for personal and household use", "Home", 1 },
                    { 2, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Business-oriented edition with advanced features for professionals and small businesses", "Professional", 1 },
                    { 3, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Full-featured edition designed for large organizations with advanced management and security capabilities", "Enterprise", 1 },
                    { 4, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Premium edition with all available features and capabilities; highest tier consumer offering", "Ultimate", 1 },
                    { 5, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Entry-level edition with limited features for budget-conscious users or emerging markets", "Starter", 1 },
                    { 6, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Mid-tier edition balancing features and cost for general business use", "Standard", 1 },
                    { 7, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "High-end server edition optimized for large-scale virtualization and cloud infrastructure", "Datacenter", 1 },
                    { 8, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "High-performance edition optimized for content creation technical computing and advanced workloads", "Workstation", 1 },
                    { 9, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Special edition for academic institutions students and educators with educational licensing", "Education", 1 },
                    { 10, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "General server edition for hosting services applications and network infrastructure", "Server", 1 },
                    { 11, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Standard desktop edition for workstation and personal computer use", "Desktop", 1 },
                    { 12, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Minimal installation edition without GUI for reduced resource usage and attack surface", "Core", 1 },
                    { 13, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Free community-supported edition typically for non-commercial use", "Community", 1 },
                    { 14, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Edition with development tools and features for software developers and programmers", "Developer", 1 },
                    { 15, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Long Term Support edition with extended support lifecycle and stability focus", "LTS", 1 },
                    { 16, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Internet of Things edition optimized for embedded devices and edge computing", "IoT", 1 },
                    { 17, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Specialized edition for embedded systems industrial automation and dedicated appliances", "Embedded", 1 },
                    { 18, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Edition designed for smartphones tablets and mobile computing devices", "Mobile", 1 },
                    { 19, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Minimal server installation without graphical interface for improved security and performance", "Server Core", 1 },
                    { 20, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Server edition optimized specifically for web hosting and internet-facing applications", "Web", 1 },
                    { 21, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Specialized edition optimized for file servers and storage area networks", "Storage", 1 },
                    { 22, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "High Performance Computing edition for scientific computing and computational clusters", "HPC", 1 },
                    { 23, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Enhanced professional edition with support for high-end hardware and advanced computing", "Pro for Workstations", 1 },
                    { 24, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Edition tailored for small business environments with simplified management features", "Small Business", 1 },
                    { 25, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Enhanced consumer edition with additional features beyond standard offering", "Premium", 1 },
                    { 26, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Simplified edition with core functionality for basic computing needs", "Basic", 1 },
                    { 27, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Time-limited trial edition for testing and evaluation purposes before purchase", "Evaluation", 1 },
                    { 28, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Original Equipment Manufacturer edition pre-installed on hardware by manufacturers", "OEM", 1 },
                    { 29, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Full retail edition sold through commercial channels with transferable licensing", "Retail", 1 },
                    { 30, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Edition for organizations purchasing multiple licenses with centralized management", "Volume License", 1 },
                    { 31, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Edition optimized for cloud deployment and multi-tenant environments", "Cloud", 1 },
                    { 32, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Server edition focused on virtualization and hypervisor functionality", "Hyper-V", 1 },
                    { 33, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Small business server edition with user/device limitations and simplified management", "Essentials", 1 },
                    { 34, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Entry-level server edition with hardware limitations for small businesses", "Foundation", 1 },
                    { 35, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Edition compiled for ARM processor architecture for mobile and embedded devices", "ARM", 1 },
                    { 36, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Stripped-down installation with only essential components for specialized deployments", "Minimal", 1 },
                    { 37, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Bootable edition that runs from external media without installation for testing or recovery", "Live", 1 },
                    { 38, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Specialized edition for system recovery troubleshooting and data rescue operations", "Rescue", 1 },
                    { 39, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Lightweight edition optimized for thin client devices and virtual desktop infrastructure", "Thin Client", 1 },
                    { 40, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Optimized edition for containerized applications and microservices architectures", "Container", 1 },
                    { 41, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Special licensing edition for educational institutions with volume discounts", "Academic", 1 },
                    { 42, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Not For Resale edition provided to partners vendors or for demonstration purposes", "NFR", 1 },
                    { 43, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Pre-release edition for testing new features before general availability", "Beta", 1 },
                    { 44, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Early access edition showcasing upcoming features for feedback and evaluation", "Preview", 1 },
                    { 45, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Continuous update edition for early adopters testing cutting-edge features", "Insider", 1 },
                    { 46, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Production-ready edition with thoroughly tested features and long-term stability", "Stable", 1 },
                    { 47, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Edition containing features undergoing validation before stable release", "Testing", 1 },
                    { 48, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Bleeding-edge edition with latest untested features for developers and testers", "Unstable", 1 },
                    { 49, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Continuously updated edition without distinct version releases", "Rolling Release", 1 },
                    { 50, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Edition receiving extended security updates beyond standard support lifecycle", "Extended Security", 1 }
                });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(8441), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(8443), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(8446), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(8448), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 756, DateTimeKind.Unspecified).AddTicks(8451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 10, 42, 757, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "UX_os_edition_name",
                table: "os_edition",
                column: "os_edition_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "os_edition");

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 403, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 51,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 52,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 53,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 54,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 55,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 56,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 57,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 58,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 59,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 60,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 61,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 62,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 63,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 64,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 65,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 66,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 67,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 68,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 69,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 70,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 71,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 72,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 73,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 74,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 75,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 76,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 77,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 78,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 79,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 80,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 81,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 82,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 83,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 84,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 85,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 86,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 87,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 88,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 89,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 90,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 91,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 92,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 93,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 94,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 95,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 96,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 97,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 98,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 99,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 100,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 101,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 102,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 103,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 104,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 105,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 106,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 107,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 108,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 109,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 110,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 111,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 112,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 113,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 114,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 115,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 116,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 117,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 118,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 119,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 120,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 121,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 122,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 123,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 124,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 125,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 126,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 127,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 128,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 129,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 130,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 131,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 132,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 133,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 134,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 135,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 136,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 137,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 138,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 139,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 140,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 141,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 142,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 143,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 144,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 145,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 146,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 147,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 148,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 149,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 150,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 151,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 152,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 153,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 154,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 155,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 156,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 157,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 158,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 159,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 160,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 161,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 162,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 163,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 164,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 165,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 166,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 167,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 168,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 169,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 170,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 171,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 172,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 173,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 174,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 175,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 176,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 177,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 178,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 179,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 180,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 404, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(7435), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(7437), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(7439), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(7441), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(7442), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(7443), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 406, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
