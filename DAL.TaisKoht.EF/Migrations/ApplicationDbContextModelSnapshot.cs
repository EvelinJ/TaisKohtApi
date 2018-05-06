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
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressFirstLine");

                    b.Property<string>("Country");

                    b.Property<string>("Locality");

                    b.Property<string>("PostCode");

                    b.Property<string>("Region");

                    b.Property<int>("RestaurantId");

                    b.HasKey("AddressId");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Domain.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<DateTime>("AvailableFrom");

                    b.Property<DateTime>("AvailableTo");

                    b.Property<bool>("Daily");

                    b.Property<decimal>("DailyPrice");

                    b.Property<string>("Description");

                    b.Property<bool>("Gluten");

                    b.Property<decimal>("Kcal");

                    b.Property<bool>("Lactose");

                    b.Property<decimal>("Price");

                    b.Property<int>("PromotionId");

                    b.Property<int>("RestaurantId");

                    b.Property<DateTime>("ServeTime");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.Property<bool>("Vegan");

                    b.Property<decimal>("WeightG");

                    b.HasKey("DishId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId1");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Domain.DishIngredient", b =>
                {
                    b.Property<int>("DishIngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<int>("Amount");

                    b.Property<int>("DishId");

                    b.Property<int>("IngredientId");

                    b.Property<int?>("MenuId");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("DishIngredientId");

                    b.HasIndex("DishId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("MenuId");

                    b.ToTable("DishIngredients");
                });

            modelBuilder.Entity("Domain.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Domain.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("ActiveFrom");

                    b.Property<DateTime>("ActiveTo");

                    b.Property<DateTime>("AddTime");

                    b.Property<int>("PromotionId");

                    b.Property<int>("RepetitionInterval");

                    b.Property<int>("RestaurantId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("MenuId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId1");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Domain.MenuDish", b =>
                {
                    b.Property<int>("MenuDishId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<int>("DishId");

                    b.Property<int>("MenuId");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("MenuDishId");

                    b.HasIndex("DishId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuDishes");
                });

            modelBuilder.Entity("Domain.Promotion", b =>
                {
                    b.Property<int>("PromotionId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("PromotionId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("Domain.RequestLog", b =>
                {
                    b.Property<int>("RequestLogId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddTime");

                    b.Property<int>("DishId");

                    b.Property<string>("Query");

                    b.Property<int>("RestaurantId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("RequestLogId");

                    b.HasIndex("DishId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId1");

                    b.ToTable("RequestLogs");
                });

            modelBuilder.Entity("Domain.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("Email");

                    b.Property<decimal>("LocationLatitude");

                    b.Property<decimal>("LocationLongitude");

                    b.Property<string>("Name");

                    b.Property<int>("PromotionId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("Url");

                    b.HasKey("RestaurantId");

                    b.HasIndex("PromotionId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Domain.RestaurantUser", b =>
                {
                    b.Property<int>("RestaurantUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<int>("DishId");

                    b.Property<int>("RestaurantId");

                    b.Property<DateTime>("StartedAt");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.Property<int?>("UserRoleId");

                    b.HasKey("RestaurantUserId");

                    b.HasIndex("DishId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId1");

                    b.HasIndex("UserRoleId");

                    b.ToTable("RestaurantUsers");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("PromotionId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<int>("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("UserRoleId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PromotionId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessLevel");

                    b.Property<bool>("Active");

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("RoleName");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("UserRoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Address", b =>
                {
                    b.HasOne("Domain.Restaurant", "Restaurant")
                        .WithOne("Address")
                        .HasForeignKey("Domain.Address", "RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict);
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
                        .HasForeignKey("UserId1")
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

            modelBuilder.Entity("Domain.Menu", b =>
                {
                    b.HasOne("Domain.Promotion", "Promotion")
                        .WithMany("Menus")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.User", "User")
                        .WithMany("Menus")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.MenuDish", b =>
                {
                    b.HasOne("Domain.Dish", "Dish")
                        .WithMany("MenuDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.RequestLog", b =>
                {
                    b.HasOne("Domain.Dish", "Dish")
                        .WithMany("RequestLogs")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Restaurant", "Restaurant")
                        .WithMany("RequestLogs")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.User", "User")
                        .WithMany("RequestLogs")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Restaurant", b =>
                {
                    b.HasOne("Domain.Promotion", "Promotion")
                        .WithMany("Restaurants")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.RestaurantUser", b =>
                {
                    b.HasOne("Domain.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Restaurant", "Restaurant")
                        .WithMany("RestaurantUsers")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.User", "User")
                        .WithMany("RestaurantUsers")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.UserRole")
                        .WithMany("RestaurantUsers")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.HasOne("Domain.Promotion", "Promotion")
                        .WithMany("Users")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
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
