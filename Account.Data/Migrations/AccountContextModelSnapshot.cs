﻿// <auto-generated />
using System;
using Account.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Account.Data.Migrations
{
    [DbContext(typeof(AccountContext))]
    partial class AccountContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Account.Data.Entities.Account", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
<<<<<<< HEAD
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Balance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1000);
=======
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("608d62d2-a2e1-4890-9275-8bbae91bee15"));

                    b.Property<double>("Balance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(1000.0);
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OpenDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
<<<<<<< HEAD
                        .HasDefaultValue(new DateTime(2020, 7, 20, 11, 29, 34, 536, DateTimeKind.Local).AddTicks(7699));
=======
                        .HasDefaultValue(new DateTime(2020, 7, 19, 13, 3, 43, 432, DateTimeKind.Local).AddTicks(6053));
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4

                    b.HasKey("AccountId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Account.Data.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
<<<<<<< HEAD
                        .HasColumnType("uniqueidentifier");
=======
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("1e09ce75-e7a4-4bd8-9509-1e12d99bb64b"));
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

<<<<<<< HEAD
                    b.ToTable("Customer");
=======
                    b.ToTable("Customers");
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4
                });

            modelBuilder.Entity("Account.Data.Entities.Account", b =>
                {
                    b.HasOne("Account.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
