﻿// <auto-generated />
using System;
using InventoryCodeAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryCodeAPI.Migrations.OrderDB
{
    [DbContext(typeof(OrderDBContext))]
    [Migration("20211013072814_OrdersMigration")]
    partial class OrdersMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryCodeAPI.Model.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TDT")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalProductPurchase")
                        .HasColumnType("int");

                    b.Property<DateTime>("UDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("customerid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("totalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
