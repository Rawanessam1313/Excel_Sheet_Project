﻿// <auto-generated />
using Excel.Data_Access_layer.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Excel.Data_Access_layer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Excel.Data_Access_layer.Entity.Excel_Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Average")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Country_or_region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Freedom_to_make_life_choices")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Generosity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Health")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Perceptions_of_corruption")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Social_support")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ExcelData");
                });
#pragma warning restore 612, 618
        }
    }
}
