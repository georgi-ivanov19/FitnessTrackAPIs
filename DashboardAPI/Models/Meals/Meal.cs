using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Models.Meals;

public partial class Meal
{
    [Key]
    public int Id { get; set; }

    [Column("applicationUserId")]
    public string ApplicationUserId { get; set; } = null!;

    public string Category { get; set; } = null!;

    public double TotalCalories { get; set; }

    public double Protein { get; set; }

    public double Fats { get; set; }

    public double Carbohydrates { get; set; }

    public DateTime Date { get; set; }
}
