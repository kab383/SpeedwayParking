using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpeedwayParking.Data.Migrations
{
    public partial class Addedalltables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entrance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surface = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LotStandardConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfAutoSpaces = table.Column<int>(type: "int", nullable: false),
                    NumberOfRvSpaces = table.Column<int>(type: "int", nullable: false),
                    NumberOfMotorcycleSpaces = table.Column<int>(type: "int", nullable: false),
                    NumberOfAdaSpaces = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotStandardConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "EventLots",
                columns: table => new
                {
                    LotId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    DailyParking = table.Column<bool>(type: "bit", nullable: false),
                    OvernightParking = table.Column<bool>(type: "bit", nullable: false),
                    Tailgating = table.Column<bool>(type: "bit", nullable: false),
                    Electricity30a = table.Column<bool>(type: "bit", nullable: false),
                    Electricity50a = table.Column<bool>(type: "bit", nullable: false),
                    Shower = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfAutoSpaces = table.Column<int>(type: "int", nullable: false),
                    NumberOfRvSpaces = table.Column<int>(type: "int", nullable: false),
                    NumberOfMotorcycleSpaces = table.Column<int>(type: "int", nullable: false),
                    NumberOfAdaSpaces = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLots", x => new { x.LotId, x.EventId });
                    table.ForeignKey(
                        name: "FK_EventLots_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventLots_Lots_LotId",
                        column: x => x.LotId,
                        principalTable: "Lots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Purchased = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Lot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Event = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfSale = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LotId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    WishlistUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Wishlists_WishlistUserId",
                        column: x => x.WishlistUserId,
                        principalTable: "Wishlists",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventLots_EventId",
                table: "EventLots",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLots_LotId",
                table: "EventLots",
                column: "LotId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_WishlistUserId",
                table: "Tickets",
                column: "WishlistUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventLots");

            migrationBuilder.DropTable(
                name: "LotStandardConfigs");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Lots");

            migrationBuilder.DropTable(
                name: "Wishlists");
        }
    }
}
