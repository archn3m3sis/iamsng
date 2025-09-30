using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOsVendorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "os_vendor",
                columns: table => new
                {
                    os_vendor_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    os_vendor_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the operating system vendor or maintainer"),
                    os_vendor_description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Description of vendor's primary operating systems and focus areas"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_os_vendor", x => x.os_vendor_id);
                },
                comment: "Operating system vendors and maintainers for software asset categorization");

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 51,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 52,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 53,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 54,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 55,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 56,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 57,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 58,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 59,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 60,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 61,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 62,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 63,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 64,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 65,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 66,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 67,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 68,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 69,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 70,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 71,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 72,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 73,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 74,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 75,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 76,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 77,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 78,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 79,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 80,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 81,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 82,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 83,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 84,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 85,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 86,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 87,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 88,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 89,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 90,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 91,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 92,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 93,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 94,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 95,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 96,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 97,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 98,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 99,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 100,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 101,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 102,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 103,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 104,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 105,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 106,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 107,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 108,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 109,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 110,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 111,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 112,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 113,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 114,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 115,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 116,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 117,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 118,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 119,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 120,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 121,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 122,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 123,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 124,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 125,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 126,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 127,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 128,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 129,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 130,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 131,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 132,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 133,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 134,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 135,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 136,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 137,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 138,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 139,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 140,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 141,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 142,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 143,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 144,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 145,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 146,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 147,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 148,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 149,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 150,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 151,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 152,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 153,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 154,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 155,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 156,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 157,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 158,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 159,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 160,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 161,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 162,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 163,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 164,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 165,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 166,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 167,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 168,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 169,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 170,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 171,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 172,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 173,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 174,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 175,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 176,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 177,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 178,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 179,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 180,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(8393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "os_vendor",
                columns: new[] { "os_vendor_id", "created_at", "created_by", "modified_at", "modified_by", "os_vendor_description", "os_vendor_name", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops Windows operating systems for desktops servers and enterprise environments", "Microsoft", 1 },
                    { 2, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops macOS iOS iPadOS watchOS and tvOS for consumer and enterprise devices", "Apple", 1 },
                    { 3, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops Android mobile OS and Chrome OS for Chromebooks and cloud-based computing", "Google", 1 },
                    { 4, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Commercial sponsor of Ubuntu Linux distribution and provider of enterprise support services", "Canonical", 1 },
                    { 5, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Enterprise Linux vendor providing RHEL and related open-source solutions; owned by IBM", "Red Hat", 1 },
                    { 6, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "European enterprise Linux vendor providing SUSE Linux Enterprise Server and Desktop", "SUSE", 1 },
                    { 7, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops Oracle Linux Oracle Solaris and enterprise database systems", "Oracle", 1 },
                    { 8, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops AIX for Power Systems and z/OS for mainframe systems", "IBM", 1 },
                    { 9, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops HP-UX Unix operating system for Integrity and PA-RISC servers", "Hewlett Packard Enterprise", 1 },
                    { 10, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-driven organization maintaining Debian GNU/Linux distribution", "Debian Project", 1 },
                    { 11, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-driven Linux distribution sponsored by Red Hat", "Fedora Project", 1 },
                    { 12, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Non-profit organization supporting Linux kernel development and related open-source projects", "Linux Foundation", 1 },
                    { 13, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Non-profit supporting FreeBSD Unix-like operating system development", "FreeBSD Foundation", 1 },
                    { 14, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops OpenBSD focused on security and code correctness", "OpenBSD Project", 1 },
                    { 15, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops NetBSD emphasizing portability across hardware platforms", "NetBSD Foundation", 1 },
                    { 16, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-maintained rolling-release Linux distribution", "Arch Linux", 1 },
                    { 17, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Maintains Gentoo Linux source-based distribution", "Gentoo Foundation", 1 },
                    { 18, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "One of oldest Linux distributions maintained by Patrick Volkerding", "Slackware Linux", 1 },
                    { 19, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Offensive Security maintains Kali Linux for penetration testing and security auditing", "Kali Linux", 1 },
                    { 20, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community Enterprise OS based on RHEL sources; now CentOS Stream maintained by Red Hat", "CentOS Project", 1 },
                    { 21, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community enterprise Linux distribution created as CentOS replacement", "Rocky Linux", 1 },
                    { 22, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-owned enterprise Linux distribution forked from RHEL", "AlmaLinux", 1 },
                    { 23, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops ESXi hypervisor and related virtualization operating systems; owned by Broadcom", "VMware", 1 },
                    { 24, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops XenServer hypervisor and virtualization platforms", "Citrix", 1 },
                    { 25, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops Amazon Linux optimized for AWS cloud infrastructure", "Amazon Web Services", 1 },
                    { 26, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops HarmonyOS for mobile devices and IoT ecosystems", "Huawei", 1 },
                    { 27, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops Tizen OS for smart TVs wearables and IoT devices", "Samsung", 1 },
                    { 28, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops VxWorks real-time operating system for embedded systems; owned by Aptiv", "Wind River", 1 },
                    { 29, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops QNX real-time operating system for automotive and embedded systems; owned by BlackBerry", "QNX Software Systems", 1 },
                    { 30, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops Junos OS for networking equipment and routers", "Juniper Networks", 1 },
                    { 31, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops IOS and IOS-XE operating systems for networking infrastructure", "Cisco Systems", 1 },
                    { 32, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops EOS network operating system for data center switches", "Arista Networks", 1 },
                    { 33, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops RouterOS for networking equipment and routers", "MikroTik", 1 },
                    { 34, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops UniFi OS and EdgeOS for networking and IoT devices", "Ubiquiti", 1 },
                    { 35, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops Proxmox VE virtualization platform based on Debian", "Proxmox Server Solutions", 1 },
                    { 36, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "iXsystems develops TrueNAS storage operating system based on FreeBSD", "TrueNAS", 1 },
                    { 37, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Netgate develops pfSense firewall and router operating system based on FreeBSD", "pfSense", 1 },
                    { 38, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-developed Linux-based OS for embedded devices and routers", "OpenWrt Project", 1 },
                    { 39, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops DiskStation Manager (DSM) for NAS devices", "Synology", 1 },
                    { 40, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), 1, "Develops QTS and QuTS operating systems for NAS and storage devices", "QNAP", 1 }
                });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(617), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(620), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(622), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(624), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 182, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_os_vendor_name",
                table: "os_vendor",
                column: "os_vendor_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "os_vendor");

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 51,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 52,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 53,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 54,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 55,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 56,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 57,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 58,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 59,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 60,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 61,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 62,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 63,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 64,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 65,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 66,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 67,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 68,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 69,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 70,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 71,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 72,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 73,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 74,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 75,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 76,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 77,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 78,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 79,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 80,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 81,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 82,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 83,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 84,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 85,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 86,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 87,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 88,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 89,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 90,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 91,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 92,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 93,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 94,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 95,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 96,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 97,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 98,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 99,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 100,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 101,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 102,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 103,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 104,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 105,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 106,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 107,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 108,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 109,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 110,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 111,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 112,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 113,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 114,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 115,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 116,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 117,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 118,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 119,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 120,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 121,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 122,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 123,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 124,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 125,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 126,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 127,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 128,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 129,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 130,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 131,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 132,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 133,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 134,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 135,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 136,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 137,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 138,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 139,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 140,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 141,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 142,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 143,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 144,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 145,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 146,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 147,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 148,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 149,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 150,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 151,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 152,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 153,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 154,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 155,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 156,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 157,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 158,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 159,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 160,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 161,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 162,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 163,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 164,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 165,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 166,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 167,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 168,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 169,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 170,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 171,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 172,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 173,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 174,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 175,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 176,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 177,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 178,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 179,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 180,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 371, DateTimeKind.Unspecified).AddTicks(8994), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 372, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 373, DateTimeKind.Unspecified).AddTicks(3651), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 373, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 373, DateTimeKind.Unspecified).AddTicks(3654), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 373, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 373, DateTimeKind.Unspecified).AddTicks(3656), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 373, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 373, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 373, DateTimeKind.Unspecified).AddTicks(3659), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 19, 44, 26, 374, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
