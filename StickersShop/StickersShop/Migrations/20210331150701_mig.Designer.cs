﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StickersShop.Data;

namespace StickersShop.Migrations
{
    [DbContext(typeof(AppDBcontent))]
    [Migration("20210331150701_mig")]
    partial class mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MountaineeringProject.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MountaineeringProject.Data.Models.ShopIt", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("shopItemId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("stickerid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("stickerid");

                    b.ToTable("ShopIt");
                });

            modelBuilder.Entity("MountaineeringProject.Data.Models.Sticker", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("available")
                        .HasColumnType("int");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isFavourite")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("shortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Sticker");
                });

            modelBuilder.Entity("MountaineeringProject.Data.Models.ShopIt", b =>
                {
                    b.HasOne("MountaineeringProject.Data.Models.Sticker", "sticker")
                        .WithMany()
                        .HasForeignKey("stickerid");

                    b.Navigation("sticker");
                });

            modelBuilder.Entity("MountaineeringProject.Data.Models.Sticker", b =>
                {
                    b.HasOne("MountaineeringProject.Data.Models.Category", "Category")
                        .WithMany("Stickers")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MountaineeringProject.Data.Models.Category", b =>
                {
                    b.Navigation("Stickers");
                });
#pragma warning restore 612, 618
        }
    }
}
