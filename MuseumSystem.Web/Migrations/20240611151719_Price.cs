using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuseumSystem.Web.Migrations
{
    /// <inheritdoc />
    public partial class Price : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_SocialStatuses_SocialStatusId",
                table: "Records");

            migrationBuilder.DropTable(
                name: "SocialStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Records_SocialStatusId",
                table: "Records");

            migrationBuilder.AddColumn<decimal>(
                name: "FullPrice",
                table: "Events",
                type: "decimal(8,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PreferentialPrice",
                table: "Events",
                type: "decimal(8,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RetirementPrice",
                table: "Events",
                type: "decimal(8,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullPrice",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PreferentialPrice",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "RetirementPrice",
                table: "Events");

            migrationBuilder.CreateTable(
                name: "SocialStatuses",
                columns: table => new
                {
                    IdSocialStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSocialStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialStatuses", x => x.IdSocialStatus);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_SocialStatusId",
                table: "Records",
                column: "SocialStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_SocialStatuses_SocialStatusId",
                table: "Records",
                column: "SocialStatusId",
                principalTable: "SocialStatuses",
                principalColumn: "IdSocialStatus",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
