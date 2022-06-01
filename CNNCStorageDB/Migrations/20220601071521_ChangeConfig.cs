using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CNNCStorageDB.Migrations
{
    public partial class ChangeConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 1, 10, 15, 21, 371, DateTimeKind.Local).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 1, 9, 40, 44, 319, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 1, 11, 15, 21, 372, DateTimeKind.Local).AddTicks(107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 1, 10, 40, 44, 319, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 15, 21, 372, DateTimeKind.Local).AddTicks(888), new DateTime(2021, 12, 1, 10, 15, 21, 372, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2022, 6, 1, 10, 15, 21, 372, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2022, 6, 1, 10, 15, 21, 372, DateTimeKind.Local).AddTicks(871));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 1, 9, 40, 44, 319, DateTimeKind.Local).AddTicks(4649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 1, 10, 15, 21, 371, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 1, 10, 40, 44, 319, DateTimeKind.Local).AddTicks(4816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 1, 11, 15, 21, 372, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 6, 1, 9, 40, 44, 319, DateTimeKind.Local).AddTicks(5696), new DateTime(2021, 12, 1, 9, 40, 44, 319, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2022, 6, 1, 9, 40, 44, 319, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2022, 6, 1, 9, 40, 44, 319, DateTimeKind.Local).AddTicks(5680));
        }
    }
}
