using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReALstate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class databaserebuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estates_EstateOwners_OwnerId",
                table: "Estates");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_EstateOwners_OwnerId1",
                table: "Estates");

            migrationBuilder.DropTable(
                name: "EstateOwners");

            migrationBuilder.DropColumn(
                name: "Address_Country",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "Address_District",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "AverageRoomHeightInMeters",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "EstateType",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "LandAreaInSquareMeters",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "PriceCalculated",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "PriceFinal",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "SuggestedTenantsQuantity",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Address_Floor",
                table: "Estates",
                newName: "Floor");

            migrationBuilder.RenameColumn(
                name: "NumberOfRooms",
                table: "Estates",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "IsFurnished",
                table: "Estates",
                newName: "IsFurnushed");

            migrationBuilder.RenameColumn(
                name: "Address_BuildingNumber",
                table: "Estates",
                newName: "BedroomsCount");

            migrationBuilder.DropColumn(
                name: "YearBuilt",
                table: "Estates");

            migrationBuilder.AddColumn<DateTime>(
                name: "YearBuilt",
                table: "Estates",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId1",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address_Voivodeship",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address_PostalCode",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address_ApartmentNumber",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_Number",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BathroomsCount",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Estates",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasAirConditioning",
                table: "Estates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasAttic",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasBalcony",
                table: "Estates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasBasement",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasGarage",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasGarden",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasHeating",
                table: "Estates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasPool",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasPrivateParkingSpace",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasTerrace",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsElevatorAvailable",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LandInSquaredMeters",
                table: "Estates",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MetersSquared",
                table: "Estates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Value",
                table: "Estates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerId1 = table.Column<int>(type: "int", nullable: false),
                    EstateId = table.Column<int>(type: "int", nullable: false),
                    ProposedPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Offers_Customers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offers_Estates_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CustomerId",
                table: "Offers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CustomerId1",
                table: "Offers",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_EstateId",
                table: "Offers",
                column: "EstateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Customers_OwnerId",
                table: "Estates",
                column: "OwnerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Customers_OwnerId1",
                table: "Estates",
                column: "OwnerId1",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Customers_OwnerId",
                table: "Estates");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Customers_OwnerId1",
                table: "Estates");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropColumn(
                name: "Address_Number",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "BathroomsCount",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasAirConditioning",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasAttic",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasBalcony",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasBasement",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasGarage",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasGarden",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasHeating",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasPool",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasPrivateParkingSpace",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "HasTerrace",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "IsElevatorAvailable",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "LandInSquaredMeters",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "MetersSquared",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Estates");

            migrationBuilder.RenameColumn(
                name: "Floor",
                table: "Estates",
                newName: "Address_Floor");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Estates",
                newName: "NumberOfRooms");

            migrationBuilder.RenameColumn(
                name: "IsFurnushed",
                table: "Estates",
                newName: "IsFurnished");

            migrationBuilder.RenameColumn(
                name: "BedroomsCount",
                table: "Estates",
                newName: "Address_BuildingNumber");

            migrationBuilder.AlterColumn<int>(
                name: "YearBuilt",
                table: "Estates",
                type: "int",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId1",
                table: "Estates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Estates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_Voivodeship",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_PostalCode",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Address_ApartmentNumber",
                table: "Estates",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Address_Country",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_District",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AverageRoomHeightInMeters",
                table: "Estates",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstateType",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LandAreaInSquareMeters",
                table: "Estates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceCalculated",
                table: "Estates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceFinal",
                table: "Estates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "SuggestedTenantsQuantity",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EstateOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateOwners", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_EstateOwners_OwnerId",
                table: "Estates",
                column: "OwnerId",
                principalTable: "EstateOwners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_EstateOwners_OwnerId1",
                table: "Estates",
                column: "OwnerId1",
                principalTable: "EstateOwners",
                principalColumn: "Id");
        }
    }
}
