using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MealsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMealsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Carbohydrates", "Category", "Date", "Fats", "Protein", "TotalCalories", "applicationUserId" },
                values: new object[,]
                {
                    { 1, 167.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8558), 42.0, 120.0, 1380.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 2, 165.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8612), 43.0, 110.0, 1414.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 3, 158.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8616), 44.0, 105.0, 1994.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 4, 154.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8619), 49.0, 102.0, 1451.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 5, 172.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8622), 40.0, 135.0, 1774.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 6, 131.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8626), 34.0, 138.0, 1621.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 7, 169.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8629), 44.0, 136.0, 1658.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 8, 143.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8633), 41.0, 107.0, 1360.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 9, 161.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8636), 39.0, 147.0, 1658.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 10, 140.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8640), 38.0, 115.0, 1787.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 11, 137.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8643), 49.0, 105.0, 1982.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 12, 151.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8646), 39.0, 103.0, 1482.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 13, 147.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8649), 43.0, 149.0, 1961.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 14, 155.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8651), 33.0, 131.0, 1584.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 15, 157.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8657), 37.0, 117.0, 1518.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 16, 137.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8660), 36.0, 144.0, 1741.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 17, 144.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8663), 41.0, 114.0, 1859.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 18, 141.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8668), 45.0, 113.0, 1526.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 19, 135.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8671), 30.0, 139.0, 1965.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 20, 136.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8674), 40.0, 124.0, 1356.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 21, 177.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8677), 47.0, 132.0, 1393.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 22, 154.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8680), 41.0, 135.0, 1656.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 23, 136.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8683), 39.0, 115.0, 1376.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 24, 170.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8686), 39.0, 134.0, 1926.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 25, 178.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8689), 30.0, 106.0, 1813.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 26, 135.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8692), 34.0, 132.0, 1386.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 27, 131.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8695), 39.0, 114.0, 1329.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 28, 152.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8699), 37.0, 107.0, 1965.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 29, 166.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8702), 43.0, 134.0, 1513.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 30, 132.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8705), 38.0, 117.0, 1890.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 31, 147.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8708), 37.0, 135.0, 1542.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 32, 139.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8712), 37.0, 129.0, 1636.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 33, 179.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8715), 46.0, 141.0, 1313.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 34, 149.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8719), 38.0, 134.0, 1847.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 35, 173.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8722), 42.0, 132.0, 1972.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 36, 157.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8725), 45.0, 123.0, 1545.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 37, 132.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8728), 49.0, 113.0, 1549.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 38, 179.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8731), 44.0, 116.0, 1670.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 39, 154.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8734), 47.0, 112.0, 1674.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 40, 135.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8737), 40.0, 112.0, 1948.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 41, 159.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8740), 44.0, 140.0, 1962.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 42, 154.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8743), 42.0, 137.0, 1723.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 43, 152.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8746), 40.0, 141.0, 1474.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 44, 171.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8750), 43.0, 101.0, 1457.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 45, 175.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8753), 43.0, 130.0, 1410.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 46, 151.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8756), 44.0, 129.0, 1728.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 47, 176.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8759), 35.0, 103.0, 1483.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 48, 136.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8762), 41.0, 139.0, 1860.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 49, 173.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8765), 40.0, 113.0, 1375.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 50, 159.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8768), 31.0, 133.0, 1581.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 51, 169.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8771), 36.0, 112.0, 1935.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 52, 130.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8774), 44.0, 149.0, 1930.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 53, 137.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8778), 31.0, 149.0, 1387.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 54, 178.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8781), 42.0, 130.0, 1412.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 55, 152.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8784), 30.0, 141.0, 1734.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 56, 156.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8787), 36.0, 134.0, 1408.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 57, 161.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8790), 47.0, 110.0, 1986.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 58, 167.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8794), 32.0, 105.0, 1460.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 59, 137.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8797), 37.0, 107.0, 1722.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 60, 170.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8801), 34.0, 137.0, 1727.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 61, 137.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8804), 42.0, 147.0, 1723.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 62, 152.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8807), 48.0, 145.0, 1448.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 63, 153.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8810), 31.0, 137.0, 1977.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 64, 154.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8813), 47.0, 149.0, 1705.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 65, 150.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8816), 34.0, 105.0, 1681.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 66, 154.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8820), 48.0, 115.0, 1863.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 67, 135.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8868), 31.0, 126.0, 1732.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 68, 147.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8872), 47.0, 100.0, 1446.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 69, 149.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8875), 49.0, 123.0, 1585.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 70, 132.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8878), 32.0, 120.0, 1497.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 71, 179.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8882), 36.0, 106.0, 1930.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 72, 177.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8886), 45.0, 107.0, 1550.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 73, 174.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8889), 37.0, 111.0, 1999.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 74, 176.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8892), 47.0, 102.0, 1404.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 75, 158.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8896), 45.0, 133.0, 1634.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 76, 138.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8899), 31.0, 140.0, 1501.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 77, 165.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8903), 42.0, 131.0, 1406.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 78, 147.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8906), 32.0, 122.0, 1535.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 79, 143.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8909), 47.0, 104.0, 1942.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 80, 162.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8913), 31.0, 118.0, 1803.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 81, 144.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8916), 47.0, 123.0, 1587.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 82, 173.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8920), 45.0, 114.0, 1645.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 83, 130.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8923), 31.0, 120.0, 1908.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 84, 168.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8926), 42.0, 110.0, 1907.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 85, 130.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8930), 34.0, 129.0, 1459.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 86, 157.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8933), 37.0, 104.0, 1951.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 87, 177.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8936), 37.0, 127.0, 1330.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 88, 154.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8939), 32.0, 148.0, 1797.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 89, 142.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8943), 39.0, 112.0, 1630.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 90, 136.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8946), 45.0, 117.0, 1641.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 91, 141.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8949), 37.0, 101.0, 1589.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 92, 162.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8952), 45.0, 118.0, 1421.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 93, 165.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8956), 49.0, 104.0, 1749.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 94, 177.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8959), 49.0, 100.0, 1653.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 95, 130.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8963), 39.0, 125.0, 1726.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 96, 152.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8966), 40.0, 105.0, 1508.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 97, 130.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8969), 37.0, 126.0, 1538.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 98, 160.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8972), 35.0, 100.0, 1616.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 99, 142.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8976), 44.0, 129.0, 1402.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 100, 160.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8979), 46.0, 122.0, 1416.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 101, 156.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8982), 30.0, 133.0, 1307.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 102, 164.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8986), 37.0, 145.0, 1799.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 103, 166.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8989), 44.0, 142.0, 1606.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 104, 162.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8993), 41.0, 100.0, 1419.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 105, 149.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8996), 41.0, 139.0, 1540.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 106, 137.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(8999), 47.0, 112.0, 1812.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 107, 169.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9003), 44.0, 121.0, 1842.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 108, 141.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9006), 48.0, 110.0, 1394.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 109, 173.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9009), 34.0, 127.0, 1462.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 110, 145.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9013), 49.0, 126.0, 1309.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 111, 169.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9016), 44.0, 148.0, 1398.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 112, 143.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9019), 32.0, 133.0, 1871.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 113, 160.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9023), 42.0, 112.0, 1335.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 114, 153.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9026), 37.0, 118.0, 1496.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 115, 163.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9030), 32.0, 137.0, 1755.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 116, 143.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9033), 37.0, 142.0, 1333.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 117, 171.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9037), 33.0, 146.0, 1840.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 118, 176.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9040), 37.0, 113.0, 1864.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 119, 172.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9044), 35.0, 127.0, 1728.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 120, 165.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9047), 45.0, 103.0, 1821.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 121, 164.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9050), 42.0, 146.0, 1467.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 122, 150.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9054), 39.0, 131.0, 1544.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 123, 154.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9057), 35.0, 120.0, 1449.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 124, 156.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9060), 39.0, 128.0, 1774.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 125, 133.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9064), 32.0, 109.0, 1578.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 126, 174.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9067), 38.0, 148.0, 1479.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 127, 144.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9071), 48.0, 139.0, 1969.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 128, 164.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9074), 35.0, 112.0, 1631.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 129, 156.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9078), 31.0, 147.0, 1995.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 130, 133.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9083), 33.0, 124.0, 1535.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 131, 171.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9086), 45.0, 147.0, 1314.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 132, 153.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9090), 41.0, 149.0, 1400.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 133, 165.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9093), 43.0, 148.0, 1460.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 134, 142.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9097), 31.0, 121.0, 1770.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 135, 175.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9100), 40.0, 120.0, 1620.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 136, 156.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9103), 43.0, 105.0, 1500.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 137, 177.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9107), 47.0, 144.0, 1495.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 138, 170.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9110), 41.0, 129.0, 1713.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 139, 144.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9113), 46.0, 135.0, 1547.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 140, 151.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9116), 39.0, 104.0, 1808.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 141, 155.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9120), 45.0, 140.0, 1929.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 142, 151.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9124), 36.0, 149.0, 1496.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 143, 177.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9164), 39.0, 107.0, 1349.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 144, 147.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9168), 34.0, 100.0, 1658.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 145, 159.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9172), 41.0, 119.0, 1965.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 146, 174.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9175), 48.0, 148.0, 1342.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 147, 175.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9179), 36.0, 134.0, 1422.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 148, 177.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9182), 49.0, 140.0, 1505.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 149, 175.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9186), 32.0, 133.0, 1690.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 150, 178.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9189), 34.0, 109.0, 1881.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 151, 166.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9193), 36.0, 133.0, 1513.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 152, 149.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9196), 42.0, 144.0, 1834.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 153, 173.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9199), 33.0, 142.0, 1516.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 154, 162.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9203), 37.0, 124.0, 1347.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 155, 133.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9207), 33.0, 131.0, 1493.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 156, 163.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9210), 45.0, 115.0, 1769.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 157, 147.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9214), 43.0, 115.0, 1936.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 158, 151.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9218), 36.0, 121.0, 1760.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 159, 150.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9222), 38.0, 111.0, 1938.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 160, 136.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9226), 39.0, 138.0, 1754.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 161, 153.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9229), 31.0, 138.0, 1919.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 162, 144.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9233), 37.0, 102.0, 1421.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 163, 154.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9236), 46.0, 121.0, 1441.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 164, 174.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9240), 46.0, 115.0, 1690.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 165, 138.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9243), 40.0, 113.0, 1386.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 166, 154.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9247), 44.0, 131.0, 1800.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 167, 162.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9250), 38.0, 103.0, 1485.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 168, 173.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9254), 46.0, 119.0, 1902.0, "b62f0930-8324-4751-8f51-28ed952311a6" },
                    { 169, 149.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9258), 49.0, 139.0, 1782.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 170, 137.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9262), 32.0, 146.0, 1430.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 171, 155.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9266), 40.0, 116.0, 1485.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 172, 156.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9269), 30.0, 109.0, 1569.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 173, 174.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9273), 48.0, 104.0, 1803.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 174, 157.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9277), 32.0, 134.0, 1911.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 175, 166.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9281), 31.0, 105.0, 1606.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 176, 155.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9285), 46.0, 130.0, 1681.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 177, 152.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9288), 37.0, 141.0, 1635.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 178, 154.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9292), 32.0, 128.0, 1963.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 179, 155.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9295), 48.0, 130.0, 1802.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 180, 162.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9299), 45.0, 103.0, 1610.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 181, 165.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9303), 39.0, 132.0, 1994.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 182, 174.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9307), 30.0, 138.0, 1436.0, "fefae04f-02fd-4441-8cb3-5a55b1fff643" },
                    { 183, 156.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9311), 38.0, 112.0, 1471.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 184, 150.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9315), 32.0, 108.0, 1593.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 185, 165.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9319), 31.0, 122.0, 1579.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 186, 175.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9323), 40.0, 138.0, 1466.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 187, 160.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9327), 39.0, 143.0, 1776.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 188, 162.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9330), 35.0, 128.0, 1687.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 189, 166.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9334), 41.0, 144.0, 1836.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 190, 163.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9338), 36.0, 132.0, 1508.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 191, 138.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9342), 48.0, 137.0, 1912.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 192, 169.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9346), 33.0, 114.0, 1346.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 193, 161.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9350), 40.0, 126.0, 1513.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 194, 167.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9354), 35.0, 111.0, 1715.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 195, 149.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9357), 41.0, 107.0, 1980.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 196, 145.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9361), 37.0, 123.0, 1457.0, "4a839a6d-2961-466b-bb2b-38b840aabb69" },
                    { 197, 160.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9365), 33.0, 123.0, 1659.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 198, 173.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9369), 47.0, 119.0, 1410.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 199, 157.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9373), 37.0, 100.0, 1934.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 200, 144.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9377), 34.0, 108.0, 1702.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 201, 160.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9381), 43.0, 108.0, 1934.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 202, 167.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9385), 30.0, 149.0, 1587.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 203, 131.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9389), 41.0, 148.0, 1847.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 204, 179.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9393), 42.0, 139.0, 1758.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 205, 153.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9397), 47.0, 137.0, 1574.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 206, 146.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9401), 41.0, 101.0, 1602.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 207, 157.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9405), 45.0, 146.0, 1387.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 208, 170.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9408), 47.0, 115.0, 1365.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 209, 176.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9412), 46.0, 125.0, 1913.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 210, 141.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9416), 41.0, 103.0, 1483.0, "9bc75699-da3d-41ab-807b-854aba8662ca" },
                    { 211, 168.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9420), 36.0, 100.0, 1604.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 212, 136.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9424), 38.0, 108.0, 1363.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 213, 161.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9428), 33.0, 126.0, 1561.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 214, 165.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9432), 49.0, 135.0, 1648.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 215, 162.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9436), 31.0, 143.0, 1402.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 216, 172.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9440), 31.0, 101.0, 1883.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 217, 143.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9444), 38.0, 128.0, 1589.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 218, 167.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9448), 31.0, 149.0, 1426.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 219, 138.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9452), 33.0, 110.0, 1570.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 220, 135.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9457), 34.0, 130.0, 1762.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 221, 141.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9461), 33.0, 146.0, 1901.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 222, 176.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9465), 41.0, 139.0, 1934.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 223, 138.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9469), 39.0, 149.0, 1885.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 224, 131.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9473), 42.0, 107.0, 1668.0, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6" },
                    { 225, 164.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9477), 30.0, 149.0, 1401.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 226, 173.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9481), 42.0, 142.0, 1720.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 227, 179.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9485), 33.0, 103.0, 1694.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 228, 175.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9489), 39.0, 148.0, 1933.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 229, 134.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9493), 44.0, 140.0, 1964.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 230, 165.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9497), 41.0, 145.0, 1940.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 231, 133.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9501), 30.0, 121.0, 1481.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 232, 175.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9505), 30.0, 136.0, 1688.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 233, 157.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9509), 37.0, 116.0, 1649.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 234, 134.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9512), 48.0, 146.0, 1300.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 235, 171.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9517), 38.0, 144.0, 1713.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 236, 135.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9521), 32.0, 115.0, 1873.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 237, 175.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9525), 46.0, 105.0, 1316.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 238, 149.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9528), 42.0, 119.0, 1903.0, "e65338b5-6083-454a-991f-1c73d2d8530d" },
                    { 239, 178.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9533), 33.0, 107.0, 1748.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 240, 154.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9537), 40.0, 125.0, 1992.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 241, 150.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9541), 30.0, 137.0, 1991.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 242, 135.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9545), 35.0, 119.0, 1601.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 243, 143.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9549), 49.0, 131.0, 1357.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 244, 169.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9553), 35.0, 123.0, 1392.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 245, 141.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9598), 47.0, 118.0, 1731.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 246, 177.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9603), 49.0, 120.0, 1803.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 247, 164.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9607), 31.0, 113.0, 1849.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 248, 144.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9612), 38.0, 130.0, 1684.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 249, 133.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9616), 39.0, 139.0, 1550.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 250, 136.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9620), 49.0, 118.0, 1578.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 251, 163.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9624), 36.0, 103.0, 1523.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 252, 148.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9628), 40.0, 140.0, 1873.0, "5ee19786-6177-43cb-bfd0-22fb5498a481" },
                    { 253, 174.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9632), 30.0, 139.0, 1314.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 254, 138.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9636), 49.0, 128.0, 1423.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 255, 163.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9641), 35.0, 130.0, 1953.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 256, 156.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9645), 48.0, 128.0, 1825.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 257, 149.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9649), 46.0, 146.0, 1307.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 258, 163.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9656), 36.0, 140.0, 1482.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 259, 152.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9660), 32.0, 115.0, 1360.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 260, 138.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9664), 38.0, 126.0, 1908.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 261, 143.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9668), 35.0, 104.0, 1779.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 262, 176.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9673), 35.0, 102.0, 1629.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 263, 155.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9677), 41.0, 129.0, 1824.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 264, 159.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9681), 40.0, 107.0, 1403.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 265, 136.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9685), 39.0, 116.0, 1356.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 266, 171.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9689), 31.0, 144.0, 1895.0, "baf0862c-14d3-4832-8290-27d899b24c26" },
                    { 267, 136.0, "Breakfast", new DateTime(2023, 4, 8, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9693), 41.0, 117.0, 1688.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 268, 134.0, "Breakfast", new DateTime(2023, 4, 7, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9697), 45.0, 122.0, 1839.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 269, 164.0, "Breakfast", new DateTime(2023, 4, 6, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9701), 45.0, 110.0, 1581.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 270, 132.0, "Breakfast", new DateTime(2023, 4, 5, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9705), 32.0, 141.0, 1856.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 271, 139.0, "Breakfast", new DateTime(2023, 4, 4, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9710), 40.0, 102.0, 1407.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 272, 159.0, "Breakfast", new DateTime(2023, 4, 3, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9714), 36.0, 132.0, 1534.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 273, 148.0, "Breakfast", new DateTime(2023, 4, 2, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9718), 42.0, 146.0, 1366.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 274, 170.0, "Breakfast", new DateTime(2023, 4, 1, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9723), 49.0, 108.0, 1565.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 275, 178.0, "Breakfast", new DateTime(2023, 3, 31, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9727), 43.0, 137.0, 1781.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 276, 174.0, "Breakfast", new DateTime(2023, 3, 30, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9731), 32.0, 100.0, 1849.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 277, 156.0, "Breakfast", new DateTime(2023, 3, 29, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9735), 42.0, 118.0, 1465.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 278, 154.0, "Breakfast", new DateTime(2023, 3, 28, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9739), 48.0, 128.0, 1806.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 279, 157.0, "Breakfast", new DateTime(2023, 3, 27, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9744), 32.0, 134.0, 1631.0, "ef1964f0-3deb-46cc-a016-d549b13701da" },
                    { 280, 133.0, "Breakfast", new DateTime(2023, 3, 26, 14, 41, 32, 414, DateTimeKind.Local).AddTicks(9749), 43.0, 143.0, 1925.0, "ef1964f0-3deb-46cc-a016-d549b13701da" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 280);
        }
    }
}
