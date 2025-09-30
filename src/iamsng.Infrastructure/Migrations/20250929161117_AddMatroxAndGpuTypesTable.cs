using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMatroxAndGpuTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gpu_types",
                columns: table => new
                {
                    gpu_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gpu_type_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name or designation of the GPU model/series"),
                    hardware_manufacturer_id = table.Column<int>(type: "int", nullable: false, comment: "Foreign key to hardware_manufacturer table"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gpu_types", x => x.gpu_type_id);
                    table.ForeignKey(
                        name: "FK_gpu_types_hardware_manufacturer",
                        column: x => x.hardware_manufacturer_id,
                        principalTable: "hardware_manufacturer",
                        principalColumn: "hardware_manufacturer_id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "GPU types and models from various manufacturers");

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 395, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "gpu_types",
                columns: new[] { "gpu_type_id", "created_at", "created_by", "gpu_type_name", "hardware_manufacturer_id", "modified_at", "modified_by", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "GeForce RTX 40 Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 2, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "GeForce RTX 30 Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 3, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "GeForce RTX 20 Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 4, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "GeForce GTX 16 Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 5, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "GeForce GTX 10 Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 6, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "GeForce GTX 900 Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 7, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "GeForce GTX 700 Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 8, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Quadro RTX Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 9, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Quadro P Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 10, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Quadro M Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 11, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Quadro K Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 12, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "RTX A Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 13, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Tesla V100", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 14, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Tesla P100", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 15, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Tesla K80", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 16, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Tesla M Series", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 17, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "A100 Tensor Core", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 18, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "H100 Tensor Core", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 19, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "L40S", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 20, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "T4 Tensor Core", 52, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 21, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon RX 7000 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 22, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon RX 6000 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 23, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon RX 5000 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 24, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon RX Vega Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 25, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon RX 500 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 26, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon RX 400 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 27, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon Pro W7000 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 28, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon Pro W6000 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 29, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon Pro W5000 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 30, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon Pro WX Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 31, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radeon Pro Vega Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 32, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "FirePro W Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 33, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "FirePro S Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 34, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Instinct MI300 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 35, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Instinct MI200 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 36, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Instinct MI100 Series", 51, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 37, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Arc A Series", 50, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 38, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "Iris Xe Graphics", 50, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 39, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "UHD Graphics 700 Series", 50, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 40, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "UHD Graphics 600 Series", 50, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 41, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, "HD Graphics 500 Series", 50, new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "hardware_manufacturer",
                columns: new[] { "hardware_manufacturer_id", "created_at", "created_by", "hardware_manufacturer_name", "hwmanu_icon_file", "modified_at", "modified_by", "hwmanu_production_focus", "version" },
                values: new object[] { 166, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Matrox", null, null, null, "Processors & Components", 1 });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 396, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 397, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 397, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 397, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 397, DateTimeKind.Unspecified).AddTicks(2989), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 397, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 397, DateTimeKind.Unspecified).AddTicks(2991), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 397, DateTimeKind.Unspecified).AddTicks(2993), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 16, 11, 17, 397, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_gpu_types_manufacturer",
                table: "gpu_types",
                column: "hardware_manufacturer_id");

            migrationBuilder.CreateIndex(
                name: "IX_gpu_types_name",
                table: "gpu_types",
                column: "gpu_type_name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gpu_types");

            migrationBuilder.DeleteData(
                table: "hardware_manufacturer",
                keyColumn: "hardware_manufacturer_id",
                keyValue: 166);

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "hw_enclosure",
                keyColumn: "hw_enclosure_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 13,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 14,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 15,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 16,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 17,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 18,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 19,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 20,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 21,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 22,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 23,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 24,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 25,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 26,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 27,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 28,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 29,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 30,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 31,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 32,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "physical_memory_type",
                keyColumn: "physical_memtype_id",
                keyValue: 33,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 603, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 604, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 604, DateTimeKind.Unspecified).AddTicks(2682), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 604, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 604, DateTimeKind.Unspecified).AddTicks(2713), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 604, DateTimeKind.Unspecified).AddTicks(2715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 604, DateTimeKind.Unspecified).AddTicks(2716), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 604, DateTimeKind.Unspecified).AddTicks(2717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 58, 17, 604, DateTimeKind.Unspecified).AddTicks(2718), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
