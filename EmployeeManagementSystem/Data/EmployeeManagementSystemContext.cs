using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeManagementSystemContext : DbContext
    {
        public EmployeeManagementSystemContext (DbContextOptions<EmployeeManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagementSystem.Data.Employee> Employee { get; set; } = default!;
        public DbSet<Flight> Flights { get; set; }
    }
}
