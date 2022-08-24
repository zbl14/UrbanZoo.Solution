using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UrbanZoo_API.Migrations
{
    public partial class Reseeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(3300), "Owners welcome public feeding", 45.471901500000001, -122.6145719, "SE 47th & SE rural", "Chicken Coup" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "City", "CreatedDate", "Description", "Lat", "Lng", "State", "StreetAddress", "Title" },
                values: new object[] { "Portland", new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8260), "Owners welcome public feeding", 45.477027900000003, -122.6174991, "OR", "SE 44th & SE Tolman", "Chicken Coup" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8280), "Can't feed the chickens", 45.482752900000001, 122.6164548, "SE 45th Ave & SE Harold St", "Chicken Coup" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "City", "CreatedDate", "Description", "Lat", "Lng", "State", "StreetAddress", "Title" },
                values: new object[] { "Portland", new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8280), "Owners welcome public feeding", 45.486022800000001, -122.6154899, "OR", "5119 SE 46th Ave", "Chicken Coup" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8290), "Owners welcome public feeding", 45.4846498, -122.602384, "5980 SE Steele St", "Chicken Coup" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "City", "CreatedDate", "Description", "Lat", "Lng", "State", "StreetAddress", "Title" },
                values: new object[] { "Portland", new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8290), "Owners welcome public feeding", 45.487687899999997, -122.6109854, "OR", "4816 SE 50th Ave", "Chickens and Ducks" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8290), "Behind chain linked fence", 45.4895937, -122.5959313, "4536 SE 65th Ave", "Goat and Pig" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8300), "Bring minifigs to trade. On telephone poll near address listed https://www.instagram.com/portlandminifigs/?hl=en", 45.491505199999999, -122.6190095, "SE 42nd Ave & SE Cora St", "PDX Lego MiniFig Exchange" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8300), "Back alley path with large branches to climb on", "4700 SE 50th Ave", "Secret passage way" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8310), "Rose bushes growing over sidewalk. Smells good in summer", 45.484494099999999, -122.5972208, "6417 SE Steele St", "Rose tunnel " });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "Availability", "City", "CreatedDate", "Description", "Lat", "Lng", "State", "StreetAddress", "Title", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { 11, true, "Portland", new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8310), "Arborvitae 'tunnel' over sidewalk with toys inside", 45.486687199999999, -122.6147603, "OR", "4601 SE Raymond St", "Fairy tunnel ", 2, "97218" },
                    { 12, true, "Portland", new DateTime(2022, 8, 24, 13, 24, 8, 746, DateTimeKind.Local).AddTicks(8320), "Diorama featuring dinosaurs and friends. https://www.instagram.com/pdxdinorama/?hl=en", 45.516819699999999, -122.58544670000001, "OR", "SE 78th Ave & SE Morrison St", "PDX Diorama", 6, "97218" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 638, DateTimeKind.Local).AddTicks(6270), "Entire contents of bedroom", 45.588689330000001, -122.56404786, "", "Roommate cleanout" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "City", "CreatedDate", "Description", "Lat", "Lng", "State", "StreetAddress", "Title" },
                values: new object[] { "Vancouver", new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1780), "Looks like 100+ figurines of all types", 45.654670580000001, -122.53756002, "WA", "", "Dog figurine collection" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1810), "Sports equipment", 45.481928770000003, -122.5580511, "", "Sports equipment" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "City", "CreatedDate", "Description", "Lat", "Lng", "State", "StreetAddress", "Title" },
                values: new object[] { "Vancouver", new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1820), "Metal junk", 45.674033960000003, -122.74122815, "WA", "", "Metal junk" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1820), "Books", 45.573054669999998, -122.64396572, "", "Books" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "City", "CreatedDate", "Description", "Lat", "Lng", "State", "StreetAddress", "Title" },
                values: new object[] { "Vancouver", new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1830), "looks useable", 45.707315459999997, -122.70110880999999, "WA", "", "Clothes dresser" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1830), "4 pairs, size men's 10", 45.487334359999998, -122.76339163999999, "", "Shoes" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1840), "size medium", 45.34753517, -122.66505906, "", "Box of women's clothes" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1840), "2 shovels, 1 hoe, 1 hose", "", "Garden tools" });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Lat", "Lng", "StreetAddress", "Title" },
                values: new object[] { new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1850), "Looks well loved, but has some more life in them", 45.570666279999998, -122.59853484, "", "Kids toys" });
        }
    }
}
