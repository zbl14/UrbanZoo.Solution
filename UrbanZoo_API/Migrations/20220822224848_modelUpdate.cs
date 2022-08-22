using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UrbanZoo_API.Migrations
{
    public partial class modelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 75, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1580));
        }
    }
}
