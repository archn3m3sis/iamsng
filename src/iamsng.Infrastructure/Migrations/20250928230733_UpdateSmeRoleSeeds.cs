using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSmeRoleSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 23, 7, 33, 235, DateTimeKind.Unspecified).AddTicks(625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 23, 7, 33, 235, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 23, 7, 33, 235, DateTimeKind.Unspecified).AddTicks(628), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 23, 7, 33, 235, DateTimeKind.Unspecified).AddTicks(629), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 23, 7, 33, 235, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 23, 7, 33, 235, DateTimeKind.Unspecified).AddTicks(632), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 23, 7, 33, 235, DateTimeKind.Unspecified).AddTicks(633), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 23, 7, 33, 235, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 1,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Change Management Specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 2,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Vulnerability Management Specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 3,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Access Control Specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 4,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Risk Management Framework Specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 5,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Database Management Specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 6,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "SAN Environment & Virtualization Specialist" });

            migrationBuilder.InsertData(
                table: "sme_role",
                columns: new[] { "smerole_id", "created_at", "created_by", "modified_at", "modified_by", "smerole_name", "version" },
                values: new object[,]
                {
                    { 7, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Linux Environment Specialist", 1 },
                    { 8, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Windows Environment Specialist", 1 },
                    { 9, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "Legacy Environment Specialist", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 102, DateTimeKind.Unspecified).AddTicks(7849), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 102, DateTimeKind.Unspecified).AddTicks(7851), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 102, DateTimeKind.Unspecified).AddTicks(7852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 102, DateTimeKind.Unspecified).AddTicks(7853), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 102, DateTimeKind.Unspecified).AddTicks(7854), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 102, DateTimeKind.Unspecified).AddTicks(7856), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 102, DateTimeKind.Unspecified).AddTicks(7857), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 102, DateTimeKind.Unspecified).AddTicks(7858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 1,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1770), new TimeSpan(0, 0, 0, 0, 0)), "database_specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 2,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 0, 0, 0, 0)), "vulnerability_specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 3,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1772), new TimeSpan(0, 0, 0, 0, 0)), "change_management_specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 4,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1774), new TimeSpan(0, 0, 0, 0, 0)), "san_specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 5,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1775), new TimeSpan(0, 0, 0, 0, 0)), "access_control_specialist" });

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 6,
                columns: new[] { "created_at", "smerole_name" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1776), new TimeSpan(0, 0, 0, 0, 0)), "rmf_specialist" });
        }
    }
}
