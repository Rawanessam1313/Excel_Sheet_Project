using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excel.Data_Access_layer.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExcelData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_or_region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Average = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Social_support = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Health = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Freedom_to_make_life_choices = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Generosity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perceptions_of_corruption = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelData", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExcelData");
        }
    }
}
