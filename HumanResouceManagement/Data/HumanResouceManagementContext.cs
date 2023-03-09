using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HumanResouceManagement;

namespace HumanResouceManagement.Data
{
    public class HumanResouceManagementContext : DbContext
    {
        public HumanResouceManagementContext (DbContextOptions<HumanResouceManagementContext> options)
            : base(options)
        {
        }

        public DbSet<HumanResouceManagement.Employees> Employees { get; set; } = default!;
    }
}
