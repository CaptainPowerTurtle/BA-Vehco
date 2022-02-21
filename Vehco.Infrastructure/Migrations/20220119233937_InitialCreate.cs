using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehco.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardConsecutiveIndex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardReplacementIndex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardRenewalIndex = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "DrtEventEnvelopes",
                columns: table => new
                {
                    EnvelopeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrtEventEnvelopes", x => x.EnvelopeId);
                });

            migrationBuilder.CreateTable(
                name: "DrtEvents",
                columns: table => new
                {
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EnvelopeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrtEvents", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "TachographActivityPeriods",
                columns: table => new
                {
                    EventTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InformationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TachographActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartMileage = table.Column<long>(type: "bigint", nullable: false),
                    EndMileage = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TachographActivityPeriods", x => x.EventTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TachographEvents",
                columns: table => new
                {
                    EventTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InformationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TachographEventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mileage = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TachographEvents", x => x.EventTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TachographInformations",
                columns: table => new
                {
                    InformationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardSlot = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TachographInformations", x => x.InformationId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleIds",
                columns: table => new
                {
                    VehicleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoadBoxId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleIds", x => x.VehicleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "DrtEventEnvelopes");

            migrationBuilder.DropTable(
                name: "DrtEvents");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "TachographActivityPeriods");

            migrationBuilder.DropTable(
                name: "TachographEvents");

            migrationBuilder.DropTable(
                name: "TachographInformations");

            migrationBuilder.DropTable(
                name: "VehicleIds");
        }
    }
}
