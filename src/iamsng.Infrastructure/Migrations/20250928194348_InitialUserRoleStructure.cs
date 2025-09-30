using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialUserRoleStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Unique role name for the system"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.role_id);
                },
                comment: "User roles for RBAC implementation - DoD compliant");

            migrationBuilder.CreateTable(
                name: "sme_role",
                columns: table => new
                {
                    smerole_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    smerole_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Unique SME role/specialization name"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sme_role", x => x.smerole_id);
                },
                comment: "Subject Matter Expert roles for specialized expertise designation");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_first = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "User's first name"),
                    user_last = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "User's last name"),
                    user_email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "User's email address - must be unique"),
                    user_phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "User's phone number - optional"),
                    user_dodid = table.Column<long>(type: "bigint", nullable: false, comment: "10-digit DoD ID number (EDIPI) for CAC authentication"),
                    user_certificate_dn = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Distinguished Name from CAC certificate"),
                    user_certificate_serial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Certificate serial number for tracking"),
                    user_account_status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)0, comment: "Account status: 0=Inactive, 1=Active, 2=Suspended, 3=Locked"),
                    user_last_cac_auth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "Timestamp of last successful CAC authentication"),
                    user_requires_cac = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Whether CAC authentication is mandatory for this user"),
                    user_piv_auth_cert_hash = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, comment: "SHA-256 hash of PIV certificate for pinning (MITM protection)"),
                    user_affiliation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Military branch or civilian agency"),
                    user_person_designator = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Personnel type: MILITARY, CIVILIAN, CONTRACTOR"),
                    user_cac_expiry = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "CAC certificate expiration date"),
                    user_role = table.Column<int>(type: "int", nullable: false, comment: "Primary role assignment (required)"),
                    sme_role = table.Column<int>(type: "int", nullable: true, comment: "Subject Matter Expert role (optional)"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_user_role",
                        column: x => x.user_role,
                        principalTable: "role",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_user_smerole",
                        column: x => x.sme_role,
                        principalTable: "sme_role",
                        principalColumn: "smerole_id",
                        onDelete: ReferentialAction.SetNull);
                },
                comment: "System users with CAC authentication support for DoD compliance");

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "role_id", "created_at", "created_by", "modified_at", "modified_by", "role_name", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5884), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "system", 1 },
                    { 2, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5887), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "cyber_user", 1 },
                    { 3, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "tem_user", 1 },
                    { 4, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5889), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "dev_user", 1 },
                    { 5, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5890), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "cyber_mgr", 1 },
                    { 6, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5891), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "tem_mgr", 1 },
                    { 7, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "org_mgr", 1 },
                    { 8, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(5894), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "sys_admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "sme_role",
                columns: new[] { "smerole_id", "created_at", "created_by", "modified_at", "modified_by", "smerole_name", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "database_specialist", 1 },
                    { 2, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7404), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "vulnerability_specialist", 1 },
                    { 3, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "change_management_specialist", 1 },
                    { 4, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "san_specialist", 1 },
                    { 5, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "access_control_specialist", 1 },
                    { 6, new DateTimeOffset(new DateTime(2025, 9, 28, 19, 43, 48, 584, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, "rmf_specialist", 1 }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "user_id", "user_account_status", "user_affiliation", "user_cac_expiry", "user_certificate_dn", "user_certificate_serial", "created_at", "created_by", "user_dodid", "user_email", "user_first", "user_last_cac_auth", "user_last", "modified_at", "modified_by", "user_person_designator", "user_phone", "user_piv_auth_cert_hash", "user_role", "sme_role", "version" },
                values: new object[] { 1, (byte)1, "SYSTEM", null, "CN=SYSTEM,OU=IAMSNG,O=DoD,C=US", "SYSTEM-ACCOUNT-NO-LOGIN", new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, 0L, "system@iamsng.local", "SYSTEM", null, "ACCOUNT", null, null, "SYSTEM", null, null, 1, null, 1 });

            migrationBuilder.CreateIndex(
                name: "UX_role_name",
                table: "role",
                column: "role_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UX_sme_role_name",
                table: "sme_role",
                column: "smerole_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_account_status",
                table: "user",
                column: "user_account_status",
                filter: "[user_account_status] = 1");

            migrationBuilder.CreateIndex(
                name: "IX_user_certificate_dn",
                table: "user",
                column: "user_certificate_dn");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_status",
                table: "user",
                columns: new[] { "user_role", "user_account_status" });

            migrationBuilder.CreateIndex(
                name: "IX_user_smerole",
                table: "user",
                column: "sme_role",
                filter: "[sme_role] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UX_user_dodid",
                table: "user",
                column: "user_dodid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UX_user_email",
                table: "user",
                column: "user_email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "sme_role");
        }
    }
}
