using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PropertyBlitz.Data
{
    public class PropertyBlitzContext : DbContext
    {
        public PropertyBlitzContext (DbContextOptions<PropertyBlitzContext> options)
            : base(options)
        {
        }

        public DbSet<Listing> Listing { get; set; } = default!;
    }
}
