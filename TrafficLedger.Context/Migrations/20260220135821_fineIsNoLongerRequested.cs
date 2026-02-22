using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrafficLedger.Context.Migrations
{
    /// <inheritdoc />
    public partial class fineIsNoLongerRequested : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fine_User_ProcessedById",
                table: "Fine");

            migrationBuilder.DropIndex(
                name: "IX_Fine_ProcessedById",
                table: "Fine");

            migrationBuilder.DropColumn(
                name: "Commentary",
                table: "Fine");

            migrationBuilder.DropColumn(
                name: "ProcessedAt",
                table: "Fine");

            migrationBuilder.DropColumn(
                name: "ProcessedById",
                table: "Fine");

            migrationBuilder.AlterColumn<Guid>(
                name: "AttachmentId",
                table: "DriverLicense",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AttachmentId",
                table: "Driver",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Commentary",
                table: "Fine",
                type: "nvarchar(2047)",
                maxLength: 2047,
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ProcessedAt",
                table: "Fine",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProcessedById",
                table: "Fine",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AttachmentId",
                table: "DriverLicense",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AttachmentId",
                table: "Driver",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Fine_ProcessedById",
                table: "Fine",
                column: "ProcessedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Fine_User_ProcessedById",
                table: "Fine",
                column: "ProcessedById",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
