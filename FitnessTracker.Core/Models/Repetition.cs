using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Core.Models
{
    public class Repetition : Entity
    {
        public int Line { get; internal set; }

        /// <summary>
        /// The extent of the repetition, based on the activity type
        /// </summary>
        public float Intensity { get; set; }

        public int SetId { get; internal set; }
        public Set Set { get; internal set; }
    }
}