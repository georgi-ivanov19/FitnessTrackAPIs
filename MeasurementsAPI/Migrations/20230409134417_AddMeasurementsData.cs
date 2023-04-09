using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeasurementsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMeasurementsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "Id", "Date", "Type", "Unit", "Value", "applicationUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1223), "Weight", "kg", 84.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 2, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1272), "Weight", "kg", 82.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 3, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1276), "Weight", "kg", 80.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 4, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1278), "Weight", "kg", 85.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 5, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1281), "Weight", "kg", 81.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 6, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1285), "Weight", "kg", 86.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 7, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1288), "Weight", "kg", 84.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 8, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1291), "Weight", "kg", 80.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 9, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1293), "Weight", "kg", 86.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 10, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1297), "Weight", "kg", 80.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 11, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1300), "Weight", "kg", 82.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 12, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1303), "Weight", "kg", 81.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 13, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1306), "Weight", "kg", 85.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 14, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1308), "Weight", "kg", 83.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 15, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1312), "Weight", "kg", 83.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 16, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1315), "Weight", "kg", 82.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 17, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1318), "Weight", "kg", 82.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 18, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1322), "Weight", "kg", 86.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 19, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1325), "Weight", "kg", 83.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 20, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1327), "Weight", "kg", 82.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 21, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1330), "Weight", "kg", 85.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 22, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1333), "Weight", "kg", 86.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 23, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1335), "Weight", "kg", 86.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 24, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1338), "Weight", "kg", 84.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 25, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1341), "Weight", "kg", 85.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 26, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1344), "Weight", "kg", 86.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 27, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1347), "Weight", "kg", 82.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 28, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1349), "Weight", "kg", 84.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 29, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1352), "Weight", "kg", 82.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 30, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1355), "Weight", "kg", 82.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 31, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1358), "Weight", "kg", 85.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 32, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1361), "Weight", "kg", 86.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 33, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1363), "Weight", "kg", 86.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 34, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1367), "Weight", "kg", 83.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 35, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1370), "Weight", "kg", 81.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 36, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1373), "Weight", "kg", 82.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 37, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1376), "Weight", "kg", 80.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 38, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1378), "Weight", "kg", 85.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 39, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1381), "Weight", "kg", 84.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 40, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1384), "Weight", "kg", 82.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 41, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1387), "Weight", "kg", 84.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 42, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1389), "Weight", "kg", 85.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 43, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1392), "Weight", "kg", 83.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 44, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1395), "Weight", "kg", 80.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 45, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1398), "Weight", "kg", 83.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 46, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1401), "Weight", "kg", 84.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 47, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1404), "Weight", "kg", 82.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 48, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1483), "Weight", "kg", 84.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 49, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1488), "Weight", "kg", 84.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 50, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1490), "Weight", "kg", 86.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 51, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1493), "Weight", "kg", 86.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 52, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1496), "Weight", "kg", 80.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 53, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1499), "Weight", "kg", 83.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 54, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1502), "Weight", "kg", 84.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 55, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1504), "Weight", "kg", 85.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 56, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1507), "Weight", "kg", 83.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 57, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1510), "Weight", "kg", 82.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 58, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1513), "Weight", "kg", 82.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 59, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1516), "Weight", "kg", 86.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 60, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1519), "Weight", "kg", 81.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 61, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1522), "Weight", "kg", 86.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 62, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1525), "Weight", "kg", 80.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 63, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1528), "Weight", "kg", 84.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 64, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1530), "Weight", "kg", 82.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 65, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1533), "Weight", "kg", 86.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 66, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1538), "Weight", "kg", 83.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 67, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1540), "Weight", "kg", 81.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 68, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1543), "Weight", "kg", 80.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 69, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1546), "Weight", "kg", 81.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 70, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1549), "Weight", "kg", 82.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 71, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1552), "Weight", "kg", 82.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 72, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1555), "Weight", "kg", 80.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 73, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1558), "Weight", "kg", 86.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 74, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1561), "Weight", "kg", 80.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 75, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1564), "Weight", "kg", 84.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 76, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1567), "Weight", "kg", 84.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 77, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1570), "Weight", "kg", 82.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 78, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1573), "Weight", "kg", 82.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 79, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1576), "Weight", "kg", 80.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 80, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1578), "Weight", "kg", 85.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 81, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1581), "Weight", "kg", 85.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 82, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1584), "Weight", "kg", 81.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 83, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1587), "Weight", "kg", 81.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 84, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1590), "Weight", "kg", 84.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 85, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1593), "Weight", "kg", 84.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 86, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1596), "Weight", "kg", 85.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 87, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1599), "Weight", "kg", 80.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 88, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1602), "Weight", "kg", 86.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 89, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1605), "Weight", "kg", 81.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 90, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1608), "Weight", "kg", 81.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 91, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1611), "Weight", "kg", 83.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 92, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1614), "Weight", "kg", 82.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 93, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1617), "Weight", "kg", 80.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 94, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1620), "Weight", "kg", 80.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 95, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1623), "Weight", "kg", 84.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 96, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1625), "Weight", "kg", 84.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 97, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1628), "Weight", "kg", 86.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 98, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1631), "Weight", "kg", 81.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 99, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1635), "Weight", "kg", 84.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 100, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1638), "Weight", "kg", 86.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 101, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1641), "Weight", "kg", 86.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 102, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1644), "Weight", "kg", 84.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 103, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1646), "Weight", "kg", 85.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 104, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1649), "Weight", "kg", 83.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 105, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1652), "Weight", "kg", 84.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 106, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1655), "Weight", "kg", 80.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 107, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1658), "Weight", "kg", 85.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 108, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1661), "Weight", "kg", 82.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 109, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1664), "Weight", "kg", 80.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 110, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1667), "Weight", "kg", 84.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 111, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1670), "Weight", "kg", 83.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 112, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1673), "Weight", "kg", 83.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 113, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1677), "Weight", "kg", 83.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 114, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1680), "Weight", "kg", 82.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 115, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1683), "Weight", "kg", 85.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 116, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1686), "Weight", "kg", 85.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 117, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1689), "Weight", "kg", 83.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 118, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1692), "Weight", "kg", 85.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 119, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1695), "Weight", "kg", 80.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 120, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1698), "Weight", "kg", 84.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 121, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1701), "Weight", "kg", 85.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 122, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1704), "Weight", "kg", 82.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 123, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1707), "Weight", "kg", 81.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 124, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1710), "Weight", "kg", 83.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 125, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1713), "Weight", "kg", 82.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 126, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1716), "Weight", "kg", 81.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 127, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1720), "Weight", "kg", 80.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 128, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1723), "Weight", "kg", 85.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 129, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1726), "Weight", "kg", 80.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 130, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1770), "Weight", "kg", 81.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 131, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1773), "Weight", "kg", 85.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 132, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1776), "Weight", "kg", 80.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 133, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1779), "Weight", "kg", 84.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 134, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1782), "Weight", "kg", 81.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 135, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1786), "Weight", "kg", 82.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 136, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1789), "Weight", "kg", 80.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 137, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1792), "Weight", "kg", 82.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 138, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1795), "Weight", "kg", 83.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 139, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1798), "Weight", "kg", 81.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 140, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1801), "Weight", "kg", 81.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 141, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1805), "Weight", "kg", 85.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 142, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1808), "Weight", "kg", 83.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 143, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1811), "Weight", "kg", 86.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 144, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1814), "Weight", "kg", 85.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 145, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1817), "Weight", "kg", 82.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 146, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1820), "Weight", "kg", 80.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 147, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1823), "Weight", "kg", 85.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 148, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1827), "Weight", "kg", 85.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 149, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1830), "Weight", "kg", 82.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 150, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1833), "Weight", "kg", 83.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 151, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1836), "Weight", "kg", 83.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 152, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1839), "Weight", "kg", 82.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 153, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1843), "Weight", "kg", 82.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 154, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1846), "Weight", "kg", 82.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 155, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1849), "Weight", "kg", 86.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 156, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1853), "Weight", "kg", 82.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 157, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1856), "Weight", "kg", 80.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 158, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1859), "Weight", "kg", 82.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 159, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1863), "Weight", "kg", 86.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 160, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1866), "Weight", "kg", 84.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 161, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1870), "Weight", "kg", 86.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 162, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1873), "Weight", "kg", 80.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 163, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1876), "Weight", "kg", 84.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 164, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1880), "Weight", "kg", 86.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 165, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1883), "Weight", "kg", 84.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 166, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1886), "Weight", "kg", 84.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 167, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1890), "Weight", "kg", 81.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 168, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1893), "Weight", "kg", 86.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 169, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1897), "Weight", "kg", 85.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 170, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1900), "Weight", "kg", 80.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 171, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1904), "Weight", "kg", 83.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 172, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1907), "Weight", "kg", 80.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 173, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1911), "Weight", "kg", 82.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 174, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1914), "Weight", "kg", 82.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 175, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1918), "Weight", "kg", 80.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 176, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1921), "Weight", "kg", 81.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 177, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1925), "Weight", "kg", 81.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 178, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1928), "Weight", "kg", 84.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 179, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1932), "Weight", "kg", 82.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 180, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1935), "Weight", "kg", 84.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 181, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1938), "Weight", "kg", 84.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 182, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1942), "Weight", "kg", 81.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 183, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1946), "Weight", "kg", 86.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 184, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1949), "Weight", "kg", 85.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 185, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1952), "Weight", "kg", 80.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 186, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1956), "Weight", "kg", 84.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 187, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1959), "Weight", "kg", 86.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 188, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1963), "Weight", "kg", 84.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 189, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1966), "Weight", "kg", 80.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 190, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1970), "Weight", "kg", 80.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 191, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1974), "Weight", "kg", 82.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 192, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1977), "Weight", "kg", 81.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 193, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1981), "Weight", "kg", 85.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 194, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1984), "Weight", "kg", 81.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 195, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1988), "Weight", "kg", 84.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 196, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1991), "Weight", "kg", 86.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 197, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1995), "Weight", "kg", 80.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 198, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(1999), "Weight", "kg", 86.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 199, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2002), "Weight", "kg", 81.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 200, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2006), "Weight", "kg", 86.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 201, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2009), "Weight", "kg", 84.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 202, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2013), "Weight", "kg", 80.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 203, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2016), "Weight", "kg", 80.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 204, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2020), "Weight", "kg", 84.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 205, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2023), "Weight", "kg", 80.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 206, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2027), "Weight", "kg", 80.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 207, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2030), "Weight", "kg", 83.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 208, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2034), "Weight", "kg", 86.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 209, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2037), "Weight", "kg", 81.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 210, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2041), "Weight", "kg", 82.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 211, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2045), "Weight", "kg", 84.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 212, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2049), "Weight", "kg", 85.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 213, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2052), "Weight", "kg", 82.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 214, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2056), "Weight", "kg", 86.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 215, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2060), "Weight", "kg", 86.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 216, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2063), "Weight", "kg", 85.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 217, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2067), "Weight", "kg", 80.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 218, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2070), "Weight", "kg", 85.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 219, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2074), "Weight", "kg", 82.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 220, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2078), "Weight", "kg", 84.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 221, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2081), "Weight", "kg", 82.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 222, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2085), "Weight", "kg", 84.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 223, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2089), "Weight", "kg", 84.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 224, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2092), "Weight", "kg", 83.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 225, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2096), "Weight", "kg", 81.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 226, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2100), "Weight", "kg", 81.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 227, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2104), "Weight", "kg", 80.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 228, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2107), "Weight", "kg", 81.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 229, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2111), "Weight", "kg", 81.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 230, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2115), "Weight", "kg", 86.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 231, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2158), "Weight", "kg", 85.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 232, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2162), "Weight", "kg", 85.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 233, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2165), "Weight", "kg", 81.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 234, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2169), "Weight", "kg", 84.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 235, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2172), "Weight", "kg", 83.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 236, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2176), "Weight", "kg", 84.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 237, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2180), "Weight", "kg", 86.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 238, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2183), "Weight", "kg", 86.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 239, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2187), "Weight", "kg", 80.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 240, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2191), "Weight", "kg", 80.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 241, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2195), "Weight", "kg", 86.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 242, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2199), "Weight", "kg", 82.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 243, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2202), "Weight", "kg", 84.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 244, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2206), "Weight", "kg", 82.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 245, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2210), "Weight", "kg", 84.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 246, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2214), "Weight", "kg", 85.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 247, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2218), "Weight", "kg", 83.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 248, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2221), "Weight", "kg", 84.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 249, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2225), "Weight", "kg", 85.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 250, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2229), "Weight", "kg", 81.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 251, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2233), "Weight", "kg", 86.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 252, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2236), "Weight", "kg", 85.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 253, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2240), "Weight", "kg", 85.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 254, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2244), "Weight", "kg", 83.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 255, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2248), "Weight", "kg", 81.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 256, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2252), "Weight", "kg", 84.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 257, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2256), "Weight", "kg", 86.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 258, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2262), "Weight", "kg", 86.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 259, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2265), "Weight", "kg", 83.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 260, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2269), "Weight", "kg", 82.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 261, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2273), "Weight", "kg", 85.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 262, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2277), "Weight", "kg", 80.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 263, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2280), "Weight", "kg", 81.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 264, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2284), "Weight", "kg", 85.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 265, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2288), "Weight", "kg", 82.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 266, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2292), "Weight", "kg", 83.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 267, new DateTime(2023, 4, 8, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2296), "Weight", "kg", 84.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 268, new DateTime(2023, 4, 7, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2300), "Weight", "kg", 83.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 269, new DateTime(2023, 4, 6, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2303), "Weight", "kg", 83.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 270, new DateTime(2023, 4, 5, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2307), "Weight", "kg", 83.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 271, new DateTime(2023, 4, 4, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2311), "Weight", "kg", 80.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 272, new DateTime(2023, 4, 3, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2315), "Weight", "kg", 82.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 273, new DateTime(2023, 4, 2, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2319), "Weight", "kg", 81.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 274, new DateTime(2023, 4, 1, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2323), "Weight", "kg", 84.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 275, new DateTime(2023, 3, 31, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2327), "Weight", "kg", 81.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 276, new DateTime(2023, 3, 30, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2331), "Weight", "kg", 81.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 277, new DateTime(2023, 3, 29, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2335), "Weight", "kg", 80.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 278, new DateTime(2023, 3, 28, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2339), "Weight", "kg", 86.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 279, new DateTime(2023, 3, 27, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2343), "Weight", "kg", 80.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 280, new DateTime(2023, 3, 26, 14, 44, 17, 830, DateTimeKind.Local).AddTicks(2347), "Weight", "kg", 81.0, "ef1964f0-3deb-46cc-a016-d549b13701da" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 280);
        }
    }
}
