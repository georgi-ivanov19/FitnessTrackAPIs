using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkoutData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "ApplicationUserId", "DateLastCompleted", "DayOfWeek", "Name" },
                values: new object[,]
                {
                    { 1, "620eebc4-69c6-48c1-b9bc-8ceb6855b607", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8686), "Monday", "Workout1" },
                    { 2, "620eebc4-69c6-48c1-b9bc-8ceb6855b607", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8854), "Wednesday", "Workout2" },
                    { 3, "620eebc4-69c6-48c1-b9bc-8ceb6855b607", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8884), "Friday", "Workout3" },
                    { 4, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8912), "Monday", "Workout1" },
                    { 5, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8939), "Wednesday", "Workout2" },
                    { 6, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9011), "Friday", "Workout3" },
                    { 7, "0371f684-9a41-4d40-ba2b-62cc5eabed46", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9040), "Monday", "Workout1" },
                    { 8, "0371f684-9a41-4d40-ba2b-62cc5eabed46", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9067), "Wednesday", "Workout2" },
                    { 9, "0371f684-9a41-4d40-ba2b-62cc5eabed46", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9094), "Friday", "Workout3" },
                    { 10, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9122), "Monday", "Workout1" },
                    { 11, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9190), "Wednesday", "Workout2" },
                    { 12, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9218), "Friday", "Workout3" },
                    { 13, "aa88aabd-677b-4588-8cb0-213d5ba9e660", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9245), "Monday", "Workout1" },
                    { 14, "aa88aabd-677b-4588-8cb0-213d5ba9e660", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9271), "Wednesday", "Workout2" },
                    { 15, "aa88aabd-677b-4588-8cb0-213d5ba9e660", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9298), "Friday", "Workout3" },
                    { 16, "f0e37b93-0558-458c-9e61-d0330ed9f4ec", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9368), "Monday", "Workout1" },
                    { 17, "f0e37b93-0558-458c-9e61-d0330ed9f4ec", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9395), "Wednesday", "Workout2" },
                    { 18, "f0e37b93-0558-458c-9e61-d0330ed9f4ec", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9425), "Friday", "Workout3" },
                    { 19, "4d0bafc4-1d88-4433-9769-1e2d251530a7", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9453), "Monday", "Workout1" },
                    { 20, "4d0bafc4-1d88-4433-9769-1e2d251530a7", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9526), "Wednesday", "Workout2" },
                    { 21, "4d0bafc4-1d88-4433-9769-1e2d251530a7", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9553), "Friday", "Workout3" },
                    { 22, "5febdbbe-d537-430f-9ccb-b48f252d2d4e", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9581), "Monday", "Workout1" },
                    { 23, "5febdbbe-d537-430f-9ccb-b48f252d2d4e", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9610), "Wednesday", "Workout2" },
                    { 24, "5febdbbe-d537-430f-9ccb-b48f252d2d4e", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9679), "Friday", "Workout3" },
                    { 25, "c4824aab-c08f-4141-86c4-082fd8bbca8c", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9707), "Monday", "Workout1" },
                    { 26, "c4824aab-c08f-4141-86c4-082fd8bbca8c", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9735), "Wednesday", "Workout2" },
                    { 27, "c4824aab-c08f-4141-86c4-082fd8bbca8c", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9763), "Friday", "Workout3" },
                    { 28, "2abf2679-ae98-456c-99ed-fe7ca2698c2e", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9790), "Monday", "Workout1" },
                    { 29, "2abf2679-ae98-456c-99ed-fe7ca2698c2e", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9818), "Wednesday", "Workout2" },
                    { 30, "2abf2679-ae98-456c-99ed-fe7ca2698c2e", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9917), "Friday", "Workout3" },
                    { 31, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9947), "Monday", "Workout1" },
                    { 32, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1", new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9975), "Wednesday", "Workout2" },
                    { 33, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(46), "Friday", "Workout3" },
                    { 34, "b62f0930-8324-4751-8f51-28ed952311a6", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(78), "Monday", "Workout1" },
                    { 35, "b62f0930-8324-4751-8f51-28ed952311a6", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(107), "Wednesday", "Workout2" },
                    { 36, "b62f0930-8324-4751-8f51-28ed952311a6", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(137), "Friday", "Workout3" },
                    { 37, "fefae04f-02fd-4441-8cb3-5a55b1fff643", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(206), "Monday", "Workout1" },
                    { 38, "fefae04f-02fd-4441-8cb3-5a55b1fff643", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(236), "Wednesday", "Workout2" },
                    { 39, "fefae04f-02fd-4441-8cb3-5a55b1fff643", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(266), "Friday", "Workout3" },
                    { 40, "4a839a6d-2961-466b-bb2b-38b840aabb69", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(295), "Monday", "Workout1" },
                    { 41, "4a839a6d-2961-466b-bb2b-38b840aabb69", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(325), "Wednesday", "Workout2" },
                    { 42, "4a839a6d-2961-466b-bb2b-38b840aabb69", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(354), "Friday", "Workout3" },
                    { 43, "9bc75699-da3d-41ab-807b-854aba8662ca", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(427), "Monday", "Workout1" },
                    { 44, "9bc75699-da3d-41ab-807b-854aba8662ca", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(458), "Wednesday", "Workout2" },
                    { 45, "9bc75699-da3d-41ab-807b-854aba8662ca", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(488), "Friday", "Workout3" },
                    { 46, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(518), "Monday", "Workout1" },
                    { 47, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(588), "Wednesday", "Workout2" },
                    { 48, "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(619), "Friday", "Workout3" },
                    { 49, "e65338b5-6083-454a-991f-1c73d2d8530d", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(649), "Monday", "Workout1" },
                    { 50, "e65338b5-6083-454a-991f-1c73d2d8530d", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(679), "Wednesday", "Workout2" },
                    { 51, "e65338b5-6083-454a-991f-1c73d2d8530d", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(710), "Friday", "Workout3" },
                    { 52, "5ee19786-6177-43cb-bfd0-22fb5498a481", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(740), "Monday", "Workout1" },
                    { 53, "5ee19786-6177-43cb-bfd0-22fb5498a481", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(813), "Wednesday", "Workout2" },
                    { 54, "5ee19786-6177-43cb-bfd0-22fb5498a481", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(845), "Friday", "Workout3" },
                    { 55, "baf0862c-14d3-4832-8290-27d899b24c26", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(877), "Monday", "Workout1" },
                    { 56, "baf0862c-14d3-4832-8290-27d899b24c26", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(908), "Wednesday", "Workout2" },
                    { 57, "baf0862c-14d3-4832-8290-27d899b24c26", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(939), "Friday", "Workout3" },
                    { 58, "ef1964f0-3deb-46cc-a016-d549b13701da", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(1088), "Monday", "Workout1" },
                    { 59, "ef1964f0-3deb-46cc-a016-d549b13701da", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(1120), "Wednesday", "Workout2" },
                    { 60, "ef1964f0-3deb-46cc-a016-d549b13701da", new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(1151), "Friday", "Workout3" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DefaultNumberOfSets", "Name", "TargetMuscle", "WorkoutId" },
                values: new object[,]
                {
                    { 1, 3, "Exercise1", "Muscle1", 1 },
                    { 2, 3, "Exercise2", "Muscle2", 1 },
                    { 3, 3, "Exercise3", "Muscle3", 1 },
                    { 4, 3, "Exercise1", "Muscle1", 2 },
                    { 5, 3, "Exercise2", "Muscle2", 2 },
                    { 6, 3, "Exercise3", "Muscle3", 2 },
                    { 7, 3, "Exercise1", "Muscle1", 3 },
                    { 8, 3, "Exercise2", "Muscle2", 3 },
                    { 9, 3, "Exercise3", "Muscle3", 3 },
                    { 10, 3, "Exercise1", "Muscle1", 4 },
                    { 11, 3, "Exercise2", "Muscle2", 4 },
                    { 12, 3, "Exercise3", "Muscle3", 4 },
                    { 13, 3, "Exercise1", "Muscle1", 5 },
                    { 14, 3, "Exercise2", "Muscle2", 5 },
                    { 15, 3, "Exercise3", "Muscle3", 5 },
                    { 16, 3, "Exercise1", "Muscle1", 6 },
                    { 17, 3, "Exercise2", "Muscle2", 6 },
                    { 18, 3, "Exercise3", "Muscle3", 6 },
                    { 19, 3, "Exercise1", "Muscle1", 7 },
                    { 20, 3, "Exercise2", "Muscle2", 7 },
                    { 21, 3, "Exercise3", "Muscle3", 7 },
                    { 22, 3, "Exercise1", "Muscle1", 8 },
                    { 23, 3, "Exercise2", "Muscle2", 8 },
                    { 24, 3, "Exercise3", "Muscle3", 8 },
                    { 25, 3, "Exercise1", "Muscle1", 9 },
                    { 26, 3, "Exercise2", "Muscle2", 9 },
                    { 27, 3, "Exercise3", "Muscle3", 9 },
                    { 28, 3, "Exercise1", "Muscle1", 10 },
                    { 29, 3, "Exercise2", "Muscle2", 10 },
                    { 30, 3, "Exercise3", "Muscle3", 10 },
                    { 31, 3, "Exercise1", "Muscle1", 11 },
                    { 32, 3, "Exercise2", "Muscle2", 11 },
                    { 33, 3, "Exercise3", "Muscle3", 11 },
                    { 34, 3, "Exercise1", "Muscle1", 12 },
                    { 35, 3, "Exercise2", "Muscle2", 12 },
                    { 36, 3, "Exercise3", "Muscle3", 12 },
                    { 37, 3, "Exercise1", "Muscle1", 13 },
                    { 38, 3, "Exercise2", "Muscle2", 13 },
                    { 39, 3, "Exercise3", "Muscle3", 13 },
                    { 40, 3, "Exercise1", "Muscle1", 14 },
                    { 41, 3, "Exercise2", "Muscle2", 14 },
                    { 42, 3, "Exercise3", "Muscle3", 14 },
                    { 43, 3, "Exercise1", "Muscle1", 15 },
                    { 44, 3, "Exercise2", "Muscle2", 15 },
                    { 45, 3, "Exercise3", "Muscle3", 15 },
                    { 46, 3, "Exercise1", "Muscle1", 16 },
                    { 47, 3, "Exercise2", "Muscle2", 16 },
                    { 48, 3, "Exercise3", "Muscle3", 16 },
                    { 49, 3, "Exercise1", "Muscle1", 17 },
                    { 50, 3, "Exercise2", "Muscle2", 17 },
                    { 51, 3, "Exercise3", "Muscle3", 17 },
                    { 52, 3, "Exercise1", "Muscle1", 18 },
                    { 53, 3, "Exercise2", "Muscle2", 18 },
                    { 54, 3, "Exercise3", "Muscle3", 18 },
                    { 55, 3, "Exercise1", "Muscle1", 19 },
                    { 56, 3, "Exercise2", "Muscle2", 19 },
                    { 57, 3, "Exercise3", "Muscle3", 19 },
                    { 58, 3, "Exercise1", "Muscle1", 20 },
                    { 59, 3, "Exercise2", "Muscle2", 20 },
                    { 60, 3, "Exercise3", "Muscle3", 20 },
                    { 61, 3, "Exercise1", "Muscle1", 21 },
                    { 62, 3, "Exercise2", "Muscle2", 21 },
                    { 63, 3, "Exercise3", "Muscle3", 21 },
                    { 64, 3, "Exercise1", "Muscle1", 22 },
                    { 65, 3, "Exercise2", "Muscle2", 22 },
                    { 66, 3, "Exercise3", "Muscle3", 22 },
                    { 67, 3, "Exercise1", "Muscle1", 23 },
                    { 68, 3, "Exercise2", "Muscle2", 23 },
                    { 69, 3, "Exercise3", "Muscle3", 23 },
                    { 70, 3, "Exercise1", "Muscle1", 24 },
                    { 71, 3, "Exercise2", "Muscle2", 24 },
                    { 72, 3, "Exercise3", "Muscle3", 24 },
                    { 73, 3, "Exercise1", "Muscle1", 25 },
                    { 74, 3, "Exercise2", "Muscle2", 25 },
                    { 75, 3, "Exercise3", "Muscle3", 25 },
                    { 76, 3, "Exercise1", "Muscle1", 26 },
                    { 77, 3, "Exercise2", "Muscle2", 26 },
                    { 78, 3, "Exercise3", "Muscle3", 26 },
                    { 79, 3, "Exercise1", "Muscle1", 27 },
                    { 80, 3, "Exercise2", "Muscle2", 27 },
                    { 81, 3, "Exercise3", "Muscle3", 27 },
                    { 82, 3, "Exercise1", "Muscle1", 28 },
                    { 83, 3, "Exercise2", "Muscle2", 28 },
                    { 84, 3, "Exercise3", "Muscle3", 28 },
                    { 85, 3, "Exercise1", "Muscle1", 29 },
                    { 86, 3, "Exercise2", "Muscle2", 29 },
                    { 87, 3, "Exercise3", "Muscle3", 29 },
                    { 88, 3, "Exercise1", "Muscle1", 30 },
                    { 89, 3, "Exercise2", "Muscle2", 30 },
                    { 90, 3, "Exercise3", "Muscle3", 30 },
                    { 91, 3, "Exercise1", "Muscle1", 31 },
                    { 92, 3, "Exercise2", "Muscle2", 31 },
                    { 93, 3, "Exercise3", "Muscle3", 31 },
                    { 94, 3, "Exercise1", "Muscle1", 32 },
                    { 95, 3, "Exercise2", "Muscle2", 32 },
                    { 96, 3, "Exercise3", "Muscle3", 32 },
                    { 97, 3, "Exercise1", "Muscle1", 33 },
                    { 98, 3, "Exercise2", "Muscle2", 33 },
                    { 99, 3, "Exercise3", "Muscle3", 33 },
                    { 100, 3, "Exercise1", "Muscle1", 34 },
                    { 101, 3, "Exercise2", "Muscle2", 34 },
                    { 102, 3, "Exercise3", "Muscle3", 34 },
                    { 103, 3, "Exercise1", "Muscle1", 35 },
                    { 104, 3, "Exercise2", "Muscle2", 35 },
                    { 105, 3, "Exercise3", "Muscle3", 35 },
                    { 106, 3, "Exercise1", "Muscle1", 36 },
                    { 107, 3, "Exercise2", "Muscle2", 36 },
                    { 108, 3, "Exercise3", "Muscle3", 36 },
                    { 109, 3, "Exercise1", "Muscle1", 37 },
                    { 110, 3, "Exercise2", "Muscle2", 37 },
                    { 111, 3, "Exercise3", "Muscle3", 37 },
                    { 112, 3, "Exercise1", "Muscle1", 38 },
                    { 113, 3, "Exercise2", "Muscle2", 38 },
                    { 114, 3, "Exercise3", "Muscle3", 38 },
                    { 115, 3, "Exercise1", "Muscle1", 39 },
                    { 116, 3, "Exercise2", "Muscle2", 39 },
                    { 117, 3, "Exercise3", "Muscle3", 39 },
                    { 118, 3, "Exercise1", "Muscle1", 40 },
                    { 119, 3, "Exercise2", "Muscle2", 40 },
                    { 120, 3, "Exercise3", "Muscle3", 40 },
                    { 121, 3, "Exercise1", "Muscle1", 41 },
                    { 122, 3, "Exercise2", "Muscle2", 41 },
                    { 123, 3, "Exercise3", "Muscle3", 41 },
                    { 124, 3, "Exercise1", "Muscle1", 42 },
                    { 125, 3, "Exercise2", "Muscle2", 42 },
                    { 126, 3, "Exercise3", "Muscle3", 42 },
                    { 127, 3, "Exercise1", "Muscle1", 43 },
                    { 128, 3, "Exercise2", "Muscle2", 43 },
                    { 129, 3, "Exercise3", "Muscle3", 43 },
                    { 130, 3, "Exercise1", "Muscle1", 44 },
                    { 131, 3, "Exercise2", "Muscle2", 44 },
                    { 132, 3, "Exercise3", "Muscle3", 44 },
                    { 133, 3, "Exercise1", "Muscle1", 45 },
                    { 134, 3, "Exercise2", "Muscle2", 45 },
                    { 135, 3, "Exercise3", "Muscle3", 45 },
                    { 136, 3, "Exercise1", "Muscle1", 46 },
                    { 137, 3, "Exercise2", "Muscle2", 46 },
                    { 138, 3, "Exercise3", "Muscle3", 46 },
                    { 139, 3, "Exercise1", "Muscle1", 47 },
                    { 140, 3, "Exercise2", "Muscle2", 47 },
                    { 141, 3, "Exercise3", "Muscle3", 47 },
                    { 142, 3, "Exercise1", "Muscle1", 48 },
                    { 143, 3, "Exercise2", "Muscle2", 48 },
                    { 144, 3, "Exercise3", "Muscle3", 48 },
                    { 145, 3, "Exercise1", "Muscle1", 49 },
                    { 146, 3, "Exercise2", "Muscle2", 49 },
                    { 147, 3, "Exercise3", "Muscle3", 49 },
                    { 148, 3, "Exercise1", "Muscle1", 50 },
                    { 149, 3, "Exercise2", "Muscle2", 50 },
                    { 150, 3, "Exercise3", "Muscle3", 50 },
                    { 151, 3, "Exercise1", "Muscle1", 51 },
                    { 152, 3, "Exercise2", "Muscle2", 51 },
                    { 153, 3, "Exercise3", "Muscle3", 51 },
                    { 154, 3, "Exercise1", "Muscle1", 52 },
                    { 155, 3, "Exercise2", "Muscle2", 52 },
                    { 156, 3, "Exercise3", "Muscle3", 52 },
                    { 157, 3, "Exercise1", "Muscle1", 53 },
                    { 158, 3, "Exercise2", "Muscle2", 53 },
                    { 159, 3, "Exercise3", "Muscle3", 53 },
                    { 160, 3, "Exercise1", "Muscle1", 54 },
                    { 161, 3, "Exercise2", "Muscle2", 54 },
                    { 162, 3, "Exercise3", "Muscle3", 54 },
                    { 163, 3, "Exercise1", "Muscle1", 55 },
                    { 164, 3, "Exercise2", "Muscle2", 55 },
                    { 165, 3, "Exercise3", "Muscle3", 55 },
                    { 166, 3, "Exercise1", "Muscle1", 56 },
                    { 167, 3, "Exercise2", "Muscle2", 56 },
                    { 168, 3, "Exercise3", "Muscle3", 56 },
                    { 169, 3, "Exercise1", "Muscle1", 57 },
                    { 170, 3, "Exercise2", "Muscle2", 57 },
                    { 171, 3, "Exercise3", "Muscle3", 57 },
                    { 172, 3, "Exercise1", "Muscle1", 58 },
                    { 173, 3, "Exercise2", "Muscle2", 58 },
                    { 174, 3, "Exercise3", "Muscle3", 58 },
                    { 175, 3, "Exercise1", "Muscle1", 59 },
                    { 176, 3, "Exercise2", "Muscle2", 59 },
                    { 177, 3, "Exercise3", "Muscle3", 59 },
                    { 178, 3, "Exercise1", "Muscle1", 60 },
                    { 179, 3, "Exercise2", "Muscle2", 60 },
                    { 180, 3, "Exercise3", "Muscle3", 60 }
                });

            migrationBuilder.InsertData(
                table: "TrackedWorkouts",
                columns: new[] { "Id", "EndTime", "IsCompleted", "Notes", "StartTime", "TotalVolume", "WorkoutId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8755), true, "Notes for TrackedWorkout1", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(8760), 1000.0, 1 },
                    { 2, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8867), true, "Notes for TrackedWorkout2", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(8870), 1000.0, 2 },
                    { 3, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8896), true, "Notes for TrackedWorkout3", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(8898), 1000.0, 3 },
                    { 4, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8924), true, "Notes for TrackedWorkout4", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(8926), 1000.0, 4 },
                    { 5, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(8951), true, "Notes for TrackedWorkout5", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(8953), 1000.0, 5 },
                    { 6, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9025), true, "Notes for TrackedWorkout6", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9027), 1000.0, 6 },
                    { 7, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9052), true, "Notes for TrackedWorkout7", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9054), 1000.0, 7 },
                    { 8, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9079), true, "Notes for TrackedWorkout8", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9081), 1000.0, 8 },
                    { 9, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9106), true, "Notes for TrackedWorkout9", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9108), 1000.0, 9 },
                    { 10, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9174), true, "Notes for TrackedWorkout10", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9176), 1000.0, 10 },
                    { 11, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9204), true, "Notes for TrackedWorkout11", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9206), 1000.0, 11 },
                    { 12, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9230), true, "Notes for TrackedWorkout12", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9232), 1000.0, 12 },
                    { 13, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9257), true, "Notes for TrackedWorkout13", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9260), 1000.0, 13 },
                    { 14, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9284), true, "Notes for TrackedWorkout14", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9286), 1000.0, 14 },
                    { 15, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9311), true, "Notes for TrackedWorkout15", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9313), 1000.0, 15 },
                    { 16, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9381), true, "Notes for TrackedWorkout16", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9383), 1000.0, 16 },
                    { 17, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9408), true, "Notes for TrackedWorkout17", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9410), 1000.0, 17 },
                    { 18, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9438), true, "Notes for TrackedWorkout18", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9440), 1000.0, 18 },
                    { 19, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9511), true, "Notes for TrackedWorkout19", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9513), 1000.0, 19 },
                    { 20, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9539), true, "Notes for TrackedWorkout20", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9541), 1000.0, 20 },
                    { 21, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9566), true, "Notes for TrackedWorkout21", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9569), 1000.0, 21 },
                    { 22, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9595), true, "Notes for TrackedWorkout22", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9597), 1000.0, 22 },
                    { 23, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9624), true, "Notes for TrackedWorkout23", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9626), 1000.0, 23 },
                    { 24, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9693), true, "Notes for TrackedWorkout24", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9695), 1000.0, 24 },
                    { 25, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9721), true, "Notes for TrackedWorkout25", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9723), 1000.0, 25 },
                    { 26, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9748), true, "Notes for TrackedWorkout26", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9750), 1000.0, 26 },
                    { 27, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9776), true, "Notes for TrackedWorkout27", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9778), 1000.0, 27 },
                    { 28, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9804), true, "Notes for TrackedWorkout28", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9806), 1000.0, 28 },
                    { 29, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9831), true, "Notes for TrackedWorkout29", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9833), 1000.0, 29 },
                    { 30, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9932), true, "Notes for TrackedWorkout30", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9934), 1000.0, 30 },
                    { 31, new DateTime(2023, 4, 9, 14, 35, 8, 759, DateTimeKind.Local).AddTicks(9961), true, "Notes for TrackedWorkout31", new DateTime(2023, 4, 9, 12, 35, 8, 759, DateTimeKind.Local).AddTicks(9963), 1000.0, 31 },
                    { 32, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(30), true, "Notes for TrackedWorkout32", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(33), 1000.0, 32 },
                    { 33, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(60), true, "Notes for TrackedWorkout33", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(62), 1000.0, 33 },
                    { 34, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(93), true, "Notes for TrackedWorkout34", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(95), 1000.0, 34 },
                    { 35, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(122), true, "Notes for TrackedWorkout35", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(124), 1000.0, 35 },
                    { 36, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(151), true, "Notes for TrackedWorkout36", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(153), 1000.0, 36 },
                    { 37, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(221), true, "Notes for TrackedWorkout37", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(223), 1000.0, 37 },
                    { 38, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(251), true, "Notes for TrackedWorkout38", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(253), 1000.0, 38 },
                    { 39, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(280), true, "Notes for TrackedWorkout39", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(282), 1000.0, 39 },
                    { 40, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(310), true, "Notes for TrackedWorkout40", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(312), 1000.0, 40 },
                    { 41, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(340), true, "Notes for TrackedWorkout41", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(342), 1000.0, 41 },
                    { 42, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(369), true, "Notes for TrackedWorkout42", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(372), 1000.0, 42 },
                    { 43, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(443), true, "Notes for TrackedWorkout43", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(445), 1000.0, 43 },
                    { 44, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(473), true, "Notes for TrackedWorkout44", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(475), 1000.0, 44 },
                    { 45, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(502), true, "Notes for TrackedWorkout45", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(505), 1000.0, 45 },
                    { 46, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(532), true, "Notes for TrackedWorkout46", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(534), 1000.0, 46 },
                    { 47, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(603), true, "Notes for TrackedWorkout47", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(606), 1000.0, 47 },
                    { 48, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(634), true, "Notes for TrackedWorkout48", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(636), 1000.0, 48 },
                    { 49, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(664), true, "Notes for TrackedWorkout49", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(666), 1000.0, 49 },
                    { 50, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(694), true, "Notes for TrackedWorkout50", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(696), 1000.0, 50 },
                    { 51, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(725), true, "Notes for TrackedWorkout51", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(727), 1000.0, 51 },
                    { 52, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(798), true, "Notes for TrackedWorkout52", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(800), 1000.0, 52 },
                    { 53, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(830), true, "Notes for TrackedWorkout53", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(832), 1000.0, 53 },
                    { 54, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(861), true, "Notes for TrackedWorkout54", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(863), 1000.0, 54 },
                    { 55, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(892), true, "Notes for TrackedWorkout55", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(894), 1000.0, 55 },
                    { 56, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(923), true, "Notes for TrackedWorkout56", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(925), 1000.0, 56 },
                    { 57, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(954), true, "Notes for TrackedWorkout57", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(956), 1000.0, 57 },
                    { 58, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(1105), true, "Notes for TrackedWorkout58", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(1107), 1000.0, 58 },
                    { 59, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(1136), true, "Notes for TrackedWorkout59", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(1139), 1000.0, 59 },
                    { 60, new DateTime(2023, 4, 9, 14, 35, 8, 760, DateTimeKind.Local).AddTicks(1167), true, "Notes for TrackedWorkout60", new DateTime(2023, 4, 9, 12, 35, 8, 760, DateTimeKind.Local).AddTicks(1169), 1000.0, 60 }
                });

            migrationBuilder.InsertData(
                table: "ExerciseSets",
                columns: new[] { "Id", "ExerciseId", "ExerciseName", "IsComplete", "IsWarmup", "Reps", "TrackedWorkoutId", "Weight" },
                values: new object[,]
                {
                    { 4, 1, "Exercise1", true, false, 10, 1, 10.0 },
                    { 5, 1, "Exercise1", true, false, 10, 1, 10.0 },
                    { 6, 1, "Exercise1", true, false, 10, 1, 10.0 },
                    { 7, 2, "Exercise2", true, false, 10, 1, 10.0 },
                    { 8, 2, "Exercise2", true, false, 10, 1, 10.0 },
                    { 9, 2, "Exercise2", true, false, 10, 1, 10.0 },
                    { 10, 3, "Exercise3", true, false, 10, 1, 10.0 },
                    { 11, 3, "Exercise3", true, false, 10, 1, 10.0 },
                    { 12, 3, "Exercise3", true, false, 10, 1, 10.0 },
                    { 13, 4, "Exercise1", true, false, 10, 2, 10.0 },
                    { 14, 4, "Exercise1", true, false, 10, 2, 10.0 },
                    { 15, 4, "Exercise1", true, false, 10, 2, 10.0 },
                    { 16, 5, "Exercise2", true, false, 10, 2, 10.0 },
                    { 17, 5, "Exercise2", true, false, 10, 2, 10.0 },
                    { 18, 5, "Exercise2", true, false, 10, 2, 10.0 },
                    { 19, 6, "Exercise3", true, false, 10, 2, 10.0 },
                    { 20, 6, "Exercise3", true, false, 10, 2, 10.0 },
                    { 21, 6, "Exercise3", true, false, 10, 2, 10.0 },
                    { 22, 7, "Exercise1", true, false, 10, 3, 10.0 },
                    { 23, 7, "Exercise1", true, false, 10, 3, 10.0 },
                    { 24, 7, "Exercise1", true, false, 10, 3, 10.0 },
                    { 25, 8, "Exercise2", true, false, 10, 3, 10.0 },
                    { 26, 8, "Exercise2", true, false, 10, 3, 10.0 },
                    { 27, 8, "Exercise2", true, false, 10, 3, 10.0 },
                    { 28, 9, "Exercise3", true, false, 10, 3, 10.0 },
                    { 29, 9, "Exercise3", true, false, 10, 3, 10.0 },
                    { 30, 9, "Exercise3", true, false, 10, 3, 10.0 },
                    { 31, 10, "Exercise1", true, false, 10, 4, 10.0 },
                    { 32, 10, "Exercise1", true, false, 10, 4, 10.0 },
                    { 33, 10, "Exercise1", true, false, 10, 4, 10.0 },
                    { 34, 11, "Exercise2", true, false, 10, 4, 10.0 },
                    { 35, 11, "Exercise2", true, false, 10, 4, 10.0 },
                    { 36, 11, "Exercise2", true, false, 10, 4, 10.0 },
                    { 37, 12, "Exercise3", true, false, 10, 4, 10.0 },
                    { 38, 12, "Exercise3", true, false, 10, 4, 10.0 },
                    { 39, 12, "Exercise3", true, false, 10, 4, 10.0 },
                    { 40, 13, "Exercise1", true, false, 10, 5, 10.0 },
                    { 41, 13, "Exercise1", true, false, 10, 5, 10.0 },
                    { 42, 13, "Exercise1", true, false, 10, 5, 10.0 },
                    { 43, 14, "Exercise2", true, false, 10, 5, 10.0 },
                    { 44, 14, "Exercise2", true, false, 10, 5, 10.0 },
                    { 45, 14, "Exercise2", true, false, 10, 5, 10.0 },
                    { 46, 15, "Exercise3", true, false, 10, 5, 10.0 },
                    { 47, 15, "Exercise3", true, false, 10, 5, 10.0 },
                    { 48, 15, "Exercise3", true, false, 10, 5, 10.0 },
                    { 49, 16, "Exercise1", true, false, 10, 6, 10.0 },
                    { 50, 16, "Exercise1", true, false, 10, 6, 10.0 },
                    { 51, 16, "Exercise1", true, false, 10, 6, 10.0 },
                    { 52, 17, "Exercise2", true, false, 10, 6, 10.0 },
                    { 53, 17, "Exercise2", true, false, 10, 6, 10.0 },
                    { 54, 17, "Exercise2", true, false, 10, 6, 10.0 },
                    { 55, 18, "Exercise3", true, false, 10, 6, 10.0 },
                    { 56, 18, "Exercise3", true, false, 10, 6, 10.0 },
                    { 57, 18, "Exercise3", true, false, 10, 6, 10.0 },
                    { 58, 19, "Exercise1", true, false, 10, 7, 10.0 },
                    { 59, 19, "Exercise1", true, false, 10, 7, 10.0 },
                    { 60, 19, "Exercise1", true, false, 10, 7, 10.0 },
                    { 61, 20, "Exercise2", true, false, 10, 7, 10.0 },
                    { 62, 20, "Exercise2", true, false, 10, 7, 10.0 },
                    { 63, 20, "Exercise2", true, false, 10, 7, 10.0 },
                    { 64, 21, "Exercise3", true, false, 10, 7, 10.0 },
                    { 65, 21, "Exercise3", true, false, 10, 7, 10.0 },
                    { 66, 21, "Exercise3", true, false, 10, 7, 10.0 },
                    { 67, 22, "Exercise1", true, false, 10, 8, 10.0 },
                    { 68, 22, "Exercise1", true, false, 10, 8, 10.0 },
                    { 69, 22, "Exercise1", true, false, 10, 8, 10.0 },
                    { 70, 23, "Exercise2", true, false, 10, 8, 10.0 },
                    { 71, 23, "Exercise2", true, false, 10, 8, 10.0 },
                    { 72, 23, "Exercise2", true, false, 10, 8, 10.0 },
                    { 73, 24, "Exercise3", true, false, 10, 8, 10.0 },
                    { 74, 24, "Exercise3", true, false, 10, 8, 10.0 },
                    { 75, 24, "Exercise3", true, false, 10, 8, 10.0 },
                    { 76, 25, "Exercise1", true, false, 10, 9, 10.0 },
                    { 77, 25, "Exercise1", true, false, 10, 9, 10.0 },
                    { 78, 25, "Exercise1", true, false, 10, 9, 10.0 },
                    { 79, 26, "Exercise2", true, false, 10, 9, 10.0 },
                    { 80, 26, "Exercise2", true, false, 10, 9, 10.0 },
                    { 81, 26, "Exercise2", true, false, 10, 9, 10.0 },
                    { 82, 27, "Exercise3", true, false, 10, 9, 10.0 },
                    { 83, 27, "Exercise3", true, false, 10, 9, 10.0 },
                    { 84, 27, "Exercise3", true, false, 10, 9, 10.0 },
                    { 85, 28, "Exercise1", true, false, 10, 10, 10.0 },
                    { 86, 28, "Exercise1", true, false, 10, 10, 10.0 },
                    { 87, 28, "Exercise1", true, false, 10, 10, 10.0 },
                    { 88, 29, "Exercise2", true, false, 10, 10, 10.0 },
                    { 89, 29, "Exercise2", true, false, 10, 10, 10.0 },
                    { 90, 29, "Exercise2", true, false, 10, 10, 10.0 },
                    { 91, 30, "Exercise3", true, false, 10, 10, 10.0 },
                    { 92, 30, "Exercise3", true, false, 10, 10, 10.0 },
                    { 93, 30, "Exercise3", true, false, 10, 10, 10.0 },
                    { 94, 31, "Exercise1", true, false, 10, 11, 10.0 },
                    { 95, 31, "Exercise1", true, false, 10, 11, 10.0 },
                    { 96, 31, "Exercise1", true, false, 10, 11, 10.0 },
                    { 97, 32, "Exercise2", true, false, 10, 11, 10.0 },
                    { 98, 32, "Exercise2", true, false, 10, 11, 10.0 },
                    { 99, 32, "Exercise2", true, false, 10, 11, 10.0 },
                    { 100, 33, "Exercise3", true, false, 10, 11, 10.0 },
                    { 101, 33, "Exercise3", true, false, 10, 11, 10.0 },
                    { 102, 33, "Exercise3", true, false, 10, 11, 10.0 },
                    { 103, 34, "Exercise1", true, false, 10, 12, 10.0 },
                    { 104, 34, "Exercise1", true, false, 10, 12, 10.0 },
                    { 105, 34, "Exercise1", true, false, 10, 12, 10.0 },
                    { 106, 35, "Exercise2", true, false, 10, 12, 10.0 },
                    { 107, 35, "Exercise2", true, false, 10, 12, 10.0 },
                    { 108, 35, "Exercise2", true, false, 10, 12, 10.0 },
                    { 109, 36, "Exercise3", true, false, 10, 12, 10.0 },
                    { 110, 36, "Exercise3", true, false, 10, 12, 10.0 },
                    { 111, 36, "Exercise3", true, false, 10, 12, 10.0 },
                    { 112, 37, "Exercise1", true, false, 10, 13, 10.0 },
                    { 113, 37, "Exercise1", true, false, 10, 13, 10.0 },
                    { 114, 37, "Exercise1", true, false, 10, 13, 10.0 },
                    { 115, 38, "Exercise2", true, false, 10, 13, 10.0 },
                    { 116, 38, "Exercise2", true, false, 10, 13, 10.0 },
                    { 117, 38, "Exercise2", true, false, 10, 13, 10.0 },
                    { 118, 39, "Exercise3", true, false, 10, 13, 10.0 },
                    { 119, 39, "Exercise3", true, false, 10, 13, 10.0 },
                    { 120, 39, "Exercise3", true, false, 10, 13, 10.0 },
                    { 121, 40, "Exercise1", true, false, 10, 14, 10.0 },
                    { 122, 40, "Exercise1", true, false, 10, 14, 10.0 },
                    { 123, 40, "Exercise1", true, false, 10, 14, 10.0 },
                    { 124, 41, "Exercise2", true, false, 10, 14, 10.0 },
                    { 125, 41, "Exercise2", true, false, 10, 14, 10.0 },
                    { 126, 41, "Exercise2", true, false, 10, 14, 10.0 },
                    { 127, 42, "Exercise3", true, false, 10, 14, 10.0 },
                    { 128, 42, "Exercise3", true, false, 10, 14, 10.0 },
                    { 129, 42, "Exercise3", true, false, 10, 14, 10.0 },
                    { 130, 43, "Exercise1", true, false, 10, 15, 10.0 },
                    { 131, 43, "Exercise1", true, false, 10, 15, 10.0 },
                    { 132, 43, "Exercise1", true, false, 10, 15, 10.0 },
                    { 133, 44, "Exercise2", true, false, 10, 15, 10.0 },
                    { 134, 44, "Exercise2", true, false, 10, 15, 10.0 },
                    { 135, 44, "Exercise2", true, false, 10, 15, 10.0 },
                    { 136, 45, "Exercise3", true, false, 10, 15, 10.0 },
                    { 137, 45, "Exercise3", true, false, 10, 15, 10.0 },
                    { 138, 45, "Exercise3", true, false, 10, 15, 10.0 },
                    { 139, 46, "Exercise1", true, false, 10, 16, 10.0 },
                    { 140, 46, "Exercise1", true, false, 10, 16, 10.0 },
                    { 141, 46, "Exercise1", true, false, 10, 16, 10.0 },
                    { 142, 47, "Exercise2", true, false, 10, 16, 10.0 },
                    { 143, 47, "Exercise2", true, false, 10, 16, 10.0 },
                    { 144, 47, "Exercise2", true, false, 10, 16, 10.0 },
                    { 145, 48, "Exercise3", true, false, 10, 16, 10.0 },
                    { 146, 48, "Exercise3", true, false, 10, 16, 10.0 },
                    { 147, 48, "Exercise3", true, false, 10, 16, 10.0 },
                    { 148, 49, "Exercise1", true, false, 10, 17, 10.0 },
                    { 149, 49, "Exercise1", true, false, 10, 17, 10.0 },
                    { 150, 49, "Exercise1", true, false, 10, 17, 10.0 },
                    { 151, 50, "Exercise2", true, false, 10, 17, 10.0 },
                    { 152, 50, "Exercise2", true, false, 10, 17, 10.0 },
                    { 153, 50, "Exercise2", true, false, 10, 17, 10.0 },
                    { 154, 51, "Exercise3", true, false, 10, 17, 10.0 },
                    { 155, 51, "Exercise3", true, false, 10, 17, 10.0 },
                    { 156, 51, "Exercise3", true, false, 10, 17, 10.0 },
                    { 157, 52, "Exercise1", true, false, 10, 18, 10.0 },
                    { 158, 52, "Exercise1", true, false, 10, 18, 10.0 },
                    { 159, 52, "Exercise1", true, false, 10, 18, 10.0 },
                    { 160, 53, "Exercise2", true, false, 10, 18, 10.0 },
                    { 161, 53, "Exercise2", true, false, 10, 18, 10.0 },
                    { 162, 53, "Exercise2", true, false, 10, 18, 10.0 },
                    { 163, 54, "Exercise3", true, false, 10, 18, 10.0 },
                    { 164, 54, "Exercise3", true, false, 10, 18, 10.0 },
                    { 165, 54, "Exercise3", true, false, 10, 18, 10.0 },
                    { 166, 55, "Exercise1", true, false, 10, 19, 10.0 },
                    { 167, 55, "Exercise1", true, false, 10, 19, 10.0 },
                    { 168, 55, "Exercise1", true, false, 10, 19, 10.0 },
                    { 169, 56, "Exercise2", true, false, 10, 19, 10.0 },
                    { 170, 56, "Exercise2", true, false, 10, 19, 10.0 },
                    { 171, 56, "Exercise2", true, false, 10, 19, 10.0 },
                    { 172, 57, "Exercise3", true, false, 10, 19, 10.0 },
                    { 173, 57, "Exercise3", true, false, 10, 19, 10.0 },
                    { 174, 57, "Exercise3", true, false, 10, 19, 10.0 },
                    { 175, 58, "Exercise1", true, false, 10, 20, 10.0 },
                    { 176, 58, "Exercise1", true, false, 10, 20, 10.0 },
                    { 177, 58, "Exercise1", true, false, 10, 20, 10.0 },
                    { 178, 59, "Exercise2", true, false, 10, 20, 10.0 },
                    { 179, 59, "Exercise2", true, false, 10, 20, 10.0 },
                    { 180, 59, "Exercise2", true, false, 10, 20, 10.0 },
                    { 181, 60, "Exercise3", true, false, 10, 20, 10.0 },
                    { 182, 60, "Exercise3", true, false, 10, 20, 10.0 },
                    { 183, 60, "Exercise3", true, false, 10, 20, 10.0 },
                    { 184, 61, "Exercise1", true, false, 10, 21, 10.0 },
                    { 185, 61, "Exercise1", true, false, 10, 21, 10.0 },
                    { 186, 61, "Exercise1", true, false, 10, 21, 10.0 },
                    { 187, 62, "Exercise2", true, false, 10, 21, 10.0 },
                    { 188, 62, "Exercise2", true, false, 10, 21, 10.0 },
                    { 189, 62, "Exercise2", true, false, 10, 21, 10.0 },
                    { 190, 63, "Exercise3", true, false, 10, 21, 10.0 },
                    { 191, 63, "Exercise3", true, false, 10, 21, 10.0 },
                    { 192, 63, "Exercise3", true, false, 10, 21, 10.0 },
                    { 193, 64, "Exercise1", true, false, 10, 22, 10.0 },
                    { 194, 64, "Exercise1", true, false, 10, 22, 10.0 },
                    { 195, 64, "Exercise1", true, false, 10, 22, 10.0 },
                    { 196, 65, "Exercise2", true, false, 10, 22, 10.0 },
                    { 197, 65, "Exercise2", true, false, 10, 22, 10.0 },
                    { 198, 65, "Exercise2", true, false, 10, 22, 10.0 },
                    { 199, 66, "Exercise3", true, false, 10, 22, 10.0 },
                    { 200, 66, "Exercise3", true, false, 10, 22, 10.0 },
                    { 201, 66, "Exercise3", true, false, 10, 22, 10.0 },
                    { 202, 67, "Exercise1", true, false, 10, 23, 10.0 },
                    { 203, 67, "Exercise1", true, false, 10, 23, 10.0 },
                    { 204, 67, "Exercise1", true, false, 10, 23, 10.0 },
                    { 205, 68, "Exercise2", true, false, 10, 23, 10.0 },
                    { 206, 68, "Exercise2", true, false, 10, 23, 10.0 },
                    { 207, 68, "Exercise2", true, false, 10, 23, 10.0 },
                    { 208, 69, "Exercise3", true, false, 10, 23, 10.0 },
                    { 209, 69, "Exercise3", true, false, 10, 23, 10.0 },
                    { 210, 69, "Exercise3", true, false, 10, 23, 10.0 },
                    { 211, 70, "Exercise1", true, false, 10, 24, 10.0 },
                    { 212, 70, "Exercise1", true, false, 10, 24, 10.0 },
                    { 213, 70, "Exercise1", true, false, 10, 24, 10.0 },
                    { 214, 71, "Exercise2", true, false, 10, 24, 10.0 },
                    { 215, 71, "Exercise2", true, false, 10, 24, 10.0 },
                    { 216, 71, "Exercise2", true, false, 10, 24, 10.0 },
                    { 217, 72, "Exercise3", true, false, 10, 24, 10.0 },
                    { 218, 72, "Exercise3", true, false, 10, 24, 10.0 },
                    { 219, 72, "Exercise3", true, false, 10, 24, 10.0 },
                    { 220, 73, "Exercise1", true, false, 10, 25, 10.0 },
                    { 221, 73, "Exercise1", true, false, 10, 25, 10.0 },
                    { 222, 73, "Exercise1", true, false, 10, 25, 10.0 },
                    { 223, 74, "Exercise2", true, false, 10, 25, 10.0 },
                    { 224, 74, "Exercise2", true, false, 10, 25, 10.0 },
                    { 225, 74, "Exercise2", true, false, 10, 25, 10.0 },
                    { 226, 75, "Exercise3", true, false, 10, 25, 10.0 },
                    { 227, 75, "Exercise3", true, false, 10, 25, 10.0 },
                    { 228, 75, "Exercise3", true, false, 10, 25, 10.0 },
                    { 229, 76, "Exercise1", true, false, 10, 26, 10.0 },
                    { 230, 76, "Exercise1", true, false, 10, 26, 10.0 },
                    { 231, 76, "Exercise1", true, false, 10, 26, 10.0 },
                    { 232, 77, "Exercise2", true, false, 10, 26, 10.0 },
                    { 233, 77, "Exercise2", true, false, 10, 26, 10.0 },
                    { 234, 77, "Exercise2", true, false, 10, 26, 10.0 },
                    { 235, 78, "Exercise3", true, false, 10, 26, 10.0 },
                    { 236, 78, "Exercise3", true, false, 10, 26, 10.0 },
                    { 237, 78, "Exercise3", true, false, 10, 26, 10.0 },
                    { 238, 79, "Exercise1", true, false, 10, 27, 10.0 },
                    { 239, 79, "Exercise1", true, false, 10, 27, 10.0 },
                    { 240, 79, "Exercise1", true, false, 10, 27, 10.0 },
                    { 241, 80, "Exercise2", true, false, 10, 27, 10.0 },
                    { 242, 80, "Exercise2", true, false, 10, 27, 10.0 },
                    { 243, 80, "Exercise2", true, false, 10, 27, 10.0 },
                    { 244, 81, "Exercise3", true, false, 10, 27, 10.0 },
                    { 245, 81, "Exercise3", true, false, 10, 27, 10.0 },
                    { 246, 81, "Exercise3", true, false, 10, 27, 10.0 },
                    { 247, 82, "Exercise1", true, false, 10, 28, 10.0 },
                    { 248, 82, "Exercise1", true, false, 10, 28, 10.0 },
                    { 249, 82, "Exercise1", true, false, 10, 28, 10.0 },
                    { 250, 83, "Exercise2", true, false, 10, 28, 10.0 },
                    { 251, 83, "Exercise2", true, false, 10, 28, 10.0 },
                    { 252, 83, "Exercise2", true, false, 10, 28, 10.0 },
                    { 253, 84, "Exercise3", true, false, 10, 28, 10.0 },
                    { 254, 84, "Exercise3", true, false, 10, 28, 10.0 },
                    { 255, 84, "Exercise3", true, false, 10, 28, 10.0 },
                    { 256, 85, "Exercise1", true, false, 10, 29, 10.0 },
                    { 257, 85, "Exercise1", true, false, 10, 29, 10.0 },
                    { 258, 85, "Exercise1", true, false, 10, 29, 10.0 },
                    { 259, 86, "Exercise2", true, false, 10, 29, 10.0 },
                    { 260, 86, "Exercise2", true, false, 10, 29, 10.0 },
                    { 261, 86, "Exercise2", true, false, 10, 29, 10.0 },
                    { 262, 87, "Exercise3", true, false, 10, 29, 10.0 },
                    { 263, 87, "Exercise3", true, false, 10, 29, 10.0 },
                    { 264, 87, "Exercise3", true, false, 10, 29, 10.0 },
                    { 265, 88, "Exercise1", true, false, 10, 30, 10.0 },
                    { 266, 88, "Exercise1", true, false, 10, 30, 10.0 },
                    { 267, 88, "Exercise1", true, false, 10, 30, 10.0 },
                    { 268, 89, "Exercise2", true, false, 10, 30, 10.0 },
                    { 269, 89, "Exercise2", true, false, 10, 30, 10.0 },
                    { 270, 89, "Exercise2", true, false, 10, 30, 10.0 },
                    { 271, 90, "Exercise3", true, false, 10, 30, 10.0 },
                    { 272, 90, "Exercise3", true, false, 10, 30, 10.0 },
                    { 273, 90, "Exercise3", true, false, 10, 30, 10.0 },
                    { 274, 91, "Exercise1", true, false, 10, 31, 10.0 },
                    { 275, 91, "Exercise1", true, false, 10, 31, 10.0 },
                    { 276, 91, "Exercise1", true, false, 10, 31, 10.0 },
                    { 277, 92, "Exercise2", true, false, 10, 31, 10.0 },
                    { 278, 92, "Exercise2", true, false, 10, 31, 10.0 },
                    { 279, 92, "Exercise2", true, false, 10, 31, 10.0 },
                    { 280, 93, "Exercise3", true, false, 10, 31, 10.0 },
                    { 281, 93, "Exercise3", true, false, 10, 31, 10.0 },
                    { 282, 93, "Exercise3", true, false, 10, 31, 10.0 },
                    { 283, 94, "Exercise1", true, false, 10, 32, 10.0 },
                    { 284, 94, "Exercise1", true, false, 10, 32, 10.0 },
                    { 285, 94, "Exercise1", true, false, 10, 32, 10.0 },
                    { 286, 95, "Exercise2", true, false, 10, 32, 10.0 },
                    { 287, 95, "Exercise2", true, false, 10, 32, 10.0 },
                    { 288, 95, "Exercise2", true, false, 10, 32, 10.0 },
                    { 289, 96, "Exercise3", true, false, 10, 32, 10.0 },
                    { 290, 96, "Exercise3", true, false, 10, 32, 10.0 },
                    { 291, 96, "Exercise3", true, false, 10, 32, 10.0 },
                    { 292, 97, "Exercise1", true, false, 10, 33, 10.0 },
                    { 293, 97, "Exercise1", true, false, 10, 33, 10.0 },
                    { 294, 97, "Exercise1", true, false, 10, 33, 10.0 },
                    { 295, 98, "Exercise2", true, false, 10, 33, 10.0 },
                    { 296, 98, "Exercise2", true, false, 10, 33, 10.0 },
                    { 297, 98, "Exercise2", true, false, 10, 33, 10.0 },
                    { 298, 99, "Exercise3", true, false, 10, 33, 10.0 },
                    { 299, 99, "Exercise3", true, false, 10, 33, 10.0 },
                    { 300, 99, "Exercise3", true, false, 10, 33, 10.0 },
                    { 301, 100, "Exercise1", true, false, 10, 34, 10.0 },
                    { 302, 100, "Exercise1", true, false, 10, 34, 10.0 },
                    { 303, 100, "Exercise1", true, false, 10, 34, 10.0 },
                    { 304, 101, "Exercise2", true, false, 10, 34, 10.0 },
                    { 305, 101, "Exercise2", true, false, 10, 34, 10.0 },
                    { 306, 101, "Exercise2", true, false, 10, 34, 10.0 },
                    { 307, 102, "Exercise3", true, false, 10, 34, 10.0 },
                    { 308, 102, "Exercise3", true, false, 10, 34, 10.0 },
                    { 309, 102, "Exercise3", true, false, 10, 34, 10.0 },
                    { 310, 103, "Exercise1", true, false, 10, 35, 10.0 },
                    { 311, 103, "Exercise1", true, false, 10, 35, 10.0 },
                    { 312, 103, "Exercise1", true, false, 10, 35, 10.0 },
                    { 313, 104, "Exercise2", true, false, 10, 35, 10.0 },
                    { 314, 104, "Exercise2", true, false, 10, 35, 10.0 },
                    { 315, 104, "Exercise2", true, false, 10, 35, 10.0 },
                    { 316, 105, "Exercise3", true, false, 10, 35, 10.0 },
                    { 317, 105, "Exercise3", true, false, 10, 35, 10.0 },
                    { 318, 105, "Exercise3", true, false, 10, 35, 10.0 },
                    { 319, 106, "Exercise1", true, false, 10, 36, 10.0 },
                    { 320, 106, "Exercise1", true, false, 10, 36, 10.0 },
                    { 321, 106, "Exercise1", true, false, 10, 36, 10.0 },
                    { 322, 107, "Exercise2", true, false, 10, 36, 10.0 },
                    { 323, 107, "Exercise2", true, false, 10, 36, 10.0 },
                    { 324, 107, "Exercise2", true, false, 10, 36, 10.0 },
                    { 325, 108, "Exercise3", true, false, 10, 36, 10.0 },
                    { 326, 108, "Exercise3", true, false, 10, 36, 10.0 },
                    { 327, 108, "Exercise3", true, false, 10, 36, 10.0 },
                    { 328, 109, "Exercise1", true, false, 10, 37, 10.0 },
                    { 329, 109, "Exercise1", true, false, 10, 37, 10.0 },
                    { 330, 109, "Exercise1", true, false, 10, 37, 10.0 },
                    { 331, 110, "Exercise2", true, false, 10, 37, 10.0 },
                    { 332, 110, "Exercise2", true, false, 10, 37, 10.0 },
                    { 333, 110, "Exercise2", true, false, 10, 37, 10.0 },
                    { 334, 111, "Exercise3", true, false, 10, 37, 10.0 },
                    { 335, 111, "Exercise3", true, false, 10, 37, 10.0 },
                    { 336, 111, "Exercise3", true, false, 10, 37, 10.0 },
                    { 337, 112, "Exercise1", true, false, 10, 38, 10.0 },
                    { 338, 112, "Exercise1", true, false, 10, 38, 10.0 },
                    { 339, 112, "Exercise1", true, false, 10, 38, 10.0 },
                    { 340, 113, "Exercise2", true, false, 10, 38, 10.0 },
                    { 341, 113, "Exercise2", true, false, 10, 38, 10.0 },
                    { 342, 113, "Exercise2", true, false, 10, 38, 10.0 },
                    { 343, 114, "Exercise3", true, false, 10, 38, 10.0 },
                    { 344, 114, "Exercise3", true, false, 10, 38, 10.0 },
                    { 345, 114, "Exercise3", true, false, 10, 38, 10.0 },
                    { 346, 115, "Exercise1", true, false, 10, 39, 10.0 },
                    { 347, 115, "Exercise1", true, false, 10, 39, 10.0 },
                    { 348, 115, "Exercise1", true, false, 10, 39, 10.0 },
                    { 349, 116, "Exercise2", true, false, 10, 39, 10.0 },
                    { 350, 116, "Exercise2", true, false, 10, 39, 10.0 },
                    { 351, 116, "Exercise2", true, false, 10, 39, 10.0 },
                    { 352, 117, "Exercise3", true, false, 10, 39, 10.0 },
                    { 353, 117, "Exercise3", true, false, 10, 39, 10.0 },
                    { 354, 117, "Exercise3", true, false, 10, 39, 10.0 },
                    { 355, 118, "Exercise1", true, false, 10, 40, 10.0 },
                    { 356, 118, "Exercise1", true, false, 10, 40, 10.0 },
                    { 357, 118, "Exercise1", true, false, 10, 40, 10.0 },
                    { 358, 119, "Exercise2", true, false, 10, 40, 10.0 },
                    { 359, 119, "Exercise2", true, false, 10, 40, 10.0 },
                    { 360, 119, "Exercise2", true, false, 10, 40, 10.0 },
                    { 361, 120, "Exercise3", true, false, 10, 40, 10.0 },
                    { 362, 120, "Exercise3", true, false, 10, 40, 10.0 },
                    { 363, 120, "Exercise3", true, false, 10, 40, 10.0 },
                    { 364, 121, "Exercise1", true, false, 10, 41, 10.0 },
                    { 365, 121, "Exercise1", true, false, 10, 41, 10.0 },
                    { 366, 121, "Exercise1", true, false, 10, 41, 10.0 },
                    { 367, 122, "Exercise2", true, false, 10, 41, 10.0 },
                    { 368, 122, "Exercise2", true, false, 10, 41, 10.0 },
                    { 369, 122, "Exercise2", true, false, 10, 41, 10.0 },
                    { 370, 123, "Exercise3", true, false, 10, 41, 10.0 },
                    { 371, 123, "Exercise3", true, false, 10, 41, 10.0 },
                    { 372, 123, "Exercise3", true, false, 10, 41, 10.0 },
                    { 373, 124, "Exercise1", true, false, 10, 42, 10.0 },
                    { 374, 124, "Exercise1", true, false, 10, 42, 10.0 },
                    { 375, 124, "Exercise1", true, false, 10, 42, 10.0 },
                    { 376, 125, "Exercise2", true, false, 10, 42, 10.0 },
                    { 377, 125, "Exercise2", true, false, 10, 42, 10.0 },
                    { 378, 125, "Exercise2", true, false, 10, 42, 10.0 },
                    { 379, 126, "Exercise3", true, false, 10, 42, 10.0 },
                    { 380, 126, "Exercise3", true, false, 10, 42, 10.0 },
                    { 381, 126, "Exercise3", true, false, 10, 42, 10.0 },
                    { 382, 127, "Exercise1", true, false, 10, 43, 10.0 },
                    { 383, 127, "Exercise1", true, false, 10, 43, 10.0 },
                    { 384, 127, "Exercise1", true, false, 10, 43, 10.0 },
                    { 385, 128, "Exercise2", true, false, 10, 43, 10.0 },
                    { 386, 128, "Exercise2", true, false, 10, 43, 10.0 },
                    { 387, 128, "Exercise2", true, false, 10, 43, 10.0 },
                    { 388, 129, "Exercise3", true, false, 10, 43, 10.0 },
                    { 389, 129, "Exercise3", true, false, 10, 43, 10.0 },
                    { 390, 129, "Exercise3", true, false, 10, 43, 10.0 },
                    { 391, 130, "Exercise1", true, false, 10, 44, 10.0 },
                    { 392, 130, "Exercise1", true, false, 10, 44, 10.0 },
                    { 393, 130, "Exercise1", true, false, 10, 44, 10.0 },
                    { 394, 131, "Exercise2", true, false, 10, 44, 10.0 },
                    { 395, 131, "Exercise2", true, false, 10, 44, 10.0 },
                    { 396, 131, "Exercise2", true, false, 10, 44, 10.0 },
                    { 397, 132, "Exercise3", true, false, 10, 44, 10.0 },
                    { 398, 132, "Exercise3", true, false, 10, 44, 10.0 },
                    { 399, 132, "Exercise3", true, false, 10, 44, 10.0 },
                    { 400, 133, "Exercise1", true, false, 10, 45, 10.0 },
                    { 401, 133, "Exercise1", true, false, 10, 45, 10.0 },
                    { 402, 133, "Exercise1", true, false, 10, 45, 10.0 },
                    { 403, 134, "Exercise2", true, false, 10, 45, 10.0 },
                    { 404, 134, "Exercise2", true, false, 10, 45, 10.0 },
                    { 405, 134, "Exercise2", true, false, 10, 45, 10.0 },
                    { 406, 135, "Exercise3", true, false, 10, 45, 10.0 },
                    { 407, 135, "Exercise3", true, false, 10, 45, 10.0 },
                    { 408, 135, "Exercise3", true, false, 10, 45, 10.0 },
                    { 409, 136, "Exercise1", true, false, 10, 46, 10.0 },
                    { 410, 136, "Exercise1", true, false, 10, 46, 10.0 },
                    { 411, 136, "Exercise1", true, false, 10, 46, 10.0 },
                    { 412, 137, "Exercise2", true, false, 10, 46, 10.0 },
                    { 413, 137, "Exercise2", true, false, 10, 46, 10.0 },
                    { 414, 137, "Exercise2", true, false, 10, 46, 10.0 },
                    { 415, 138, "Exercise3", true, false, 10, 46, 10.0 },
                    { 416, 138, "Exercise3", true, false, 10, 46, 10.0 },
                    { 417, 138, "Exercise3", true, false, 10, 46, 10.0 },
                    { 418, 139, "Exercise1", true, false, 10, 47, 10.0 },
                    { 419, 139, "Exercise1", true, false, 10, 47, 10.0 },
                    { 420, 139, "Exercise1", true, false, 10, 47, 10.0 },
                    { 421, 140, "Exercise2", true, false, 10, 47, 10.0 },
                    { 422, 140, "Exercise2", true, false, 10, 47, 10.0 },
                    { 423, 140, "Exercise2", true, false, 10, 47, 10.0 },
                    { 424, 141, "Exercise3", true, false, 10, 47, 10.0 },
                    { 425, 141, "Exercise3", true, false, 10, 47, 10.0 },
                    { 426, 141, "Exercise3", true, false, 10, 47, 10.0 },
                    { 427, 142, "Exercise1", true, false, 10, 48, 10.0 },
                    { 428, 142, "Exercise1", true, false, 10, 48, 10.0 },
                    { 429, 142, "Exercise1", true, false, 10, 48, 10.0 },
                    { 430, 143, "Exercise2", true, false, 10, 48, 10.0 },
                    { 431, 143, "Exercise2", true, false, 10, 48, 10.0 },
                    { 432, 143, "Exercise2", true, false, 10, 48, 10.0 },
                    { 433, 144, "Exercise3", true, false, 10, 48, 10.0 },
                    { 434, 144, "Exercise3", true, false, 10, 48, 10.0 },
                    { 435, 144, "Exercise3", true, false, 10, 48, 10.0 },
                    { 436, 145, "Exercise1", true, false, 10, 49, 10.0 },
                    { 437, 145, "Exercise1", true, false, 10, 49, 10.0 },
                    { 438, 145, "Exercise1", true, false, 10, 49, 10.0 },
                    { 439, 146, "Exercise2", true, false, 10, 49, 10.0 },
                    { 440, 146, "Exercise2", true, false, 10, 49, 10.0 },
                    { 441, 146, "Exercise2", true, false, 10, 49, 10.0 },
                    { 442, 147, "Exercise3", true, false, 10, 49, 10.0 },
                    { 443, 147, "Exercise3", true, false, 10, 49, 10.0 },
                    { 444, 147, "Exercise3", true, false, 10, 49, 10.0 },
                    { 445, 148, "Exercise1", true, false, 10, 50, 10.0 },
                    { 446, 148, "Exercise1", true, false, 10, 50, 10.0 },
                    { 447, 148, "Exercise1", true, false, 10, 50, 10.0 },
                    { 448, 149, "Exercise2", true, false, 10, 50, 10.0 },
                    { 449, 149, "Exercise2", true, false, 10, 50, 10.0 },
                    { 450, 149, "Exercise2", true, false, 10, 50, 10.0 },
                    { 451, 150, "Exercise3", true, false, 10, 50, 10.0 },
                    { 452, 150, "Exercise3", true, false, 10, 50, 10.0 },
                    { 453, 150, "Exercise3", true, false, 10, 50, 10.0 },
                    { 454, 151, "Exercise1", true, false, 10, 51, 10.0 },
                    { 455, 151, "Exercise1", true, false, 10, 51, 10.0 },
                    { 456, 151, "Exercise1", true, false, 10, 51, 10.0 },
                    { 457, 152, "Exercise2", true, false, 10, 51, 10.0 },
                    { 458, 152, "Exercise2", true, false, 10, 51, 10.0 },
                    { 459, 152, "Exercise2", true, false, 10, 51, 10.0 },
                    { 460, 153, "Exercise3", true, false, 10, 51, 10.0 },
                    { 461, 153, "Exercise3", true, false, 10, 51, 10.0 },
                    { 462, 153, "Exercise3", true, false, 10, 51, 10.0 },
                    { 463, 154, "Exercise1", true, false, 10, 52, 10.0 },
                    { 464, 154, "Exercise1", true, false, 10, 52, 10.0 },
                    { 465, 154, "Exercise1", true, false, 10, 52, 10.0 },
                    { 466, 155, "Exercise2", true, false, 10, 52, 10.0 },
                    { 467, 155, "Exercise2", true, false, 10, 52, 10.0 },
                    { 468, 155, "Exercise2", true, false, 10, 52, 10.0 },
                    { 469, 156, "Exercise3", true, false, 10, 52, 10.0 },
                    { 470, 156, "Exercise3", true, false, 10, 52, 10.0 },
                    { 471, 156, "Exercise3", true, false, 10, 52, 10.0 },
                    { 472, 157, "Exercise1", true, false, 10, 53, 10.0 },
                    { 473, 157, "Exercise1", true, false, 10, 53, 10.0 },
                    { 474, 157, "Exercise1", true, false, 10, 53, 10.0 },
                    { 475, 158, "Exercise2", true, false, 10, 53, 10.0 },
                    { 476, 158, "Exercise2", true, false, 10, 53, 10.0 },
                    { 477, 158, "Exercise2", true, false, 10, 53, 10.0 },
                    { 478, 159, "Exercise3", true, false, 10, 53, 10.0 },
                    { 479, 159, "Exercise3", true, false, 10, 53, 10.0 },
                    { 480, 159, "Exercise3", true, false, 10, 53, 10.0 },
                    { 481, 160, "Exercise1", true, false, 10, 54, 10.0 },
                    { 482, 160, "Exercise1", true, false, 10, 54, 10.0 },
                    { 483, 160, "Exercise1", true, false, 10, 54, 10.0 },
                    { 484, 161, "Exercise2", true, false, 10, 54, 10.0 },
                    { 485, 161, "Exercise2", true, false, 10, 54, 10.0 },
                    { 486, 161, "Exercise2", true, false, 10, 54, 10.0 },
                    { 487, 162, "Exercise3", true, false, 10, 54, 10.0 },
                    { 488, 162, "Exercise3", true, false, 10, 54, 10.0 },
                    { 489, 162, "Exercise3", true, false, 10, 54, 10.0 },
                    { 490, 163, "Exercise1", true, false, 10, 55, 10.0 },
                    { 491, 163, "Exercise1", true, false, 10, 55, 10.0 },
                    { 492, 163, "Exercise1", true, false, 10, 55, 10.0 },
                    { 493, 164, "Exercise2", true, false, 10, 55, 10.0 },
                    { 494, 164, "Exercise2", true, false, 10, 55, 10.0 },
                    { 495, 164, "Exercise2", true, false, 10, 55, 10.0 },
                    { 496, 165, "Exercise3", true, false, 10, 55, 10.0 },
                    { 497, 165, "Exercise3", true, false, 10, 55, 10.0 },
                    { 498, 165, "Exercise3", true, false, 10, 55, 10.0 },
                    { 499, 166, "Exercise1", true, false, 10, 56, 10.0 },
                    { 500, 166, "Exercise1", true, false, 10, 56, 10.0 },
                    { 501, 166, "Exercise1", true, false, 10, 56, 10.0 },
                    { 502, 167, "Exercise2", true, false, 10, 56, 10.0 },
                    { 503, 167, "Exercise2", true, false, 10, 56, 10.0 },
                    { 504, 167, "Exercise2", true, false, 10, 56, 10.0 },
                    { 505, 168, "Exercise3", true, false, 10, 56, 10.0 },
                    { 506, 168, "Exercise3", true, false, 10, 56, 10.0 },
                    { 507, 168, "Exercise3", true, false, 10, 56, 10.0 },
                    { 508, 169, "Exercise1", true, false, 10, 57, 10.0 },
                    { 509, 169, "Exercise1", true, false, 10, 57, 10.0 },
                    { 510, 169, "Exercise1", true, false, 10, 57, 10.0 },
                    { 511, 170, "Exercise2", true, false, 10, 57, 10.0 },
                    { 512, 170, "Exercise2", true, false, 10, 57, 10.0 },
                    { 513, 170, "Exercise2", true, false, 10, 57, 10.0 },
                    { 514, 171, "Exercise3", true, false, 10, 57, 10.0 },
                    { 515, 171, "Exercise3", true, false, 10, 57, 10.0 },
                    { 516, 171, "Exercise3", true, false, 10, 57, 10.0 },
                    { 517, 172, "Exercise1", true, false, 10, 58, 10.0 },
                    { 518, 172, "Exercise1", true, false, 10, 58, 10.0 },
                    { 519, 172, "Exercise1", true, false, 10, 58, 10.0 },
                    { 520, 173, "Exercise2", true, false, 10, 58, 10.0 },
                    { 521, 173, "Exercise2", true, false, 10, 58, 10.0 },
                    { 522, 173, "Exercise2", true, false, 10, 58, 10.0 },
                    { 523, 174, "Exercise3", true, false, 10, 58, 10.0 },
                    { 524, 174, "Exercise3", true, false, 10, 58, 10.0 },
                    { 525, 174, "Exercise3", true, false, 10, 58, 10.0 },
                    { 526, 175, "Exercise1", true, false, 10, 59, 10.0 },
                    { 527, 175, "Exercise1", true, false, 10, 59, 10.0 },
                    { 528, 175, "Exercise1", true, false, 10, 59, 10.0 },
                    { 529, 176, "Exercise2", true, false, 10, 59, 10.0 },
                    { 530, 176, "Exercise2", true, false, 10, 59, 10.0 },
                    { 531, 176, "Exercise2", true, false, 10, 59, 10.0 },
                    { 532, 177, "Exercise3", true, false, 10, 59, 10.0 },
                    { 533, 177, "Exercise3", true, false, 10, 59, 10.0 },
                    { 534, 177, "Exercise3", true, false, 10, 59, 10.0 },
                    { 535, 178, "Exercise1", true, false, 10, 60, 10.0 },
                    { 536, 178, "Exercise1", true, false, 10, 60, 10.0 },
                    { 537, 178, "Exercise1", true, false, 10, 60, 10.0 },
                    { 538, 179, "Exercise2", true, false, 10, 60, 10.0 },
                    { 539, 179, "Exercise2", true, false, 10, 60, 10.0 },
                    { 540, 179, "Exercise2", true, false, 10, 60, 10.0 },
                    { 541, 180, "Exercise3", true, false, 10, 60, 10.0 },
                    { 542, 180, "Exercise3", true, false, 10, 60, 10.0 },
                    { 543, 180, "Exercise3", true, false, 10, 60, 10.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TrackedWorkouts",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}
