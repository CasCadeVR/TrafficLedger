using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrafficLedger.Context.Migrations
{
    /// <inheritdoc />
    public partial class tryingToFigureOutAttachmentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_ProcessedById",
                table: "Payment");

            migrationBuilder.AddColumn<Guid>(
                name: "AttachmentId",
                table: "DriverLicense",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AttachmentId",
                table: "Driver",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FineId",
                table: "Attachment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TransportId",
                table: "Attachment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicense_AttachmentId",
                table: "DriverLicense",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_AttachmentId",
                table: "Driver",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_FineId",
                table: "Attachment",
                column: "FineId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_TransportId",
                table: "Attachment",
                column: "TransportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_Fine_FineId",
                table: "Attachment",
                column: "FineId",
                principalTable: "Fine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_Transport_TransportId",
                table: "Attachment",
                column: "TransportId",
                principalTable: "Transport",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Attachment_AttachmentId",
                table: "Driver",
                column: "AttachmentId",
                principalTable: "Attachment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLicense_Attachment_AttachmentId",
                table: "DriverLicense",
                column: "AttachmentId",
                principalTable: "Attachment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_ProcessedById",
                table: "Payment",
                column: "ProcessedById",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_Fine_FineId",
                table: "Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_Transport_TransportId",
                table: "Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Attachment_AttachmentId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverLicense_Attachment_AttachmentId",
                table: "DriverLicense");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_ProcessedById",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_DriverLicense_AttachmentId",
                table: "DriverLicense");

            migrationBuilder.DropIndex(
                name: "IX_Driver_AttachmentId",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "IX_Attachment_FineId",
                table: "Attachment");

            migrationBuilder.DropIndex(
                name: "IX_Attachment_TransportId",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "DriverLicense");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "FineId",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "TransportId",
                table: "Attachment");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_ProcessedById",
                table: "Payment",
                column: "ProcessedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
