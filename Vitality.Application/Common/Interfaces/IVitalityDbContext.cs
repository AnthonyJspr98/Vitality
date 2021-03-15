using Vitality.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vitality.Application.Common.Interfaces
{
    public interface IVitalityDbContext
    {
        public DbSet<User> Users {get; set;}
    }
}