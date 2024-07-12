using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace south_country_garden.Migrations
{
    public partial class MigrationOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "booking_records",
                columns: table => new
                {
                    booking_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    contact_number = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    additional_message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_records", x => x.booking_id);
                });

            migrationBuilder.CreateTable(
                name: "booking_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    payment_status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_status", x => x.id);
                    table.ForeignKey(
                        name: "FK_booking_status_booking_records_booking_id",
                        column: x => x.booking_id,
                        principalTable: "booking_records",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "event_add_ons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    hair_and_make_up = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    giveaway = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    photo_and_video_coverage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    photo_booth = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    bridal_car = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    entourage_church_flower = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    additional_stages = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_add_ons", x => x.id);
                    table.ForeignKey(
                        name: "FK_event_add_ons_booking_records_booking_id",
                        column: x => x.booking_id,
                        principalTable: "booking_records",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "event_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    event_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    color_motif = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    event_date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    church = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    venue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    time_preparation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    pax_number = table.Column<int>(type: "int", nullable: false),
                    event_time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_event_details_booking_records_booking_id",
                        column: x => x.booking_id,
                        principalTable: "booking_records",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "event_inclusions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    event_coordination = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    program_hosting = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    mobile_sound_system = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    lighting_system = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    catering = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tiffany_chairs_and_tables = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    red_carpets = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    personalized_cake_layers = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    photo_gallery = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    table_numbers = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tarpaulin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    signature_frame = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    holding_area_rooms = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    lcd_and_projectors = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    event_extras = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_inclusions", x => x.id);
                    table.ForeignKey(
                        name: "FK_event_inclusions_booking_records_booking_id",
                        column: x => x.booking_id,
                        principalTable: "booking_records",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "food_arrangements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    beef = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    seafood = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pork = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    chicken = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pasta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vegetable = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rice = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    dessert = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_food_arrangements", x => x.id);
                    table.ForeignKey(
                        name: "FK_food_arrangements_booking_records_booking_id",
                        column: x => x.booking_id,
                        principalTable: "booking_records",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "terms_and_conditions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_terms_and_conditions", x => x.id);
                    table.ForeignKey(
                        name: "FK_terms_and_conditions_booking_records_booking_id",
                        column: x => x.booking_id,
                        principalTable: "booking_records",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_status_booking_id",
                table: "booking_status",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_event_add_ons_booking_id",
                table: "event_add_ons",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_event_details_booking_id",
                table: "event_details",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_event_inclusions_booking_id",
                table: "event_inclusions",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_food_arrangements_booking_id",
                table: "food_arrangements",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_terms_and_conditions_booking_id",
                table: "terms_and_conditions",
                column: "booking_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking_status");

            migrationBuilder.DropTable(
                name: "event_add_ons");

            migrationBuilder.DropTable(
                name: "event_details");

            migrationBuilder.DropTable(
                name: "event_inclusions");

            migrationBuilder.DropTable(
                name: "food_arrangements");

            migrationBuilder.DropTable(
                name: "terms_and_conditions");

            migrationBuilder.DropTable(
                name: "booking_records");
        }
    }
}
