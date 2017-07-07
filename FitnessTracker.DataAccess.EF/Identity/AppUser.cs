using FitnessTracker.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTracker.DataAccess.EF.Identity
{
    public class AppUser : IdentityUser, IAppUser
    {
        [NotMapped]
        public string AuthenticationType { get; set; }

        [NotMapped]
        public bool IsAuthenticated { get; set; }

        [NotMapped]
        public string Name
        {
            get { return UserName; }
            set { UserName = value; }
        }

        private List<Set> _sets;
        public List<Set> Sets => _sets;
    }
}
