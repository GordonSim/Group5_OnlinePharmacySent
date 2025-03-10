﻿// <auto-generated />
using System;
using Group5_OnlinePharmacy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Group5_OnlinePharmacy.Migrations
{
    [DbContext(typeof(Group5_OnlinePharmacyContext))]
    partial class Group5_OnlinePharmacyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Group5_OnlinePharmacy.Data.Group5_OnlinePharmacyUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b3e71057-57d0-49fe-840d-dc41935ec77c",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEE15vFB3+k5t1KnEtt7OZFaHeigQR0AK+0f2jO0m0DIjcWCw5WrDYbZmjAaVuZlIqw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3f5f92db-5f94-41a0-b3a8-09634adf4e13",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        });
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Allergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<string>("Reaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MedicineId");

                    b.ToTable("Allergy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            MedicineId = 4,
                            Reaction = "Swelling and Rash",
                            Severity = "High"
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 1,
                            MedicineId = 3,
                            Reaction = "Itchy Skin",
                            Severity = "Mild"
                        });
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AspNetUserIdId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "789 Admin St, Singapore",
                            AspNetUserIdId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            Email = "admin@example.com",
                            Name = "Admin UserId",
                            Password = "hashed_password_3",
                            PhoneNumber = "90011234"
                        });
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("StockQty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medicine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Relieves sore throat and cough symptoms.",
                            ImageURL = "Difflam.jpg",
                            Name = "Difflam",
                            Price = 8.99f,
                            StockQty = 50
                        },
                        new
                        {
                            Id = 2,
                            Description = "Traditional remedy for cough and sore throat.",
                            ImageURL = "Pei Pa Koa.jpg",
                            Name = "Pei Pa Koa",
                            Price = 6.99f,
                            StockQty = 40
                        },
                        new
                        {
                            Id = 3,
                            Description = "Helps restore gut health and control diarrhea.",
                            ImageURL = "Lacteolfort.jpg",
                            Name = "Lacteolfort",
                            Price = 4.99f,
                            StockQty = 30
                        },
                        new
                        {
                            Id = 4,
                            Description = "Lubricates dry eyes and provides long-lasting relief.",
                            ImageURL = "Moist Eye-mo.jpg",
                            Name = "Moist Eye-mo",
                            Price = 5.49f,
                            StockQty = 25
                        },
                        new
                        {
                            Id = 5,
                            Description = "Relieves symptoms of allergies and hay fever.",
                            ImageURL = "Clarityne.jpg",
                            Name = "Clarityne",
                            Price = 7.99f,
                            StockQty = 40
                        },
                        new
                        {
                            Id = 6,
                            Description = "Provides relief from acid reflux and heartburn.",
                            ImageURL = "Gaviscon.jpg",
                            Name = "Gaviscon",
                            Price = 6.49f,
                            StockQty = 20
                        },
                        new
                        {
                            Id = 7,
                            Description = "Effective relief for headaches, fever, and pain.",
                            ImageURL = "Panadol.jpg",
                            Name = "Panadol",
                            Price = 4.99f,
                            StockQty = 100
                        });
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            OrderDate = new DateTime(2025, 1, 15, 19, 15, 0, 0, DateTimeKind.Unspecified),
                            PaymentStatus = "Paid",
                            ShippingAddress = "123 Main St, Singapore",
                            TotalPrice = 99.99f
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 1,
                            OrderDate = new DateTime(2025, 1, 16, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            PaymentStatus = "Pending",
                            ShippingAddress = "456 Marina Bay, Singapore",
                            TotalPrice = 89.5f
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 1,
                            OrderDate = new DateTime(2025, 1, 17, 16, 45, 0, 0, DateTimeKind.Unspecified),
                            PaymentStatus = "Failed",
                            ShippingAddress = "789 Tampines Street, Singapore",
                            TotalPrice = 120.75f
                        });
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ItemPrice")
                        .HasColumnType("real");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicineId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemPrice = 5.99f,
                            MedicineId = 1,
                            OrderId = 1,
                            Qty = 2
                        },
                        new
                        {
                            Id = 2,
                            ItemPrice = 7.49f,
                            MedicineId = 2,
                            OrderId = 1,
                            Qty = 1
                        },
                        new
                        {
                            Id = 3,
                            ItemPrice = 4.99f,
                            MedicineId = 3,
                            OrderId = 2,
                            Qty = 3
                        },
                        new
                        {
                            Id = 4,
                            ItemPrice = 9.99f,
                            MedicineId = 4,
                            OrderId = 3,
                            Qty = 2
                        });
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Symptom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Symptom");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A reflex action to clear airways of mucus, dust, or foreign particles.",
                            Name = "Cough"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Frequent, loose, or watery stools, often caused by an infection.",
                            Name = "Diarrhea"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Symptoms affecting the eyes, such as dryness or irritation.",
                            Name = "Eye Care"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A common viral infection causing fever, chills, and muscle aches.",
                            Name = "Flu"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Discomfort in the stomach associated with difficulty digesting food.",
                            Name = "Indigestion"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Physical discomfort or suffering caused by injury or illness.",
                            Name = "Pain"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                            Name = "UserId",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Allergy", b =>
                {
                    b.HasOne("Group5_OnlinePharmacy.Domain.Customer", "Customer")
                        .WithMany("Allergies")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group5_OnlinePharmacy.Domain.Medicine", "Medicine")
                        .WithMany("Allergies")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Order", b =>
                {
                    b.HasOne("Group5_OnlinePharmacy.Domain.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.OrderItem", b =>
                {
                    b.HasOne("Group5_OnlinePharmacy.Domain.Medicine", "Medicine")
                        .WithMany("OrderItems")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group5_OnlinePharmacy.Domain.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Group5_OnlinePharmacy.Data.Group5_OnlinePharmacyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Group5_OnlinePharmacy.Data.Group5_OnlinePharmacyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group5_OnlinePharmacy.Data.Group5_OnlinePharmacyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Group5_OnlinePharmacy.Data.Group5_OnlinePharmacyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Customer", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Medicine", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Group5_OnlinePharmacy.Domain.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
