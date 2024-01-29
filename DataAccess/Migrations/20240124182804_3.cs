using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Model.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityProduct");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

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
                    Widht = table.Column<int>(type: "int", nullable: false),
                    Lenght = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "AttributesId", "ImageUrl" },
                values: new object[] { 1, "https://resource.logitechg.com/w_692,c_lpad,ar_4:3,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/gaming/en/products/drivingforce/g920-gallery-3-1.png?v=1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AttributesId", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 2, 2, "The torque of 16 Nm and the professional direct drive (Direct Drive) can meet the needs of all racers in games and training!", "https://simracinggear.com.ua/wp-content/uploads/2023/12/%D0%A0%D1%83%D0%BB%D1%8C%D0%BE%D0%B2%D0%B0-%D0%B1%D0%B0%D0%B7%D0%B0-Moza-R12.png", "Moza R12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AttributesId", "CategoryId", "Description", "ImageUrl", "Name", "Rating" },
                values: new object[] { 3, 2, "The torque of 9 Nm and the professional direct drive (Direct Drive) can meet the needs of most racers in games and training!", "https://simracinggear.com.ua/wp-content/uploads/2023/05/MOZA-R9-Wheel-Base1.webp", "Moza R9 V2", 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AttributesId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Rating" },
                values: new object[] { 4, 3, "The MOZA ES, a masterfully crafted sim racing steering wheel, is ready to make you jump into an immersive racing experience. Enjoy the luxury of hand-made stitch leather grips, combining comfort and style.", "https://simracinggear.com.ua/wp-content/uploads/2023/05/ES-Steering-Wheel-1.png", "Moza ES Steering Wheel", 129m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AttributesId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Rating" },
                values: new object[] { 5, 3, "Introducing the MOZA KS Sim Racing Steering Wheel, a brand-new offering designed specifically for GT enthusiasts. This 300mm butterfly-style GT wheel brings the thrill of the track to your fingertips.", "https://i0.wp.com/mozaracing.com/wp-content/uploads/2023/06/KS-Steering-Wheel-1.webp?fit=1000%2C1000&quality=80&ssl=1", "KS Steering Wheel", 279m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AttributesId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Rating" },
                values: new object[] { 6, 4, "Master your speed like a pro with the MOZA CRP Pedals. Featuring a 3-stage clutch for superior control. The CNC aluminum pedal assembly ensures sturdiness and reliability. Adjust the angle to suit your preference and optimize your performance.", "https://i0.wp.com/mozaracing.com/wp-content/uploads/2021/06/CRP-Product-1.webp?fit=1000%2C1000&quality=80&ssl=1", "CRP Pedals", 459m, 4 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityProduct",
                columns: table => new
                {
                    CitiesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityProduct", x => new { x.CitiesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CityProduct_City_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Rivne" },
                    { 2, "Kyiv" },
                    { 3, "Lviv" },
                    { 4, "Cherksy" },
                    { 5, "Uzhorod" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, "Realistic control console\r\nDriving Force technology is compatible with the latest racing games for Xbox One. Once you've tried the Driving Force game wheel, you won't want to go back to a regular controller. The G920 Driving Force can also be used with some PC games after pre-configuration with Logitech Gaming Software.\r\n\r\nFeel every tire roll, braking slack, or weight shift\r\nFeel the grip of the tires on the road in every turn and on any type of surface, as well as the effects of understeer or oversteer, skidding and more. A powerful force feedback mechanism with a dual electric motor realistically reproduces force effects and ensures the accuracy of the player's response.", "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg", "Logitech g920" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Rating" },
                values: new object[] { 1, "The G27 Racing Wheel is a legendary steering wheel from Logitech that will allow you to feel like you are on a race track or rally course and enjoy driving powerful cars.\r\n\r\nEnjoy thrilling, hair-raising turns as you feel the tires lose grip and bounce over every bump in the road. Adjustable dual-motor effort feedback accurately and realistically simulates a dizzying race to the very finish line.\r\n\r\nEnjoy the power of effortless feedback without road noise, thanks to a smooth and quiet gearbox similar to that used in car transmissions.", "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg", "Logitech g27", 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Rating" },
                values: new object[] { 1, "high quality materials. Handmade components. A team of passionate racing fans set a goal: to provide the most realistic experience possible. With the Logitech® G25 Racing Wheel, you can experience a different kind of racing simulator experience, and we want you to experience it. The unique force feedback mechanism with the G25 dual electric motor provides colorful and realistic effects when steering the hand-crafted leather-wrapped wheel. It provides a realistic feeling that in front of an obstacle the steering wheel is higher or not enough.", "https://c3.klipartz.com/pngpicture/362/750/sticker-png-logitech-g-series-icons-g25-racing-wheel-thumbnail.png", "Logitech g25", 296m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Rating" },
                values: new object[] { 2, "The torque of 16 Nm and the professional direct drive (Direct Drive) can meet the needs of all racers in games and training!", "https://simracinggear.com.ua/wp-content/uploads/2023/12/%D0%A0%D1%83%D0%BB%D1%8C%D0%BE%D0%B2%D0%B0-%D0%B1%D0%B0%D0%B7%D0%B0-Moza-R12.png", "Moza R12", 296m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Rating" },
                values: new object[] { 2, "The torque of 9 Nm and the professional direct drive (Direct Drive) can meet the needs of most racers in games and training!", "https://simracinggear.com.ua/wp-content/uploads/2023/05/MOZA-R9-Wheel-Base1.webp", "Moza R9 V2", 296m, 5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImageUrl", "InStock", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 7, 3, "The MOZA ES, a masterfully crafted sim racing steering wheel, is ready to make you jump into an immersive racing experience. Enjoy the luxury of hand-made stitch leather grips, combining comfort and style.", 0, "https://simracinggear.com.ua/wp-content/uploads/2023/05/ES-Steering-Wheel-1.png", true, "Moza ES Steering Wheel", 129m, 5 },
                    { 8, 3, "Introducing the MOZA KS Sim Racing Steering Wheel, a brand-new offering designed specifically for GT enthusiasts. This 300mm butterfly-style GT wheel brings the thrill of the track to your fingertips.", 0, "https://i0.wp.com/mozaracing.com/wp-content/uploads/2023/06/KS-Steering-Wheel-1.webp?fit=1000%2C1000&quality=80&ssl=1", true, "KS Steering Wheel", 279m, 5 },
                    { 9, 4, "Master your speed like a pro with the MOZA CRP Pedals. Featuring a 3-stage clutch for superior control. The CNC aluminum pedal assembly ensures sturdiness and reliability. Adjust the angle to suit your preference and optimize your performance.", 0, "https://i0.wp.com/mozaracing.com/wp-content/uploads/2021/06/CRP-Product-1.webp?fit=1000%2C1000&quality=80&ssl=1", true, "CRP Pedals", 459m, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityProduct_ProductsId",
                table: "CityProduct",
                column: "ProductsId");
        }
    }
}
