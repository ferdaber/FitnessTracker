using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Core.Models
{
    public abstract class Entity
    {
        public int Id { get; internal set; }

        public override bool Equals(object obj)
        {
            Entity entityObj = obj as Entity;
            if (entityObj != null)
            {
                return entityObj.Id == Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
