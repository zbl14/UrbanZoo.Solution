using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UrbanZoo_API.Migrations
{
    public partial class StreetAddress_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Features",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Features",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 638, DateTimeKind.Local).AddTicks(6270), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1780), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1810), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1820), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1820), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1830), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1830), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1840), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1840), "" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "StreetAddress" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1850), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Features");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Features",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 177, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 15, 48, 48, 178, DateTimeKind.Local).AddTicks(860));
        }
    }
}
