using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Core.Models
{
    class Set
    {
        public int ID { get; set; }
        public int Line { get; set; }
        public User PerformedBy { get; set; }
        public DateTime DatePerformed { get; set; }
        public Exercise Exercise { get; set; }
        public Repetition Repetitions { get; set; }
        public List<Resistance> Resistances { get; set; }
    }
}
