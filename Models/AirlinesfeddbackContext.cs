using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vehicleregsration.Models;

public partial class AirlinesfeddbackContext : Microsoft.EntityFrameworkCore.DbContext
{
    public AirlinesfeddbackContext(DbContextOptions<AirlinesfeddbackContext> options)
    {
    }

    public virtual DbSet<Vehichledatum> Vehichledata { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-APMVBAH;\n Initial Catalog=Airlinesfeddback;Integrated Security=True;multipleactiveresultsets=True;encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vehichledatum>(entity =>
        {
            entity.HasKey(e => e.VehId);

            entity.Property(e => e.VehId).HasColumnName("vehId");
            entity.Property(e => e.VehSerialno).HasColumnName("vehSerialno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
