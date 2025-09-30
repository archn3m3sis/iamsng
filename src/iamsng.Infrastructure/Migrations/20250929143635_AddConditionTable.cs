using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddConditionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "condition",
                columns: table => new
                {
                    condition_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    condition_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name or label of the condition state"),
                    condition_description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Detailed description of what this condition means"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_condition", x => x.condition_id);
                },
                comment: "Asset condition states for lifecycle and maintenance tracking");

            migrationBuilder.InsertData(
                table: "condition",
                columns: new[] { "condition_id", "condition_description", "condition_name", "created_at", "created_by", "modified_at", "modified_by", "version" },
                values: new object[,]
                {
                    { 1, "Device is brand new, unused, and in original packaging", "New", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 2, "Device is in like-new condition with no visible wear or defects", "Excellent", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 3, "Device is fully functional with minor cosmetic wear but no operational issues", "Good", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 4, "Device is functional but shows moderate wear or has minor non-critical issues", "Fair", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 5, "Device has significant wear or operational issues but remains usable", "Poor", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 6, "Device is not operational and requires repair or replacement", "Non-Functional", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 7, "Device is currently being serviced or repaired", "Under Repair", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 8, "Device has been marked for disposal or decommissioning", "Awaiting Disposal", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 9, "Device has been properly disposed of or decommissioned", "Disposed", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 10, "Device cannot be located and is considered missing from inventory", "Missing", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 11, "Device has physical damage affecting functionality or safety", "Damaged", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 },
                    { 12, "Device is outdated and no longer supported for operational use", "Obsolete", new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2025, 9, 29, 14, 36, 35, 473, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 0, 0, 0, 0)), 1, 1 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_condition_name",
                table: "condition",
                column: "condition_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "condition");

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 12, 52, 40, 455, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 12, 52, 40, 455, DateTimeKind.Unspecified).AddTicks(1864), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 12, 52, 40, 455, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 12, 52, 40, 455, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 12, 52, 40, 455, DateTimeKind.Unspecified).AddTicks(1868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 12, 52, 40, 455, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 12, 52, 40, 455, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 29, 12, 52, 40, 455, DateTimeKind.Unspecified).AddTicks(1871), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
