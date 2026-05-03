using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace AVTOV.Models;

public partial class Ispr2524LinkovNIAvtooContext : DbContext
{
    public Ispr2524LinkovNIAvtooContext()
    {
    }

    public Ispr2524LinkovNIAvtooContext(DbContextOptions<Ispr2524LinkovNIAvtooContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;database=ISPr25-24_KirovAA_Avtoo;user=ISPr25-24_KirovAA;password=ISPr25-24_KirovAA", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PRIMARY");

            entity.ToTable("comments");

            entity.HasIndex(e => e.MasterId, "fk_comments_master");

            entity.HasIndex(e => e.RequestId, "fk_comments_request");

            entity.Property(e => e.CommentId)
                .ValueGeneratedNever()
                .HasColumnName("commentID");
            entity.Property(e => e.MasterId).HasColumnName("masterID");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.RequestId).HasColumnName("requestID");

            entity.HasOne(d => d.Master).WithMany(p => p.Comments)
                .HasForeignKey(d => d.MasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_comments_master");

            entity.HasOne(d => d.Request).WithMany(p => p.Comments)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("fk_comments_request");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PRIMARY");

            entity.ToTable("requests");

            entity.HasIndex(e => e.ClientId, "fk_requests_client");

            entity.HasIndex(e => e.MasterId, "fk_requests_master");

            entity.Property(e => e.RequestId)
                .ValueGeneratedNever()
                .HasColumnName("requestID");
            entity.Property(e => e.CarModel)
                .HasMaxLength(255)
                .HasColumnName("carModel");
            entity.Property(e => e.CarType)
                .HasMaxLength(100)
                .HasColumnName("carType");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.CompletionDate).HasColumnName("completionDate");
            entity.Property(e => e.MasterId).HasColumnName("masterID");
            entity.Property(e => e.ProblemDescryption)
                .HasColumnType("text")
                .HasColumnName("problemDescryption");
            entity.Property(e => e.RepairParts)
                .HasColumnType("text")
                .HasColumnName("repairParts");
            entity.Property(e => e.RequestStatus)
                .HasMaxLength(100)
                .HasColumnName("requestStatus");
            entity.Property(e => e.StartDate).HasColumnName("startDate");

            entity.HasOne(d => d.Client).WithMany(p => p.RequestClients)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_requests_client");

            entity.HasOne(d => d.Master).WithMany(p => p.RequestMasters)
                .HasForeignKey(d => d.MasterId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_requests_master");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "uk_users_login").IsUnique();

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userID");
            entity.Property(e => e.Fio)
                .HasMaxLength(255)
                .HasColumnName("fio");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
