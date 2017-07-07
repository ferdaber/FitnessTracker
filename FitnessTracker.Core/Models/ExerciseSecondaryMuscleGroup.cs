using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Core.Models
{
    public class ExerciseSecondaryMuscleGroup : Entity
    {
        public int ExerciseId { get; internal set; }
        public Exercise Exercise { get; internal set; }

        public int MuscleGroupId { get; internal set; }
        public MuscleGroup MuscleGroup { get; internal set; }
    }
}
