using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessTracker.Core.Models
{
    /// <summary>
    /// This entity represents the concept of an exercise.
    /// </summary>
    public class Exercise : Entity
    {
        /// <summary>
        /// The category of exercise that the user performs
        /// </summary>
        public ExerciseType Type { get; set; }
        
        public int? PrimaryMuscleGroupId { get; internal set; }
        /// <summary>
        /// Primary muscle group worked by the exercise
        /// </summary>
        public MuscleGroup PrimaryMuscleGroup { get; internal set; }

        /// <summary>
        /// Any other muscle groups that may be worked
        /// </summary>
        public List<ExerciseSecondaryMuscleGroup> _exerciseSecondaryMuscleGroups { get; internal set; }
        public List<MuscleGroup> SecondaryMuscleGroups => _exerciseSecondaryMuscleGroups.Select(m => m.MuscleGroup).ToList();

        /// <summary>
        /// Different ways that the activities can be recorded for this exercise
        /// </summary>
        public List<ExerciseActivity> _exerciseActivities { get; internal set; }
        public List<Activity> ValidActivities => _exerciseActivities.Select(m => m.Activity).ToList();

        /// <summary>
        /// Possible ways to add resistance to the exercise
        /// </summary>
        public List<ExerciseResistance> _exerciseResistances { get; internal set; }
        public List<Resistance> ValidResistances => _exerciseResistances.Select(m => m.Resistance).ToList();

        public List<Set> Sets { get; internal set; }

        public void SetMuscleGroupAsPrimary(MuscleGroup muscleGroup)
        {
            throw new NotImplementedException();
        }

        public void AddMuscleGroup(MuscleGroup m)
        {
            throw new NotImplementedException();
        }


    }
}
