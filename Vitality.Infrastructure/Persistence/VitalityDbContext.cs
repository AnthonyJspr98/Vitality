using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Vitality.Application.Common.Interfaces;
using Vitality.Domain.Entities;

namespace Vitality.Infrastructure.Persistence
{
    public class VitalityDbContext : DbContext , IVitalityDbContext
    {
        public DbSet<User> Users {get; set;}

         public VitalityDbContext(DbContextOptions<VitalityDbContext> dbContext) : base (dbContext)
		{ 		
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
    }
}