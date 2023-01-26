using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherApp2.Migrations
{
    public partial class GuidToId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "WeatherForecasts",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WeatherForecasts",
                newName: "Guid");
        }
    }
}
