using System;
using System.Collections.Generic;

namespace FitnessTracker.Core.Models
{
    public class Exercise
    {
        public int ID { get; set; }
        public ExerciseType Type { get; set; }
        public MuscleGroup PrimaryMuscleGroup { get; set; }
        public List<MuscleGroup> SecondaryMuscleGroups { get; set; }
        public List<Activity> ValidActivities { get; set; }
        public List<Resistance> ValidResistances { get; set; }
    }
}
