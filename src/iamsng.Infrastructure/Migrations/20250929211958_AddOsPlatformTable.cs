using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOsPlatformTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "os_platform",
                columns: table => new
                {
                    os_platform_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    os_platform_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the operating system platform or family"),
                    os_platform_description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Description of the platform and its primary use cases"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_os_platform", x => x.os_platform_id);
                },
                comment: "Operating system platforms and families for software categorization");

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

            migrationBuilder.InsertData(
                table: "os_platform",
                columns: new[] { "os_platform_id", "created_at", "created_by", "modified_at", "modified_by", "os_platform_description", "os_platform_name", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Microsoft's desktop and server operating system platform for personal computers and enterprise environments", "Windows", 1 },
                    { 2, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Apple's Unix-based operating system platform for Macintosh desktop and laptop computers", "macOS", 1 },
                    { 3, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Open-source Unix-like operating system kernel with various distributions for servers desktops and embedded systems", "Linux", 1 },
                    { 4, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Family of multitasking multiuser operating systems derived from original AT&T Unix", "Unix", 1 },
                    { 5, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Google's Linux-based mobile operating system platform for smartphones tablets and embedded devices", "Android", 1 },
                    { 6, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Apple's mobile operating system platform for iPhone devices", "iOS", 1 },
                    { 7, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Apple's tablet operating system platform derived from iOS specifically for iPad devices", "iPadOS", 1 },
                    { 8, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Google's Linux-based operating system platform for Chromebook laptops and cloud-centric computing", "Chrome OS", 1 },
                    { 9, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Unix-like operating system platform derived from Berkeley Software Distribution focused on performance", "FreeBSD", 1 },
                    { 10, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Unix-like operating system platform emphasizing security code correctness and cryptography", "OpenBSD", 1 },
                    { 11, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Unix-like operating system platform emphasizing portability across diverse hardware architectures", "NetBSD", 1 },
                    { 12, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Oracle's Unix operating system platform for enterprise servers and workstations", "Solaris", 1 },
                    { 13, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "IBM's Unix operating system platform for Power Systems and enterprise servers", "AIX", 1 },
                    { 14, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Hewlett Packard Enterprise's Unix operating system platform for Integrity and PA-RISC servers", "HP-UX", 1 },
                    { 15, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "IBM's mainframe operating system platform for System z and zSeries mainframe computers", "z/OS", 1 },
                    { 16, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Apple's operating system platform for Apple Watch wearable devices", "watchOS", 1 },
                    { 17, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Apple's operating system platform for Apple TV set-top boxes and streaming devices", "tvOS", 1 },
                    { 18, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Huawei's distributed operating system platform for mobile devices IoT and smart devices", "HarmonyOS", 1 },
                    { 19, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Linux-based operating system platform for smart TVs wearables and IoT devices developed by Samsung and partners", "Tizen", 1 },
                    { 20, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Wind River's real-time operating system platform for embedded systems and mission-critical applications", "VxWorks", 1 },
                    { 21, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "BlackBerry's Unix-like real-time operating system platform for automotive and embedded systems", "QNX", 1 },
                    { 22, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Juniper Networks' FreeBSD-based operating system platform for networking equipment", "Junos", 1 },
                    { 23, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Cisco's internetwork operating system platform for networking routers and switches", "Cisco IOS", 1 },
                    { 24, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "VMware's bare-metal hypervisor platform for server virtualization and cloud infrastructure", "ESXi", 1 },
                    { 25, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Open-source virtualization platform based on Debian Linux for running VMs and containers", "Proxmox VE", 1 },
                    { 26, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Citrix's hypervisor platform for server virtualization and cloud computing", "XenServer", 1 },
                    { 27, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "MikroTik's operating system platform for routers switches and wireless systems", "RouterOS", 1 },
                    { 28, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Open-source firewall and router operating system platform based on FreeBSD", "pfSense", 1 },
                    { 29, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Linux-based operating system platform for embedded devices and consumer routers", "OpenWrt", 1 },
                    { 30, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Open-source storage operating system platform based on FreeBSD for network-attached storage", "TrueNAS", 1 },
                    { 31, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Synology's DiskStation Manager operating system platform for NAS devices", "DSM", 1 },
                    { 32, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "QNAP's operating system platform for NAS and storage devices", "QTS", 1 },
                    { 33, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Microsoft's server operating system platform for enterprise datacenter and cloud environments", "Windows Server", 1 },
                    { 34, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Enterprise-grade Linux platform for servers cloud and containerized applications", "Red Hat Enterprise Linux", 1 },
                    { 35, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Debian-based Linux platform for desktops servers and cloud computing", "Ubuntu", 1 },
                    { 36, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-driven enterprise Linux platform compatible with Red Hat Enterprise Linux", "CentOS", 1 },
                    { 37, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-maintained Linux platform known for stability and free software principles", "Debian", 1 },
                    { 38, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-driven Linux platform featuring cutting-edge open-source technologies", "Fedora", 1 },
                    { 39, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Enterprise Linux platform for mission-critical workloads and SAP applications", "SUSE Linux Enterprise", 1 },
                    { 40, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Enterprise Linux platform optimized for Oracle software and database systems", "Oracle Linux", 1 },
                    { 41, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "AWS-optimized Linux platform designed for cloud computing on Amazon infrastructure", "Amazon Linux", 1 },
                    { 42, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community enterprise Linux platform providing downstream RHEL compatibility", "Rocky Linux", 1 },
                    { 43, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Community-owned enterprise Linux platform offering RHEL binary compatibility", "AlmaLinux", 1 },
                    { 44, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Rolling-release Linux platform emphasizing simplicity and user control", "Arch Linux", 1 },
                    { 45, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Debian-based Linux platform specialized for penetration testing and security auditing", "Kali Linux", 1 },
                    { 46, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Source-based Linux platform offering extreme customization and optimization", "Gentoo", 1 },
                    { 47, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "One of oldest Linux platforms emphasizing simplicity and stability", "Slackware", 1 },
                    { 48, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Microsoft's discontinued disk operating system platform for early personal computers", "MS-DOS", 1 },
                    { 49, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "IBM's discontinued operating system platform originally developed with Microsoft", "OS/2", 1 },
                    { 50, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 21, 19, 58, 405, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 0, 0, 0, 0)), 1, "Discontinued multimedia operating system platform known for performance; spiritual successor is Haiku", "BeOS", 1 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_os_platform_name",
                table: "os_platform",
                column: "os_platform_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "os_platform");

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

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 20, 37, 50, 181, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

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
        }
    }
}
