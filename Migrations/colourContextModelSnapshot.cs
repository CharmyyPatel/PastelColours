﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace pastel.Migrations
{
    [DbContext(typeof(colourContext))]
    partial class colourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("colour.Models.Program1", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PowerAcquisitionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("hexcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("meaning")
                        .HasColumnType("TEXT");

                    b.Property<string>("mix1")
                        .HasColumnType("TEXT");

                    b.Property<string>("mix2")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Program1");
                });
#pragma warning restore 612, 618
        }
    }
}
