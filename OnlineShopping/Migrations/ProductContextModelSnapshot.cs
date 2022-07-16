﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShopping.Models;

namespace OnlineShopping.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShopping.Models.CartItem", b =>
                {
                    b.Property<int>("CTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProdId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SSId")
                        .HasColumnType("int");

                    b.HasKey("CTId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("OnlineShopping.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("ProdId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShopping.Models.OrderDetail", b =>
                {
                    b.Property<int>("OId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("City")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Fname")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Landmark")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Lname")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("OnlineShopping.Models.PaymentDetail", b =>
                {
                    b.Property<int>("PaymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("CardOwnerName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ExpirationDate")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("PaymentDetailId");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("OnlineShopping.Models.Product", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProdCategory")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProdDescription")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProdImage")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("ProdName")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("ProdPrice")
                        .HasColumnType("decimal");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProdId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineShopping.Models.ShoppingSession", b =>
                {
                    b.Property<int>("SSId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ShoppingSessionTotal")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SSId");

                    b.ToTable("ShoppingSessions");
                });

            modelBuilder.Entity("OnlineShopping.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(40)");

                    b.Property<decimal>("PhoneNumber")
                        .HasColumnType("decimal(18,0)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("varchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
