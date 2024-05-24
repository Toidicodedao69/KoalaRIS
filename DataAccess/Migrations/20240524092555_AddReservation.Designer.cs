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
    [Migration("20240524092555_AddReservation")]
    partial class AddReservation
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

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeliverable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Cart", b =>
                {
                    b.HasOne("Application.Entities.Ordering.Order", null)
                        .WithOne("Cart")
                        .HasForeignKey("Application.Entities.Ordering.Cart", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Application.Entities.Ordering.Item", b =>
                {
                    b.HasOne("Application.Entities.Ordering.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartID");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Order", b =>
                {
                    b.HasOne("Application.Entities.Auth.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Application.Entities.Ordering.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Application.Entities.Ordering.Order", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
