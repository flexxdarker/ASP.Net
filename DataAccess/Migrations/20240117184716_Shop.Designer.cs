﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DataAccess.Model.Data;

#nullable disable

namespace DataAccess.Model.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20240117184716_Shop")]
    partial class Shop
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_02_MVC.Model.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Setup",
                            Description = "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car",
                            Discount = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg",
                            InStock = true,
                            Name = "Logitech g29",
                            Price = 296m
                        },
                        new
                        {
                            Id = 2,
                            Category = "Setup",
                            Description = "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car",
                            Discount = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg",
                            InStock = true,
                            Name = "Logitech g920",
                            Price = 296m
                        },
                        new
                        {
                            Id = 3,
                            Category = "Setup",
                            Description = "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car",
                            Discount = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg",
                            InStock = true,
                            Name = "Logitech g27",
                            Price = 296m
                        },
                        new
                        {
                            Id = 4,
                            Category = "Setup",
                            Description = "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car",
                            Discount = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg",
                            InStock = true,
                            Name = "Logitech g25",
                            Price = 296m
                        },
                        new
                        {
                            Id = 5,
                            Category = "Setup",
                            Description = "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car",
                            Discount = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg",
                            InStock = true,
                            Name = "Logitech g29",
                            Price = 296m
                        },
                        new
                        {
                            Id = 6,
                            Category = "Setup",
                            Description = "Immersive Gaming Experience: Perfect for PlayStation 5, PS4 and PC gaming titles, the Driving Force simulates the feeling of driving a real car with precision steering and pressure-sensitive pedals\r\nPremium Control: The Driving Force feedback racing wheel provides a detailed simulation of driving a real car, with helical gearing delivering smooth, quiet steering and a hand-stitched leather cover\r\nCustomizable Pedals: These pressure-sensitive nonlinear brake pedals provide a responsive, accurate braking feel on a sturdy base - with adjustable pedal faces for finer control\r\n900-Degree Rotation: Lock-to-lock rotation of the Driving Force means you can turn the wheel around two and a half times, hand over hand on wide turns - just like a real F1 race car",
                            Discount = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/61IwZwlTopL._AC_SX466_.jpg",
                            InStock = true,
                            Name = "Logitech g29",
                            Price = 296m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
