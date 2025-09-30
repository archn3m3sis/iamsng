using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iamsng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInstallationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "installation",
                columns: table => new
                {
                    installation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    installation_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the military installation"),
                    installation_state = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "State where installation is located"),
                    installation_city = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "City where installation is located"),
                    installation_area_of_excellence = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Primary area of excellence or specialization for this installation"),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    modified_by = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_installation", x => x.installation_id);
                },
                comment: "Military installations/bases with area of excellence for asset management");

            migrationBuilder.InsertData(
                table: "installation",
                columns: new[] { "installation_id", "created_at", "created_by", "installation_area_of_excellence", "installation_city", "installation_name", "installation_state", "modified_at", "modified_by", "version" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Ground Combat Vehicles", "Anniston", "Anniston Army Depot", "Alabama", null, null, 1 },
                    { 2, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Air Assault", "Fort Campbell", "Fort Campbell", "Kentucky", null, null, 1 },
                    { 3, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Armored Warfare", "Killeen", "Fort Cavazos", "Texas", null, null, 1 },
                    { 4, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Cyber Warfare", "Augusta", "Fort Eisenhower", "Georgia", null, null, 1 },
                    { 5, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Special Operations", "Fayetteville", "Fort Liberty", "North Carolina", null, null, 1 },
                    { 6, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Maneuver Center of Excellence", "Columbus", "Fort Moore", "Georgia", null, null, 1 },
                    { 7, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Power Projection Platform", "Tacoma", "Joint Base Lewis-McChord", "Washington", null, null, 1 },
                    { 8, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Missile and Ammunition", "Chambersburg", "Letterkenny Army Depot", "Pennsylvania", null, null, 1 },
                    { 9, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Combat Vehicle Repair", "Texarkana", "Red River Army Depot", "Texas", null, null, 1 },
                    { 10, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Manufacturing and Logistics", "Rock Island", "Rock Island Arsenal", "Illinois", null, null, 1 },
                    { 11, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Ammunition Storage", "Herlong", "Sierra Army Depot", "California", null, null, 1 },
                    { 12, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Communications Electronics", "Tobyhanna", "Tobyhanna Army Depot", "Pennsylvania", null, null, 1 },
                    { 13, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Cannon Manufacturing", "Watervliet", "Watervliet Arsenal", "New York", null, null, 1 },
                    { 14, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Air Defense Artillery", "El Paso", "Fort Bliss", "Texas", null, null, 1 },
                    { 15, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Mountain Warfare", "Colorado Springs", "Fort Carson", "Colorado", null, null, 1 },
                    { 16, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Cold Weather Training", "Watertown", "Fort Drum", "New York", null, null, 1 },
                    { 17, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Intelligence Training", "Sierra Vista", "Fort Huachuca", "Arizona", null, null, 1 },
                    { 18, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "National Training Center", "Barstow", "Fort Irwin", "California", null, null, 1 },
                    { 19, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Joint Readiness Training Center", "Leesville", "Fort Johnson", "Louisiana", null, null, 1 },
                    { 20, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Human Resources", "Fort Knox", "Fort Knox", "Kentucky", null, null, 1 },
                    { 21, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Combined Arms Center", "Leavenworth", "Fort Leavenworth", "Kansas", null, null, 1 },
                    { 22, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Sustainment", "Petersburg", "Fort Lee", "Virginia", null, null, 1 },
                    { 23, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Engineer Training", "St. Robert", "Fort Leonard Wood", "Missouri", null, null, 1 },
                    { 24, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Aviation Training", "Daleville", "Fort Novosel", "Alabama", null, null, 1 },
                    { 25, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Division Headquarters", "Junction City", "Fort Riley", "Kansas", null, null, 1 },
                    { 26, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Field Artillery", "Lawton", "Fort Sill", "Oklahoma", null, null, 1 },
                    { 27, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Heavy Mechanized Infantry", "Hinesville", "Fort Stewart", "Georgia", null, null, 1 },
                    { 28, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Arctic Warfare", "Fairbanks", "Fort Wainwright", "Alaska", null, null, 1 },
                    { 29, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Pacific Air Power", "Anchorage", "Joint Base Elmendorf-Richardson", "Alaska", null, null, 1 },
                    { 30, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Air Combat Command", "Hampton", "Joint Base Langley-Eustis", "Virginia", null, null, 1 },
                    { 31, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Military Medical Training", "San Antonio", "Joint Base San Antonio", "Texas", null, null, 1 },
                    { 32, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Armaments Research", "Dover", "Picatinny Arsenal", "New Jersey", null, null, 1 },
                    { 33, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Chemical/Biological Defense", "Pine Bluff", "Pine Bluff Arsenal", "Arkansas", null, null, 1 },
                    { 34, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Missile and Space", "Huntsville", "Redstone Arsenal", "Alabama", null, null, 1 },
                    { 35, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Test and Evaluation", "Aberdeen", "Aberdeen Proving Ground", "Maryland", null, null, 1 },
                    { 36, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Chemical/Biological Testing", "Dugway", "Dugway Proving Ground", "Utah", null, null, 1 },
                    { 37, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Missile Testing", "Las Cruces", "White Sands Missile Range", "New Mexico", null, null, 1 },
                    { 38, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Desert Testing", "Yuma", "Yuma Proving Ground", "Arizona", null, null, 1 },
                    { 39, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Mobilization Training", "Edinburgh", "Camp Atterbury", "Indiana", null, null, 1 },
                    { 40, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "National Guard Training", "Johnston", "Camp Dodge", "Iowa", null, null, 1 },
                    { 41, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Joint Maneuver Training", "Grayling", "Camp Grayling", "Michigan", null, null, 1 },
                    { 42, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Winter Operations", "Little Falls", "Camp Ripley", "Minnesota", null, null, 1 },
                    { 43, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Mobilization Site", "Hattiesburg", "Camp Shelby", "Mississippi", null, null, 1 },
                    { 44, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Joint Training", "Fort Smith", "Fort Chaffee", "Arkansas", null, null, 1 },
                    { 45, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Combat Support Training", "Jolon", "Fort Hunter Liggett", "California", null, null, 1 },
                    { 46, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Reserve Training", "Sparta", "Fort McCoy", "Wisconsin", null, null, 1 },
                    { 47, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Foreign Military Training", "Blackstone", "Fort Pickett", "Virginia", null, null, 1 },
                    { 48, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Regional Training", "Helena", "Fort William Henry Harrison", "Montana", null, null, 1 },
                    { 49, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Air National Guard", "Boise", "Gowen Field", "Idaho", null, null, 1 },
                    { 50, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Munitions Storage", "Bellemont", "Camp Navajo", "Arizona", null, null, 1 },
                    { 51, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Reserve Operations", "Dublin", "Camp Parks", "California", null, null, 1 },
                    { 52, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Maneuver Training", "Bastrop", "Camp Swift", "Texas", null, null, 1 }
                });

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
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1770), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1772), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1774), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 22, 33, 40, 103, DateTimeKind.Unspecified).AddTicks(1776), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_installation_area_excellence",
                table: "installation",
                column: "installation_area_of_excellence");

            migrationBuilder.CreateIndex(
                name: "IX_installation_name",
                table: "installation",
                column: "installation_name");

            migrationBuilder.CreateIndex(
                name: "IX_installation_state",
                table: "installation",
                column: "installation_state");

            migrationBuilder.CreateIndex(
                name: "IX_installation_state_city",
                table: "installation",
                columns: new[] { "installation_state", "installation_city" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "installation");

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(3815), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(3819), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(3822), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(7806), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(7807), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(7808), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "sme_role",
                keyColumn: "smerole_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTimeOffset(new DateTime(2025, 9, 28, 21, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(7809), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
