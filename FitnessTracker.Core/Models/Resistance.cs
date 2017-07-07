using System.Collections.Generic;

namespace FitnessTracker.Core.Models
{
    public class Resistance : Entity
    {
        public ResistanceType Type { get; set; }

        public List<ExerciseResistance> ExerciseResistances { get; internal set; }

        public List<SetResistance> SetResistances { get; internal set; }
    }
}