using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrafficLedger.Context.Migrations
{
    /// <inheritdoc />
    public partial class changedParkingZoneCordsLinkName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GeometryWkt",
                table: "ParkingZone",
                newName: "CoordinatesLink");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoordinatesLink",
                table: "ParkingZone",
                newName: "GeometryWkt");
        }
    }
}
