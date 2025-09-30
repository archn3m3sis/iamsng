using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddHwEnclosureTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hw_enclosure",
                columns: table => new
                {
                    hw_enclosure_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enclosure_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name or type of the hardware enclosure"),
                    enclosure_description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Detailed description of the enclosure type and use case"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hw_enclosure", x => x.hw_enclosure_id);
                },
                comment: "Hardware enclosure types defining form factors and mounting styles");

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "hw_enclosure",
                columns: new[] { "hw_enclosure_id", "created_at", "created_by", "enclosure_description", "enclosure_name", "modified_at", "modified_by", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Standard 19-inch server rack mountable enclosure", "Server Rackmount Enclosure", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 2, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Vertical tower case design for standalone server or workstation", "Tower", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 3, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Modular blade server enclosure housing multiple blade servers", "Blade", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 4, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Standard desktop computer case", "Desktop", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 5, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Compact desktop enclosure with reduced footprint", "Small Form Factor", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 6, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Integrated enclosure with display and computer components", "All-in-One", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 7, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Laptop or notebook form factor enclosure", "Portable", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 8, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Slate-style touchscreen mobile device enclosure", "Tablet", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 9, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Multi-node chassis for rack-mounted server systems", "Rackmount Chassis", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 10, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Purpose-built enclosure for network devices", "Network Appliance", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 11, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Ruggedized enclosure for harsh industrial environments", "Industrial PC", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 12, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Enclosure designed for DIN rail mounting in control panels", "DIN Rail Mount", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 13, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Enclosure designed for wall-mounted installation", "Wall Mount", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 14, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Weather-resistant enclosure for outdoor deployment", "Outdoor Rated", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 15, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Enclosure meeting NEMA environmental protection standards", "NEMA Rated", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 16, new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, "Compact embedded system enclosure", "Embedded", new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 254, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 255, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 255, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 255, DateTimeKind.Unspecified).AddTicks(2579), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 255, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 255, DateTimeKind.Unspecified).AddTicks(2582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 255, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 255, DateTimeKind.Unspecified).AddTicks(2584), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 15, 27, 48, 255, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_hw_enclosure_name",
                table: "hw_enclosure",
                column: "enclosure_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hw_enclosure");

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 4,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 5,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 6,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 7,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 8,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 9,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 10,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 11,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "condition",
                keyColumn: "condition_id",
                keyValue: 12,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(9525), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(9527), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(9528), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(9531), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
