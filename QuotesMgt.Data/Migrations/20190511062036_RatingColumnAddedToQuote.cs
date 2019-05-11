using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotesMgt.Data.Migrations
{
    public partial class RatingColumnAddedToQuote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Quotes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Quotes");
        }
    }
}
