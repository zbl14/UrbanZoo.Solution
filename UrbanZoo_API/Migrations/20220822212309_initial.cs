using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UrbanZoo_API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    State = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lat = table.Column<double>(type: "double", nullable: false),
                    Lng = table.Column<double>(type: "double", nullable: false),
                    Zipcode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "Availability", "City", "CreatedDate", "Description", "Lat", "Lng", "State", "Title", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { 1, true, "Portland", new DateTime(2022, 8, 22, 14, 23, 9, 75, DateTimeKind.Local).AddTicks(6760), "Entire contents of bedroom", 45.588689330000001, -122.56404786, "OR", "Roommate cleanout", 4, "97211" },
                    { 2, true, "Vancouver", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1530), "Looks like 100+ figurines of all types", 45.654670580000001, -122.53756002, "WA", "Dog figurine collection", 3, "98682" },
                    { 3, true, "Portland", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1550), "Sports equipment", 45.481928770000003, -122.5580511, "OR", "Sports equipment", 3, "97266" },
                    { 4, true, "Vancouver", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1550), "Metal junk", 45.674033960000003, -122.74122815, "WA", "Metal junk", 2, "98660" },
                    { 5, true, "Portland", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1560), "Books", 45.573054669999998, -122.64396572, "OR", "Books", 1, "97211" },
                    { 6, true, "Vancouver", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1560), "looks useable", 45.707315459999997, -122.70110880999999, "WA", "Clothes dresser", 4, "98685" },
                    { 7, true, "Portland", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1570), "4 pairs, size men's 10", 45.487334359999998, -122.76339163999999, "OR", "Shoes", 1, "97225" },
                    { 8, true, "Portland", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1570), "size medium", 45.34753517, -122.66505906, "OR", "Box of women's clothes", 5, "97068" },
                    { 9, true, "Portland", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1570), "2 shovels, 1 hoe, 1 hose", 45.604418240000001, -122.8296801, "OR", "Garden tools", 6, "97231" },
                    { 10, true, "Portland", new DateTime(2022, 8, 22, 14, 23, 9, 76, DateTimeKind.Local).AddTicks(1580), "Looks well loved, but has some more life in them", 45.570666279999998, -122.59853484, "OR", "Kids toys", 2, "97218" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
