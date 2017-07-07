using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Core.Models
{
    /// <summary>
    /// This entity represents how an exercise's activity is recorded, such as via laps, repetitions, or speed.
    /// The collection of Activities is meant to be built-in and not edited by the user
    /// </summary>
    public class Activity : Entity
    {
        public ActivityType Type { get; internal set; }

        /// <summary>
        /// The dimensional units that the activity is recorded in (repetitions, seconds, meters, etc.)
        /// </summary>
        [MaxLength(20)]
        public string Unit { get; internal set; }

        public List<ExerciseActivity> ExerciseActivities { get; internal set; }
    }
}