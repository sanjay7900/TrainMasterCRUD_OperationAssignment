using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TrainsClassLibraryFile.Models
{
    public partial class TrainMasterContext : DbContext
    {
        public TrainMasterContext()
        {
        }

        public TrainMasterContext(DbContextOptions<TrainMasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DaysOnWhichEveryTrainRun> DaysOnWhichEveryTrainRuns { get; set; } = null!;
        public virtual DbSet<Train> Trains { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-AMR2CQS\\MSSQLSERVER01;Initial Catalog=TrainMaster;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DaysOnWhichEveryTrainRun>(entity =>
            {
                entity.ToTable("days_on_which_every_train_run");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TrainNo).HasColumnName("trainNo");

                entity.Property(e => e.TrainRunDays)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Train)
                    .WithMany(p => p.DaysOnWhichEveryTrainRuns)
                    .HasPrincipalKey(p => p.TrainNo)
                    .HasForeignKey(d => d.TrainNo)
                    .HasConstraintName("FK__days_on_w__train__29572725");
            });

            modelBuilder.Entity<Train>(entity =>
            {
                entity.HasIndex(e => e.TrainNo, "UQ__Trains__9EC24438B1575ADB")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FromStation)
                    .HasMaxLength(50)
                    .HasColumnName("From_Station");

                entity.Property(e => e.JourneyEndTime).HasColumnName("Journey_End_Time");

                entity.Property(e => e.JourneyStartTime).HasColumnName("Journey_Start_Time");

                entity.Property(e => e.ToStation).HasMaxLength(50);

                entity.Property(e => e.TrainName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Train_name");

                entity.Property(e => e.TrainNo)
                    .IsRequired()
                    .HasColumnName("trainNo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
