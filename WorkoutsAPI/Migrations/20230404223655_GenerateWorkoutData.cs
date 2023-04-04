using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutsAPI.Migrations
{
    /// <inheritdoc />
    public partial class GenerateWorkoutData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "ApplicationUserId", "DateLastCompleted", "DayOfWeek", "Name" },
                values: new object[,]
                {
                    { 1, "620eebc4-69c6-48c1-b9bc-8ceb6855b607", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(3851), "Monday", "Workout1" },
                    { 2, "620eebc4-69c6-48c1-b9bc-8ceb6855b607", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4024), "Wednesday", "Workout2" },
                    { 3, "620eebc4-69c6-48c1-b9bc-8ceb6855b607", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4049), "Friday", "Workout3" },
                    { 4, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4128), "Monday", "Workout1" },
                    { 5, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4153), "Wednesday", "Workout2" },
                    { 6, "9bb8263a-6dd1-42e9-8f29-a847dbb3e059", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4175), "Friday", "Workout3" },
                    { 7, "0371f684-9a41-4d40-ba2b-62cc5eabed46", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4196), "Monday", "Workout1" },
                    { 8, "0371f684-9a41-4d40-ba2b-62cc5eabed46", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4217), "Wednesday", "Workout2" },
                    { 9, "0371f684-9a41-4d40-ba2b-62cc5eabed46", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4272), "Friday", "Workout3" },
                    { 10, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4296), "Monday", "Workout1" },
                    { 11, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4318), "Wednesday", "Workout2" },
                    { 12, "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4340), "Friday", "Workout3" },
                    { 13, "aa88aabd-677b-4588-8cb0-213d5ba9e660", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4394), "Monday", "Workout1" },
                    { 14, "aa88aabd-677b-4588-8cb0-213d5ba9e660", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4416), "Wednesday", "Workout2" },
                    { 15, "aa88aabd-677b-4588-8cb0-213d5ba9e660", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4437), "Friday", "Workout3" },
                    { 16, "f0e37b93-0558-458c-9e61-d0330ed9f4ec", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4460), "Monday", "Workout1" },
                    { 17, "f0e37b93-0558-458c-9e61-d0330ed9f4ec", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4514), "Wednesday", "Workout2" },
                    { 18, "f0e37b93-0558-458c-9e61-d0330ed9f4ec", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4537), "Friday", "Workout3" },
                    { 19, "4d0bafc4-1d88-4433-9769-1e2d251530a7", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4559), "Monday", "Workout1" },
                    { 20, "4d0bafc4-1d88-4433-9769-1e2d251530a7", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4580), "Wednesday", "Workout2" },
                    { 21, "4d0bafc4-1d88-4433-9769-1e2d251530a7", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4601), "Friday", "Workout3" },
                    { 22, "5febdbbe-d537-430f-9ccb-b48f252d2d4e", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4657), "Monday", "Workout1" },
                    { 23, "5febdbbe-d537-430f-9ccb-b48f252d2d4e", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4682), "Wednesday", "Workout2" },
                    { 24, "5febdbbe-d537-430f-9ccb-b48f252d2d4e", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4703), "Friday", "Workout3" },
                    { 25, "c4824aab-c08f-4141-86c4-082fd8bbca8c", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4724), "Monday", "Workout1" },
                    { 26, "c4824aab-c08f-4141-86c4-082fd8bbca8c", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4746), "Wednesday", "Workout2" },
                    { 27, "c4824aab-c08f-4141-86c4-082fd8bbca8c", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4801), "Friday", "Workout3" },
                    { 28, "2abf2679-ae98-456c-99ed-fe7ca2698c2e", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4823), "Monday", "Workout1" },
                    { 29, "2abf2679-ae98-456c-99ed-fe7ca2698c2e", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4844), "Wednesday", "Workout2" },
                    { 30, "2abf2679-ae98-456c-99ed-fe7ca2698c2e", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4901), "Friday", "Workout3" },
                    { 31, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4923), "Monday", "Workout1" },
                    { 32, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4945), "Wednesday", "Workout2" },
                    { 33, "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1", new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4966), "Friday", "Workout3" }
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
                    { 99, 3, "Exercise3", "Muscle3", 33 }
                });

            migrationBuilder.InsertData(
                table: "TrackedWorkouts",
                columns: new[] { "Id", "EndTime", "IsCompleted", "Notes", "StartTime", "TotalVolume", "WorkoutId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(3914), true, "Notes for TrackedWorkout1", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(3918), 1000.0, 1 },
                    { 2, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4036), true, "Notes for TrackedWorkout2", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4037), 1000.0, 2 },
                    { 3, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4058), true, "Notes for TrackedWorkout3", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4060), 1000.0, 3 },
                    { 4, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4139), true, "Notes for TrackedWorkout4", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4141), 1000.0, 4 },
                    { 5, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4162), true, "Notes for TrackedWorkout5", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4164), 1000.0, 5 },
                    { 6, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4185), true, "Notes for TrackedWorkout6", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4187), 1000.0, 6 },
                    { 7, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4205), true, "Notes for TrackedWorkout7", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4207), 1000.0, 7 },
                    { 8, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4227), true, "Notes for TrackedWorkout8", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4228), 1000.0, 8 },
                    { 9, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4283), true, "Notes for TrackedWorkout9", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4284), 1000.0, 9 },
                    { 10, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4306), true, "Notes for TrackedWorkout10", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4308), 1000.0, 10 },
                    { 11, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4329), true, "Notes for TrackedWorkout11", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4330), 1000.0, 11 },
                    { 12, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4350), true, "Notes for TrackedWorkout12", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4351), 1000.0, 12 },
                    { 13, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4405), true, "Notes for TrackedWorkout13", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4406), 1000.0, 13 },
                    { 14, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4426), true, "Notes for TrackedWorkout14", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4427), 1000.0, 14 },
                    { 15, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4447), true, "Notes for TrackedWorkout15", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4448), 1000.0, 15 },
                    { 16, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4470), true, "Notes for TrackedWorkout16", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4471), 1000.0, 16 },
                    { 17, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4525), true, "Notes for TrackedWorkout17", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4526), 1000.0, 17 },
                    { 18, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4547), true, "Notes for TrackedWorkout18", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4549), 1000.0, 18 },
                    { 19, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4569), true, "Notes for TrackedWorkout19", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4570), 1000.0, 19 },
                    { 20, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4590), true, "Notes for TrackedWorkout20", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4591), 1000.0, 20 },
                    { 21, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4611), true, "Notes for TrackedWorkout21", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4613), 1000.0, 21 },
                    { 22, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4670), true, "Notes for TrackedWorkout22", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4671), 1000.0, 22 },
                    { 23, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4692), true, "Notes for TrackedWorkout23", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4693), 1000.0, 23 },
                    { 24, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4713), true, "Notes for TrackedWorkout24", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4714), 1000.0, 24 },
                    { 25, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4735), true, "Notes for TrackedWorkout25", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4736), 1000.0, 25 },
                    { 26, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4756), true, "Notes for TrackedWorkout26", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4758), 1000.0, 26 },
                    { 27, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4812), true, "Notes for TrackedWorkout27", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4813), 1000.0, 27 },
                    { 28, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4833), true, "Notes for TrackedWorkout28", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4835), 1000.0, 28 },
                    { 29, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4855), true, "Notes for TrackedWorkout29", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4857), 1000.0, 29 },
                    { 30, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4912), true, "Notes for TrackedWorkout30", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4913), 1000.0, 30 },
                    { 31, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4934), true, "Notes for TrackedWorkout31", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4935), 1000.0, 31 },
                    { 32, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4955), true, "Notes for TrackedWorkout32", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4957), 1000.0, 32 },
                    { 33, new DateTime(2023, 4, 4, 23, 36, 55, 766, DateTimeKind.Local).AddTicks(4977), true, "Notes for TrackedWorkout33", new DateTime(2023, 4, 4, 21, 36, 55, 766, DateTimeKind.Local).AddTicks(4978), 1000.0, 33 }
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
                    { 300, 99, "Exercise3", true, false, 10, 33, 10.0 }
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
        }
    }
}
