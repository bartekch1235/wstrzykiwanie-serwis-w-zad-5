using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wstrzykiwanie_serwisów_zad_5.Migrations
{
    /// <inheritdoc />
    public partial class _1121 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Person");
        }
    }
}
