namespace WorkoutsAPI.Context
{
    using WorkoutsAPI.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Workout>().HasMany(m => m.Exercises).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Workout>().HasMany(m => m.TrackedWorkouts).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Workout>().Navigation(e => e.Exercises).AutoInclude();
            builder.Entity<Workout>().Navigation(e => e.TrackedWorkouts).AutoInclude();
            builder.Entity<TrackedWorkout>().HasMany(e => e.ExerciseSetsCompleted).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.Entity<TrackedWorkout>().Navigation(e => e.ExerciseSetsCompleted).AutoInclude();
        }


        public DbSet<Workout> Workouts => Set<Workout>();
        public DbSet<TrackedWorkout> TrackedWorkouts => Set<TrackedWorkout>();
        public DbSet<Exercise> Exercises => Set<Exercise>();
        public DbSet<ExerciseSet> ExerciseSets => Set<ExerciseSet>();
    }
}
