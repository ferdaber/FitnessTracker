using FitnessTracker.Core.Models;
using FitnessTracker.DataAccess.EF.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FitnessTracker.DataAccess.EF
{
    class FitnessTrackerContext : IdentityDbContext<AppUser>
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<Repetition> Repetitions { get; set; }
        public DbSet<Resistance> Resistances { get; set; }
        public DbSet<Set> Sets { get; set; }
        
        public FitnessTrackerContext(DbContextOptions opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Exercise>(b =>
            {
                b.HasOne(e => e.PrimaryMuscleGroup).WithMany(m => m.PrimaryExercises).HasForeignKey(e => e.PrimaryMuscleGroupId);
                b.Ignore(e => e.ValidActivities);
                b.Ignore(e => e.ValidResistances);
            });
            builder.Entity<Set>().HasOne(s => (AppUser)s.PerformedBy).WithMany(u => u.Sets).IsRequired();

            foreach (var entity in builder.Model.GetEntityTypes())
            {
                if (entity.ClrType != null)
                {
                    string uniqueName = entity.ClrType.Name;
                    int indexOfGenericArity = uniqueName.IndexOf('`');
                    uniqueName = indexOfGenericArity > -1 ? uniqueName.Substring(0, indexOfGenericArity) : uniqueName;
                    entity.Relational().TableName = uniqueName;
                }
            }
        }


    }
}
