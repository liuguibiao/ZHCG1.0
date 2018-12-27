using Microsoft.EntityFrameworkCore;
using System;
using ZHCG.Data.Entity;

namespace ZHCG.Data
{
    public class ZHCGContext : DbContext
    {
        public ZHCGContext(DbContextOptions<ZHCGContext> options)
            : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
