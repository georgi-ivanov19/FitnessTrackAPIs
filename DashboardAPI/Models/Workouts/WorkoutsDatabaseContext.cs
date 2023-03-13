using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Models.Workouts;

public partial class WorkoutsDatabaseContext : DbContext
{
    public WorkoutsDatabaseContext()
    {
    }

    public WorkoutsDatabaseContext(DbContextOptions<WorkoutsDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Exercise> Exercises { get; set; }

    public virtual DbSet<ExerciseSet> ExerciseSets { get; set; }

    public virtual DbSet<TrackedWorkout> TrackedWorkouts { get; set; }

    public virtual DbSet<Workout> Workouts { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=localhost,1401;Database=master;User=sa;Password=S3cur3P@ssW0rd!;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
