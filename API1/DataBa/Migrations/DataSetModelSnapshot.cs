﻿// <auto-generated />
using API1.DataBa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API1.DataBa.Migrations
{
    [DbContext(typeof(DataSet))]
    partial class DataSetModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("API1.Entities.AddCustom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MyCustomer");
                });
#pragma warning restore 612, 618
        }
    }
}
