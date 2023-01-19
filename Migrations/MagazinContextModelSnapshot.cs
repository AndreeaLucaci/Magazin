﻿// <auto-generated />
using System;
using Magazin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Magazin.Migrations
{
    [DbContext(typeof(MagazinContext))]
    partial class MagazinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Magazin.Models.Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("MaterialID")
                        .HasColumnType("int");

                    b.Property<string>("NumeMaterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MaterialID");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("Magazin.Models.Producator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("NumeProducator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Producator");
                });

            modelBuilder.Entity("Magazin.Models.Produs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Culoare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterialID")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("ProducatorID")
                        .HasColumnType("int");

                    b.Property<int>("SezonID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MaterialID");

                    b.HasIndex("ProducatorID");

                    b.HasIndex("SezonID");

                    b.ToTable("Produs");
                });

            modelBuilder.Entity("Magazin.Models.Sezon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("NumeSezon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SezonID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SezonID");

                    b.ToTable("Sezon");
                });

            modelBuilder.Entity("Magazin.Models.Material", b =>
                {
                    b.HasOne("Magazin.Models.Material", null)
                        .WithMany("Materiale")
                        .HasForeignKey("MaterialID");
                });

            modelBuilder.Entity("Magazin.Models.Produs", b =>
                {
                    b.HasOne("Magazin.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Magazin.Models.Producator", "Producator")
                        .WithMany("Produse")
                        .HasForeignKey("ProducatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Magazin.Models.Sezon", "Sezon")
                        .WithMany()
                        .HasForeignKey("SezonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Producator");

                    b.Navigation("Sezon");
                });

            modelBuilder.Entity("Magazin.Models.Sezon", b =>
                {
                    b.HasOne("Magazin.Models.Sezon", null)
                        .WithMany("Sezoane")
                        .HasForeignKey("SezonID");
                });

            modelBuilder.Entity("Magazin.Models.Material", b =>
                {
                    b.Navigation("Materiale");
                });

            modelBuilder.Entity("Magazin.Models.Producator", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("Magazin.Models.Sezon", b =>
                {
                    b.Navigation("Sezoane");
                });
#pragma warning restore 612, 618
        }
    }
}
