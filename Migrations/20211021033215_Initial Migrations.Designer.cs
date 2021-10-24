﻿// <auto-generated />
using System;
using FinalProject1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject1.Migrations
{
    [DbContext(typeof(PaymentContext))]
    [Migration("20211021033215_Initial Migrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("FinalProject1.Models.PaymentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("longtext");

                    b.Property<string>("DetailsPayment")
                        .HasColumnType("longtext");

                    b.Property<double>("Pay")
                        .HasColumnType("double");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("DetailPayments");
                });
#pragma warning restore 612, 618
        }
    }
}