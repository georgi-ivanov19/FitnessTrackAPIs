using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Models.Measuremets;

public partial class Measurement
{
    [Key]
    public int Id { get; set; }

    [Column("applicationUserId")]
    public string ApplicationUserId { get; set; } = null!;

    public string Type { get; set; } = null!;

    public double? Value { get; set; }

    public string Unit { get; set; } = null!;

    public DateTime Date { get; set; }
}
