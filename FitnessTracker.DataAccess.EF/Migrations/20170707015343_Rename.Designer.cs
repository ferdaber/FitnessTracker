using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FitnessTracker.DataAccess.EF;
using FitnessTracker.Core.Models;

namespace FitnessTracker.DataAccess.EF.Migrations
{
    [DbContext(typeof(FitnessTrackerContext))]
    [Migration("20170707015343_Rename")]
    partial class Rename
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitnessTracker.Core.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Type");

                    b.Property<string>("Unit")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PrimaryMuscleGroupId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("PrimaryMuscleGroupId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.ExerciseActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityId");

                    b.Property<int>("ExerciseId");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseActivity");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.ExerciseResistance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExerciseId");

                    b.Property<int>("ResistanceId");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("ResistanceId");

                    b.ToTable("ExerciseResistance");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.ExerciseSecondaryMuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExerciseId");

                    b.Property<int>("MuscleGroupId");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("ExerciseSecondaryMuscleGroup");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.MuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("MuscleGroup");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.Repetition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Intensity");

                    b.Property<int>("Line");

                    b.Property<int>("SetId");

                    b.HasKey("Id");

                    b.HasIndex("SetId");

                    b.ToTable("Repetition");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.Resistance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SetId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SetId");

                    b.ToTable("Resistance");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatePerformed");

                    b.Property<int>("ExerciseId");

                    b.Property<int>("Line");

                    b.Property<string>("PerformedById")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("PerformedById");

                    b.ToTable("Set");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.SetResistance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ResistanceId");

                    b.Property<int>("SetId");

                    b.HasKey("Id");

                    b.HasIndex("ResistanceId");

                    b.HasIndex("SetId");

                    b.ToTable("SetResistance");
                });

            modelBuilder.Entity("FitnessTracker.DataAccess.EF.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("IdentityRoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("IdentityUserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("IdentityUserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("IdentityUserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("IdentityUserToken");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.Exercise", b =>
                {
                    b.HasOne("FitnessTracker.Core.Models.MuscleGroup", "PrimaryMuscleGroup")
                        .WithMany("PrimaryExercises")
                        .HasForeignKey("PrimaryMuscleGroupId");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.ExerciseActivity", b =>
                {
                    b.HasOne("FitnessTracker.Core.Models.Activity", "Activity")
                        .WithMany("ExerciseActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessTracker.Core.Models.Exercise", "Exercise")
                        .WithMany("_exerciseActivities")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.ExerciseResistance", b =>
                {
                    b.HasOne("FitnessTracker.Core.Models.Exercise", "Exercise")
                        .WithMany("_exerciseResistances")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessTracker.Core.Models.Resistance", "Resistance")
                        .WithMany("ExerciseResistances")
                        .HasForeignKey("ResistanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.ExerciseSecondaryMuscleGroup", b =>
                {
                    b.HasOne("FitnessTracker.Core.Models.Exercise", "Exercise")
                        .WithMany("_exerciseSecondaryMuscleGroups")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessTracker.Core.Models.MuscleGroup", "MuscleGroup")
                        .WithMany("ExerciseSecondaryMuscleGroups")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.Repetition", b =>
                {
                    b.HasOne("FitnessTracker.Core.Models.Set", "Set")
                        .WithMany("Repetitions")
                        .HasForeignKey("SetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.Resistance", b =>
                {
                    b.HasOne("FitnessTracker.Core.Models.Set")
                        .WithMany("Resistances")
                        .HasForeignKey("SetId");
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.Set", b =>
                {
                    b.HasOne("FitnessTracker.Core.Models.Exercise", "Exercise")
                        .WithMany("Sets")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessTracker.DataAccess.EF.Identity.AppUser", "PerformedBy")
                        .WithMany("Sets")
                        .HasForeignKey("PerformedById")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessTracker.Core.Models.SetResistance", b =>
                {
                    b.HasOne("FitnessTracker.Core.Models.Resistance", "Resistance")
                        .WithMany("SetResistances")
                        .HasForeignKey("ResistanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessTracker.Core.Models.Set", "Set")
                        .WithMany()
                        .HasForeignKey("SetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FitnessTracker.DataAccess.EF.Identity.AppUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FitnessTracker.DataAccess.EF.Identity.AppUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessTracker.DataAccess.EF.Identity.AppUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
