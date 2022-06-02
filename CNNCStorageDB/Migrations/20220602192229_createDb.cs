using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CNNCStorageDB.Migrations
{
    public partial class createDb : Migration
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
                    Login = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 2, 22, 22, 29, 374, DateTimeKind.Local).AddTicks(74)),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 2, 23, 22, 29, 374, DateTimeKind.Local).AddTicks(235)),
                    FinalPrice = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
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
                    Salary = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Premium = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
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
                columns: new[] { "Id", "IsAdmin", "Login", "Password" },
                values: new object[,]
                {
                    { 1, true, "administrator", "F@1ders1" },
                    { 2, false, "Oksana.Stepanchuk", "Oksana123" },
                    { 3, false, "Inna.Koltaniuk", "Inna1234" },
                    { 4, false, "Katia.Tomecher", "Katia123" },
                    { 5, false, "Sasha.Melnik", "Sasha123" }
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
                    { 13, 5, "DevOps" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "ClientId", "EndTime", "FinalPrice", "Name", "StartTime" },
                values: new object[] { 1, 100000, 1, new DateTime(2022, 6, 2, 22, 22, 29, 374, DateTimeKind.Local).AddTicks(1203), 99880, "Phone caller for own workers", new DateTime(2021, 12, 2, 22, 22, 29, 374, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "Birthdate", "Email", "FirstName", "LastName", "LocationId", "MiddleName", "Phone", "PositionId", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "romantomechek@gmail.com", "Roman", "Tomecher", 1, "Mukolaiovych", "+380678965789", 3, 3500 },
                    { 2, new DateTime(1995, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "oksanastepanchuk@gmail.com", "Oksana", "Stepanchuk", 1, "Vadymivna", "+380938965789", 5, 1000 },
                    { 3, new DateTime(1993, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "innakoltaniuk@gmail.com", "Inna", "Koltaniuk", 2, "Mykolaivna", "+380938467895", 5, 1000 },
                    { 4, new DateTime(1997, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "katiatomecher@gmail.com", "Katia", "Tomecher", 2, "Oleksiivna", "+380684579512", 12, 1000 },
                    { 5, new DateTime(1999, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "sashamelnik@gmail.com", "Sasha", "Melnik", 3, "Artemivna", "+380995467845", 11, 1000 }
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
