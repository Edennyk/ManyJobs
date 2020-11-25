using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ManyJobs.Models
{
    public partial class ManyJobsContext : DbContext
    {
        public ManyJobsContext()
        {
        }

        public ManyJobsContext(DbContextOptions<ManyJobsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JobOffer> JobOffer { get; set; }
        public virtual DbSet<JobSeeker> JobSeeker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source =manyjobsdb.cmheqkuxwcyv.us-east-1.rds.amazonaws.com,1433;Database=ManyJobs;User ID=db4project; Password=password;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobOffer>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK__JobOffer__056690C29E8F5E43");

                entity.Property(e => e.JobAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobExperience)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobSalary)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Skill)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobSeeker>(entity =>
            {
                entity.HasKey(e => e.SeekerId)
                    .HasName("PK__JobSeeke__5BBA3DA124E6E94A");

                entity.Property(e => e.SeekerCity).HasMaxLength(30);

                entity.Property(e => e.SeekerCountry).HasMaxLength(30);

                entity.Property(e => e.SeekerEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SeekerMajor).HasMaxLength(50);

                entity.Property(e => e.SeekerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Skill)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
