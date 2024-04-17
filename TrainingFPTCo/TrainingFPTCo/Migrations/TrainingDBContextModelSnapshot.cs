﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingFPTCo.DBContext;

#nullable disable

namespace TrainingFPTCo.Migrations
{
    [DbContext(typeof(TrainingDBContext))]
    partial class TrainingDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrainingFPTCo.DBContext.CategoryDBContext", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Description");

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("NameCategory");

                    b.Property<string>("ParentId")
                        .IsRequired()
                        .HasColumnType("Integer")
                        .HasColumnName("ParentId");

                    b.Property<string>("PosterImage")
                        .IsRequired()
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("PosterImage");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TrainingFPTCo.DBContext.CourseDBContext", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Description");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("Varchar(250)")
                        .HasColumnName("Image");

                    b.Property<int?>("LikeCourse")
                        .HasColumnType("Integer")
                        .HasColumnName("LikeCourse");

                    b.Property<string>("NameCourse")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("NameCourse");

                    b.Property<int?>("StarCourse")
                        .HasColumnType("Integer")
                        .HasColumnName("StarCourse");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TrainingFPTCo.DBContext.RolesDBContext", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Description");

                    b.Property<string>("NameRole")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("NameRole");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TrainingFPTCo.DBContext.CourseDBContext", b =>
                {
                    b.HasOne("TrainingFPTCo.DBContext.CategoryDBContext", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
