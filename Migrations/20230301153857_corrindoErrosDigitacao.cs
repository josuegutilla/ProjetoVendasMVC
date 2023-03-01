using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendasWebMvc.Migrations
{
    /// <inheritdoc />
    public partial class corrindoErrosDigitacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BaseSalry",
                table: "Sellers",
                newName: "BaseSalary");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Sellers",
                newName: "BaseSalry");
        }
    }
}
