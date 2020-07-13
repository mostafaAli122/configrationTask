namespace Configration.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Configration.Domain;

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=Conn")
        {
        }

        public virtual DbSet<C_InstructorConfigurationKeys> C_InstructorConfigurationKeys { get; set; }
        public virtual DbSet<C_ITIBranchConfigurationKeys> C_ITIBranchConfigurationKeys { get; set; }
        public virtual DbSet<C_StudentConfigurationKeys> C_StudentConfigurationKeys { get; set; }
        public virtual DbSet<InstructorConfiguration> InstructorConfigurations { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<ITIBranchConfiguration> ITIBranchConfigurations { get; set; }
        public virtual DbSet<ITIBranch> ITIBranchs { get; set; }
        public virtual DbSet<StudentConfiguration> StudentConfigurations { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_InstructorConfigurationKeys>()
                .Property(e => e.NameE)
                .IsUnicode(false);

            modelBuilder.Entity<C_InstructorConfigurationKeys>()
                .Property(e => e.C_InstructorConfigurationKeyValue)
                .IsUnicode(false);

            modelBuilder.Entity<C_InstructorConfigurationKeys>()
                .HasMany(e => e.InstructorConfigurations)
                .WithRequired(e => e.C_InstructorConfigurationKeys)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_ITIBranchConfigurationKeys>()
                .Property(e => e.NameE)
                .IsUnicode(false);

            modelBuilder.Entity<C_ITIBranchConfigurationKeys>()
                .Property(e => e.C_ITIBranchConfigurationKeyValue)
                .IsUnicode(false);

            modelBuilder.Entity<C_ITIBranchConfigurationKeys>()
                .HasMany(e => e.ITIBranchConfigurations)
                .WithRequired(e => e.C_ITIBranchConfigurationKeys)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_StudentConfigurationKeys>()
                .Property(e => e.NameE)
                .IsUnicode(false);

            modelBuilder.Entity<C_StudentConfigurationKeys>()
                .Property(e => e.C_StudentConfigurationKeyValue)
                .IsUnicode(false);

            modelBuilder.Entity<C_StudentConfigurationKeys>()
                .HasMany(e => e.StudentConfigurations)
                .WithRequired(e => e.C_StudentConfigurationKeys)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InstructorConfiguration>()
                .Property(e => e.InstructorConfigurationsValue)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.InstructorConfigurations)
                .WithRequired(e => e.Instructor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ITIBranchConfiguration>()
                .Property(e => e.ITIBranchConfigurationsValue)
                .IsUnicode(false);

            modelBuilder.Entity<ITIBranch>()
                .HasMany(e => e.ITIBranchConfigurations)
                .WithRequired(e => e.ITIBranch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentConfiguration>()
                .Property(e => e.StudentConfigurationsValue)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentConfigurations)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
