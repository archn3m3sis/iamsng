using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMotherboardTypeTableAndManufacturers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "motherboard_type",
                columns: table => new
                {
                    mobo_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mobo_type_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    hardware_manufacturer_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motherboard_type", x => x.mobo_type_id);
                    table.ForeignKey(
                        name: "FK_motherboard_type_hardware_manufacturer_hardware_manufacturer_id",
                        column: x => x.hardware_manufacturer_id,
                        principalTable: "hardware_manufacturer",
                        principalColumn: "hardware_manufacturer_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 51,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 52,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 53,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 54,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 55,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 56,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 57,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 58,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 59,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 60,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 61,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 62,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 63,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 64,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 65,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 66,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 67,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 68,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 69,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 70,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 71,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 72,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 73,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 74,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 75,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 76,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 77,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 78,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 79,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 80,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 81,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 82,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 83,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 84,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 85,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 86,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 87,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 88,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 89,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 90,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 91,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 92,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 93,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 94,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 95,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 96,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 97,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 98,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 99,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 100,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 101,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 102,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 103,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 104,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 105,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 106,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 107,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 108,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 109,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 110,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 111,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 112,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 113,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 114,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 115,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 116,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 117,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 118,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 119,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 120,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 121,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 122,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 123,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 124,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 125,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 126,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 127,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 128,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 129,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 130,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 131,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 132,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 133,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 134,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 135,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 136,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 137,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 138,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 139,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 140,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 141,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 142,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 143,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 144,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 145,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 146,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 147,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 148,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 149,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 150,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 151,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 152,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 153,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 154,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 155,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 156,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 157,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 158,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 159,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 160,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 161,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 162,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 163,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 164,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 165,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 166,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 167,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 168,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 169,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 170,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 171,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 172,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 173,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 174,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 175,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 176,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 177,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 178,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 179,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 180,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 899, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "hardware_manufacturer",
                columns: new[] { "hardware_manufacturer_id", "created_at", "created_by", "hardware_manufacturer_name", "hwmanu_icon_file", "modified_at", "modified_by", "hwmanu_production_focus", "version" },
                values: new object[,]
                {
                    { 173, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "ASRock", null, null, null, "Computing Hardware", 1 },
                    { 174, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Tyan", null, null, null, "Computing Hardware", 1 },
                    { 175, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Biostar", null, null, null, "Computing Hardware", 1 },
                    { 176, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "ECS", null, null, null, "Computing Hardware", 1 }
                });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "motherboard_type",
                columns: new[] { "mobo_type_id", "created_at", "created_by", "hardware_manufacturer_id", "mobo_type_name", "modified_at", "modified_by", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "Z790 Chipset ATX", null, null, 1 },
                    { 2, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "Z690 Chipset ATX", null, null, 1 },
                    { 3, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "B760 Chipset ATX", null, null, 1 },
                    { 4, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "B660 Chipset Micro-ATX", null, null, 1 },
                    { 5, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "H770 Chipset ATX", null, null, 1 },
                    { 6, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "H610 Chipset Micro-ATX", null, null, 1 },
                    { 7, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "X670E Chipset ATX", null, null, 1 },
                    { 8, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "X670 Chipset ATX", null, null, 1 },
                    { 9, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "B650E Chipset ATX", null, null, 1 },
                    { 10, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "B650 Chipset Micro-ATX", null, null, 1 },
                    { 11, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "A620 Chipset Micro-ATX", null, null, 1 },
                    { 12, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "TRX50 Chipset E-ATX", null, null, 1 },
                    { 13, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "WRX90 Chipset E-ATX", null, null, 1 },
                    { 14, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "W680 Chipset ATX", null, null, 1 },
                    { 15, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "C621 Chipset ATX", null, null, 1 },
                    { 16, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "C246 Chipset Micro-ATX", null, null, 1 },
                    { 17, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI Z790 Chipset ATX", null, null, 1 },
                    { 18, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI Z690 Chipset ATX", null, null, 1 },
                    { 19, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI B760 Chipset ATX", null, null, 1 },
                    { 20, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI B660 Chipset Micro-ATX", null, null, 1 },
                    { 21, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI H770 Chipset ATX", null, null, 1 },
                    { 22, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI X670E Chipset ATX", null, null, 1 },
                    { 23, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI X670 Chipset ATX", null, null, 1 },
                    { 24, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI B650E Chipset ATX", null, null, 1 },
                    { 25, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI B650 Chipset Micro-ATX", null, null, 1 },
                    { 26, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI A620 Chipset Micro-ATX", null, null, 1 },
                    { 27, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI TRX50 Chipset E-ATX", null, null, 1 },
                    { 28, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI WRX90 Chipset E-ATX", null, null, 1 },
                    { 29, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI C621 Chipset ATX", null, null, 1 },
                    { 30, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte Z790 Chipset ATX", null, null, 1 },
                    { 31, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte Z690 Chipset ATX", null, null, 1 },
                    { 32, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte B760 Chipset ATX", null, null, 1 },
                    { 33, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte B660 Chipset Micro-ATX", null, null, 1 },
                    { 34, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte H770 Chipset ATX", null, null, 1 },
                    { 35, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte X670E Chipset ATX", null, null, 1 },
                    { 36, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte X670 Chipset ATX", null, null, 1 },
                    { 37, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte B650E Chipset ATX", null, null, 1 },
                    { 38, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte B650 Chipset Micro-ATX", null, null, 1 },
                    { 39, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte A620 Chipset Micro-ATX", null, null, 1 },
                    { 40, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte TRX50 Chipset E-ATX", null, null, 1 },
                    { 41, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte WRX90 Chipset E-ATX", null, null, 1 },
                    { 54, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "X11 Series LGA3647 ATX", null, null, 1 },
                    { 55, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "X12 Series LGA4189 ATX", null, null, 1 },
                    { 56, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "X13 Series LGA4677 ATX", null, null, 1 },
                    { 57, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "H11 Series SP3 ATX", null, null, 1 },
                    { 58, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "H12 Series SP3 ATX", null, null, 1 },
                    { 59, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "H13 Series SP5 ATX", null, null, 1 },
                    { 60, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "A2 Series ATX", null, null, 1 },
                    { 61, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "M11 Series Micro-ATX", null, null, 1 },
                    { 62, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "M12 Series Micro-ATX", null, null, 1 },
                    { 63, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "X11DPi-N Dual Socket", null, null, 1 },
                    { 64, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "X12DPi-N6 Dual Socket", null, null, 1 },
                    { 65, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "H11DSi Dual Socket EPYC", null, null, 1 },
                    { 66, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "H12DSi Dual Socket EPYC", null, null, 1 },
                    { 67, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "PowerEdge R740 System Board", null, null, 1 },
                    { 68, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "PowerEdge R750 System Board", null, null, 1 },
                    { 69, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "PowerEdge R760 System Board", null, null, 1 },
                    { 70, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "PowerEdge R640 System Board", null, null, 1 },
                    { 71, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "PowerEdge R650 System Board", null, null, 1 },
                    { 72, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "PowerEdge T550 System Board", null, null, 1 },
                    { 73, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "Precision 7920 Workstation Board", null, null, 1 },
                    { 74, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "Precision 7960 Workstation Board", null, null, 1 },
                    { 75, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "OptiPlex 7010 System Board", null, null, 1 },
                    { 76, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "OptiPlex 7090 System Board", null, null, 1 },
                    { 77, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 1, "Latitude 5430 System Board", null, null, 1 },
                    { 78, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "ProLiant DL380 Gen10 System Board", null, null, 1 },
                    { 79, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "ProLiant DL380 Gen10 Plus System Board", null, null, 1 },
                    { 80, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "ProLiant DL360 Gen10 System Board", null, null, 1 },
                    { 81, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "ProLiant DL360 Gen10 Plus System Board", null, null, 1 },
                    { 82, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "ProLiant ML350 Gen10 System Board", null, null, 1 },
                    { 83, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "ProLiant DL580 Gen10 System Board", null, null, 1 },
                    { 84, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "Z8 G4 Workstation Board", null, null, 1 },
                    { 85, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "Z6 G5 Workstation Board", null, null, 1 },
                    { 86, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 2, "EliteDesk 800 G9 System Board", null, null, 1 },
                    { 87, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 4, "ThinkSystem SR650 System Board", null, null, 1 },
                    { 88, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 4, "ThinkSystem SR850 System Board", null, null, 1 },
                    { 89, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 4, "ThinkSystem SR950 System Board", null, null, 1 },
                    { 90, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 4, "ThinkSystem ST650 System Board", null, null, 1 },
                    { 91, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 4, "ThinkStation P620 System Board", null, null, 1 },
                    { 92, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 4, "ThinkStation P920 System Board", null, null, 1 },
                    { 93, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 4, "ThinkStation P360 System Board", null, null, 1 },
                    { 94, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 4, "ThinkCentre M90a System Board", null, null, 1 },
                    { 95, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "Z590 Chipset ATX", null, null, 1 },
                    { 96, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "Z490 Chipset ATX", null, null, 1 },
                    { 97, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "X570 Chipset ATX", null, null, 1 },
                    { 98, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "X470 Chipset ATX", null, null, 1 },
                    { 99, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "B550 Chipset ATX", null, null, 1 },
                    { 100, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "B450 Chipset Micro-ATX", null, null, 1 },
                    { 101, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI Z590 Chipset ATX", null, null, 1 },
                    { 102, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI Z490 Chipset ATX", null, null, 1 },
                    { 103, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI X570 Chipset ATX", null, null, 1 },
                    { 104, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI X470 Chipset ATX", null, null, 1 },
                    { 105, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI B550 Chipset ATX", null, null, 1 },
                    { 106, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI B450 Chipset Micro-ATX", null, null, 1 },
                    { 107, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte Z590 Chipset ATX", null, null, 1 },
                    { 108, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte Z490 Chipset ATX", null, null, 1 },
                    { 109, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte X570 Chipset ATX", null, null, 1 },
                    { 110, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte B550 Chipset ATX", null, null, 1 },
                    { 115, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "Mini-ITX Z790", null, null, 1 },
                    { 116, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "Mini-ITX Z690", null, null, 1 },
                    { 117, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "Mini-ITX B650", null, null, 1 },
                    { 118, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "Mini-ITX X670", null, null, 1 },
                    { 119, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI Mini-ITX Z790", null, null, 1 },
                    { 120, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI Mini-ITX B650", null, null, 1 },
                    { 121, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte Mini-ITX Z790", null, null, 1 },
                    { 122, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte Mini-ITX B650", null, null, 1 },
                    { 125, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "E-ATX Z790", null, null, 1 },
                    { 126, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "E-ATX X670E", null, null, 1 },
                    { 127, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI E-ATX Z790", null, null, 1 },
                    { 128, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI E-ATX X670E", null, null, 1 },
                    { 129, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte E-ATX Z790", null, null, 1 },
                    { 130, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte E-ATX X670E", null, null, 1 },
                    { 131, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "C621E Chipset SSI-EEB", null, null, 1 },
                    { 132, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "C627 Chipset E-ATX", null, null, 1 },
                    { 133, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 6, "C621A Chipset ATX", null, null, 1 },
                    { 134, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "X299 Chipset ATX", null, null, 1 },
                    { 135, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI X299 Chipset ATX", null, null, 1 },
                    { 136, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte X299 Chipset ATX", null, null, 1 },
                    { 137, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "X399 Chipset ATX", null, null, 1 },
                    { 138, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI X399 Chipset E-ATX", null, null, 1 },
                    { 139, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "TRX40 Chipset E-ATX", null, null, 1 },
                    { 140, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 11, "MSI TRX40 Chipset E-ATX", null, null, 1 },
                    { 141, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 12, "Gigabyte TRX40 Chipset E-ATX", null, null, 1 },
                    { 143, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 10, "WRX80 Chipset E-ATX", null, null, 1 },
                    { 145, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 50, "Intel S2600 Series", null, null, 1 },
                    { 146, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 50, "Intel S1200 Series", null, null, 1 },
                    { 147, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 50, "Intel C236 Chipset", null, null, 1 },
                    { 148, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 51, "AMD EPYC Rome Platform", null, null, 1 },
                    { 149, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 51, "AMD EPYC Milan Platform", null, null, 1 },
                    { 154, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 7, "Fujitsu Primergy Board", null, null, 1 },
                    { 155, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 16, "Cisco UCS C-Series Board", null, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 900, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(4146), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(4147), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(4149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(4151), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(4153), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 901, DateTimeKind.Unspecified).AddTicks(4154), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 23, 25, 20, 902, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "motherboard_type",
                columns: new[] { "mobo_type_id", "created_at", "created_by", "hardware_manufacturer_id", "mobo_type_name", "modified_at", "modified_by", "version" },
                values: new object[,]
                {
                    { 42, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock Z790 Chipset ATX", null, null, 1 },
                    { 43, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock Z690 Chipset ATX", null, null, 1 },
                    { 44, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock B760 Chipset ATX", null, null, 1 },
                    { 45, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock B660 Chipset Micro-ATX", null, null, 1 },
                    { 46, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock H770 Chipset ATX", null, null, 1 },
                    { 47, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock X670E Chipset ATX", null, null, 1 },
                    { 48, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock X670 Chipset ATX", null, null, 1 },
                    { 49, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock B650E Chipset ATX", null, null, 1 },
                    { 50, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock B650 Chipset Micro-ATX", null, null, 1 },
                    { 51, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock A620 Chipset Micro-ATX", null, null, 1 },
                    { 52, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock TRX50 Chipset E-ATX", null, null, 1 },
                    { 53, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock WRX90 Chipset E-ATX", null, null, 1 },
                    { 111, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock Z590 Chipset ATX", null, null, 1 },
                    { 112, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock Z490 Chipset ATX", null, null, 1 },
                    { 113, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock X570 Chipset ATX", null, null, 1 },
                    { 114, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock B550 Chipset ATX", null, null, 1 },
                    { 123, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock Mini-ITX Z790", null, null, 1 },
                    { 124, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock Mini-ITX B650", null, null, 1 },
                    { 142, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock TRX40 Chipset E-ATX", null, null, 1 },
                    { 144, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 173, "ASRock WRX80 Chipset E-ATX", null, null, 1 },
                    { 150, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 174, "Tyan S8030 Series", null, null, 1 },
                    { 151, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 174, "Tyan Thunder Series", null, null, 1 },
                    { 152, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 175, "Biostar Racing Series", null, null, 1 },
                    { 153, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 176, "ECS Server Board", null, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_motherboard_type_hardware_manufacturer_id",
                table: "motherboard_type",
                column: "hardware_manufacturer_id");

            migrationBuilder.CreateIndex(
                name: "UX_motherboard_type_name",
                table: "motherboard_type",
                column: "mobo_type_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "motherboard_type");

            migrationBuilder.DeleteData(
                table: "hardware_manufacturer",
                keyColumn: "hardware_manufacturer_id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "hardware_manufacturer",
                keyColumn: "hardware_manufacturer_id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "hardware_manufacturer",
                keyColumn: "hardware_manufacturer_id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "hardware_manufacturer",
                keyColumn: "hardware_manufacturer_id",
                keyValue: 176);

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 51,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 52,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 53,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 54,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 55,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 56,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 57,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 58,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 59,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 60,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 61,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 62,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 63,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 64,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 65,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 66,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 67,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 68,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 69,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 70,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 71,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 72,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 73,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 74,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 75,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 76,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 77,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 78,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 79,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 80,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 81,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 82,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 83,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 84,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 85,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 86,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 87,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 88,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 89,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 90,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 91,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 92,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 93,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 94,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 95,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 96,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 97,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 98,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 99,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 100,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 101,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 102,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 103,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 104,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 105,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 106,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 107,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 108,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 109,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 110,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 111,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 112,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 113,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 114,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 115,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 116,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 117,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 118,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 119,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 120,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 121,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 122,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 123,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 124,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 125,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 126,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 127,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 128,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 129,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 130,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 131,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 132,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 133,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 134,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 135,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 136,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 137,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 138,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 139,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 140,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 141,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 142,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 143,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 144,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 145,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 146,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 147,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 148,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 149,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 150,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 151,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 152,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 153,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 154,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 155,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 156,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 157,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 158,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 159,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 160,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 161,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 162,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 163,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 164,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 165,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 166,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 167,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 168,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 169,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 170,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 171,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 172,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 173,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 174,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 175,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 176,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 177,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 178,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 179,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "cpu_type",
                keyColumn: "cpu_type_id",
                keyValue: 180,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 662, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "gpu_types",
                keyColumn: "gpu_type_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 41,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 42,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 43,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 44,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 45,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 46,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 47,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 48,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 49,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_platform",
                keyColumn: "os_platform_id",
                keyValue: 50,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 34,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 35,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 36,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 37,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 38,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 39,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "os_vendor",
                keyColumn: "os_vendor_id",
                keyValue: 40,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 663, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(4012), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(4014), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(4015), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(4017), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 664, DateTimeKind.Unspecified).AddTicks(4058), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "sys_architecture",
                keyColumn: "sys_architecture_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 22, 49, 44, 665, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
