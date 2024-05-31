﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240531044329_Loc")]
    partial class Loc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Application.Entities.Auth.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique()
                        .HasFilter("[OrderId] IS NOT NULL");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Application.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ReserveQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReserveTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Application.ValueObjects.DeliveryDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("DeliveryDetail");
                });

            modelBuilder.Entity("Application.ValueObjects.PaymentDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CVC")
                        .HasColumnType("int");

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TransactionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("PaymentDetail");
                });

            modelBuilder.Entity("CartItem", b =>
                {
                    b.Property<Guid>("CartsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartsId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Cart", b =>
                {
                    b.HasOne("Application.Entities.Ordering.Order", null)
                        .WithOne("Cart")
                        .HasForeignKey("Application.Entities.Ordering.Cart", "OrderId");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Order", b =>
                {
                    b.HasOne("Application.Entities.Auth.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Application.Entities.Reservation", b =>
                {
                    b.HasOne("Application.Entities.Auth.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Application.ValueObjects.DeliveryDetail", b =>
                {
                    b.HasOne("Application.Entities.Ordering.Order", null)
                        .WithOne("DeliveryDetail")
                        .HasForeignKey("Application.ValueObjects.DeliveryDetail", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Application.ValueObjects.PaymentDetail", b =>
                {
                    b.HasOne("Application.Entities.Ordering.Order", null)
                        .WithOne("PaymentDetail")
                        .HasForeignKey("Application.ValueObjects.PaymentDetail", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CartItem", b =>
                {
                    b.HasOne("Application.Entities.Ordering.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Application.Entities.Ordering.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Application.Entities.Ordering.Order", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("DeliveryDetail");

                    b.Navigation("PaymentDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
