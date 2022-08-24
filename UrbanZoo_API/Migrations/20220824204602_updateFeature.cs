using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UrbanZoo_API.Migrations
{
    public partial class updateFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 324, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Lat", "Lng" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9100), 45.487687600000001, -122.6109854 });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 46, 2, 325, DateTimeKind.Local).AddTicks(9120));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Lat", "Lng" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8300), 45.604418240000001, -122.8296801 });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8320));
        }
    }
}
