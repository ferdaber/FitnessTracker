using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Core.Models
{
    public class MuscleGroup : Entity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public List<Exercise> PrimaryExercises { get; internal set; }

        public List<ExerciseSecondaryMuscleGroup> ExerciseSecondaryMuscleGroups { get; internal set; }
    }
}