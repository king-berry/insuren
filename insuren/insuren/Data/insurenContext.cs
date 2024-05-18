using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using insuren.Models;

namespace insuren.Data
{
    public class insurenContext : DbContext
    {
        public insurenContext (DbContextOptions<insurenContext> options)
            : base(options)
        {
        }

        public DbSet<insuren.Models.Acount> Acount { get; set; } = default!;
        public DbSet<insuren.Models.Company> Company { get; set; } = default!;
        public DbSet<insuren.Models.Employee> Employee { get; set; } = default!;
        public DbSet<insuren.Models.EmployeeSubService> EmployeeSubService { get; set; } = default!;
        public DbSet<insuren.Models.Order> Order { get; set; } = default!;
        public DbSet<insuren.Models.OrderDetail> OrderDetail { get; set; } = default!;
        public DbSet<insuren.Models.Service> Service { get; set; } = default!;
        public DbSet<insuren.Models.SubService> SubService { get; set; } = default!;
    }
}
