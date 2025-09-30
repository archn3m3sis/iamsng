using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProgramTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "program",
                columns: table => new
                {
                    program_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    program_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Current program name"),
                    legacy_program_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Historical/legacy program name"),
                    program_manager = table.Column<int>(type: "int", nullable: true, comment: "User ID of program manager (nullable until data available)"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_program", x => x.program_id);
                    table.ForeignKey(
                        name: "FK_program_manager_user",
                        column: x => x.program_manager,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.SetNull);
                },
                comment: "DoD programs that own/manage industrial assets");

            migrationBuilder.InsertData(
                table: "program",
                columns: new[] { "program_id", "created_at", "created_by", "legacy_program_name", "modified_at", "modified_by", "program_manager", "program_name", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Patriot", null, null, null, "IFMC", 1 },
                    { 2, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Himars", null, null, null, "STORM", 1 },
                    { 3, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "TOW", null, null, null, "TAGM", 1 },
                    { 4, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Avenger", null, null, null, "SHIELD", 1 },
                    { 5, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "MULTI", null, null, null, "MULTI", 1 },
                    { 6, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Sentinel", null, null, null, "STARE", 1 }
                });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(1645), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(1649), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(1650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(1651), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(1652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(1653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(2941), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(2944), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(2945), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(2946), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 20, 31, 40, 731, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_program_asset_lookup",
                table: "program",
                column: "program_id")
                .Annotation("SqlServer:Include", new[] { "program_name", "legacy_program_name" });

            migrationBuilder.CreateIndex(
                name: "IX_program_legacy_name",
                table: "program",
                column: "legacy_program_name");

            migrationBuilder.CreateIndex(
                name: "IX_program_program_manager",
                table: "program",
                column: "program_manager");

            migrationBuilder.CreateIndex(
                name: "UX_program_name",
                table: "program",
                column: "program_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "program");

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5884), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5887), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5889), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5891), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5894), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7404), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
