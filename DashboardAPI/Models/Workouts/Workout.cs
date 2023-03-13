using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Models.Workouts;

public partial class Workout
{
    [Key]
    public int Id { get; set; }

    public string ApplicationUserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string DayOfWeek { get; set; } = null!;

    public DateTime DateLastCompleted { get; set; }

    [InverseProperty("Workout")]
    public virtual ICollection<Exercise> Exercises { get; } = new List<Exercise>();

    [InverseProperty("Workout")]
    public virtual ICollection<TrackedWorkout> TrackedWorkouts { get; } = new List<TrackedWorkout>();
}
