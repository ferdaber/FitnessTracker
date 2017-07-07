using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Core.Models
{
    public class ExerciseResistance : Entity
    {
        public int ExerciseId { get; internal set; }
        public Exercise Exercise { get; internal set; }

        public int ResistanceId { get; internal set; }
        public Resistance Resistance { get; internal set; }
    }
}
