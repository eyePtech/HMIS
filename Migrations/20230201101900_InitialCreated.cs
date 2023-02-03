using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HMIS.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "person_m",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name_prefix = table.Column<string>(type: "text", nullable: true),
                    Name_suffix = table.Column<string>(type: "text", nullable: true),
                    S_name = table.Column<string>(type: "text", nullable: true),
                    L_name = table.Column<string>(type: "text", nullable: true),
                    Name_text = table.Column<string>(type: "text", nullable: false),
                    Name_Nickname = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    birthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    deceased_YN = table.Column<bool>(type: "boolean", nullable: false),
                    deceasedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsMarried = table.Column<bool>(type: "boolean", nullable: false),
                    Race = table.Column<string>(type: "text", nullable: false),
                    Ethnicity = table.Column<int>(type: "integer", nullable: false),
                    BirthSex = table.Column<string>(type: "text", nullable: true),
                    language_1 = table.Column<int>(type: "integer", nullable: false),
                    language_2 = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    natioanlity = table.Column<string>(type: "text", nullable: true),
                    NationalIDNumber = table.Column<int>(type: "integer", nullable: false),
                    PassortNumber = table.Column<int>(type: "integer", nullable: true),
                    DLNumber = table.Column<int>(type: "integer", nullable: true),
                    id_type = table.Column<int>(type: "integer", nullable: true),
                    id_number = table.Column<int>(type: "integer", nullable: true),
                    Mobile = table.Column<int>(type: "integer", nullable: true),
                    Phone_Home = table.Column<int>(type: "integer", nullable: true),
                    Phone_Work = table.Column<int>(type: "integer", nullable: true),
                    email_work = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    modified_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_user_id = table.Column<int>(type: "integer", nullable: true),
                    modified_user_id = table.Column<int>(type: "integer", nullable: true),
                    created_location_id = table.Column<int>(type: "integer", nullable: true),
                    modified_location_id = table.Column<int>(type: "integer", nullable: true),
                    is_active = table.Column<int>(type: "integer", nullable: true),
                    is_deleted = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person_m", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sec_user_m",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    staff_id = table.Column<int>(type: "integer", nullable: false),
                    valid_from = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    valid_to = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    can_change_pwd = table.Column<bool>(type: "boolean", nullable: false),
                    tenent_id = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: false),
                    modified_user_id = table.Column<int>(type: "integer", nullable: false),
                    created_location_id = table.Column<int>(type: "integer", nullable: false),
                    modified_location_id = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<int>(type: "integer", nullable: false),
                    is_deleted = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sec_user_m", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Service_Center_m",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    department_id = table.Column<int>(type: "integer", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false),
                    desc = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: false),
                    modified_user_id = table.Column<int>(type: "integer", nullable: false),
                    created_location_id = table.Column<int>(type: "integer", nullable: false),
                    modified_location_id = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<int>(type: "integer", nullable: false),
                    is_deleted = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_Center_m", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "person_address_m",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonMasterId = table.Column<int>(type: "integer", nullable: false),
                    Address1 = table.Column<string>(type: "text", nullable: true),
                    Address2 = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    distict = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    postal_code = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: true),
                    country = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: false),
                    modified_user_id = table.Column<int>(type: "integer", nullable: false),
                    created_location_id = table.Column<int>(type: "integer", nullable: false),
                    modified_location_id = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<int>(type: "integer", nullable: false),
                    is_deleted = table.Column<int>(type: "integer", nullable: false),
                    PersonMasterid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person_address_m", x => x.id);
                    table.ForeignKey(
                        name: "FK_person_address_m_person_m_PersonMasterid",
                        column: x => x.PersonMasterid,
                        principalTable: "person_m",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_person_address_m_PersonMasterid",
                table: "person_address_m",
                column: "PersonMasterid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "person_address_m");

            migrationBuilder.DropTable(
                name: "sec_user_m");

            migrationBuilder.DropTable(
                name: "Service_Center_m");

            migrationBuilder.DropTable(
                name: "person_m");
        }
    }
}
