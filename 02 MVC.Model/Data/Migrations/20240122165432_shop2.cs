using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _02_MVC.Model.Migrations
{
    /// <inheritdoc />
    public partial class shop2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bundles" },
                    { 2, "Wheel Base" },
                    { 3, "Steering Wheels" },
                    { 4, "Pedals" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Rating" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Rating" },
                values: new object[] { 1, "Realistic control console\r\nDriving Force technology is compatible with the latest racing games for Xbox One. Once you've tried the Driving Force game wheel, you won't want to go back to a regular controller. The G920 Driving Force can also be used with some PC games after pre-configuration with Logitech Gaming Software.\r\n\r\nFeel every tire roll, braking slack, or weight shift\r\nFeel the grip of the tires on the road in every turn and on any type of surface, as well as the effects of understeer or oversteer, skidding and more. A powerful force feedback mechanism with a dual electric motor realistically reproduces force effects and ensures the accuracy of the player's response.", 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Rating" },
                values: new object[] { 1, "The G27 Racing Wheel is a legendary steering wheel from Logitech that will allow you to feel like you are on a race track or rally course and enjoy driving powerful cars.\r\n\r\nEnjoy thrilling, hair-raising turns as you feel the tires lose grip and bounce over every bump in the road. Adjustable dual-motor effort feedback accurately and realistically simulates a dizzying race to the very finish line.\r\n\r\nEnjoy the power of effortless feedback without road noise, thanks to a smooth and quiet gearbox similar to that used in car transmissions.", 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Rating" },
                values: new object[] { 1, "high quality materials. Handmade components. A team of passionate racing fans set a goal: to provide the most realistic experience possible. With the Logitech® G25 Racing Wheel, you can experience a different kind of racing simulator experience, and we want you to experience it. The unique force feedback mechanism with the G25 dual electric motor provides colorful and realistic effects when steering the hand-crafted leather-wrapped wheel. It provides a realistic feeling that in front of an obstacle the steering wheel is higher or not enough.", "https://c3.klipartz.com/pngpicture/362/750/sticker-png-logitech-g-series-icons-g25-racing-wheel-thumbnail.png", 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Rating" },
                values: new object[] { 2, "The torque of 16 Nm and the professional direct drive (Direct Drive) can meet the needs of all racers in games and training!", "https://simracinggear.com.ua/wp-content/uploads/2023/12/%D0%A0%D1%83%D0%BB%D1%8C%D0%BE%D0%B2%D0%B0-%D0%B1%D0%B0%D0%B7%D0%B0-Moza-R12.png", "Moza R12", 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Rating" },
                values: new object[] { 2, "The torque of 9 Nm and the professional direct drive (Direct Drive) can meet the needs of most racers in games and training!", "https://simracinggear.com.ua/wp-content/uploads/2023/05/MOZA-R9-Wheel-Base1.webp", "Moza R9 V2", 5 });

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
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

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

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Setup");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description" },
                values: new object[] { "Setup", "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description" },
                values: new object[] { "Setup", "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "ImageUrl" },
                values: new object[] { "Setup", "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car", "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "ImageUrl", "Name" },
                values: new object[] { "Setup", "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car", "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg", "Logitech g29" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "ImageUrl", "Name" },
                values: new object[] { "Setup", "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car", "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg", "Logitech g29" });
        }
    }
}
