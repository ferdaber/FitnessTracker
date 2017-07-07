using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace FitnessTracker.Core.Models
{
    public interface IAppUser : IIdentity
    {
        string Id { get; set; }
        string UserName { get; set; }
        string Email { get; set; }

        List<Set> Sets { get; }
    }
}
