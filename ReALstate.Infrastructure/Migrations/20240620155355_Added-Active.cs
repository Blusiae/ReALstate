using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReALstate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsFurnushed",
                table: "Estates",
                newName: "IsFurnished");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Estates",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Estates");

            migrationBuilder.RenameColumn(
                name: "IsFurnished",
                table: "Estates",
                newName: "IsFurnushed");
        }
    }
}
