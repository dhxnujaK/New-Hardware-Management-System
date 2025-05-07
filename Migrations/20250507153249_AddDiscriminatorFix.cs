using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace New_Hardware_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscriminatorFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SteelRods");

            migrationBuilder.AddColumn<int>(
                name: "Nails_Length",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paint_Brand",
                table: "Items",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nails_Length",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Paint_Brand",
                table: "Items");

            migrationBuilder.CreateTable(
                name: "SteelRods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Length = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SteelRods", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
