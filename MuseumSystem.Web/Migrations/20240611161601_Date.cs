using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuseumSystem.Web.Migrations
{
    /// <inheritdoc />
    public partial class Date : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateEvents");

            migrationBuilder.DropColumn(
                name: "SocialStatusId",
                table: "Records");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Records",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Records");

            migrationBuilder.AddColumn<int>(
                name: "SocialStatusId",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DateEvents",
                columns: table => new
                {
                    IdDateEvent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateEvents", x => x.IdDateEvent);
                    table.ForeignKey(
                        name: "FK_DateEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DateEvents_EventId",
                table: "DateEvents",
                column: "EventId");
        }
    }
}
