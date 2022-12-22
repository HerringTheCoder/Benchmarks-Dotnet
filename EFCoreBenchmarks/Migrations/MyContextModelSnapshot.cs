﻿// <auto-generated />
using System;
using EFCoreBenchmarks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreBenchmarks.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Aggregate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aggregates");
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AggregateId");

                    b.ToTable("Entity1");
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AggregateId");

                    b.ToTable("Entity2");
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity3", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AggregateId");

                    b.ToTable("Entity3");
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity4", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AggregateId");

                    b.ToTable("Entity4");
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity5", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AggregateId");

                    b.ToTable("Entity5");
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity1", b =>
                {
                    b.HasOne("EFCoreBenchmarks.SplitQuery.Models.Aggregate", null)
                        .WithMany("Entities1")
                        .HasForeignKey("AggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity2", b =>
                {
                    b.HasOne("EFCoreBenchmarks.SplitQuery.Models.Aggregate", null)
                        .WithMany("Entities2")
                        .HasForeignKey("AggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity3", b =>
                {
                    b.HasOne("EFCoreBenchmarks.SplitQuery.Models.Aggregate", null)
                        .WithMany("Entities3")
                        .HasForeignKey("AggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity4", b =>
                {
                    b.HasOne("EFCoreBenchmarks.SplitQuery.Models.Aggregate", null)
                        .WithMany("Entities4")
                        .HasForeignKey("AggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Entity5", b =>
                {
                    b.HasOne("EFCoreBenchmarks.SplitQuery.Models.Aggregate", null)
                        .WithMany("Entities5")
                        .HasForeignKey("AggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreBenchmarks.SplitQuery.Models.Aggregate", b =>
                {
                    b.Navigation("Entities1");

                    b.Navigation("Entities2");

                    b.Navigation("Entities3");

                    b.Navigation("Entities4");

                    b.Navigation("Entities5");
                });
#pragma warning restore 612, 618
        }
    }
}
