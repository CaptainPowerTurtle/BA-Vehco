﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vehco.Repository;

#nullable disable

namespace Vehco.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Vehco.Repository.Models.DRTEvent.Card", b =>
                {
                    b.Property<string>("CardId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CardConsecutiveIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardRenewalIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardReplacementIndex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Vehco.Repository.Models.DRTEvent.DRTEvent", b =>
                {
                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EnvelopeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("DrtEvents");
                });

            modelBuilder.Entity("Vehco.Repository.Models.DRTEvent.DRTEventEnvelope", b =>
                {
                    b.Property<string>("EnvelopeId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EnvelopeId");

                    b.ToTable("DrtEventEnvelopes");
                });

            modelBuilder.Entity("Vehco.Repository.Models.DRTEvent.TachographActivityPeriod", b =>
                {
                    b.Property<string>("EventTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DriverId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EndMileage")
                        .HasColumnType("bigint");

                    b.Property<string>("EndPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("InformationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StartMileage")
                        .HasColumnType("bigint");

                    b.Property<string>("StartPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("TachographActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventTypeId");

                    b.ToTable("TachographActivityPeriods");
                });

            modelBuilder.Entity("Vehco.Repository.Models.DRTEvent.TachographEvent", b =>
                {
                    b.Property<string>("EventTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DriverId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mileage")
                        .HasColumnType("bigint");

                    b.Property<string>("PositionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TachographEventType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("VehicleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventTypeId");

                    b.ToTable("TachographEvents");
                });

            modelBuilder.Entity("Vehco.Repository.Models.DRTEvent.TachographInformation", b =>
                {
                    b.Property<string>("InformationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CardId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardSlot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InformationId");

                    b.ToTable("TachographInformations");
                });

            modelBuilder.Entity("Vehco.Repository.Models.General.Driver", b =>
                {
                    b.Property<string>("DriverId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Vehco.Repository.Models.General.Position", b =>
                {
                    b.Property<string>("PositionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Vehco.Repository.Models.General.Vehicle", b =>
                {
                    b.Property<string>("VehicleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicensePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoadBoxId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.ToTable("VehicleIds");
                });
#pragma warning restore 612, 618
        }
    }
}
