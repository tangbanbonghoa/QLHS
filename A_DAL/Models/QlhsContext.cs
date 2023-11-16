using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Models;

public partial class QlhsContext : DbContext
{
    public QlhsContext()
    {
    }

    public QlhsContext(DbContextOptions<QlhsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Qlh> Qlhs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MN98SD2\\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Qlh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__qlhs__3213E83F39C654D9");

            entity.ToTable("qlhs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(100)
                .HasColumnName("diachi");
            entity.Property(e => e.Loaicongviec)
                .HasMaxLength(255)
                .HasColumnName("loaicongviec");
            entity.Property(e => e.Ngaylam)
                .HasColumnType("date")
                .HasColumnName("ngaylam");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
            entity.Property(e => e.Tiencong).HasColumnName("tiencong");
            entity.Property(e => e.Tiendathanhtoan).HasColumnName("tiendathanhtoan");
            entity.Property(e => e.Tongtien).HasColumnName("tongtien");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
