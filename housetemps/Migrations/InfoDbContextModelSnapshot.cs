﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using housetemps.Data;

#nullable disable

namespace housetemps.Migrations
{
    [DbContext(typeof(InfoDbContext))]
    partial class InfoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("housetemps.Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<float?>("Humidity")
                        .HasColumnType("float")
                        .HasColumnName("humidity");

                    b.Property<float?>("Temperature")
                        .HasColumnType("float")
                        .HasColumnName("temperature");

                    b.Property<DateTime?>("Time")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("time")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "id_UNIQUE")
                        .IsUnique();

                    b.ToTable("temperature", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}