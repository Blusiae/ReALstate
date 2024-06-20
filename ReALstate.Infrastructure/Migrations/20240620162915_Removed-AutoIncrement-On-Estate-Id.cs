using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReALstate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedAutoIncrementOnEstateId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Rename the existing Id column to a temporary column
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Estates",
                newName: "TempId");

            // Create the new Id column without the IDENTITY property
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Estates",
                nullable: false);

            // Copy the values from the temporary column to the new Id column
            // This step is optional and depends on whether you need to preserve the data
            migrationBuilder.Sql(
                "UPDATE Estates SET Id = TempId");

            // Drop the temporary column
            migrationBuilder.DropColumn(
                name: "TempId",
                table: "Estates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Reverse the process to restore the IDENTITY property if needed
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Estates",
                newName: "TempId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Estates",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.Sql(
                "UPDATE Estates SET Id = TempId");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "Estates");
        }
    }
}
