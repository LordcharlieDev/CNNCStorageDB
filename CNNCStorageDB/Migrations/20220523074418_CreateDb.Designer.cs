﻿// <auto-generated />
using System;
using CNNCStorageDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CNNCStorageDB.Migrations
{
    [DbContext(typeof(CNNCDbContext))]
    [Migration("20220523074418_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClientProject", b =>
                {
                    b.Property<int>("ClientsId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("ClientsId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("ClientProject");
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = " 333 Hollenbeck St, Rochester, NY 14621, US",
                            Email = "uacommercialfreightrochester@gmail.com",
                            FullName = "US Commercial Freight - Rochester, NY Location",
                            Phone = "+1585266"
                        });
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Technical"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Human resource"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Procurement"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Accounting"
                        });
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Remote"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rivne"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lviv"
                        });
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Name = "NodeJS Developer"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 1,
                            Name = "React.JS Developer"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 1,
                            Name = "Fullstack .NET Developer"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 1,
                            Name = "Fullstack React.JS, Node.JS Developer"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 3,
                            Name = "HR manager"
                        });
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Budget")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("EndTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 5, 23, 11, 44, 18, 541, DateTimeKind.Local).AddTicks(4110));

                    b.Property<int>("FinalPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 5, 23, 10, 44, 18, 541, DateTimeKind.Local).AddTicks(3942));

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 100000,
                            EndTime = new DateTime(2022, 5, 23, 10, 44, 18, 541, DateTimeKind.Local).AddTicks(4952),
                            FinalPrice = 99880,
                            Name = "Phone caller for own workers",
                            StartTime = new DateTime(2021, 11, 23, 10, 44, 18, 541, DateTimeKind.Local).AddTicks(4949)
                        });
                });

            modelBuilder.Entity("CNNCStorageDB.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "admin",
                            Password = "admin"
                        });
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("Premium")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("PositionId");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(2022, 5, 23, 10, 44, 18, 541, DateTimeKind.Local).AddTicks(4929),
                            Email = "romantomechek@gmail.com",
                            FirstName = "Roman",
                            LastName = "Mukolaiovych",
                            LocationId = 1,
                            MiddleName = "Tomecher",
                            Phone = "+380678965789",
                            PositionId = 3,
                            Premium = 0,
                            Salary = 3500
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(2022, 5, 23, 10, 44, 18, 541, DateTimeKind.Local).AddTicks(4936),
                            Email = "oksanastepanchuk@gmail.com",
                            FirstName = "Oksana",
                            LastName = "Vadymivna",
                            LocationId = 1,
                            MiddleName = "Stepanchuk",
                            Phone = "+380938965789",
                            PositionId = 5,
                            Premium = 0,
                            Salary = 1000
                        });
                });

            modelBuilder.Entity("ProjectWorker", b =>
                {
                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.Property<int>("WorkersId")
                        .HasColumnType("int");

                    b.HasKey("ProjectsId", "WorkersId");

                    b.HasIndex("WorkersId");

                    b.ToTable("ProjectWorker");
                });

            modelBuilder.Entity("ClientProject", b =>
                {
                    b.HasOne("CNNCStorageDB.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CNNCStorageDB.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Position", b =>
                {
                    b.HasOne("CNNCStorageDB.Models.Department", "Department")
                        .WithMany("Positions")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Worker", b =>
                {
                    b.HasOne("CNNCStorageDB.Models.Location", "Location")
                        .WithMany("Workers")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CNNCStorageDB.Models.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ProjectWorker", b =>
                {
                    b.HasOne("CNNCStorageDB.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CNNCStorageDB.Models.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Department", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Location", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Position", b =>
                {
                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
