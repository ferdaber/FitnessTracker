using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Core.Models
{
    public class SetResistance : Entity
    {
        public int SetId { get; internal set; }
        public Set Set { get; internal set; }

        public int ResistanceId { get; internal set; }
        public Resistance Resistance { get; internal set; }
    }
}
