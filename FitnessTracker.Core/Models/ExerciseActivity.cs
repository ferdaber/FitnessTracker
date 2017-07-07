using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Core.Models
{
    public class ExerciseActivity : Entity
    {
        public int ExerciseId { get; internal set; }
        public Exercise Exercise { get; internal set; }

        public int ActivityId { get; internal set; }
        public Activity Activity { get; internal set; }
    }
}
