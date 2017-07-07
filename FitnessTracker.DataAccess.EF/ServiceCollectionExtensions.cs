using FitnessTracker.DataAccess.EF.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.DataAccess.EF
{
    /// <summary>
    /// Collection of service injection wrappers related with EF core and Identity
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds FitnessTrackerDbContext to the list of database contexts
        /// </summary>
        public static IServiceCollection AddDbContextWithEFCore(this IServiceCollection services, Action<DbContextOptionsBuilder> optionsAction = null)
        {
            return services.AddDbContext<FitnessTrackerContext>(optionsAction);
        }

        /// <summary>
        /// Adds default implementation of IdentityDbContext with EF Core
        /// </summary>
        public static IServiceCollection AddIdentityDbContextWithEFCore(this IServiceCollection services, Action<DbContextOptionsBuilder> optionsAction = null)
        {
            return services.AddDbContext<IdentityDbContext>(optionsAction);
        }

        /// <summary>
        /// Adds Identity and adds default stores and providers using IdentityDbContext
        /// </summary>
        public static IdentityBuilder AddIdentityWithEFCore(this IServiceCollection services, Action<IdentityBuilder> optionsAction = null)
        {
            return services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<FitnessTrackerContext>().AddDefaultTokenProviders();
        }

        /// <summary>
        /// Inject necessary services for Identity and EF Framework using a SQL server, or optionally a SQLite DB
        /// </summary>
        public static IServiceCollection AddFitnessTrackerDbAndIdentityServicesSql(this IServiceCollection services, string sqlConnectionString, bool useSqlite = false)
        {
            services.AddIdentityWithEFCore();
            if (useSqlite)
            {
                return services.AddDbContextWithEFCore(opt => opt.UseSqlite(sqlConnectionString));
            }
            else
            {
                return services.AddDbContextWithEFCore(opt => opt.UseSqlServer(sqlConnectionString));
            }
        }
    }
}
