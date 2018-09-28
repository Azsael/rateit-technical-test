using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RateIt.Entities.Migrations
{
    public partial class InitialCreateAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Timezone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyId = table.Column<int>(nullable: false),
                    DateRecorded = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatingResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RatingId = table.Column<int>(nullable: false),
                    ResultType = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RatingResults_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name", "Timezone" },
                values: new object[] { 1, "Blueberry", "AUS Eastern Standard Time" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name", "Timezone" },
                values: new object[] { 2, "Redberry", "Singapore Standard Time" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name", "Timezone" },
                values: new object[] { 3, "Greenberry", "Australian Western Standard Time" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 8, 1, new DateTimeOffset(new DateTime(2018, 8, 4, 13, 53, 20, 289, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 458, 2, new DateTimeOffset(new DateTime(2018, 4, 17, 15, 25, 35, 414, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 457, 2, new DateTimeOffset(new DateTime(2018, 4, 20, 17, 4, 2, 517, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 456, 2, new DateTimeOffset(new DateTime(2018, 8, 17, 11, 38, 12, 429, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 454, 2, new DateTimeOffset(new DateTime(2018, 4, 20, 13, 20, 12, 355, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 440, 2, new DateTimeOffset(new DateTime(2018, 4, 6, 16, 44, 54, 346, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 435, 2, new DateTimeOffset(new DateTime(2018, 6, 10, 21, 11, 40, 654, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 434, 2, new DateTimeOffset(new DateTime(2018, 5, 27, 16, 45, 31, 841, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 430, 2, new DateTimeOffset(new DateTime(2018, 4, 11, 15, 31, 53, 277, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 429, 2, new DateTimeOffset(new DateTime(2018, 9, 5, 9, 7, 37, 423, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 428, 2, new DateTimeOffset(new DateTime(2018, 5, 12, 22, 45, 42, 586, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 424, 2, new DateTimeOffset(new DateTime(2018, 5, 16, 15, 35, 0, 282, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 423, 2, new DateTimeOffset(new DateTime(2018, 6, 25, 22, 30, 52, 621, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 419, 2, new DateTimeOffset(new DateTime(2018, 7, 13, 12, 9, 57, 750, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 412, 2, new DateTimeOffset(new DateTime(2018, 6, 14, 11, 11, 11, 250, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 411, 2, new DateTimeOffset(new DateTime(2018, 8, 29, 17, 24, 48, 996, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 405, 2, new DateTimeOffset(new DateTime(2018, 7, 11, 12, 28, 42, 92, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 404, 2, new DateTimeOffset(new DateTime(2018, 6, 30, 13, 44, 38, 91, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 403, 2, new DateTimeOffset(new DateTime(2018, 6, 24, 21, 19, 49, 378, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 402, 2, new DateTimeOffset(new DateTime(2018, 5, 22, 13, 54, 41, 124, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 401, 2, new DateTimeOffset(new DateTime(2018, 8, 7, 10, 48, 41, 631, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 399, 2, new DateTimeOffset(new DateTime(2018, 3, 26, 17, 13, 38, 970, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 398, 2, new DateTimeOffset(new DateTime(2018, 7, 1, 13, 32, 56, 637, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 391, 2, new DateTimeOffset(new DateTime(2018, 4, 24, 15, 44, 7, 809, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 386, 2, new DateTimeOffset(new DateTime(2018, 9, 1, 17, 4, 43, 774, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 385, 2, new DateTimeOffset(new DateTime(2018, 7, 11, 12, 35, 54, 845, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 378, 2, new DateTimeOffset(new DateTime(2018, 6, 10, 23, 58, 42, 144, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 375, 2, new DateTimeOffset(new DateTime(2018, 8, 14, 19, 7, 58, 372, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 462, 2, new DateTimeOffset(new DateTime(2018, 4, 9, 9, 58, 13, 19, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 364, 2, new DateTimeOffset(new DateTime(2018, 6, 5, 15, 46, 59, 777, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 465, 2, new DateTimeOffset(new DateTime(2018, 5, 5, 18, 56, 31, 28, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 469, 2, new DateTimeOffset(new DateTime(2018, 4, 13, 1, 24, 19, 673, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 66, 3, new DateTimeOffset(new DateTime(2018, 8, 7, 11, 7, 27, 532, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 61, 3, new DateTimeOffset(new DateTime(2018, 8, 7, 15, 56, 41, 796, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 58, 3, new DateTimeOffset(new DateTime(2018, 4, 23, 21, 50, 54, 662, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 57, 3, new DateTimeOffset(new DateTime(2018, 4, 13, 12, 16, 7, 936, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 56, 3, new DateTimeOffset(new DateTime(2018, 9, 2, 13, 27, 2, 250, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 50, 3, new DateTimeOffset(new DateTime(2018, 5, 7, 9, 14, 20, 634, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 45, 3, new DateTimeOffset(new DateTime(2018, 8, 18, 15, 35, 0, 677, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 44, 3, new DateTimeOffset(new DateTime(2018, 8, 28, 15, 53, 42, 968, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 42, 3, new DateTimeOffset(new DateTime(2018, 4, 29, 12, 58, 0, 413, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 41, 3, new DateTimeOffset(new DateTime(2018, 5, 9, 12, 39, 9, 85, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 39, 3, new DateTimeOffset(new DateTime(2018, 5, 27, 11, 57, 14, 240, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 30, 3, new DateTimeOffset(new DateTime(2018, 6, 16, 10, 8, 49, 444, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 24, 3, new DateTimeOffset(new DateTime(2018, 8, 22, 13, 43, 42, 972, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 23, 3, new DateTimeOffset(new DateTime(2018, 5, 5, 18, 13, 43, 940, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 22, 3, new DateTimeOffset(new DateTime(2018, 4, 21, 18, 46, 24, 486, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 18, 3, new DateTimeOffset(new DateTime(2018, 8, 19, 10, 53, 35, 948, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 16, 3, new DateTimeOffset(new DateTime(2018, 6, 20, 14, 41, 44, 953, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 6, 3, new DateTimeOffset(new DateTime(2018, 8, 12, 19, 28, 42, 443, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 3, 3, new DateTimeOffset(new DateTime(2018, 4, 15, 14, 16, 27, 570, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 1, 3, new DateTimeOffset(new DateTime(2018, 6, 7, 16, 44, 42, 936, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 496, 2, new DateTimeOffset(new DateTime(2018, 4, 21, 10, 58, 47, 623, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 490, 2, new DateTimeOffset(new DateTime(2018, 7, 26, 18, 11, 26, 57, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 488, 2, new DateTimeOffset(new DateTime(2018, 8, 18, 9, 55, 9, 572, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 487, 2, new DateTimeOffset(new DateTime(2018, 6, 9, 14, 7, 32, 774, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 486, 2, new DateTimeOffset(new DateTime(2018, 5, 21, 11, 40, 44, 40, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 482, 2, new DateTimeOffset(new DateTime(2018, 8, 1, 11, 29, 38, 750, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 472, 2, new DateTimeOffset(new DateTime(2018, 7, 13, 15, 22, 52, 542, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 467, 2, new DateTimeOffset(new DateTime(2018, 6, 25, 11, 41, 0, 985, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 360, 2, new DateTimeOffset(new DateTime(2018, 7, 29, 16, 8, 44, 365, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 353, 2, new DateTimeOffset(new DateTime(2018, 7, 21, 14, 10, 22, 4, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 352, 2, new DateTimeOffset(new DateTime(2018, 8, 31, 10, 3, 17, 864, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 250, 2, new DateTimeOffset(new DateTime(2018, 5, 25, 20, 12, 44, 508, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 249, 2, new DateTimeOffset(new DateTime(2018, 3, 26, 9, 50, 36, 817, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 245, 2, new DateTimeOffset(new DateTime(2018, 4, 24, 13, 1, 8, 558, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 244, 2, new DateTimeOffset(new DateTime(2018, 4, 27, 12, 3, 24, 737, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 243, 2, new DateTimeOffset(new DateTime(2018, 5, 2, 17, 33, 23, 17, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 240, 2, new DateTimeOffset(new DateTime(2018, 5, 18, 17, 53, 8, 88, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 238, 2, new DateTimeOffset(new DateTime(2018, 8, 10, 13, 8, 12, 62, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 234, 2, new DateTimeOffset(new DateTime(2018, 4, 6, 13, 50, 12, 256, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 233, 2, new DateTimeOffset(new DateTime(2018, 6, 22, 15, 35, 35, 961, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 232, 2, new DateTimeOffset(new DateTime(2018, 8, 30, 10, 17, 24, 324, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 230, 2, new DateTimeOffset(new DateTime(2018, 6, 11, 15, 43, 7, 24, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 229, 2, new DateTimeOffset(new DateTime(2018, 4, 15, 11, 57, 41, 135, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 228, 2, new DateTimeOffset(new DateTime(2018, 5, 20, 18, 11, 39, 174, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 226, 2, new DateTimeOffset(new DateTime(2018, 6, 21, 15, 14, 32, 502, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 224, 2, new DateTimeOffset(new DateTime(2018, 6, 24, 12, 3, 34, 130, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 220, 2, new DateTimeOffset(new DateTime(2018, 5, 25, 10, 15, 3, 853, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 219, 2, new DateTimeOffset(new DateTime(2018, 7, 11, 21, 47, 30, 759, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 216, 2, new DateTimeOffset(new DateTime(2018, 4, 22, 3, 36, 40, 703, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 214, 2, new DateTimeOffset(new DateTime(2018, 4, 8, 15, 30, 22, 814, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 209, 2, new DateTimeOffset(new DateTime(2018, 4, 27, 15, 8, 51, 863, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 208, 2, new DateTimeOffset(new DateTime(2018, 5, 31, 19, 23, 55, 482, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 205, 2, new DateTimeOffset(new DateTime(2018, 7, 20, 10, 56, 56, 373, DateTimeKind.Unspecified), new TimeSpan(0, 6, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 203, 2, new DateTimeOffset(new DateTime(2018, 7, 22, 10, 29, 49, 291, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 199, 2, new DateTimeOffset(new DateTime(2018, 7, 23, 13, 18, 48, 467, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 197, 2, new DateTimeOffset(new DateTime(2018, 6, 25, 16, 23, 30, 114, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 193, 2, new DateTimeOffset(new DateTime(2018, 9, 5, 12, 25, 12, 197, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 191, 2, new DateTimeOffset(new DateTime(2018, 8, 25, 12, 2, 8, 286, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 254, 2, new DateTimeOffset(new DateTime(2018, 7, 4, 14, 41, 38, 733, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 262, 2, new DateTimeOffset(new DateTime(2018, 7, 19, 13, 54, 24, 303, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 264, 2, new DateTimeOffset(new DateTime(2018, 5, 28, 11, 29, 28, 511, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 267, 2, new DateTimeOffset(new DateTime(2018, 7, 18, 12, 19, 10, 794, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 344, 2, new DateTimeOffset(new DateTime(2018, 4, 14, 20, 8, 14, 297, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 342, 2, new DateTimeOffset(new DateTime(2018, 8, 25, 11, 35, 21, 64, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 340, 2, new DateTimeOffset(new DateTime(2018, 7, 1, 16, 14, 9, 194, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 335, 2, new DateTimeOffset(new DateTime(2018, 8, 7, 16, 0, 31, 854, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 331, 2, new DateTimeOffset(new DateTime(2018, 4, 27, 11, 54, 40, 622, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 328, 2, new DateTimeOffset(new DateTime(2018, 7, 28, 15, 47, 40, 456, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 327, 2, new DateTimeOffset(new DateTime(2018, 4, 27, 13, 43, 50, 124, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 320, 2, new DateTimeOffset(new DateTime(2018, 4, 2, 12, 6, 13, 460, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 316, 2, new DateTimeOffset(new DateTime(2018, 8, 12, 12, 58, 17, 630, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 313, 2, new DateTimeOffset(new DateTime(2018, 6, 29, 18, 41, 23, 64, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 311, 2, new DateTimeOffset(new DateTime(2018, 6, 23, 13, 0, 5, 923, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 310, 2, new DateTimeOffset(new DateTime(2018, 7, 5, 14, 50, 33, 693, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 309, 2, new DateTimeOffset(new DateTime(2018, 7, 18, 10, 5, 14, 158, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 69, 3, new DateTimeOffset(new DateTime(2018, 6, 15, 20, 15, 19, 312, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 307, 2, new DateTimeOffset(new DateTime(2018, 6, 9, 10, 54, 58, 604, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 297, 2, new DateTimeOffset(new DateTime(2018, 6, 26, 16, 50, 56, 478, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 296, 2, new DateTimeOffset(new DateTime(2018, 8, 11, 15, 42, 31, 868, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 294, 2, new DateTimeOffset(new DateTime(2018, 6, 17, 21, 15, 48, 531, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 288, 2, new DateTimeOffset(new DateTime(2018, 6, 19, 12, 53, 1, 524, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 287, 2, new DateTimeOffset(new DateTime(2018, 4, 27, 15, 35, 54, 611, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 285, 2, new DateTimeOffset(new DateTime(2018, 7, 15, 16, 13, 12, 497, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 284, 2, new DateTimeOffset(new DateTime(2018, 5, 24, 14, 52, 2, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 283, 2, new DateTimeOffset(new DateTime(2018, 5, 31, 19, 43, 12, 281, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 279, 2, new DateTimeOffset(new DateTime(2018, 6, 1, 17, 33, 28, 452, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 278, 2, new DateTimeOffset(new DateTime(2018, 6, 9, 20, 15, 47, 833, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 275, 2, new DateTimeOffset(new DateTime(2018, 4, 4, 21, 40, 1, 990, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 272, 2, new DateTimeOffset(new DateTime(2018, 5, 22, 9, 50, 21, 964, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 271, 2, new DateTimeOffset(new DateTime(2018, 7, 12, 18, 48, 5, 351, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 306, 2, new DateTimeOffset(new DateTime(2018, 5, 11, 15, 53, 9, 960, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 190, 2, new DateTimeOffset(new DateTime(2018, 7, 29, 12, 26, 7, 891, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 72, 3, new DateTimeOffset(new DateTime(2018, 5, 4, 15, 39, 12, 273, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 77, 3, new DateTimeOffset(new DateTime(2018, 8, 25, 16, 46, 8, 262, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 407, 3, new DateTimeOffset(new DateTime(2018, 6, 19, 14, 15, 55, 54, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 397, 3, new DateTimeOffset(new DateTime(2018, 7, 16, 11, 13, 31, 326, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 395, 3, new DateTimeOffset(new DateTime(2018, 7, 5, 12, 42, 20, 703, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 389, 3, new DateTimeOffset(new DateTime(2018, 4, 3, 14, 31, 46, 386, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 388, 3, new DateTimeOffset(new DateTime(2018, 8, 8, 15, 40, 16, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 387, 3, new DateTimeOffset(new DateTime(2018, 4, 28, 11, 1, 36, 67, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 384, 3, new DateTimeOffset(new DateTime(2018, 8, 13, 12, 5, 56, 732, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 383, 3, new DateTimeOffset(new DateTime(2018, 7, 24, 19, 22, 55, 700, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 382, 3, new DateTimeOffset(new DateTime(2018, 6, 7, 11, 54, 39, 30, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 374, 3, new DateTimeOffset(new DateTime(2018, 6, 2, 15, 36, 2, 964, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 373, 3, new DateTimeOffset(new DateTime(2018, 7, 5, 16, 5, 11, 645, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 371, 3, new DateTimeOffset(new DateTime(2018, 4, 8, 11, 38, 41, 948, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 368, 3, new DateTimeOffset(new DateTime(2018, 4, 26, 14, 13, 8, 920, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 367, 3, new DateTimeOffset(new DateTime(2018, 7, 7, 13, 31, 18, 348, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 366, 3, new DateTimeOffset(new DateTime(2018, 7, 13, 8, 7, 44, 809, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 358, 3, new DateTimeOffset(new DateTime(2018, 5, 11, 17, 26, 57, 844, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 357, 3, new DateTimeOffset(new DateTime(2018, 4, 21, 17, 46, 21, 509, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 349, 3, new DateTimeOffset(new DateTime(2018, 6, 23, 16, 3, 50, 216, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 345, 3, new DateTimeOffset(new DateTime(2018, 8, 11, 16, 59, 51, 178, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 339, 3, new DateTimeOffset(new DateTime(2018, 5, 15, 22, 52, 23, 100, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 338, 3, new DateTimeOffset(new DateTime(2018, 4, 28, 13, 36, 25, 788, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 336, 3, new DateTimeOffset(new DateTime(2018, 5, 4, 10, 42, 27, 240, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 324, 3, new DateTimeOffset(new DateTime(2018, 6, 29, 22, 0, 45, 709, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 319, 3, new DateTimeOffset(new DateTime(2018, 4, 19, 11, 14, 31, 297, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 317, 3, new DateTimeOffset(new DateTime(2018, 4, 21, 19, 27, 46, 867, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 304, 3, new DateTimeOffset(new DateTime(2018, 5, 6, 14, 37, 41, 67, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 303, 3, new DateTimeOffset(new DateTime(2018, 6, 13, 22, 8, 18, 692, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 409, 3, new DateTimeOffset(new DateTime(2018, 7, 12, 19, 53, 44, 279, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 302, 3, new DateTimeOffset(new DateTime(2018, 5, 26, 11, 37, 50, 505, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 410, 3, new DateTimeOffset(new DateTime(2018, 4, 29, 15, 16, 18, 165, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 416, 3, new DateTimeOffset(new DateTime(2018, 6, 11, 15, 14, 48, 68, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 494, 3, new DateTimeOffset(new DateTime(2018, 6, 24, 13, 3, 43, 109, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 493, 3, new DateTimeOffset(new DateTime(2018, 4, 21, 15, 37, 27, 811, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 489, 3, new DateTimeOffset(new DateTime(2018, 4, 29, 11, 28, 4, 868, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 485, 3, new DateTimeOffset(new DateTime(2018, 5, 6, 13, 13, 2, 480, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 483, 3, new DateTimeOffset(new DateTime(2018, 6, 4, 11, 5, 46, 860, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 481, 3, new DateTimeOffset(new DateTime(2018, 6, 14, 18, 35, 37, 620, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 479, 3, new DateTimeOffset(new DateTime(2018, 7, 17, 17, 34, 21, 921, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 477, 3, new DateTimeOffset(new DateTime(2018, 3, 24, 19, 20, 9, 439, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 475, 3, new DateTimeOffset(new DateTime(2018, 7, 1, 15, 43, 59, 897, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 473, 3, new DateTimeOffset(new DateTime(2018, 4, 10, 12, 11, 23, 260, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 466, 3, new DateTimeOffset(new DateTime(2018, 6, 18, 9, 14, 27, 579, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 464, 3, new DateTimeOffset(new DateTime(2018, 5, 20, 14, 29, 32, 248, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 463, 3, new DateTimeOffset(new DateTime(2018, 4, 19, 20, 1, 32, 36, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 461, 3, new DateTimeOffset(new DateTime(2018, 7, 17, 20, 22, 42, 526, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 460, 3, new DateTimeOffset(new DateTime(2018, 5, 12, 12, 58, 2, 25, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 455, 3, new DateTimeOffset(new DateTime(2018, 6, 4, 12, 31, 50, 509, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 452, 3, new DateTimeOffset(new DateTime(2018, 8, 5, 11, 17, 19, 311, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 449, 3, new DateTimeOffset(new DateTime(2018, 8, 25, 19, 21, 26, 190, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 448, 3, new DateTimeOffset(new DateTime(2018, 5, 31, 20, 19, 15, 923, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 446, 3, new DateTimeOffset(new DateTime(2018, 7, 15, 14, 36, 11, 932, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 442, 3, new DateTimeOffset(new DateTime(2018, 7, 12, 9, 48, 43, 760, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 438, 3, new DateTimeOffset(new DateTime(2018, 6, 23, 13, 18, 34, 283, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 427, 3, new DateTimeOffset(new DateTime(2018, 7, 11, 11, 42, 20, 715, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 425, 3, new DateTimeOffset(new DateTime(2018, 7, 21, 13, 19, 11, 462, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 420, 3, new DateTimeOffset(new DateTime(2018, 8, 28, 21, 46, 36, 776, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 418, 3, new DateTimeOffset(new DateTime(2018, 6, 27, 16, 0, 46, 494, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 417, 3, new DateTimeOffset(new DateTime(2018, 4, 14, 9, 41, 29, 371, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 415, 3, new DateTimeOffset(new DateTime(2018, 9, 1, 21, 15, 49, 847, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 301, 3, new DateTimeOffset(new DateTime(2018, 6, 1, 14, 10, 10, 714, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 298, 3, new DateTimeOffset(new DateTime(2018, 9, 3, 17, 14, 23, 226, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 295, 3, new DateTimeOffset(new DateTime(2018, 8, 9, 10, 6, 14, 608, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 164, 3, new DateTimeOffset(new DateTime(2018, 5, 18, 19, 17, 24, 175, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 163, 3, new DateTimeOffset(new DateTime(2018, 8, 12, 13, 51, 57, 703, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 158, 3, new DateTimeOffset(new DateTime(2018, 8, 14, 14, 7, 15, 8, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 156, 3, new DateTimeOffset(new DateTime(2018, 6, 12, 15, 35, 10, 102, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 155, 3, new DateTimeOffset(new DateTime(2018, 4, 12, 19, 32, 56, 966, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 151, 3, new DateTimeOffset(new DateTime(2018, 4, 8, 10, 4, 42, 609, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 150, 3, new DateTimeOffset(new DateTime(2018, 5, 10, 10, 6, 30, 935, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 148, 3, new DateTimeOffset(new DateTime(2018, 4, 22, 14, 14, 27, 754, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 146, 3, new DateTimeOffset(new DateTime(2018, 6, 21, 13, 16, 11, 6, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 145, 3, new DateTimeOffset(new DateTime(2018, 4, 17, 17, 54, 56, 565, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 139, 3, new DateTimeOffset(new DateTime(2018, 4, 29, 10, 59, 10, 121, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 137, 3, new DateTimeOffset(new DateTime(2018, 6, 26, 16, 20, 42, 646, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 129, 3, new DateTimeOffset(new DateTime(2018, 6, 16, 14, 33, 18, 621, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 127, 3, new DateTimeOffset(new DateTime(2018, 7, 1, 15, 25, 48, 181, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 125, 3, new DateTimeOffset(new DateTime(2018, 7, 5, 15, 57, 42, 609, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 116, 3, new DateTimeOffset(new DateTime(2018, 3, 26, 17, 23, 17, 868, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 102, 3, new DateTimeOffset(new DateTime(2018, 5, 6, 12, 21, 38, 126, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 100, 3, new DateTimeOffset(new DateTime(2018, 7, 30, 14, 26, 9, 24, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 98, 3, new DateTimeOffset(new DateTime(2018, 7, 6, 11, 3, 19, 373, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 97, 3, new DateTimeOffset(new DateTime(2018, 4, 25, 11, 31, 6, 73, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 94, 3, new DateTimeOffset(new DateTime(2018, 8, 25, 8, 54, 15, 429, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 90, 3, new DateTimeOffset(new DateTime(2018, 8, 2, 10, 6, 54, 376, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 85, 3, new DateTimeOffset(new DateTime(2018, 6, 19, 18, 40, 46, 141, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 84, 3, new DateTimeOffset(new DateTime(2018, 7, 12, 12, 32, 9, 261, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 82, 3, new DateTimeOffset(new DateTime(2018, 8, 15, 15, 7, 30, 64, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 81, 3, new DateTimeOffset(new DateTime(2018, 7, 13, 20, 58, 26, 413, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 78, 3, new DateTimeOffset(new DateTime(2018, 8, 17, 12, 4, 38, 839, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 166, 3, new DateTimeOffset(new DateTime(2018, 5, 2, 14, 9, 0, 589, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 177, 3, new DateTimeOffset(new DateTime(2018, 4, 12, 18, 52, 31, 238, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 180, 3, new DateTimeOffset(new DateTime(2018, 8, 9, 13, 4, 1, 318, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 184, 3, new DateTimeOffset(new DateTime(2018, 8, 21, 18, 14, 45, 606, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 291, 3, new DateTimeOffset(new DateTime(2018, 4, 1, 19, 47, 44, 433, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 290, 3, new DateTimeOffset(new DateTime(2018, 6, 21, 15, 20, 12, 348, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 289, 3, new DateTimeOffset(new DateTime(2018, 7, 15, 12, 36, 9, 144, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 286, 3, new DateTimeOffset(new DateTime(2018, 5, 12, 15, 8, 10, 857, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 282, 3, new DateTimeOffset(new DateTime(2018, 7, 31, 16, 3, 7, 831, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 276, 3, new DateTimeOffset(new DateTime(2018, 6, 15, 18, 21, 46, 121, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 274, 3, new DateTimeOffset(new DateTime(2018, 4, 30, 10, 0, 53, 560, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 269, 3, new DateTimeOffset(new DateTime(2018, 5, 30, 17, 8, 16, 634, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 261, 3, new DateTimeOffset(new DateTime(2018, 4, 30, 15, 53, 29, 648, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 260, 3, new DateTimeOffset(new DateTime(2018, 4, 5, 17, 46, 18, 796, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 259, 3, new DateTimeOffset(new DateTime(2018, 6, 15, 20, 17, 9, 827, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 257, 3, new DateTimeOffset(new DateTime(2018, 5, 11, 16, 59, 23, 602, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 256, 3, new DateTimeOffset(new DateTime(2018, 7, 16, 16, 32, 54, 915, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 76, 3, new DateTimeOffset(new DateTime(2018, 6, 14, 14, 56, 50, 832, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 255, 3, new DateTimeOffset(new DateTime(2018, 4, 4, 18, 53, 40, 501, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 236, 3, new DateTimeOffset(new DateTime(2018, 5, 5, 11, 26, 49, 676, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 235, 3, new DateTimeOffset(new DateTime(2018, 5, 13, 21, 28, 27, 158, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 227, 3, new DateTimeOffset(new DateTime(2018, 8, 4, 16, 52, 7, 866, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 225, 3, new DateTimeOffset(new DateTime(2018, 3, 30, 16, 31, 53, 762, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 223, 3, new DateTimeOffset(new DateTime(2018, 4, 29, 14, 33, 58, 421, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 221, 3, new DateTimeOffset(new DateTime(2018, 3, 29, 17, 50, 22, 523, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 218, 3, new DateTimeOffset(new DateTime(2018, 6, 3, 13, 34, 20, 319, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 202, 3, new DateTimeOffset(new DateTime(2018, 3, 29, 7, 58, 32, 883, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 201, 3, new DateTimeOffset(new DateTime(2018, 7, 27, 14, 38, 10, 880, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 200, 3, new DateTimeOffset(new DateTime(2018, 6, 10, 10, 41, 27, 265, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 198, 3, new DateTimeOffset(new DateTime(2018, 6, 21, 14, 27, 53, 909, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 196, 3, new DateTimeOffset(new DateTime(2018, 7, 18, 20, 31, 56, 718, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 195, 3, new DateTimeOffset(new DateTime(2018, 9, 1, 15, 0, 36, 806, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 242, 3, new DateTimeOffset(new DateTime(2018, 7, 2, 13, 53, 53, 657, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 189, 2, new DateTimeOffset(new DateTime(2018, 5, 11, 17, 3, 38, 521, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 187, 2, new DateTimeOffset(new DateTime(2018, 8, 18, 11, 16, 46, 686, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 182, 2, new DateTimeOffset(new DateTime(2018, 8, 9, 11, 59, 1, 395, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 273, 1, new DateTimeOffset(new DateTime(2018, 8, 18, 12, 56, 47, 848, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 270, 1, new DateTimeOffset(new DateTime(2018, 6, 18, 12, 52, 58, 265, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 268, 1, new DateTimeOffset(new DateTime(2018, 4, 21, 14, 56, 1, 68, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 266, 1, new DateTimeOffset(new DateTime(2018, 7, 29, 12, 1, 13, 823, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 265, 1, new DateTimeOffset(new DateTime(2018, 4, 20, 18, 49, 3, 390, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 263, 1, new DateTimeOffset(new DateTime(2018, 8, 9, 13, 18, 20, 983, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 258, 1, new DateTimeOffset(new DateTime(2018, 5, 26, 10, 54, 23, 372, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 253, 1, new DateTimeOffset(new DateTime(2018, 6, 13, 19, 47, 42, 600, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 252, 1, new DateTimeOffset(new DateTime(2018, 5, 4, 16, 30, 12, 31, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 251, 1, new DateTimeOffset(new DateTime(2018, 7, 8, 12, 29, 52, 271, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 248, 1, new DateTimeOffset(new DateTime(2018, 8, 6, 20, 27, 29, 132, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 247, 1, new DateTimeOffset(new DateTime(2018, 4, 5, 17, 32, 57, 949, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 246, 1, new DateTimeOffset(new DateTime(2018, 8, 12, 10, 6, 29, 101, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 241, 1, new DateTimeOffset(new DateTime(2018, 7, 13, 18, 20, 47, 443, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 239, 1, new DateTimeOffset(new DateTime(2018, 8, 24, 14, 13, 11, 643, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 237, 1, new DateTimeOffset(new DateTime(2018, 7, 17, 15, 53, 43, 90, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 231, 1, new DateTimeOffset(new DateTime(2018, 8, 9, 18, 31, 28, 175, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 222, 1, new DateTimeOffset(new DateTime(2018, 7, 14, 13, 59, 55, 157, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 217, 1, new DateTimeOffset(new DateTime(2018, 8, 11, 16, 13, 0, 204, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 215, 1, new DateTimeOffset(new DateTime(2018, 7, 1, 18, 2, 4, 262, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 213, 1, new DateTimeOffset(new DateTime(2018, 3, 28, 16, 4, 58, 929, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 212, 1, new DateTimeOffset(new DateTime(2018, 6, 11, 1, 33, 13, 725, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 211, 1, new DateTimeOffset(new DateTime(2018, 6, 5, 11, 30, 8, 930, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 210, 1, new DateTimeOffset(new DateTime(2018, 6, 25, 17, 29, 57, 822, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 207, 1, new DateTimeOffset(new DateTime(2018, 6, 23, 22, 15, 40, 967, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 206, 1, new DateTimeOffset(new DateTime(2018, 4, 28, 12, 55, 27, 641, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 204, 1, new DateTimeOffset(new DateTime(2018, 4, 29, 11, 49, 9, 385, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 277, 1, new DateTimeOffset(new DateTime(2018, 9, 2, 18, 37, 14, 839, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 194, 1, new DateTimeOffset(new DateTime(2018, 6, 22, 18, 15, 45, 788, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 280, 1, new DateTimeOffset(new DateTime(2018, 6, 16, 14, 29, 17, 559, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 292, 1, new DateTimeOffset(new DateTime(2018, 9, 1, 17, 5, 46, 25, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 351, 1, new DateTimeOffset(new DateTime(2018, 6, 2, 7, 56, 17, 667, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 350, 1, new DateTimeOffset(new DateTime(2018, 4, 18, 7, 36, 53, 55, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 348, 1, new DateTimeOffset(new DateTime(2018, 8, 7, 14, 12, 32, 33, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 347, 1, new DateTimeOffset(new DateTime(2018, 5, 23, 16, 9, 46, 272, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 346, 1, new DateTimeOffset(new DateTime(2018, 5, 15, 16, 42, 9, 816, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 343, 1, new DateTimeOffset(new DateTime(2018, 6, 3, 15, 43, 15, 655, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 341, 1, new DateTimeOffset(new DateTime(2018, 7, 14, 15, 46, 28, 68, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 337, 1, new DateTimeOffset(new DateTime(2018, 6, 24, 13, 52, 50, 216, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 334, 1, new DateTimeOffset(new DateTime(2018, 6, 8, 16, 56, 40, 874, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 333, 1, new DateTimeOffset(new DateTime(2018, 7, 11, 17, 29, 48, 319, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 332, 1, new DateTimeOffset(new DateTime(2018, 5, 7, 19, 13, 29, 714, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 330, 1, new DateTimeOffset(new DateTime(2018, 8, 22, 18, 2, 6, 43, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 329, 1, new DateTimeOffset(new DateTime(2018, 5, 4, 11, 14, 46, 944, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 326, 1, new DateTimeOffset(new DateTime(2018, 7, 2, 15, 12, 43, 995, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 325, 1, new DateTimeOffset(new DateTime(2018, 4, 17, 14, 18, 54, 19, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 323, 1, new DateTimeOffset(new DateTime(2018, 8, 17, 19, 39, 2, 325, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 322, 1, new DateTimeOffset(new DateTime(2018, 6, 15, 20, 13, 8, 738, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 321, 1, new DateTimeOffset(new DateTime(2018, 6, 29, 13, 15, 22, 680, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 318, 1, new DateTimeOffset(new DateTime(2018, 4, 2, 13, 55, 21, 257, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 315, 1, new DateTimeOffset(new DateTime(2018, 7, 7, 12, 57, 27, 792, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 314, 1, new DateTimeOffset(new DateTime(2018, 8, 20, 14, 15, 50, 846, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 312, 1, new DateTimeOffset(new DateTime(2018, 6, 26, 21, 13, 31, 550, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 308, 1, new DateTimeOffset(new DateTime(2018, 4, 10, 16, 31, 52, 342, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 305, 1, new DateTimeOffset(new DateTime(2018, 4, 19, 16, 4, 42, 507, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 300, 1, new DateTimeOffset(new DateTime(2018, 4, 25, 2, 47, 58, 529, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 299, 1, new DateTimeOffset(new DateTime(2018, 6, 9, 14, 53, 56, 329, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 293, 1, new DateTimeOffset(new DateTime(2018, 7, 17, 11, 33, 41, 279, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 281, 1, new DateTimeOffset(new DateTime(2018, 8, 4, 14, 29, 38, 3, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 192, 1, new DateTimeOffset(new DateTime(2018, 8, 3, 15, 33, 3, 444, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 188, 1, new DateTimeOffset(new DateTime(2018, 6, 19, 13, 1, 23, 276, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 186, 1, new DateTimeOffset(new DateTime(2018, 5, 2, 11, 42, 56, 940, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 92, 1, new DateTimeOffset(new DateTime(2018, 8, 11, 13, 51, 54, 78, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 89, 1, new DateTimeOffset(new DateTime(2018, 7, 14, 11, 51, 14, 506, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 88, 1, new DateTimeOffset(new DateTime(2018, 8, 3, 19, 58, 46, 826, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 79, 1, new DateTimeOffset(new DateTime(2018, 6, 24, 17, 48, 49, 419, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 75, 1, new DateTimeOffset(new DateTime(2018, 5, 23, 15, 17, 31, 951, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 74, 1, new DateTimeOffset(new DateTime(2018, 8, 12, 15, 1, 37, 687, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 73, 1, new DateTimeOffset(new DateTime(2018, 7, 7, 14, 51, 56, 558, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 68, 1, new DateTimeOffset(new DateTime(2018, 8, 31, 10, 59, 52, 597, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 65, 1, new DateTimeOffset(new DateTime(2018, 4, 3, 12, 21, 42, 699, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 62, 1, new DateTimeOffset(new DateTime(2018, 8, 20, 9, 45, 26, 424, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 60, 1, new DateTimeOffset(new DateTime(2018, 4, 20, 13, 40, 35, 67, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 59, 1, new DateTimeOffset(new DateTime(2018, 8, 5, 14, 45, 51, 622, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 52, 1, new DateTimeOffset(new DateTime(2018, 3, 31, 15, 47, 16, 469, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 46, 1, new DateTimeOffset(new DateTime(2018, 9, 5, 8, 35, 18, 224, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 40, 1, new DateTimeOffset(new DateTime(2018, 5, 17, 10, 45, 9, 158, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 33, 1, new DateTimeOffset(new DateTime(2018, 6, 15, 20, 27, 47, 398, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 32, 1, new DateTimeOffset(new DateTime(2018, 4, 27, 12, 58, 41, 656, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 29, 1, new DateTimeOffset(new DateTime(2018, 8, 16, 13, 15, 39, 717, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 28, 1, new DateTimeOffset(new DateTime(2018, 8, 12, 18, 50, 50, 666, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 27, 1, new DateTimeOffset(new DateTime(2018, 5, 24, 13, 12, 42, 848, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 26, 1, new DateTimeOffset(new DateTime(2018, 5, 18, 16, 21, 36, 640, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 25, 1, new DateTimeOffset(new DateTime(2018, 7, 22, 11, 37, 16, 801, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 20, 1, new DateTimeOffset(new DateTime(2018, 8, 31, 15, 54, 46, 385, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 19, 1, new DateTimeOffset(new DateTime(2018, 7, 22, 14, 47, 57, 596, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 17, 1, new DateTimeOffset(new DateTime(2018, 8, 4, 17, 51, 35, 633, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 15, 1, new DateTimeOffset(new DateTime(2018, 7, 7, 12, 7, 5, 505, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 11, 1, new DateTimeOffset(new DateTime(2018, 5, 18, 16, 27, 5, 468, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 95, 1, new DateTimeOffset(new DateTime(2018, 5, 6, 11, 58, 0, 666, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 96, 1, new DateTimeOffset(new DateTime(2018, 6, 17, 16, 18, 2, 183, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 99, 1, new DateTimeOffset(new DateTime(2018, 5, 14, 16, 20, 19, 222, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 105, 1, new DateTimeOffset(new DateTime(2018, 6, 22, 13, 51, 1, 670, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 185, 1, new DateTimeOffset(new DateTime(2018, 9, 4, 20, 47, 59, 940, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 183, 1, new DateTimeOffset(new DateTime(2018, 6, 5, 11, 53, 5, 951, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 175, 1, new DateTimeOffset(new DateTime(2018, 7, 26, 12, 0, 37, 376, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 174, 1, new DateTimeOffset(new DateTime(2018, 4, 8, 13, 57, 26, 980, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 169, 1, new DateTimeOffset(new DateTime(2018, 6, 11, 17, 4, 10, 978, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 167, 1, new DateTimeOffset(new DateTime(2018, 5, 29, 18, 8, 29, 164, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 165, 1, new DateTimeOffset(new DateTime(2018, 6, 15, 16, 31, 27, 104, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 161, 1, new DateTimeOffset(new DateTime(2018, 5, 18, 18, 0, 8, 255, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 159, 1, new DateTimeOffset(new DateTime(2018, 6, 27, 20, 41, 51, 28, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 157, 1, new DateTimeOffset(new DateTime(2018, 4, 23, 15, 16, 0, 207, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 154, 1, new DateTimeOffset(new DateTime(2018, 5, 29, 14, 16, 30, 349, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 152, 1, new DateTimeOffset(new DateTime(2018, 8, 1, 16, 19, 14, 261, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 147, 1, new DateTimeOffset(new DateTime(2018, 4, 18, 14, 40, 38, 407, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 354, 1, new DateTimeOffset(new DateTime(2018, 8, 23, 11, 21, 48, 324, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 143, 1, new DateTimeOffset(new DateTime(2018, 7, 21, 20, 54, 44, 57, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 140, 1, new DateTimeOffset(new DateTime(2018, 4, 21, 14, 9, 52, 926, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 138, 1, new DateTimeOffset(new DateTime(2018, 6, 21, 18, 54, 11, 796, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 131, 1, new DateTimeOffset(new DateTime(2018, 8, 26, 16, 8, 35, 286, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 130, 1, new DateTimeOffset(new DateTime(2018, 6, 13, 14, 30, 4, 213, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 126, 1, new DateTimeOffset(new DateTime(2018, 5, 14, 17, 43, 44, 19, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 124, 1, new DateTimeOffset(new DateTime(2018, 4, 24, 11, 12, 25, 131, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 120, 1, new DateTimeOffset(new DateTime(2018, 6, 23, 18, 56, 58, 195, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 119, 1, new DateTimeOffset(new DateTime(2018, 5, 12, 18, 7, 4, 234, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 115, 1, new DateTimeOffset(new DateTime(2018, 9, 4, 16, 57, 27, 452, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 114, 1, new DateTimeOffset(new DateTime(2018, 4, 12, 14, 12, 29, 103, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 113, 1, new DateTimeOffset(new DateTime(2018, 6, 11, 12, 12, 34, 86, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 111, 1, new DateTimeOffset(new DateTime(2018, 5, 8, 19, 19, 44, 637, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 109, 1, new DateTimeOffset(new DateTime(2018, 6, 16, 12, 54, 23, 863, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 142, 1, new DateTimeOffset(new DateTime(2018, 4, 28, 13, 46, 23, 467, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 355, 1, new DateTimeOffset(new DateTime(2018, 5, 13, 15, 21, 18, 660, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 356, 1, new DateTimeOffset(new DateTime(2018, 4, 16, 14, 21, 45, 676, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 359, 1, new DateTimeOffset(new DateTime(2018, 3, 30, 16, 57, 30, 852, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 103, 2, new DateTimeOffset(new DateTime(2018, 7, 5, 12, 9, 3, 639, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 101, 2, new DateTimeOffset(new DateTime(2018, 9, 2, 17, 26, 26, 72, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 93, 2, new DateTimeOffset(new DateTime(2018, 6, 20, 11, 12, 14, 67, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 91, 2, new DateTimeOffset(new DateTime(2018, 9, 1, 14, 52, 39, 528, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 87, 2, new DateTimeOffset(new DateTime(2018, 9, 1, 13, 9, 16, 595, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 86, 2, new DateTimeOffset(new DateTime(2018, 4, 11, 17, 12, 1, 909, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 83, 2, new DateTimeOffset(new DateTime(2018, 6, 30, 20, 6, 32, 25, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 80, 2, new DateTimeOffset(new DateTime(2018, 5, 7, 19, 52, 11, 416, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 71, 2, new DateTimeOffset(new DateTime(2018, 5, 19, 16, 23, 33, 621, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 70, 2, new DateTimeOffset(new DateTime(2018, 8, 21, 16, 59, 30, 492, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 67, 2, new DateTimeOffset(new DateTime(2018, 7, 26, 16, 27, 43, 362, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 64, 2, new DateTimeOffset(new DateTime(2018, 4, 21, 13, 4, 19, 812, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 63, 2, new DateTimeOffset(new DateTime(2018, 6, 26, 15, 41, 8, 774, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 55, 2, new DateTimeOffset(new DateTime(2018, 8, 25, 13, 38, 22, 649, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 54, 2, new DateTimeOffset(new DateTime(2018, 8, 30, 16, 51, 4, 93, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 53, 2, new DateTimeOffset(new DateTime(2018, 5, 27, 20, 23, 2, 158, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 51, 2, new DateTimeOffset(new DateTime(2018, 8, 24, 13, 58, 33, 475, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 49, 2, new DateTimeOffset(new DateTime(2018, 6, 11, 11, 56, 12, 167, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 48, 2, new DateTimeOffset(new DateTime(2018, 4, 16, 13, 35, 8, 185, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 47, 2, new DateTimeOffset(new DateTime(2018, 4, 17, 17, 56, 6, 920, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 43, 2, new DateTimeOffset(new DateTime(2018, 4, 24, 14, 0, 44, 673, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 38, 2, new DateTimeOffset(new DateTime(2018, 4, 27, 16, 50, 55, 495, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 37, 2, new DateTimeOffset(new DateTime(2018, 8, 29, 15, 35, 56, 841, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 36, 2, new DateTimeOffset(new DateTime(2018, 5, 26, 16, 59, 28, 734, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 35, 2, new DateTimeOffset(new DateTime(2018, 5, 27, 12, 6, 43, 476, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 34, 2, new DateTimeOffset(new DateTime(2018, 5, 7, 12, 51, 5, 979, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 31, 2, new DateTimeOffset(new DateTime(2018, 3, 26, 16, 16, 9, 141, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 104, 2, new DateTimeOffset(new DateTime(2018, 7, 11, 15, 52, 29, 414, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 106, 2, new DateTimeOffset(new DateTime(2018, 4, 20, 21, 35, 40, 684, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 107, 2, new DateTimeOffset(new DateTime(2018, 8, 18, 11, 42, 17, 242, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 108, 2, new DateTimeOffset(new DateTime(2018, 5, 16, 15, 41, 24, 172, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 181, 2, new DateTimeOffset(new DateTime(2018, 4, 1, 13, 12, 20, 876, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 179, 2, new DateTimeOffset(new DateTime(2018, 6, 8, 19, 30, 19, 310, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 178, 2, new DateTimeOffset(new DateTime(2018, 7, 8, 11, 18, 39, 963, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 176, 2, new DateTimeOffset(new DateTime(2018, 5, 17, 17, 54, 16, 615, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 173, 2, new DateTimeOffset(new DateTime(2018, 6, 5, 12, 41, 51, 853, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 172, 2, new DateTimeOffset(new DateTime(2018, 4, 13, 15, 5, 8, 619, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 171, 2, new DateTimeOffset(new DateTime(2018, 3, 31, 13, 18, 28, 621, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 170, 2, new DateTimeOffset(new DateTime(2018, 8, 13, 21, 1, 39, 431, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 168, 2, new DateTimeOffset(new DateTime(2018, 7, 8, 8, 10, 13, 235, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 162, 2, new DateTimeOffset(new DateTime(2018, 8, 2, 14, 2, 49, 762, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 160, 2, new DateTimeOffset(new DateTime(2018, 5, 29, 14, 14, 53, 328, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 153, 2, new DateTimeOffset(new DateTime(2018, 7, 18, 13, 11, 27, 148, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 149, 2, new DateTimeOffset(new DateTime(2018, 4, 3, 17, 5, 9, 156, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 21, 2, new DateTimeOffset(new DateTime(2018, 6, 16, 11, 17, 23, 121, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 144, 2, new DateTimeOffset(new DateTime(2018, 7, 17, 14, 43, 30, 666, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 136, 2, new DateTimeOffset(new DateTime(2018, 8, 14, 11, 26, 4, 243, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 135, 2, new DateTimeOffset(new DateTime(2018, 6, 19, 18, 6, 55, 219, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 134, 2, new DateTimeOffset(new DateTime(2018, 4, 10, 15, 13, 35, 518, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 133, 2, new DateTimeOffset(new DateTime(2018, 8, 26, 14, 32, 22, 368, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 132, 2, new DateTimeOffset(new DateTime(2018, 4, 17, 13, 19, 21, 250, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 128, 2, new DateTimeOffset(new DateTime(2018, 7, 11, 15, 57, 41, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 123, 2, new DateTimeOffset(new DateTime(2018, 5, 14, 22, 44, 21, 393, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 122, 2, new DateTimeOffset(new DateTime(2018, 4, 8, 19, 7, 42, 270, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 121, 2, new DateTimeOffset(new DateTime(2018, 5, 30, 16, 8, 26, 792, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 118, 2, new DateTimeOffset(new DateTime(2018, 8, 3, 21, 43, 19, 362, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 117, 2, new DateTimeOffset(new DateTime(2018, 6, 6, 16, 11, 53, 933, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 112, 2, new DateTimeOffset(new DateTime(2018, 4, 17, 14, 14, 31, 468, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 110, 2, new DateTimeOffset(new DateTime(2018, 4, 29, 14, 22, 45, 819, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 141, 2, new DateTimeOffset(new DateTime(2018, 6, 10, 18, 11, 20, 80, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 497, 3, new DateTimeOffset(new DateTime(2018, 8, 21, 18, 14, 2, 256, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 14, 2, new DateTimeOffset(new DateTime(2018, 8, 18, 17, 3, 51, 106, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 12, 2, new DateTimeOffset(new DateTime(2018, 8, 26, 12, 44, 21, 193, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 432, 1, new DateTimeOffset(new DateTime(2018, 8, 10, 14, 27, 47, 947, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 431, 1, new DateTimeOffset(new DateTime(2018, 4, 13, 17, 17, 20, 984, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 426, 1, new DateTimeOffset(new DateTime(2018, 5, 25, 20, 19, 17, 440, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 422, 1, new DateTimeOffset(new DateTime(2018, 6, 1, 19, 14, 36, 754, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 421, 1, new DateTimeOffset(new DateTime(2018, 6, 19, 19, 10, 48, 682, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 414, 1, new DateTimeOffset(new DateTime(2018, 4, 12, 11, 15, 47, 895, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 413, 1, new DateTimeOffset(new DateTime(2018, 6, 17, 16, 7, 51, 951, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 408, 1, new DateTimeOffset(new DateTime(2018, 4, 11, 16, 20, 42, 586, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 406, 1, new DateTimeOffset(new DateTime(2018, 7, 27, 11, 16, 55, 676, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 400, 1, new DateTimeOffset(new DateTime(2018, 8, 4, 13, 52, 15, 393, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 396, 1, new DateTimeOffset(new DateTime(2018, 6, 11, 17, 20, 5, 73, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 394, 1, new DateTimeOffset(new DateTime(2018, 9, 1, 15, 31, 22, 723, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 393, 1, new DateTimeOffset(new DateTime(2018, 5, 4, 9, 38, 54, 16, DateTimeKind.Unspecified), new TimeSpan(0, -7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 392, 1, new DateTimeOffset(new DateTime(2018, 5, 26, 12, 59, 10, 49, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 390, 1, new DateTimeOffset(new DateTime(2018, 8, 10, 12, 20, 28, 25, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 381, 1, new DateTimeOffset(new DateTime(2018, 7, 12, 13, 24, 41, 340, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 380, 1, new DateTimeOffset(new DateTime(2018, 7, 11, 18, 27, 2, 945, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 379, 1, new DateTimeOffset(new DateTime(2018, 4, 27, 14, 9, 45, 742, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 377, 1, new DateTimeOffset(new DateTime(2018, 8, 9, 13, 20, 24, 366, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 376, 1, new DateTimeOffset(new DateTime(2018, 5, 26, 17, 34, 22, 508, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 372, 1, new DateTimeOffset(new DateTime(2018, 6, 19, 11, 11, 4, 612, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 370, 1, new DateTimeOffset(new DateTime(2018, 7, 9, 17, 50, 5, 266, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 369, 1, new DateTimeOffset(new DateTime(2018, 8, 5, 12, 4, 7, 137, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 365, 1, new DateTimeOffset(new DateTime(2018, 7, 25, 16, 27, 8, 346, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 363, 1, new DateTimeOffset(new DateTime(2018, 5, 4, 17, 23, 58, 163, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 362, 1, new DateTimeOffset(new DateTime(2018, 8, 4, 15, 58, 2, 524, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 361, 1, new DateTimeOffset(new DateTime(2018, 7, 10, 14, 17, 16, 41, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 433, 1, new DateTimeOffset(new DateTime(2018, 4, 14, 11, 42, 55, 894, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 436, 1, new DateTimeOffset(new DateTime(2018, 6, 24, 14, 8, 55, 872, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 437, 1, new DateTimeOffset(new DateTime(2018, 7, 28, 12, 6, 32, 365, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 439, 1, new DateTimeOffset(new DateTime(2018, 7, 4, 16, 44, 59, 686, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 10, 2, new DateTimeOffset(new DateTime(2018, 5, 25, 17, 9, 6, 34, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 9, 2, new DateTimeOffset(new DateTime(2018, 8, 5, 14, 30, 51, 231, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 7, 2, new DateTimeOffset(new DateTime(2018, 6, 10, 15, 10, 14, 657, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 5, 2, new DateTimeOffset(new DateTime(2018, 7, 28, 15, 31, 27, 496, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 4, 2, new DateTimeOffset(new DateTime(2018, 5, 30, 15, 16, 16, 902, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 2, 2, new DateTimeOffset(new DateTime(2018, 6, 7, 18, 3, 7, 798, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 500, 1, new DateTimeOffset(new DateTime(2018, 4, 1, 12, 47, 30, 662, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 499, 1, new DateTimeOffset(new DateTime(2018, 4, 10, 15, 40, 44, 281, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 495, 1, new DateTimeOffset(new DateTime(2018, 5, 27, 13, 18, 43, 131, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 492, 1, new DateTimeOffset(new DateTime(2018, 7, 6, 15, 4, 3, 888, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 491, 1, new DateTimeOffset(new DateTime(2018, 5, 9, 15, 39, 15, 113, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 484, 1, new DateTimeOffset(new DateTime(2018, 5, 8, 17, 51, 20, 523, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 480, 1, new DateTimeOffset(new DateTime(2018, 8, 29, 11, 25, 56, 74, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 13, 2, new DateTimeOffset(new DateTime(2018, 6, 6, 13, 20, 10, 515, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 478, 1, new DateTimeOffset(new DateTime(2018, 5, 19, 12, 26, 1, 971, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 474, 1, new DateTimeOffset(new DateTime(2018, 3, 31, 12, 57, 4, 365, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 471, 1, new DateTimeOffset(new DateTime(2018, 7, 7, 16, 11, 57, 14, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 470, 1, new DateTimeOffset(new DateTime(2018, 8, 10, 18, 32, 43, 375, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 468, 1, new DateTimeOffset(new DateTime(2018, 4, 26, 13, 58, 44, 816, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 459, 1, new DateTimeOffset(new DateTime(2018, 6, 11, 15, 48, 46, 195, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 453, 1, new DateTimeOffset(new DateTime(2018, 4, 20, 21, 50, 22, 565, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 451, 1, new DateTimeOffset(new DateTime(2018, 8, 13, 10, 44, 49, 636, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 450, 1, new DateTimeOffset(new DateTime(2018, 5, 22, 14, 52, 34, 726, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 447, 1, new DateTimeOffset(new DateTime(2018, 8, 21, 14, 58, 19, 121, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 445, 1, new DateTimeOffset(new DateTime(2018, 4, 8, 18, 5, 44, 169, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 444, 1, new DateTimeOffset(new DateTime(2018, 7, 3, 15, 22, 17, 426, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 443, 1, new DateTimeOffset(new DateTime(2018, 6, 11, 11, 4, 26, 391, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 441, 1, new DateTimeOffset(new DateTime(2018, 6, 13, 12, 11, 10, 262, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 476, 1, new DateTimeOffset(new DateTime(2018, 8, 6, 12, 38, 39, 864, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CompanyId", "DateRecorded" },
                values: new object[] { 498, 3, new DateTimeOffset(new DateTime(2018, 6, 21, 19, 20, 24, 956, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 11, 8, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 684, 428, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 685, 428, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 686, 429, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 687, 429, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 688, 430, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 695, 434, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 696, 434, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 697, 435, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 698, 435, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 706, 440, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 707, 440, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 730, 454, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 731, 454, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 734, 456, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 735, 456, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 736, 457, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 737, 457, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 738, 458, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 745, 462, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 746, 462, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 750, 465, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 678, 424, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 752, 467, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 677, 424, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 675, 423, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 621, 385, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 622, 385, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 623, 386, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 624, 386, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 629, 391, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 637, 398, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 638, 398, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 639, 399, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 640, 399, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 643, 401, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 644, 401, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 645, 402, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 646, 403, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 647, 403, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 648, 404, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 649, 404, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 650, 405, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 660, 411, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 661, 411, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 662, 412, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 672, 419, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 676, 423, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 753, 467, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 754, 469, 0, "5" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 755, 469, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 65, 39, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 67, 41, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 68, 42, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 69, 42, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 72, 44, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 73, 44, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 74, 45, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 83, 50, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 84, 50, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 93, 56, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 94, 56, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 95, 57, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 96, 57, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 97, 58, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 98, 58, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 103, 61, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 104, 61, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 112, 66, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 113, 66, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 116, 69, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 117, 69, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 64, 39, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 50, 30, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 49, 30, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 39, 24, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 759, 472, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 760, 472, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 777, 482, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 778, 482, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 783, 486, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 784, 486, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 785, 487, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 786, 487, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 787, 488, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 789, 490, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 609, 378, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 790, 490, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 1, 1, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 4, 3, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 9, 6, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 25, 16, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 27, 18, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 34, 22, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 35, 22, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 36, 23, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 37, 23, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 38, 24, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 800, 496, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 122, 72, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 608, 378, 0, "6" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 602, 375, 0, "6" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 373, 226, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 375, 228, 0, "6" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 376, 228, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 377, 229, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 378, 229, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 379, 230, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 380, 230, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 383, 232, 0, "5" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 384, 232, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 385, 233, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 386, 233, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 387, 234, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 393, 238, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 394, 240, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 399, 243, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 400, 244, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 407, 249, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 408, 249, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 409, 250, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 410, 250, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 416, 254, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 372, 226, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 417, 254, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 369, 224, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 362, 220, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 318, 191, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 320, 193, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 324, 197, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 325, 197, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 328, 199, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 329, 199, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 333, 203, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 334, 203, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 337, 205, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 338, 205, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 343, 208, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 344, 208, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 345, 209, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 346, 209, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 351, 214, 0, "3" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 352, 214, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 354, 216, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 355, 216, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 359, 219, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 360, 219, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 361, 220, 0, "6" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 368, 224, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 429, 264, 0, "3" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 430, 264, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 432, 267, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 505, 309, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 506, 309, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 507, 310, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 508, 311, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 517, 320, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 518, 320, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 529, 327, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 530, 327, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 534, 331, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 535, 331, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 539, 335, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 540, 335, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 547, 340, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 550, 342, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 551, 344, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 552, 344, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 565, 352, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 566, 352, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 575, 360, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 582, 364, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 583, 364, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 502, 307, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 501, 307, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 500, 306, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 484, 296, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 433, 267, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 439, 271, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 440, 272, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 441, 272, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 445, 275, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 446, 275, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 451, 278, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 452, 278, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 453, 279, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 454, 279, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 603, 375, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 461, 283, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 463, 284, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 464, 284, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 465, 285, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 468, 287, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 469, 287, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 470, 288, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 471, 288, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 479, 294, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 480, 294, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 483, 296, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 462, 283, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 317, 190, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 123, 72, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 128, 76, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 588, 367, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 589, 368, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 590, 368, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 594, 371, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 595, 371, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 598, 373, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 599, 373, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 600, 374, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 601, 374, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 615, 382, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 616, 382, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 617, 383, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 618, 383, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 619, 384, 0, "5" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 620, 384, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 625, 387, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 626, 388, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 627, 388, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 633, 395, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 634, 395, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 636, 397, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 587, 367, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 653, 407, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 586, 366, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 572, 358, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 490, 301, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 491, 301, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 492, 302, 0, "6" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 493, 302, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 494, 303, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 495, 303, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 496, 304, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 497, 304, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 513, 317, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 516, 319, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 524, 324, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 541, 336, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 543, 338, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 544, 338, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 545, 339, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 546, 339, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 553, 345, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 559, 349, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 560, 349, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 570, 357, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 571, 357, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 585, 366, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 654, 407, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 657, 409, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 658, 410, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 748, 463, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 749, 464, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 751, 466, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 761, 473, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 762, 473, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 764, 475, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 765, 475, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 767, 477, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 768, 477, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 771, 479, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 772, 479, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 775, 481, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 776, 481, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 779, 483, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 782, 485, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 788, 489, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 795, 493, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 796, 494, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 797, 494, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 801, 497, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 802, 497, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 747, 463, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 744, 461, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 743, 461, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 742, 460, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 659, 410, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 666, 415, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 667, 415, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 668, 416, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 669, 417, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 670, 418, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 671, 418, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 673, 420, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 679, 425, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 682, 427, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 486, 298, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 683, 427, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 703, 438, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 710, 442, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 717, 446, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 720, 449, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 721, 449, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 726, 452, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 727, 452, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 732, 455, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 733, 455, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 741, 460, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 702, 438, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 127, 76, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 485, 298, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 481, 295, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 214, 125, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 217, 127, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 218, 127, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 221, 129, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 222, 129, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 234, 137, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 235, 137, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 237, 139, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 243, 145, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 244, 146, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 247, 148, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 248, 148, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 251, 150, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 252, 150, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 253, 151, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 254, 151, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 258, 155, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 259, 155, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 260, 156, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 263, 158, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 264, 158, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 213, 125, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 271, 163, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 198, 116, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 173, 102, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 129, 77, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 130, 77, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 131, 78, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 132, 78, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 137, 81, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 138, 81, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 139, 82, 0, "6" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 140, 82, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 143, 84, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 144, 85, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 145, 85, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 151, 90, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 152, 90, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 158, 94, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 159, 94, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 163, 97, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 164, 98, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 165, 98, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 168, 100, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 169, 100, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 172, 102, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 197, 116, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 272, 163, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 273, 164, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 274, 164, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 397, 242, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 398, 242, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 418, 255, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 419, 255, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 420, 256, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 423, 259, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 424, 260, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 425, 261, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 426, 261, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 436, 269, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 437, 269, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 444, 274, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 447, 276, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 448, 276, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 459, 282, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 460, 282, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 466, 286, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 467, 286, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 472, 290, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 473, 291, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 474, 291, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 391, 236, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 390, 236, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 389, 235, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 388, 235, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 277, 166, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 293, 177, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 294, 177, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 299, 180, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 300, 180, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 306, 184, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 307, 184, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 322, 195, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 323, 196, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 326, 198, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 482, 295, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 327, 198, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 331, 201, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 332, 202, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 358, 218, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 363, 221, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 364, 221, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 366, 223, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 367, 223, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 370, 225, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 371, 225, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 374, 227, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 330, 200, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 803, 498, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 316, 190, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 313, 187, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 413, 252, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 414, 253, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 415, 253, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 421, 258, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 422, 258, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 427, 263, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 428, 263, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 431, 266, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 434, 268, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 435, 268, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 438, 270, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 442, 273, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 443, 273, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 449, 277, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 450, 277, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 455, 280, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 456, 280, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 457, 281, 0, "2" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 458, 281, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 475, 292, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 476, 292, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 412, 251, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 477, 293, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 411, 251, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 405, 248, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 339, 206, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 340, 206, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 341, 207, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 342, 207, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 347, 211, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 348, 211, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 349, 212, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 350, 213, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 353, 215, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 356, 217, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 357, 217, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 365, 222, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 381, 231, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 382, 231, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 392, 237, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 395, 241, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 396, 241, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 401, 246, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 402, 246, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 403, 247, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 404, 247, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 406, 248, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 478, 293, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 487, 299, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 488, 300, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 542, 337, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 548, 341, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 549, 341, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 554, 346, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 555, 346, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 556, 347, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 557, 348, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 558, 348, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 561, 350, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 562, 350, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 563, 351, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 564, 351, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 567, 354, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 568, 354, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 569, 355, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 573, 359, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 574, 359, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 576, 361, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 577, 361, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 578, 362, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 579, 362, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 538, 333, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 537, 332, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 536, 332, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 533, 330, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 489, 300, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 498, 305, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 499, 305, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 503, 308, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 504, 308, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 509, 312, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 510, 312, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 511, 314, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 512, 315, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 514, 318, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 336, 204, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 515, 318, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 520, 321, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 521, 322, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 522, 322, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 523, 323, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 525, 325, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 526, 325, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 527, 326, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 528, 326, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 531, 329, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 532, 329, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 519, 321, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 580, 363, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 335, 204, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 319, 192, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 86, 52, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 99, 59, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 100, 59, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 101, 60, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 102, 60, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 105, 62, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 110, 65, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 111, 65, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 115, 68, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 124, 73, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 125, 74, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 126, 75, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 133, 79, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 134, 79, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 149, 88, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 150, 89, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 155, 92, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 160, 95, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 161, 96, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 162, 96, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 166, 99, 0, "5" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 85, 52, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 167, 99, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 76, 46, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 66, 40, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 12, 8, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 16, 11, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 17, 11, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 24, 15, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 26, 17, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 28, 19, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 29, 19, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 30, 20, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 31, 20, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 40, 25, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 41, 26, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 42, 26, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 43, 27, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 44, 27, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 45, 28, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 46, 28, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 47, 29, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 48, 29, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 53, 32, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 54, 33, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 55, 33, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 75, 46, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 178, 105, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 184, 109, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 185, 109, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 257, 154, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 261, 157, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 262, 157, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 265, 159, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 266, 159, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 269, 161, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 275, 165, 0, "2" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 276, 165, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 278, 167, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 280, 169, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 281, 169, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 288, 174, 0, "2" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 289, 174, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 290, 175, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 304, 183, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 305, 183, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 308, 185, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 309, 185, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 310, 186, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 311, 186, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 314, 188, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 255, 152, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 246, 147, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 245, 147, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 240, 143, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 188, 111, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 189, 111, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 192, 113, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 193, 113, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 194, 114, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 195, 115, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 196, 115, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 202, 119, 0, "5" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 203, 119, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 204, 120, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 321, 194, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 205, 120, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 212, 124, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 215, 126, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 216, 126, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 223, 130, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 224, 130, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 225, 131, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 226, 131, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 236, 138, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 238, 140, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 239, 142, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 211, 124, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 315, 189, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 581, 363, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 591, 369, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 118, 70, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 119, 70, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 120, 71, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 121, 71, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 135, 80, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 136, 80, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 141, 83, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 142, 83, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 146, 86, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 147, 86, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 148, 87, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 153, 91, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 154, 91, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 156, 93, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 157, 93, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 170, 101, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 171, 101, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 174, 103, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 175, 103, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 176, 104, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 177, 104, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 114, 67, 0, "5" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 179, 106, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 109, 64, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 107, 63, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 58, 35, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 59, 35, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 60, 36, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 61, 37, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 62, 38, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 63, 38, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 70, 43, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 71, 43, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 77, 47, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 78, 47, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 79, 48, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 80, 48, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 81, 49, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 82, 49, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 87, 53, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 88, 53, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 89, 54, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 90, 54, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 91, 55, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 92, 55, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 106, 63, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 108, 64, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 180, 106, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 181, 107, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 182, 107, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 256, 153, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 267, 160, 0, "6" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 268, 160, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 270, 162, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 279, 168, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 282, 170, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 283, 170, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 284, 171, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 285, 172, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 286, 172, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 287, 173, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 291, 176, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 292, 176, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 295, 178, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 296, 178, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 297, 179, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 298, 179, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 301, 181, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 302, 182, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 303, 182, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 312, 187, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 250, 149, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 249, 149, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 242, 144, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 241, 144, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 183, 108, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 186, 110, 0, "2" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 187, 110, 1, "The wait was too long" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 190, 112, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 191, 112, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 199, 117, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 200, 117, 1, "How can I get future discounts?" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 201, 118, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 206, 121, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 207, 122, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 57, 34, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 208, 122, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 210, 123, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 219, 128, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 220, 128, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 227, 132, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 228, 133, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 229, 134, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 230, 134, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 231, 135, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 232, 135, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 233, 136, 1, "Great range, keep it up" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 209, 123, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 584, 365, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 56, 34, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 51, 31, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 664, 413, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 665, 414, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 674, 422, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 680, 426, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 681, 426, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 689, 431, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 690, 431, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 691, 432, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 692, 432, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 693, 433, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 694, 433, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 699, 436, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 700, 436, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 701, 437, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 704, 439, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 705, 439, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 708, 441, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 709, 441, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 711, 443, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 712, 443, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 713, 444, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 663, 413, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 714, 444, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 656, 408, 1, "No stock left of what I was after (new summer Ts in S)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 652, 406, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 592, 370, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 593, 370, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 596, 372, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 597, 372, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 604, 376, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 605, 376, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 606, 377, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 607, 377, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 610, 379, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 611, 380, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 612, 380, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 613, 381, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 614, 381, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 628, 390, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 630, 392, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 631, 392, 1, "Service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 632, 393, 1, "Perhaps your staff should pay attention to customers coming in instead of talking amoungst themselves and playing with their phones\"" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 635, 396, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 641, 400, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 642, 400, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 651, 406, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 655, 408, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 715, 445, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 716, 445, 1, "The store could be cleaner" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 718, 447, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 805, 499, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 806, 499, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 807, 500, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 2, 2, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 3, 2, 1, "Quick and easy, service was great" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 5, 4, 0, "8" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 6, 4, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 7, 5, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 8, 5, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 10, 7, 1, "Really happy with the service, special thanks to Jenny" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 13, 9, 0, "2" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 14, 9, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 15, 10, 1, "The staff was VERY rude to me. Never shopping here again :(" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 18, 12, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 19, 12, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 20, 13, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 21, 13, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 22, 14, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 23, 14, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 32, 21, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 33, 21, 1, "I'd love to see more men's t shirts" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 799, 495, 1, "Wow, the the staff really went out of their way to help me, thanks Tim!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 798, 495, 0, "0" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 794, 492, 1, "Thanks for all the help!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 793, 492, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 719, 447, 1, "Why can't you offer a refund, I only bought it yesterday!!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 722, 450, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 723, 450, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 724, 451, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 725, 451, 1, "Beautiful store & staff" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 728, 453, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 729, 453, 1, "All good, but you did run out of the basics (no M sized plain black Tshirts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 739, 459, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 740, 459, 1, "It was a great experience" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 756, 470, 0, "9" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 52, 31, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 757, 471, 0, "7" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 763, 474, 1, "I appreciate all the help I got from the staff." });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 766, 476, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 769, 478, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 770, 478, 1, "Would be great to see more accessories (belts)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 773, 480, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 774, 480, 1, "I love everything here :)" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 780, 484, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 781, 484, 1, "It was ok" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 791, 491, 0, "10" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 792, 491, 1, "You didn't have the product I wanted!" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 758, 471, 1, "The prices should be a bit easier to read. The tag colours are hard to distiguish" });

            migrationBuilder.InsertData(
                table: "RatingResults",
                columns: new[] { "Id", "RatingId", "ResultType", "Value" },
                values: new object[] { 804, 498, 1, "Service was great" });

            migrationBuilder.CreateIndex(
                name: "IX_RatingResults_RatingId",
                table: "RatingResults",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CompanyId",
                table: "Ratings",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RatingResults");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
