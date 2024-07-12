﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using south_country_garden.Data;

#nullable disable

namespace south_country_garden.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230505135421_MigrationOne")]
    partial class MigrationOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("south_country_garden.Model.booking_records", b =>
                {
                    b.Property<int>("booking_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("booking_id"), 1L, 1);

                    b.Property<string>("additional_message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("contact_number")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("booking_id");

                    b.ToTable("booking_records");
                });

            modelBuilder.Entity("south_country_garden.Model.booking_status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("booking_id")
                        .HasColumnType("int");

                    b.Property<string>("payment_status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("remarks")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.HasIndex("booking_id");

                    b.ToTable("booking_status");
                });

            modelBuilder.Entity("south_country_garden.Model.event_add_ons", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("additional_stages")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("booking_id")
                        .HasColumnType("int");

                    b.Property<string>("bridal_car")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("entourage_church_flower")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("giveaway")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("hair_and_make_up")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("photo_and_video_coverage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("photo_booth")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.HasIndex("booking_id");

                    b.ToTable("event_add_ons");
                });

            modelBuilder.Entity("south_country_garden.Model.event_details", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("booking_id")
                        .HasColumnType("int");

                    b.Property<string>("church")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("color_motif")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("event_date")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("event_time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("pax_number")
                        .HasColumnType("int");

                    b.Property<string>("time_preparation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("venue")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.HasIndex("booking_id");

                    b.ToTable("event_details");
                });

            modelBuilder.Entity("south_country_garden.Model.event_inclusions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("booking_id")
                        .HasColumnType("int");

                    b.Property<string>("catering")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("event_coordination")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("event_extras")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("holding_area_rooms")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("lcd_and_projectors")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("lighting_system")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("mobile_sound_system")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("personalized_cake_layers")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("photo_gallery")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("program_hosting")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("red_carpets")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("signature_frame")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("table_numbers")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("tarpaulin")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("tiffany_chairs_and_tables")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.HasIndex("booking_id");

                    b.ToTable("event_inclusions");
                });

            modelBuilder.Entity("south_country_garden.Model.food_arrangements", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("beef")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("booking_id")
                        .HasColumnType("int");

                    b.Property<string>("chicken")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("dessert")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("pasta")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("pork")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("rice")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("seafood")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("vegetable")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.HasIndex("booking_id");

                    b.ToTable("food_arrangements");
                });

            modelBuilder.Entity("south_country_garden.Model.terms_and_conditions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("booking_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("booking_id");

                    b.ToTable("terms_and_conditions");
                });

            modelBuilder.Entity("south_country_garden.Model.booking_status", b =>
                {
                    b.HasOne("south_country_garden.Model.booking_records", "booking_")
                        .WithMany("booking_statuse_s")
                        .HasForeignKey("booking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking_");
                });

            modelBuilder.Entity("south_country_garden.Model.event_add_ons", b =>
                {
                    b.HasOne("south_country_garden.Model.booking_records", "booking_")
                        .WithMany("event_add_ons_s")
                        .HasForeignKey("booking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking_");
                });

            modelBuilder.Entity("south_country_garden.Model.event_details", b =>
                {
                    b.HasOne("south_country_garden.Model.booking_records", "booking_")
                        .WithMany("event_details_s")
                        .HasForeignKey("booking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking_");
                });

            modelBuilder.Entity("south_country_garden.Model.event_inclusions", b =>
                {
                    b.HasOne("south_country_garden.Model.booking_records", "booking_")
                        .WithMany("event_inclusions_s")
                        .HasForeignKey("booking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking_");
                });

            modelBuilder.Entity("south_country_garden.Model.food_arrangements", b =>
                {
                    b.HasOne("south_country_garden.Model.booking_records", "booking_")
                        .WithMany("food_arrangements_s")
                        .HasForeignKey("booking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking_");
                });

            modelBuilder.Entity("south_country_garden.Model.terms_and_conditions", b =>
                {
                    b.HasOne("south_country_garden.Model.booking_records", "booking_")
                        .WithMany("terms_and_conditions_s")
                        .HasForeignKey("booking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking_");
                });

            modelBuilder.Entity("south_country_garden.Model.booking_records", b =>
                {
                    b.Navigation("booking_statuse_s");

                    b.Navigation("event_add_ons_s");

                    b.Navigation("event_details_s");

                    b.Navigation("event_inclusions_s");

                    b.Navigation("food_arrangements_s");

                    b.Navigation("terms_and_conditions_s");
                });
#pragma warning restore 612, 618
        }
    }
}
