﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORMDemo.MultiTenancy;

namespace ORMDemo.MultiTenancy.Migrations.Tenants
{
    [DbContext(typeof(TenantsContext))]
    [Migration("20181114050902_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORMDemo.MultiTenancy.Models.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Tenants");

                    b.HasData(
                        new { Id = new Guid("b992d195-56ce-49bf-bfdd-4145ba9a0c13"), Host = "localhost:5200", Name = "Customer A" },
                        new { Id = new Guid("f55ae0c8-4573-4a0a-9ef9-32f66a828d0e"), Host = "localhost:5300", Name = "Customer B" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
