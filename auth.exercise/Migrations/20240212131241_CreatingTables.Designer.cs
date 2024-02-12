﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using auth.exercise.Data;

#nullable disable

namespace auth.exercise.Migrations
{
    [DbContext(typeof(StoreDataContext))]
    [Migration("20240212131241_CreatingTables")]
    partial class CreatingTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("auth.exercise.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Price")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Laptop",
                            Price = 100,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "Phone",
                            Price = 200,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 3,
                            Name = "Keyboard",
                            Price = 300,
                            Quantity = 30
                        });
                });
#pragma warning restore 612, 618
        }
    }
}