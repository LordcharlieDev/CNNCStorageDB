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
    [Migration("20221204093601_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            Phone = "+158526625744"
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
                            Name = "Node.JS Developer"
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
                            DepartmentId = 2,
                            Name = "HR manager"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 1,
                            Name = "Team Lead"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 1,
                            Name = "Product Manager"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 1,
                            Name = "Project Manager"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 3,
                            Name = "Marketer"
                        },
                        new
                        {
                            Id = 10,
                            DepartmentId = 3,
                            Name = "PR manager"
                        },
                        new
                        {
                            Id = 11,
                            DepartmentId = 4,
                            Name = "Warehouse manager"
                        },
                        new
                        {
                            Id = 12,
                            DepartmentId = 5,
                            Name = "Bookkeeper"
                        },
                        new
                        {
                            Id = 13,
                            DepartmentId = 1,
                            Name = "System Administrator"
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

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 4, 12, 36, 1, 433, DateTimeKind.Local).AddTicks(6585));

                    b.Property<int>("FinalCost")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 4, 11, 36, 1, 433, DateTimeKind.Local).AddTicks(6334));

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 100000,
                            ClientId = 1,
                            EndDate = new DateTime(2022, 12, 4, 11, 36, 1, 433, DateTimeKind.Local).AddTicks(8014),
                            FinalCost = 101500,
                            Name = "Phone caller for own workers",
                            StartDate = new DateTime(2022, 6, 4, 11, 36, 1, 433, DateTimeKind.Local).AddTicks(8004)
                        });
                });

            modelBuilder.Entity("CNNCStorageDB.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAdmin = true,
                            Password = "F@1ders1",
                            Username = "administrator"
                        },
                        new
                        {
                            Id = 2,
                            IsAdmin = false,
                            Password = "Oksana123",
                            Username = "Oksana.Stepanchuk"
                        },
                        new
                        {
                            Id = 3,
                            IsAdmin = false,
                            Password = "Inna1234",
                            Username = "Inna.Koltaniuk"
                        },
                        new
                        {
                            Id = 4,
                            IsAdmin = false,
                            Password = "Katia123",
                            Username = "Katia.Tomecher"
                        });
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("Army")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Childrens")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfEmployment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 4, 19, 36, 1, 433, DateTimeKind.Local).AddTicks(3434));

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

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

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

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("PositionId");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rivnenska, Rivnensky, Rivne, Soborna str, 8/13",
                            Army = false,
                            Birthdate = new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Childrens = 0,
                            DateOfEmployment = new DateTime(2017, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "romantomechek@gmail.com",
                            FirstName = "Roman",
                            LastName = "Tomecher",
                            LocationId = 2,
                            MaritalStatus = "Unmarried",
                            MiddleName = "Mukolaiovych",
                            Passport = "75698745",
                            Phone = "+380678965789",
                            PositionId = 13,
                            Premium = 0,
                            Salary = 3500,
                            Sex = "Male"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Rivnenska, Rivnensky, Rivne, Soborna str, 254",
                            Army = false,
                            Birthdate = new DateTime(1995, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Childrens = 0,
                            DateOfEmployment = new DateTime(2017, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "oksanastepanchuk@gmail.com",
                            FirstName = "Oksana",
                            LastName = "Stepanchuk",
                            LocationId = 2,
                            MaritalStatus = "Married",
                            MiddleName = "Vadymivna",
                            Passport = "54789654",
                            Phone = "+380938965789",
                            PositionId = 5,
                            Premium = 0,
                            Salary = 1000,
                            Sex = "Female"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Rivnenska, Rivnensky, Rivne, Kyivska str, 145",
                            Army = false,
                            Birthdate = new DateTime(1993, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Childrens = 1,
                            DateOfEmployment = new DateTime(2018, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "innakoltaniuk@gmail.com",
                            FirstName = "Inna",
                            LastName = "Koltaniuk",
                            LocationId = 1,
                            MaritalStatus = "Married",
                            MiddleName = "Mykolaivna",
                            Passport = "98745627",
                            Phone = "+380938467895",
                            PositionId = 5,
                            Premium = 0,
                            Salary = 1000,
                            Sex = "Female"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Rivnenska, Rivnensky, Rivne, Chornovola str, 25",
                            Army = false,
                            Birthdate = new DateTime(1997, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Childrens = 0,
                            DateOfEmployment = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "katiatomecher@gmail.com",
                            FirstName = "Katia",
                            LastName = "Tomecher",
                            LocationId = 2,
                            MaritalStatus = "Married",
                            MiddleName = "Oleksiivna",
                            Passport = "15794563",
                            Phone = "+380684579512",
                            PositionId = 12,
                            Premium = 0,
                            Salary = 1000,
                            Sex = "Female"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Rivnenska, Rivnensky, Rivne, Stepana Bandery str, 256/15",
                            Army = false,
                            Birthdate = new DateTime(1999, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Childrens = 0,
                            DateOfEmployment = new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sashamelnik@gmail.com",
                            FirstName = "Sasha",
                            LastName = "Melnik",
                            LocationId = 3,
                            MaritalStatus = "Married",
                            MiddleName = "Artemivna",
                            Passport = "97845612",
                            Phone = "+380995467845",
                            PositionId = 11,
                            Premium = 0,
                            Salary = 1000,
                            Sex = "Female"
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

            modelBuilder.Entity("CNNCStorageDB.Models.Position", b =>
                {
                    b.HasOne("CNNCStorageDB.Models.Department", "Department")
                        .WithMany("Positions")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CNNCStorageDB.Models.Project", b =>
                {
                    b.HasOne("CNNCStorageDB.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
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

            modelBuilder.Entity("CNNCStorageDB.Models.Client", b =>
                {
                    b.Navigation("Projects");
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
