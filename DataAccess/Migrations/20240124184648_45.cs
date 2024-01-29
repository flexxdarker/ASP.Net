using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Model.Migrations
{
    /// <inheritdoc />
    public partial class _45 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Attributes_AttributesId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropIndex(
                name: "IX_Products_AttributesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AttributesId",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttributesId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Lenght = table.Column<int>(type: "int", nullable: false),
                    Widht = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "Height", "Lenght", "Widht" },
                values: new object[,]
                {
                    { 1, 270, 278, 260 },
                    { 2, 124, 226, 157 },
                    { 3, 124, 240, 157 },
                    { 4, 124, 240, 157 },
                    { 5, 124, 240, 157 },
                    { 6, 124, 240, 157 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AttributesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AttributesId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AttributesId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AttributesId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AttributesId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AttributesId",
                value: 6);

            migrationBuilder.CreateIndex(
                name: "IX_Products_AttributesId",
                table: "Products",
                column: "AttributesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Attributes_AttributesId",
                table: "Products",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
