using _02_MVC.Model.Data.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace _02_MVC.Model.Data
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ShopDbContext()
        {

        }
        public ShopDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product() { Id = 1, Name = "Logitech g29", CategoryId = 1, Discount = 0, Price = 296, ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg", InStock = true, Rating = 3, Description = "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car" },
                new Product() { Id = 2, Name = "Logitech g920", CategoryId = 1, Discount = 0, Price = 296, ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg", InStock = true, Rating = 4, Description = "Realistic control console\r\nDriving Force technology is compatible with the latest racing games for Xbox One. Once you've tried the Driving Force game wheel, you won't want to go back to a regular controller. The G920 Driving Force can also be used with some PC games after pre-configuration with Logitech Gaming Software.\r\n\r\nFeel every tire roll, braking slack, or weight shift\r\nFeel the grip of the tires on the road in every turn and on any type of surface, as well as the effects of understeer or oversteer, skidding and more. A powerful force feedback mechanism with a dual electric motor realistically reproduces force effects and ensures the accuracy of the player's response." },
                new Product() { Id = 3, Name = "Logitech g27", CategoryId = 1, Discount = 0, Price = 296, ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg", InStock = true, Rating = 3, Description = "The G27 Racing Wheel is a legendary steering wheel from Logitech that will allow you to feel like you are on a race track or rally course and enjoy driving powerful cars.\r\n\r\nEnjoy thrilling, hair-raising turns as you feel the tires lose grip and bounce over every bump in the road. Adjustable dual-motor effort feedback accurately and realistically simulates a dizzying race to the very finish line.\r\n\r\nEnjoy the power of effortless feedback without road noise, thanks to a smooth and quiet gearbox similar to that used in car transmissions." },
                new Product() { Id = 4, Name = "Logitech g25", CategoryId = 1, Discount = 0, Price = 296, ImageUrl = "https://c3.klipartz.com/pngpicture/362/750/sticker-png-logitech-g-series-icons-g25-racing-wheel-thumbnail.png", InStock = true, Rating = 4, Description = "high quality materials. Handmade components. A team of passionate racing fans set a goal: to provide the most realistic experience possible. With the Logitech® G25 Racing Wheel, you can experience a different kind of racing simulator experience, and we want you to experience it. The unique force feedback mechanism with the G25 dual electric motor provides colorful and realistic effects when steering the hand-crafted leather-wrapped wheel. It provides a realistic feeling that in front of an obstacle the steering wheel is higher or not enough." },
                new Product() { Id = 5, Name = "Moza R12", CategoryId = 2, Discount = 0, Price = 296, ImageUrl = "https://simracinggear.com.ua/wp-content/uploads/2023/12/%D0%A0%D1%83%D0%BB%D1%8C%D0%BE%D0%B2%D0%B0-%D0%B1%D0%B0%D0%B7%D0%B0-Moza-R12.png", InStock = true, Rating = 4, Description = "The torque of 16 Nm and the professional direct drive (Direct Drive) can meet the needs of all racers in games and training!" },
                new Product() { Id = 6, Name = "Moza R9 V2", CategoryId = 2, Discount = 0, Price = 296, ImageUrl = "https://simracinggear.com.ua/wp-content/uploads/2023/05/MOZA-R9-Wheel-Base1.webp", InStock = true, Rating = 5, Description = "The torque of 9 Nm and the professional direct drive (Direct Drive) can meet the needs of most racers in games and training!" },
                new Product() { Id = 7, Name = "Moza ES Steering Wheel", CategoryId = 3, Discount = 0, Price = 129, ImageUrl = "https://simracinggear.com.ua/wp-content/uploads/2023/05/ES-Steering-Wheel-1.png", InStock = true, Rating = 5, Description = "The MOZA ES, a masterfully crafted sim racing steering wheel, is ready to make you jump into an immersive racing experience. Enjoy the luxury of hand-made stitch leather grips, combining comfort and style."},
                new Product() { Id = 8, Name  = "KS Steering Wheel", CategoryId = 3, Discount = 0, Price = 279, ImageUrl = "https://i0.wp.com/mozaracing.com/wp-content/uploads/2023/06/KS-Steering-Wheel-1.webp?fit=1000%2C1000&quality=80&ssl=1", InStock = true, Rating = 5, Description = "Introducing the MOZA KS Sim Racing Steering Wheel, a brand-new offering designed specifically for GT enthusiasts. This 300mm butterfly-style GT wheel brings the thrill of the track to your fingertips."},
                new Product() { Id = 9, Name = "CRP Pedals", CategoryId =4, Discount =0, Price = 459, ImageUrl = "https://i0.wp.com/mozaracing.com/wp-content/uploads/2021/06/CRP-Product-1.webp?fit=1000%2C1000&quality=80&ssl=1", InStock = true, Rating = 4, Description = "Master your speed like a pro with the MOZA CRP Pedals. Featuring a 3-stage clutch for superior control. The CNC aluminum pedal assembly ensures sturdiness and reliability. Adjust the angle to suit your preference and optimize your performance."}
            });
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Bundles"},
                new Category() { Id = 2, Name = "Wheel Base"},
                new Category() { Id = 3, Name = "Steering Wheels"},
                new Category() { Id = 4, Name = "Pedals"}
            });
        }
        
    }
}
