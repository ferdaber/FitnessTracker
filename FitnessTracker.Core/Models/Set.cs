using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Core.Models
{
    public class Set : Entity
    {
        public int Line { get; internal set; }

        public IAppUser PerformedBy { get; internal set; }

        public DateTime DatePerformed { get; set; }

        public int ExerciseId { get; internal set; }
        public Exercise Exercise { get; internal set; }

        public List<Repetition> Repetitions { get; internal set; }

        public List<Resistance> Resistances { get; internal set; }
    }
}
