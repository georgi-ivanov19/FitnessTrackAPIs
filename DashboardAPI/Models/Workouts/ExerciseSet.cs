using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Models.Workouts;

[Index("TrackedWorkoutId", Name = "IX_ExerciseSets_TrackedWorkoutId")]
public partial class ExerciseSet
{
    [Key]
    public int Id { get; set; }

    public int? ExerciseId { get; set; }

    public string ExerciseName { get; set; } = null!;

    public int? Reps { get; set; }

    public double? Weight { get; set; }

    public bool IsWarmup { get; set; }

    public bool IsComplete { get; set; }

    public int TrackedWorkoutId { get; set; }

    [ForeignKey("TrackedWorkoutId")]
    [InverseProperty("ExerciseSets")]
    public virtual TrackedWorkout TrackedWorkout { get; set; } = null!;
}
