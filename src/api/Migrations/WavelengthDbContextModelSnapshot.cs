using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Wavelength.Api;

namespace api.Migrations
{
    [DbContext(typeof(WavelengthDbContext))]
    partial class WavelengthDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Wavelength.Api.Models.Bar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LogoUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Bars");
                });

            modelBuilder.Entity("Wavelength.Api.Models.BarReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BarId");

                    b.Property<float?>("Capacity");

                    b.Property<int?>("Cover");

                    b.Property<float?>("Line");

                    b.Property<Guid?>("ReportedById");

                    b.Property<DateTime>("ReportedOn");

                    b.HasKey("Id");

                    b.HasIndex("BarId");

                    b.HasIndex("ReportedById");

                    b.ToTable("BarReports");
                });

            modelBuilder.Entity("Wavelength.Api.Models.Deal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int?>("BarId");

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("Start");

                    b.Property<bool>("Weekly");

                    b.HasKey("Id");

                    b.HasIndex("BarId");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("Wavelength.Api.Models.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<string>("FacebookId");

                    b.Property<int?>("FavoriteBarId");

                    b.Property<bool>("IsTender");

                    b.HasKey("Id");

                    b.HasIndex("FavoriteBarId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Wavelength.Api.Models.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BarId");

                    b.Property<DateTime>("End");

                    b.Property<Guid?>("ProfileId");

                    b.Property<DateTime>("Start");

                    b.HasKey("Id");

                    b.HasIndex("BarId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("Wavelength.Api.Models.BarReport", b =>
                {
                    b.HasOne("Wavelength.Api.Models.Bar", "Bar")
                        .WithMany("Reports")
                        .HasForeignKey("BarId");

                    b.HasOne("Wavelength.Api.Models.Profile", "ReportedBy")
                        .WithMany()
                        .HasForeignKey("ReportedById");
                });

            modelBuilder.Entity("Wavelength.Api.Models.Deal", b =>
                {
                    b.HasOne("Wavelength.Api.Models.Bar", "Bar")
                        .WithMany("Deals")
                        .HasForeignKey("BarId");
                });

            modelBuilder.Entity("Wavelength.Api.Models.Profile", b =>
                {
                    b.HasOne("Wavelength.Api.Models.Bar", "FavoriteBar")
                        .WithMany()
                        .HasForeignKey("FavoriteBarId");
                });

            modelBuilder.Entity("Wavelength.Api.Models.Shift", b =>
                {
                    b.HasOne("Wavelength.Api.Models.Bar", "Bar")
                        .WithMany()
                        .HasForeignKey("BarId");

                    b.HasOne("Wavelength.Api.Models.Profile", "Profile")
                        .WithMany("Shifts")
                        .HasForeignKey("ProfileId");
                });
        }
    }
}
