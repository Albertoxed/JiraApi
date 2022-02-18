using ApiJira.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJira
{
    public class ApplicationDbContext : DbContext,IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
                
        }
        public DbSet<T> GetDbSet<T>() where T : class, IbaseEntity => Set<T>();
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Employee> Employees { get; set; }

      
      
    }
}
