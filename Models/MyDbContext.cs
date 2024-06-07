using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FOM.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblPost> TblPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=AzeznConn");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblPost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPosts");

            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.DateInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Dislikes).HasColumnName("dislikes");
            entity.Property(e => e.Img).HasColumnName("img");
            entity.Property(e => e.Likes).HasColumnName("likes");
            entity.Property(e => e.Link1).HasColumnName("link1");
            entity.Property(e => e.Link2).HasColumnName("link2");
            entity.Property(e => e.Link3).HasColumnName("link3");
            entity.Property(e => e.Link4).HasColumnName("link4");
            entity.Property(e => e.Link5).HasColumnName("link5");
            entity.Property(e => e.Link6).HasColumnName("link6");
            entity.Property(e => e.Mcategory).HasColumnName("mcategory");
            entity.Property(e => e.Meta).HasColumnName("meta");
            entity.Property(e => e.Pid)
                .ValueGeneratedOnAdd()
                .HasColumnName("pid");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Slug).HasColumnName("slug");
            entity.Property(e => e.Tags).HasColumnName("tags");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Tlink1).HasColumnName("tlink1");
            entity.Property(e => e.Tlink2).HasColumnName("tlink2");
            entity.Property(e => e.Tlink3).HasColumnName("tlink3");
            entity.Property(e => e.Tlink4).HasColumnName("tlink4");
            entity.Property(e => e.Tlink5).HasColumnName("tlink5");
            entity.Property(e => e.Tlink6).HasColumnName("tlink6");
            entity.Property(e => e.Views).HasColumnName("views");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
