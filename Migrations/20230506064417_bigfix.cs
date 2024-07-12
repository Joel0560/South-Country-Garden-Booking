using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace south_country_garden.Migrations
{
    public partial class bigfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "additional_stages",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "beef",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "booking_status",
                table: "booking_records",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bridal_car",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "catering",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "chicken",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "church",
                table: "booking_records",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "color_motif",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dessert",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "entourage_church_flower",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "event_coordination",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "event_date",
                table: "booking_records",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "event_extras",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "event_time",
                table: "booking_records",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "event_title",
                table: "booking_records",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "giveaway",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hair_and_make_up",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "holding_area_rooms",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lcd_and_projectors",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lighting_system",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mobile_sound_system",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pasta",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "pax_number",
                table: "booking_records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "payment_status",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "personalized_cake_layers",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "photo_and_video_coverage",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "photo_booth",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "photo_gallery",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pork",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "program_hosting",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "red_carpets",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "remarks",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rice",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "seafood",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "signature_frame",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "table_numbers",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tarpaulin",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tiffany_chairs_and_tables",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "time_preparation",
                table: "booking_records",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "total_package",
                table: "booking_records",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "vegetable",
                table: "booking_records",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "venue",
                table: "booking_records",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "additional_stages",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "beef",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "booking_status",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "bridal_car",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "catering",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "chicken",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "church",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "color_motif",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "dessert",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "entourage_church_flower",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "event_coordination",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "event_date",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "event_extras",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "event_time",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "event_title",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "giveaway",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "hair_and_make_up",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "holding_area_rooms",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "lcd_and_projectors",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "lighting_system",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "mobile_sound_system",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "pasta",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "pax_number",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "payment_status",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "personalized_cake_layers",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "photo_and_video_coverage",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "photo_booth",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "photo_gallery",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "pork",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "program_hosting",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "red_carpets",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "remarks",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "rice",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "seafood",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "signature_frame",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "table_numbers",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "tarpaulin",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "tiffany_chairs_and_tables",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "time_preparation",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "total_package",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "vegetable",
                table: "booking_records");

            migrationBuilder.DropColumn(
                name: "venue",
                table: "booking_records");

            migrationBuilder.CreateTable(
                name: "booking_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_id = table.Column<int>(type: "int", nullable: false),
                    payment_status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    additional_stages = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    bridal_car = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    entourage_church_flower = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    giveaway = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    hair_and_make_up = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    photo_and_video_coverage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    photo_booth = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
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
                    church = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    color_motif = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    event_date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    event_time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    event_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pax_number = table.Column<int>(type: "int", nullable: false),
                    time_preparation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    venue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    catering = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    event_coordination = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    event_extras = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    holding_area_rooms = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    lcd_and_projectors = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    lighting_system = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    mobile_sound_system = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    personalized_cake_layers = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    photo_gallery = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    program_hosting = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    red_carpets = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    signature_frame = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    table_numbers = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tarpaulin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tiffany_chairs_and_tables = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
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
                    chicken = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    dessert = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pasta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pork = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rice = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    seafood = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vegetable = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
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
    }
}
