﻿// <auto-generated />
using System;
using InventoryCodeAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryCodeAPI.Migrations
{
    [DbContext(typeof(UsersDBContext))]
    [Migration("20211006141504_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryCodeAPI.Model.User", b =>
                {
                    b.Property<int>("userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("contact")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("passkey")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("userid");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
