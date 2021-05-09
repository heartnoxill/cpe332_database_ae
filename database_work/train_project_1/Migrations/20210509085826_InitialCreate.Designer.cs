﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using train_project_1.Data;

namespace train_project_1.Migrations
{
    [DbContext(typeof(TrainContext))]
    [Migration("20210509085826_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("train_project_1.Models.Class", b =>
                {
                    b.Property<int>("C_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aisle_no")
                        .HasColumnType("int");

                    b.Property<int>("Class_price")
                        .HasColumnType("int");

                    b.Property<string>("Classname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seat_no")
                        .HasColumnType("int");

                    b.HasKey("C_id");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("train_project_1.Models.Passenger", b =>
                {
                    b.Property<int>("P_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("P_DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("P_contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("P_id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("train_project_1.Models.Price", b =>
                {
                    b.Property<int>("TicketT_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassC_id")
                        .HasColumnType("int");

                    b.Property<int>("PromotionPromotion_id")
                        .HasColumnType("int");

                    b.Property<int>("RouteR_id")
                        .HasColumnType("int");

                    b.Property<int?>("TicketT_id1")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("TicketT_id");

                    b.HasIndex("ClassC_id");

                    b.HasIndex("PromotionPromotion_id");

                    b.HasIndex("RouteR_id");

                    b.HasIndex("TicketT_id1");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("train_project_1.Models.Promotion", b =>
                {
                    b.Property<int>("Promotion_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Discount_percent")
                        .HasColumnType("int");

                    b.Property<DateTime>("Expiration_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Promotion_id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("train_project_1.Models.Route", b =>
                {
                    b.Property<int>("R_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Departure_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departure_state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departure_station")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination_state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination_station")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2");

                    b.Property<int>("R_price")
                        .HasColumnType("int");

                    b.HasKey("R_id");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("train_project_1.Models.Schedule", b =>
                {
                    b.Property<int>("RouteR_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckIn_time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure_time")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoutesR_id")
                        .HasColumnType("int");

                    b.HasKey("RouteR_id");

                    b.HasIndex("RoutesR_id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("train_project_1.Models.Staff", b =>
                {
                    b.Property<int>("ST_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ST_DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("ST_fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ST_lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ST_resp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrainTR_id")
                        .HasColumnType("int");

                    b.HasKey("ST_id");

                    b.HasIndex("TrainTR_id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("train_project_1.Models.Ticket", b =>
                {
                    b.Property<int>("T_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassC_id")
                        .HasColumnType("int");

                    b.Property<int>("PassengerP_id")
                        .HasColumnType("int");

                    b.Property<int>("R_id")
                        .HasColumnType("int");

                    b.Property<int?>("RouteR_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduleDeparture_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ScheduleRouteR_id")
                        .HasColumnType("int");

                    b.Property<int>("TrainTR_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_issued")
                        .HasColumnType("datetime2");

                    b.HasKey("T_id");

                    b.HasIndex("ClassC_id");

                    b.HasIndex("PassengerP_id");

                    b.HasIndex("RouteR_id");

                    b.HasIndex("ScheduleRouteR_id");

                    b.HasIndex("TrainTR_id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("train_project_1.Models.Train", b =>
                {
                    b.Property<int>("TR_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Max_cap")
                        .HasColumnType("int");

                    b.Property<int>("Maxspeed")
                        .HasColumnType("int");

                    b.Property<int>("Platform")
                        .HasColumnType("int");

                    b.Property<int>("Seats_filled")
                        .HasColumnType("int");

                    b.Property<int>("Seats_remain")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TR_age")
                        .HasColumnType("datetime2");

                    b.HasKey("TR_id");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("train_project_1.Models.Price", b =>
                {
                    b.HasOne("train_project_1.Models.Class", "Class")
                        .WithMany("Prices")
                        .HasForeignKey("ClassC_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("train_project_1.Models.Promotion", "Promotion")
                        .WithMany("Prices")
                        .HasForeignKey("PromotionPromotion_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("train_project_1.Models.Route", "Route")
                        .WithMany("Prices")
                        .HasForeignKey("RouteR_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("train_project_1.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketT_id1");

                    b.Navigation("Class");

                    b.Navigation("Promotion");

                    b.Navigation("Route");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("train_project_1.Models.Schedule", b =>
                {
                    b.HasOne("train_project_1.Models.Route", "Routes")
                        .WithMany("Schedules")
                        .HasForeignKey("RoutesR_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Routes");
                });

            modelBuilder.Entity("train_project_1.Models.Staff", b =>
                {
                    b.HasOne("train_project_1.Models.Train", "Train")
                        .WithMany("Staffs")
                        .HasForeignKey("TrainTR_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Train");
                });

            modelBuilder.Entity("train_project_1.Models.Ticket", b =>
                {
                    b.HasOne("train_project_1.Models.Class", "Class")
                        .WithMany("Tickets")
                        .HasForeignKey("ClassC_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("train_project_1.Models.Passenger", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerP_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("train_project_1.Models.Route", "Route")
                        .WithMany("Tickets")
                        .HasForeignKey("RouteR_id");

                    b.HasOne("train_project_1.Models.Schedule", "Schedule")
                        .WithMany("Tickets")
                        .HasForeignKey("ScheduleRouteR_id");

                    b.HasOne("train_project_1.Models.Train", "Train")
                        .WithMany("Tickets")
                        .HasForeignKey("TrainTR_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Passenger");

                    b.Navigation("Route");

                    b.Navigation("Schedule");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("train_project_1.Models.Class", b =>
                {
                    b.Navigation("Prices");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("train_project_1.Models.Passenger", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("train_project_1.Models.Promotion", b =>
                {
                    b.Navigation("Prices");
                });

            modelBuilder.Entity("train_project_1.Models.Route", b =>
                {
                    b.Navigation("Prices");

                    b.Navigation("Schedules");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("train_project_1.Models.Schedule", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("train_project_1.Models.Train", b =>
                {
                    b.Navigation("Staffs");

                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
