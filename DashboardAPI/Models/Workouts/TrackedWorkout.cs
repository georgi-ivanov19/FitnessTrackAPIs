using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Models.Workouts;

[Index("WorkoutId", Name = "IX_TrackedWorkouts_WorkoutId")]
public partial class TrackedWorkout
{
    [Key]
    public int Id { get; set; }

    public double TotalVolume { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool IsCompleted { get; set; }

    public int WorkoutId { get; set; }

    public string Notes { get; set; } = null!;

    [InverseProperty("TrackedWorkout")]
    public virtual ICollection<ExerciseSet> ExerciseSets { get; } = new List<ExerciseSet>();

    [ForeignKey("WorkoutId")]
    [InverseProperty("TrackedWorkouts")]
    public virtual Workout Workout { get; set; } = null!;
}
