﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dateOptimizer.data;

namespace dateOptimizer.data.Migrations
{
    [DbContext(typeof(DateOptimizerContext))]
    partial class DateOptimizerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("dateOptimizer.data.entities.DayRangeEntitity", b =>
                {
                    b.Property<int>("Fip")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Day0");

                    b.Property<double>("Day1");

                    b.Property<double>("Day10");

                    b.Property<double>("Day2");

                    b.Property<double>("Day3");

                    b.Property<double>("Day4");

                    b.Property<double>("Day5");

                    b.Property<double>("Day6");

                    b.Property<double>("Day7");

                    b.Property<double>("Day8");

                    b.Property<double>("Day9");

                    b.HasKey("Fip");

                    b.ToTable("AppraisalPercentages");
                });
#pragma warning restore 612, 618
        }
    }
}
