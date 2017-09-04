using asptest.Models;
using Microsoft.EntityFrameworkCore;

namespace asptest.Context
{
 
    public class RentContext : DbContext
    {
        public RentContext(DbContextOptions<RentContext> options)
            : base(options)
        { }

        public DbSet<Address> Addresses { get; set; }
    }
}