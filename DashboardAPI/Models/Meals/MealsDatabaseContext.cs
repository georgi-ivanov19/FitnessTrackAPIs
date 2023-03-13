using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Models.Meals;

public partial class MealsDatabaseContext : DbContext
{
    public MealsDatabaseContext()
    {
    }

    public MealsDatabaseContext(DbContextOptions<MealsDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Meal> Meals { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=localhost,1403;Database=master;User=sa;Password=S3cur3P@ssW0rd!;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
