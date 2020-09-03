﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantManagement.Models;

namespace RestaurantManagement.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20200903054947_FoodItemFoodSellAdded")]
    partial class FoodItemFoodSellAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantManagement.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodPrice")
                        .HasColumnType("int");

                    b.Property<string>("FoodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeDelivery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsAvailable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodId");

                    b.ToTable("FoodItems");
                });

            modelBuilder.Entity("RestaurantManagement.Models.FoodSell", b =>
                {
                    b.Property<int>("SellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("WhoOrdered")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SellId");

                    b.ToTable("FoodSells");
                });
#pragma warning restore 612, 618
        }
    }
}