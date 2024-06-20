using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReALstate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAutoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Estates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Estates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
