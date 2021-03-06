﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebGame.Data;

namespace WebGame.Data.Migrations
{
    [DbContext(typeof(WebGameContext))]
    [Migration("20180704181649_GeographyInit")]
    partial class GeographyInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebGame.Core.Models.Geography.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebGame.Core.Models.Geography.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("PlanetId");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WebGame.Core.Models.Geography.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("WebGame.Core.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId");

                    b.Property<string>("Pseudo");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("WebGame.Core.Models.Geography.City", b =>
                {
                    b.HasOne("WebGame.Core.Models.Geography.Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("WebGame.Core.Models.Geography.Country", b =>
                {
                    b.HasOne("WebGame.Core.Models.Geography.Planet")
                        .WithMany("Countries")
                        .HasForeignKey("PlanetId");
                });

            modelBuilder.Entity("WebGame.Core.Models.Player", b =>
                {
                    b.HasOne("WebGame.Core.Models.Geography.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });
#pragma warning restore 612, 618
        }
    }
}
