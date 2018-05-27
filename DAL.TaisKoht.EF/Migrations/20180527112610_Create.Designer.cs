﻿// <auto-generated />
using DAL.TaisKoht.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DAL.TaisKoht.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180527112610_Create")]
    partial class Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("AddressFirstLine")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<string>("Locality")
                        .HasMaxLength(50);

                    b.Property<decimal?>("LocationLatitude")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<decimal?>("LocationLongitude")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<string>("PostCode")
                        .HasMaxLength(20);

                    b.Property<string>("Region")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Domain.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<DateTime?>("AvailableFrom");

                    b.Property<DateTime?>("AvailableTo");

                    b.Property<bool?>("Daily");

                    b.Property<decimal?>("DailyPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<bool?>("GlutenFree");

                    b.Property<decimal?>("Kcal")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<bool?>("LactoseFree");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int?>("PromotionId");

                    b.Property<int>("RestaurantId");

                    b.Property<DateTime?>("ServeTime");

                    b.Property<string>("Title")
                        .HasMaxLength(40);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<bool?>("Vegan");

                    b.Property<decimal?>("WeightG")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("DishId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Domain.DishIngredient", b =>
                {
                    b.Property<int>("IngredientId");

                    b.Property<int>("DishId");

                    b.Property<DateTime>("AddTime");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int?>("MenuId");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("IngredientId", "DishId");

                    b.HasIndex("DishId");

                    b.HasIndex("MenuId");

                    b.ToTable("DishIngredients");
                });

            modelBuilder.Entity("Domain.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("AmountUnit")
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("IngredientId");

                    b.HasIndex("UserId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Domain.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime?>("ActiveFrom");

                    b.Property<DateTime?>("ActiveTo");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int?>("PromotionId");

                    b.Property<int?>("RepetitionInterval");

                    b.Property<int>("RestaurantId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("MenuId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Domain.MenuDish", b =>
                {
                    b.Property<int>("MenuId");

                    b.Property<int>("DishId");

                    b.Property<DateTime>("AddTime");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("MenuId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("MenuDishes");
                });

            modelBuilder.Entity("Domain.Promotion", b =>
                {
                    b.Property<int>("PromotionId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("ClassName")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<DateTime?>("ValidTo");

                    b.HasKey("PromotionId");

                    b.HasIndex("UserId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("Domain.RatingLog", b =>
                {
                    b.Property<int>("RatingLogId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("Comment")
                        .HasMaxLength(2000);

                    b.Property<int?>("DishId");

                    b.Property<int>("Rating");

                    b.Property<int?>("RestaurantId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("RatingLogId");

                    b.HasIndex("DishId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("RatingLogs");
                });

            modelBuilder.Entity("Domain.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<int?>("AddressId");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("PromotionId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("Url")
                        .HasMaxLength(255);

                    b.HasKey("RestaurantId");

                    b.HasIndex("AddressId");

                    b.HasIndex("PromotionId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Domain.RestaurantUser", b =>
                {
                    b.Property<int>("RestaurantId");

                    b.Property<string>("UserId");

                    b.Property<DateTime>("AddTime");

                    b.Property<DateTime?>("StartedAt");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("RestaurantId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RestaurantUsers");
                });

            modelBuilder.Entity("Domain.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoleId");

                    b.Property<string>("AccessLevel")
                        .HasMaxLength(50);

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId");

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoleClaimId");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserClaimId");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.Property<DateTime>("AddTime");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("Domain.Dish", b =>
                {
                    b.HasOne("Domain.Promotion", "Promotion")
                        .WithMany("Dishes")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Restaurant", "Restaurant")
                        .WithMany("Dishes")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.User", "User")
                        .WithMany("Dishes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.DishIngredient", b =>
                {
                    b.HasOne("Domain.Dish", "Dish")
                        .WithMany("DishIngredients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Ingredient", "Ingredient")
                        .WithMany("DishIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Menu")
                        .WithMany("DishIngredients")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Ingredient", b =>
                {
                    b.HasOne("Domain.User", "User")
                        .WithMany("Ingredients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Menu", b =>
                {
                    b.HasOne("Domain.Promotion", "Promotion")
                        .WithMany("Menus")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Restaurant", "Restaurant")
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.User", "User")
                        .WithMany("Menus")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.MenuDish", b =>
                {
                    b.HasOne("Domain.Dish", "Dish")
                        .WithMany("MenuDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Menu", "Menu")
                        .WithMany("MenuDishes")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Promotion", b =>
                {
                    b.HasOne("Domain.User", "User")
                        .WithMany("Promotions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.RatingLog", b =>
                {
                    b.HasOne("Domain.Dish", "Dish")
                        .WithMany("RatingLogs")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Restaurant", "Restaurant")
                        .WithMany("RatingLogs")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.User", "User")
                        .WithMany("RatingLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Restaurant", b =>
                {
                    b.HasOne("Domain.Address", "Address")
                        .WithMany("Restaurant")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Promotion", "Promotion")
                        .WithMany("Restaurants")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.RestaurantUser", b =>
                {
                    b.HasOne("Domain.Restaurant", "Restaurant")
                        .WithMany("RestaurantUsers")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.User", "User")
                        .WithMany("RestaurantUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Domain.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Domain.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
