using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeasurementsAPI.Migrations
{
    /// <inheritdoc />
    public partial class GenerateMeasurements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "Id", "Date", "Type", "Unit", "Value", "applicationUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8078), "Weight", "kg", 80.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 2, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8126), "Weight", "kg", 83.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 3, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8129), "Weight", "kg", 83.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 4, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8131), "Weight", "kg", 80.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 5, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8133), "Weight", "kg", 83.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 6, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8137), "Weight", "kg", 80.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 7, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8139), "Weight", "kg", 86.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 8, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8141), "Weight", "kg", 84.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 9, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8143), "Weight", "kg", 83.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 10, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8146), "Weight", "kg", 85.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 11, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8149), "Weight", "kg", 86.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 12, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8151), "Weight", "kg", 83.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 13, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8153), "Weight", "kg", 83.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 14, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8155), "Weight", "kg", 84.0, "620eebc4-69c6-48c1-b9bc-8ceb6855b607" },
                    { 15, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8158), "Weight", "kg", 84.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 16, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8161), "Weight", "kg", 80.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 17, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8163), "Weight", "kg", 82.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 18, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8166), "Weight", "kg", 84.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 19, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8168), "Weight", "kg", 86.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 20, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8170), "Weight", "kg", 81.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 21, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8172), "Weight", "kg", 84.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 22, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8175), "Weight", "kg", 85.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 23, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8177), "Weight", "kg", 84.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 24, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8179), "Weight", "kg", 84.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 25, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8181), "Weight", "kg", 80.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 26, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8183), "Weight", "kg", 81.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 27, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8186), "Weight", "kg", 80.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 28, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8188), "Weight", "kg", 80.0, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059" },
                    { 29, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8190), "Weight", "kg", 80.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 30, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8193), "Weight", "kg", 83.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 31, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8195), "Weight", "kg", 84.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 32, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8197), "Weight", "kg", 84.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 33, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8199), "Weight", "kg", 86.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 34, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8202), "Weight", "kg", 85.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 35, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8204), "Weight", "kg", 82.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 36, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8206), "Weight", "kg", 82.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 37, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8209), "Weight", "kg", 80.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 38, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8211), "Weight", "kg", 82.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 39, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8213), "Weight", "kg", 86.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 40, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8215), "Weight", "kg", 86.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 41, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8217), "Weight", "kg", 84.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 42, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8220), "Weight", "kg", 81.0, "0371f684-9a41-4d40-ba2b-62cc5eabed46" },
                    { 43, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8222), "Weight", "kg", 85.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 44, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8224), "Weight", "kg", 81.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 45, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8227), "Weight", "kg", 86.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 46, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8229), "Weight", "kg", 80.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 47, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8231), "Weight", "kg", 85.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 48, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8234), "Weight", "kg", 84.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 49, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8236), "Weight", "kg", 84.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 50, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8238), "Weight", "kg", 80.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 51, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8240), "Weight", "kg", 85.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 52, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8242), "Weight", "kg", 86.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 53, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8245), "Weight", "kg", 80.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 54, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8247), "Weight", "kg", 80.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 55, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8249), "Weight", "kg", 84.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 56, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8251), "Weight", "kg", 80.0, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b" },
                    { 57, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8254), "Weight", "kg", 85.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 58, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8256), "Weight", "kg", 83.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 59, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8259), "Weight", "kg", 86.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 60, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8261), "Weight", "kg", 81.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 61, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8263), "Weight", "kg", 82.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 62, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8265), "Weight", "kg", 83.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 63, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8268), "Weight", "kg", 85.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 64, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8309), "Weight", "kg", 85.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 65, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8312), "Weight", "kg", 81.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 66, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8315), "Weight", "kg", 84.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 67, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8318), "Weight", "kg", 84.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 68, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8320), "Weight", "kg", 82.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 69, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8322), "Weight", "kg", 84.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 70, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8324), "Weight", "kg", 84.0, "aa88aabd-677b-4588-8cb0-213d5ba9e660" },
                    { 71, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8327), "Weight", "kg", 84.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 72, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8329), "Weight", "kg", 83.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 73, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8332), "Weight", "kg", 81.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 74, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8334), "Weight", "kg", 83.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 75, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8337), "Weight", "kg", 80.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 76, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8339), "Weight", "kg", 86.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 77, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8341), "Weight", "kg", 81.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 78, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8344), "Weight", "kg", 84.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 79, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8346), "Weight", "kg", 83.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 80, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8348), "Weight", "kg", 83.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 81, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8351), "Weight", "kg", 85.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 82, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8353), "Weight", "kg", 83.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 83, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8355), "Weight", "kg", 83.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 84, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8357), "Weight", "kg", 80.0, "f0e37b93-0558-458c-9e61-d0330ed9f4ec" },
                    { 85, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8360), "Weight", "kg", 83.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 86, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8362), "Weight", "kg", 80.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 87, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8365), "Weight", "kg", 85.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 88, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8367), "Weight", "kg", 81.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 89, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8369), "Weight", "kg", 85.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 90, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8372), "Weight", "kg", 84.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 91, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8374), "Weight", "kg", 82.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 92, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8377), "Weight", "kg", 81.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 93, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8379), "Weight", "kg", 82.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 94, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8381), "Weight", "kg", 81.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 95, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8384), "Weight", "kg", 85.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 96, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8386), "Weight", "kg", 81.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 97, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8388), "Weight", "kg", 82.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 98, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8391), "Weight", "kg", 83.0, "4d0bafc4-1d88-4433-9769-1e2d251530a7" },
                    { 99, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8393), "Weight", "kg", 83.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 100, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8396), "Weight", "kg", 81.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 101, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8398), "Weight", "kg", 86.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 102, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8400), "Weight", "kg", 81.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 103, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8403), "Weight", "kg", 83.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 104, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8405), "Weight", "kg", 86.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 105, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8408), "Weight", "kg", 82.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 106, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8410), "Weight", "kg", 86.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 107, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8413), "Weight", "kg", 82.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 108, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8415), "Weight", "kg", 86.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 109, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8418), "Weight", "kg", 82.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 110, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8420), "Weight", "kg", 85.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 111, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8423), "Weight", "kg", 81.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 112, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8425), "Weight", "kg", 86.0, "5febdbbe-d537-430f-9ccb-b48f252d2d4e" },
                    { 113, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8428), "Weight", "kg", 84.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 114, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8430), "Weight", "kg", 85.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 115, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8433), "Weight", "kg", 83.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 116, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8435), "Weight", "kg", 83.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 117, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8438), "Weight", "kg", 85.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 118, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8441), "Weight", "kg", 81.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 119, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8443), "Weight", "kg", 86.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 120, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8446), "Weight", "kg", 80.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 121, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8448), "Weight", "kg", 82.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 122, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8451), "Weight", "kg", 80.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 123, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8453), "Weight", "kg", 83.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 124, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8456), "Weight", "kg", 85.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 125, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8458), "Weight", "kg", 84.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 126, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8461), "Weight", "kg", 80.0, "c4824aab-c08f-4141-86c4-082fd8bbca8c" },
                    { 127, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8463), "Weight", "kg", 85.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 128, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8466), "Weight", "kg", 82.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 129, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8468), "Weight", "kg", 85.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 130, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8472), "Weight", "kg", 81.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 131, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8475), "Weight", "kg", 86.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 132, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8477), "Weight", "kg", 82.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 133, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8480), "Weight", "kg", 82.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 134, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8515), "Weight", "kg", 80.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 135, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8517), "Weight", "kg", 85.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 136, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8520), "Weight", "kg", 85.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 137, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8523), "Weight", "kg", 81.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 138, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8525), "Weight", "kg", 82.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 139, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8528), "Weight", "kg", 80.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 140, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8530), "Weight", "kg", 80.0, "2abf2679-ae98-456c-99ed-fe7ca2698c2e" },
                    { 141, new DateTime(2023, 4, 3, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8533), "Weight", "kg", 83.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 142, new DateTime(2023, 4, 2, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8536), "Weight", "kg", 80.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 143, new DateTime(2023, 4, 1, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8538), "Weight", "kg", 83.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 144, new DateTime(2023, 3, 31, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8541), "Weight", "kg", 80.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 145, new DateTime(2023, 3, 30, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8543), "Weight", "kg", 82.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 146, new DateTime(2023, 3, 29, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8546), "Weight", "kg", 80.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 147, new DateTime(2023, 3, 28, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8549), "Weight", "kg", 84.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 148, new DateTime(2023, 3, 27, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8551), "Weight", "kg", 83.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 149, new DateTime(2023, 3, 26, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8554), "Weight", "kg", 84.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 150, new DateTime(2023, 3, 25, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8556), "Weight", "kg", 81.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 151, new DateTime(2023, 3, 24, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8559), "Weight", "kg", 80.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 152, new DateTime(2023, 3, 23, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8561), "Weight", "kg", 81.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 153, new DateTime(2023, 3, 22, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8564), "Weight", "kg", 83.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" },
                    { 154, new DateTime(2023, 3, 21, 23, 28, 47, 854, DateTimeKind.Local).AddTicks(8566), "Weight", "kg", 86.0, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1" }
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
        }
    }
}
