using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Models.Workouts;

[Index("WorkoutId", Name = "IX_Exercises_WorkoutId")]
public partial class Exercise
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int WorkoutId { get; set; }

    public int? DefaultNumberOfSets { get; set; }

    public string TargetMuscle { get; set; } = null!;

    [ForeignKey("WorkoutId")]
    [InverseProperty("Exercises")]
    public virtual Workout Workout { get; set; } = null!;
}
