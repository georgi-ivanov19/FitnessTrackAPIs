using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MealsAPI.Migrations
{
    /// <inheritdoc />
    public partial class GenerateMeals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Carbohydrates", "Category", "Date", "Fats", "Protein", "TotalCalories", "applicationUserId" },
                values: new object[,]
                {
                    { 1, 139.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(6940), 47.0, 141.0, 1996.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 2, 167.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(6989), 34.0, 120.0, 1515.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 3, 167.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(6991), 35.0, 144.0, 1738.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 4, 170.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(6994), 47.0, 121.0, 1523.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 5, 133.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(6996), 34.0, 136.0, 1418.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 6, 155.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(6999), 33.0, 118.0, 1495.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 7, 159.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7042), 42.0, 101.0, 1849.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 8, 168.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7045), 41.0, 100.0, 1753.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 9, 160.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7047), 37.0, 136.0, 1848.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 10, 153.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7050), 30.0, 102.0, 1970.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 11, 177.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7053), 42.0, 128.0, 1411.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 12, 175.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7055), 45.0, 129.0, 1909.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 13, 148.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7058), 40.0, 101.0, 1854.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 14, 134.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7060), 40.0, 122.0, 1952.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 15, 156.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7064), 40.0, 112.0, 1468.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 16, 145.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7067), 46.0, 105.0, 1698.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 17, 130.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7069), 43.0, 124.0, 1824.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 18, 166.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7073), 39.0, 100.0, 1949.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 19, 156.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7076), 48.0, 132.0, 1810.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 20, 175.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7078), 44.0, 108.0, 1331.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 21, 142.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7081), 33.0, 101.0, 1736.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 22, 178.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7083), 37.0, 120.0, 1638.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 23, 169.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7086), 42.0, 109.0, 1591.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 24, 153.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7088), 32.0, 128.0, 1805.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 25, 137.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7091), 40.0, 101.0, 1967.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 26, 170.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7093), 49.0, 133.0, 1717.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 27, 161.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7096), 47.0, 126.0, 1405.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 28, 148.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7098), 41.0, 113.0, 1616.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 29, 173.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7101), 36.0, 103.0, 1989.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 30, 135.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7104), 32.0, 101.0, 1433.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 31, 145.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7107), 38.0, 133.0, 1583.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 32, 143.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7110), 44.0, 101.0, 1795.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 33, 141.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7112), 30.0, 138.0, 1743.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 34, 132.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7115), 45.0, 130.0, 1984.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 35, 162.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7118), 42.0, 126.0, 1327.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 36, 178.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7120), 30.0, 143.0, 1351.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 37, 154.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7123), 43.0, 137.0, 1546.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 38, 156.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7125), 39.0, 106.0, 1661.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 39, 132.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7128), 44.0, 131.0, 1580.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 40, 169.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7130), 44.0, 120.0, 1484.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 41, 139.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7133), 47.0, 100.0, 1976.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 42, 137.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7136), 40.0, 128.0, 1860.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 43, 179.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7138), 37.0, 121.0, 1737.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 44, 137.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7141), 43.0, 134.0, 1850.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 45, 148.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7143), 34.0, 141.0, 1584.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 46, 169.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7146), 34.0, 126.0, 1505.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 47, 179.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7149), 32.0, 123.0, 1895.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 48, 138.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7152), 49.0, 114.0, 1769.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 49, 145.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7154), 39.0, 121.0, 1614.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 50, 132.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7157), 44.0, 149.0, 1617.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 51, 168.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7160), 46.0, 127.0, 1483.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 52, 166.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7162), 33.0, 148.0, 1591.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 53, 152.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7165), 38.0, 106.0, 1933.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 54, 152.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7168), 39.0, 137.0, 1318.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 55, 176.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7170), 43.0, 114.0, 1485.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 56, 154.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7173), 30.0, 141.0, 1337.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 57, 176.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7176), 47.0, 129.0, 1726.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 58, 154.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7179), 38.0, 118.0, 1491.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 59, 170.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7182), 49.0, 121.0, 1718.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 60, 166.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7184), 49.0, 105.0, 1599.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 61, 170.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7187), 38.0, 121.0, 1604.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 62, 136.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7189), 30.0, 119.0, 1515.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 63, 159.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7192), 46.0, 112.0, 1841.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 64, 135.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7195), 41.0, 105.0, 1745.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 65, 136.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7197), 49.0, 102.0, 1310.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 66, 143.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7201), 36.0, 117.0, 1606.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 67, 178.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7204), 30.0, 126.0, 1930.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 68, 167.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7207), 49.0, 124.0, 1675.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 69, 155.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7210), 44.0, 148.0, 1862.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 70, 130.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7212), 47.0, 141.0, 1760.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 71, 141.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7215), 43.0, 115.0, 1667.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 72, 159.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7218), 34.0, 105.0, 1862.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 73, 140.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7221), 38.0, 118.0, 1364.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 74, 173.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7223), 43.0, 110.0, 1428.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 75, 178.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7227), 42.0, 128.0, 1685.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 76, 168.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7229), 39.0, 121.0, 1939.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 77, 143.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7232), 37.0, 121.0, 1590.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 78, 138.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7235), 49.0, 131.0, 1437.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 79, 173.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7237), 35.0, 116.0, 1854.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 80, 130.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7240), 30.0, 136.0, 1372.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 81, 142.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7243), 31.0, 137.0, 1564.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 82, 150.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7245), 48.0, 106.0, 1528.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 83, 156.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7248), 45.0, 139.0, 1656.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 84, 163.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7282), 33.0, 146.0, 1689.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 85, 171.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7285), 48.0, 112.0, 1992.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 86, 150.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7288), 31.0, 101.0, 1886.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 87, 169.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7291), 37.0, 138.0, 1656.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 88, 133.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7294), 47.0, 139.0, 1415.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 89, 156.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7297), 44.0, 103.0, 1443.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 90, 144.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7300), 49.0, 119.0, 1868.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 91, 170.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7302), 30.0, 125.0, 1305.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 92, 178.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7305), 47.0, 134.0, 1565.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 93, 140.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7308), 49.0, 136.0, 1321.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 94, 152.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7310), 42.0, 111.0, 1377.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 95, 140.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7313), 38.0, 148.0, 1623.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 96, 163.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7316), 39.0, 141.0, 1702.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 97, 147.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7319), 37.0, 126.0, 1526.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 98, 175.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7321), 46.0, 130.0, 1982.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 99, 153.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7324), 33.0, 146.0, 1589.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 100, 136.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7327), 47.0, 130.0, 1546.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 101, 167.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7330), 32.0, 126.0, 1795.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 102, 176.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7333), 41.0, 108.0, 1596.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 103, 169.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7336), 43.0, 134.0, 1709.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 104, 169.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7339), 40.0, 115.0, 1421.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 105, 139.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7342), 42.0, 133.0, 1856.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 106, 169.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7345), 40.0, 113.0, 1544.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 107, 164.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7347), 34.0, 137.0, 1954.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 108, 134.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7350), 36.0, 107.0, 1719.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 109, 159.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7353), 31.0, 128.0, 1913.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 110, 155.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7356), 44.0, 119.0, 1672.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 111, 171.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7359), 44.0, 140.0, 1608.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 112, 141.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7362), 38.0, 126.0, 1722.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 113, 161.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7365), 30.0, 145.0, 1777.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 114, 158.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7368), 38.0, 106.0, 1849.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 115, 174.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7371), 47.0, 119.0, 1741.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 116, 153.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7374), 43.0, 149.0, 1589.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 117, 165.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7377), 40.0, 118.0, 1860.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 118, 150.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7380), 42.0, 141.0, 1639.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 119, 153.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7383), 30.0, 124.0, 1340.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 120, 138.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7386), 33.0, 114.0, 1938.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 121, 137.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7389), 30.0, 134.0, 1323.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 122, 149.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7392), 38.0, 115.0, 1938.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 123, 154.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7395), 35.0, 102.0, 1848.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 124, 133.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7398), 37.0, 128.0, 1672.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 125, 177.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7400), 44.0, 112.0, 1955.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 126, 132.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7403), 36.0, 108.0, 1801.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 127, 177.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7406), 47.0, 141.0, 1965.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 128, 163.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7409), 37.0, 100.0, 1574.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 129, 146.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7412), 40.0, 114.0, 1528.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 130, 149.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7416), 41.0, 121.0, 1558.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 131, 168.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7419), 44.0, 142.0, 1700.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 132, 177.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7422), 37.0, 104.0, 1749.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 133, 155.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7425), 34.0, 108.0, 1529.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 134, 141.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7428), 34.0, 112.0, 1735.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 135, 140.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7431), 36.0, 134.0, 1886.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 136, 160.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7434), 47.0, 143.0, 1592.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 137, 169.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7437), 37.0, 116.0, 1488.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 138, 149.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7440), 35.0, 124.0, 1521.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 139, 130.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7442), 49.0, 129.0, 1356.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 140, 168.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7446), 45.0, 115.0, 1642.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 141, 156.0, "Breakfast", new DateTime(2023, 4, 3, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7449), 47.0, 119.0, 1424.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 142, 145.0, "Breakfast", new DateTime(2023, 4, 2, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7452), 39.0, 131.0, 1416.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 143, 163.0, "Breakfast", new DateTime(2023, 4, 1, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7455), 39.0, 118.0, 1528.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 144, 139.0, "Breakfast", new DateTime(2023, 3, 31, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7458), 47.0, 125.0, 1887.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 145, 158.0, "Breakfast", new DateTime(2023, 3, 30, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7460), 38.0, 140.0, 1860.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 146, 172.0, "Breakfast", new DateTime(2023, 3, 29, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7463), 32.0, 136.0, 1475.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 147, 141.0, "Breakfast", new DateTime(2023, 3, 28, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7466), 43.0, 149.0, 1583.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 148, 141.0, "Breakfast", new DateTime(2023, 3, 27, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7469), 39.0, 114.0, 1513.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 149, 158.0, "Breakfast", new DateTime(2023, 3, 26, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7472), 41.0, 119.0, 1436.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 150, 155.0, "Breakfast", new DateTime(2023, 3, 25, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7475), 37.0, 115.0, 1624.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 151, 172.0, "Breakfast", new DateTime(2023, 3, 24, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7478), 36.0, 130.0, 1805.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 152, 150.0, "Breakfast", new DateTime(2023, 3, 23, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7481), 45.0, 147.0, 1776.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 153, 179.0, "Breakfast", new DateTime(2023, 3, 22, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7484), 47.0, 128.0, 1501.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 154, 163.0, "Breakfast", new DateTime(2023, 3, 21, 23, 24, 6, 354, DateTimeKind.Local).AddTicks(7487), 44.0, 142.0, 1698.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" }
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
        }
    }
}
