﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace blogApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220818115002_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.Models.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("SeoUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2c90cdb6-910b-4f9a-a0b9-de2e88c79de0"),
                            Content = "Lorem ipsum dolor sit amet.",
                            CreatedDate = new DateTime(2022, 8, 18, 13, 50, 2, 374, DateTimeKind.Local).AddTicks(9691),
                            Description = "This is the first blog post",
                            SeoUrl = "first-blog-post",
                            Title = "First Blog Post"
                        },
                        new
                        {
                            Id = new Guid("9c24f5f5-23f5-40f0-8452-db9445700895"),
                            Content = "Lorem ipsum dolor sit amet 2.",
                            CreatedDate = new DateTime(2022, 8, 18, 13, 50, 2, 374, DateTimeKind.Local).AddTicks(9737),
                            Description = "This is the second blog post",
                            SeoUrl = "second-blog-post",
                            Title = "Second Blog Post"
                        });
                });

            modelBuilder.Entity("Entities.Models.ArticleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ArticleCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = new Guid("2c90cdb6-910b-4f9a-a0b9-de2e88c79de0"),
                            CategoryId = new Guid("4cc2f0ce-9e1a-46e3-a2b0-d75a275a6aec")
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = new Guid("2c90cdb6-910b-4f9a-a0b9-de2e88c79de0"),
                            CategoryId = new Guid("a522488a-931f-4424-946f-213dd65ea1b3")
                        });
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("varchar(160)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4cc2f0ce-9e1a-46e3-a2b0-d75a275a6aec"),
                            CreatedDate = new DateTime(2022, 8, 18, 13, 50, 2, 374, DateTimeKind.Local).AddTicks(9865),
                            Name = "Dotnet Core"
                        },
                        new
                        {
                            Id = new Guid("a522488a-931f-4424-946f-213dd65ea1b3"),
                            CreatedDate = new DateTime(2022, 8, 18, 13, 50, 2, 374, DateTimeKind.Local).AddTicks(9871),
                            Name = "Dotnet Framework"
                        });
                });

            modelBuilder.Entity("Entities.Models.ArticleCategory", b =>
                {
                    b.HasOne("Entities.Models.Article", "Article")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Models.Article", b =>
                {
                    b.Navigation("ArticleCategories");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("ArticleCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
