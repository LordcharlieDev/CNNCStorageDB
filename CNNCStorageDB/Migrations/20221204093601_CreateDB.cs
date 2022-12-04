using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CNNCStorageDB.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 4, 11, 36, 1, 433, DateTimeKind.Local).AddTicks(6334)),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 4, 12, 36, 1, 433, DateTimeKind.Local).AddTicks(6585)),
                    FinalCost = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Army = table.Column<bool>(type: "bit", nullable: false),
                    Passport = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Childrens = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Premium = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DateOfEmployment = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 4, 19, 36, 1, 433, DateTimeKind.Local).AddTicks(3434)),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectWorker",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "int", nullable: false),
                    WorkersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectWorker", x => new { x.ProjectsId, x.WorkersId });
                    table.ForeignKey(
                        name: "FK_ProjectWorker_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectWorker_Workers_WorkersId",
                        column: x => x.WorkersId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Email", "FullName", "Phone" },
                values: new object[] { 1, " 333 Hollenbeck St, Rochester, NY 14621, US", "uacommercialfreightrochester@gmail.com", "US Commercial Freight - Rochester, NY Location", "+158526625744" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Technical" },
                    { 2, "Human resource" },
                    { 3, "Sales" },
                    { 4, "Procurement" },
                    { 5, "Accounting" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Remote" },
                    { 2, "Rivne" },
                    { 3, "Lviv" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsAdmin", "Password", "Username" },
                values: new object[,]
                {
                    { 1, true, "F@1ders1", "administrator" },
                    { 2, false, "Oksana123", "Oksana.Stepanchuk" },
                    { 3, false, "Inna1234", "Inna.Koltaniuk" },
                    { 4, false, "Katia123", "Katia.Tomecher" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Node.JS Developer" },
                    { 2, 1, "React.JS Developer" },
                    { 3, 1, "Fullstack .NET Developer" },
                    { 4, 1, "Fullstack React.JS, Node.JS Developer" },
                    { 5, 2, "HR manager" },
                    { 6, 1, "Team Lead" },
                    { 7, 1, "Product Manager" },
                    { 8, 1, "Project Manager" },
                    { 9, 3, "Marketer" },
                    { 10, 3, "PR manager" },
                    { 11, 4, "Warehouse manager" },
                    { 12, 5, "Bookkeeper" },
                    { 13, 1, "System Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "ClientId", "EndDate", "FinalCost", "Name", "StartDate" },
                values: new object[] { 1, 100000, 1, new DateTime(2022, 12, 4, 11, 36, 1, 433, DateTimeKind.Local).AddTicks(8014), 101500, "Phone caller for own workers", new DateTime(2022, 6, 4, 11, 36, 1, 433, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "Address", "Army", "Birthdate", "Childrens", "DateOfEmployment", "Email", "FirstName", "LastName", "LocationId", "MaritalStatus", "MiddleName", "Passport", "Phone", "PositionId", "Salary", "Sex" },
                values: new object[,]
                {
                    { 1, "Rivnenska, Rivnensky, Rivne, Soborna str, 8/13", false, new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2017, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "romantomechek@gmail.com", "Roman", "Tomecher", 2, "Unmarried", "Mukolaiovych", "75698745", "+380678965789", 13, 3500, "Male" },
                    { 2, "Rivnenska, Rivnensky, Rivne, Soborna str, 254", false, new DateTime(1995, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2017, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "oksanastepanchuk@gmail.com", "Oksana", "Stepanchuk", 2, "Married", "Vadymivna", "54789654", "+380938965789", 5, 1000, "Female" },
                    { 3, "Rivnenska, Rivnensky, Rivne, Kyivska str, 145", false, new DateTime(1993, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2018, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "innakoltaniuk@gmail.com", "Inna", "Koltaniuk", 1, "Married", "Mykolaivna", "98745627", "+380938467895", 5, 1000, "Female" },
                    { 4, "Rivnenska, Rivnensky, Rivne, Chornovola str, 25", false, new DateTime(1997, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "katiatomecher@gmail.com", "Katia", "Tomecher", 2, "Married", "Oleksiivna", "15794563", "+380684579512", 12, 1000, "Female" },
                    { 5, "Rivnenska, Rivnensky, Rivne, Stepana Bandery str, 256/15", false, new DateTime(1999, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "sashamelnik@gmail.com", "Sasha", "Melnik", 3, "Married", "Artemivna", "97845612", "+380995467845", 11, 1000, "Female" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmentId",
                table: "Positions",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectWorker_WorkersId",
                table: "ProjectWorker",
                column: "WorkersId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_LocationId",
                table: "Workers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_PositionId",
                table: "Workers",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectWorker");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
