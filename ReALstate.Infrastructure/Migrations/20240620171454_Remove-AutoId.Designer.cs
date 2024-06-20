﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReALstate.Infrastructure.DbContext;

#nullable disable

namespace ReALstate.Infrastructure.Migrations
{
    [DbContext(typeof(EstatesDbContext))]
    [Migration("20240620171454_Remove-AutoId")]
    partial class RemoveAutoId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReALstate.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ResourceOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResourceOwnerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.Estate", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("BathroomsCount")
                        .HasColumnType("int");

                    b.Property<int>("BedroomsCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<bool>("HasAirConditioning")
                        .HasColumnType("bit");

                    b.Property<bool>("HasBalcony")
                        .HasColumnType("bit");

                    b.Property<bool>("HasHeating")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFurnished")
                        .HasColumnType("bit");

                    b.Property<double>("MetersSquared")
                        .HasColumnType("float");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId1")
                        .HasColumnType("int");

                    b.Property<Guid?>("ResourceOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<DateTime?>("YearBuilt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("OwnerId1");

                    b.HasIndex("ResourceOwnerId");

                    b.ToTable("Estates");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Estate");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId1")
                        .HasColumnType("int");

                    b.Property<int>("EstateId")
                        .HasColumnType("int");

                    b.Property<double>("ProposedPrice")
                        .HasColumnType("float");

                    b.Property<Guid?>("ResourceOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("EstateId");

                    b.HasIndex("ResourceOwnerId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.Apartment", b =>
                {
                    b.HasBaseType("ReALstate.Domain.Entities.Estate");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<bool>("HasPrivateParkingSpace")
                        .HasColumnType("bit");

                    b.Property<bool>("IsElevatorAvailable")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Apartment");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.House", b =>
                {
                    b.HasBaseType("ReALstate.Domain.Entities.Estate");

                    b.Property<bool>("HasAttic")
                        .HasColumnType("bit");

                    b.Property<bool>("HasBasement")
                        .HasColumnType("bit");

                    b.Property<bool>("HasGarage")
                        .HasColumnType("bit");

                    b.Property<bool>("HasGarden")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPool")
                        .HasColumnType("bit");

                    b.Property<bool>("HasTerrace")
                        .HasColumnType("bit");

                    b.Property<double>("LandInSquaredMeters")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("House");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.Customer", b =>
                {
                    b.HasOne("ReALstate.Domain.Entities.User", "ResourceOwner")
                        .WithMany("Customers")
                        .HasForeignKey("ResourceOwnerId");

                    b.Navigation("ResourceOwner");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.Estate", b =>
                {
                    b.HasOne("ReALstate.Domain.Entities.Customer", null)
                        .WithMany("Estates")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ReALstate.Domain.Entities.Customer", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReALstate.Domain.Entities.User", "ResourceOwner")
                        .WithMany("Estates")
                        .HasForeignKey("ResourceOwnerId");

                    b.OwnsOne("ReALstate.Domain.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<int>("EstateId")
                                .HasColumnType("int");

                            b1.Property<string>("ApartmentNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Voivodeship")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("EstateId");

                            b1.ToTable("Estates");

                            b1.WithOwner()
                                .HasForeignKey("EstateId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("ResourceOwner");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.Offer", b =>
                {
                    b.HasOne("ReALstate.Domain.Entities.Customer", null)
                        .WithMany("Offers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ReALstate.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReALstate.Domain.Entities.Estate", "Estate")
                        .WithMany()
                        .HasForeignKey("EstateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ReALstate.Domain.Entities.User", "ResourceOwner")
                        .WithMany("Offers")
                        .HasForeignKey("ResourceOwnerId");

                    b.Navigation("Customer");

                    b.Navigation("Estate");

                    b.Navigation("ResourceOwner");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Estates");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ReALstate.Domain.Entities.User", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Estates");

                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
