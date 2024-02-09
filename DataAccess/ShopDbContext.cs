using DataAccess.Model.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.Model.Data
{
    public class ShopDbContext : IdentityDbContext<User>
	{
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public ShopDbContext() { }
        public ShopDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(x => x.Category).WithMany(x => x.Poducts).HasForeignKey(x => x.CategoryId);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product() { Id = 1, Name = "Logitech g29",  CategoryId = 1, Discount = 0, Price = 296, ImageUrl = "https://content.rozetka.com.ua/goods/images/big/322365492.jpg", InStock = true, Rating = 3, Description = "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car" },
                new Product() { Id = 2, Name = "Moza R12",CategoryId = 2, Discount = 0, Price = 296, ImageUrl = "https://simracinggear.com.ua/wp-content/uploads/2023/12/%D0%A0%D1%83%D0%BB%D1%8C%D0%BE%D0%B2%D0%B0-%D0%B1%D0%B0%D0%B7%D0%B0-Moza-R12.png", InStock = true, Rating = 4, Description = "The torque of 16 Nm and the professional direct drive (Direct Drive) can meet the needs of all racers in games and training!" },
                new Product() { Id = 3, Name = "Moza R9 V2",CategoryId = 2, Discount = 0, Price = 296, ImageUrl = "https://simracinggear.com.ua/wp-content/uploads/2023/05/MOZA-R9-Wheel-Base1.webp", InStock = true, Rating = 5, Description = "The torque of 9 Nm and the professional direct drive (Direct Drive) can meet the needs of most racers in games and training!" },
                new Product() { Id = 4, Name = "Moza ES Steering Wheel",CategoryId = 3, Discount = 0, Price = 129, ImageUrl = "https://simracinggear.com.ua/wp-content/uploads/2023/05/ES-Steering-Wheel-1.png", InStock = true, Rating = 5, Description = "The MOZA ES, a masterfully crafted sim racing steering wheel, is ready to make you jump into an immersive racing experience. Enjoy the luxury of hand-made stitch leather grips, combining comfort and style."},
                new Product() { Id = 5, Name = "KS Steering Wheel",CategoryId = 3, Discount = 0, Price = 279, ImageUrl = "https://i0.wp.com/mozaracing.com/wp-content/uploads/2023/06/KS-Steering-Wheel-1.webp?fit=1000%2C1000&quality=80&ssl=1", InStock = true, Rating = 5, Description = "Introducing the MOZA KS Sim Racing Steering Wheel, a brand-new offering designed specifically for GT enthusiasts. This 300mm butterfly-style GT wheel brings the thrill of the track to your fingertips."},
                new Product() { Id = 6, Name = "CRP Pedals", CategoryId = 4,Discount = 0, Price = 459, ImageUrl = "https://i0.wp.com/mozaracing.com/wp-content/uploads/2021/06/CRP-Product-1.webp?fit=1000%2C1000&quality=80&ssl=1", InStock = true, Rating = 4, Description = "Master your speed like a pro with the MOZA CRP Pedals. Featuring a 3-stage clutch for superior control. The CNC aluminum pedal assembly ensures sturdiness and reliability. Adjust the angle to suit your preference and optimize your performance."}
            });
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Bundle"},
                new Category() { Id = 2, Name = "Wheel Base"},
                new Category() { Id = 3, Name = "Steering Wheel"},
                new Category() { Id = 4, Name = "Pedals"}
            });
            //modelBuilder.Entity<Attributes>().HasData(new[]
            //{
            //    new Attributes() { Id = 1, Height = 270, Widht = 260, Lenght = 278},
            //    new Attributes() { Id = 2, Height = 124, Widht = 157, Lenght = 226},
            //    new Attributes() { Id = 3, Height = 124, Widht = 157, Lenght = 240},
            //    new Attributes() { Id = 4, Height = 124, Widht = 157, Lenght = 240},
            //    new Attributes() { Id = 5, Height = 124, Widht = 157, Lenght = 240},
            //    new Attributes() { Id = 6, Height = 124, Widht = 157, Lenght = 240},
            //});
        }
    }
}
