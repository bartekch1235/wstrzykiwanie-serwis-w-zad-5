using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wstrzykiwanie_serwisów_zad_5.Migrations
{
    /// <inheritdoc />
    public partial class _11211 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "Person");
        }
    }
}
