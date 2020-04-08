﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORMDemo.MultiTenancy;

namespace ORMDemo.MultiTenancy.Migrations.Blogging
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORMDemo.MultiTenancy.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("TenantId");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new { Id = 1, Name = "Blog1 by A", TenantId = new Guid("b992d195-56ce-49bf-bfdd-4145ba9a0c13"), Url = "http://sample.com/1" },
                        new { Id = 2, Name = "Blog2 by A", TenantId = new Guid("b992d195-56ce-49bf-bfdd-4145ba9a0c13"), Url = "http://sample.com/2" },
                        new { Id = 3, Name = "Blog1 by B", TenantId = new Guid("f55ae0c8-4573-4a0a-9ef9-32f66a828d0e"), Url = "http://sample.com/3" }
                    );
                });

            modelBuilder.Entity("ORMDemo.MultiTenancy.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Content")
                        .HasMaxLength(500);

                    b.Property<Guid>("TenantId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ORMDemo.MultiTenancy.Models.Post", b =>
                {
                    b.HasOne("ORMDemo.MultiTenancy.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}