﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherAPI;

#nullable disable

namespace WeatherAPI.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20230112194639_initTest")]
    partial class initTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("WeatherAPI.RawData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("time")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("RawDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
