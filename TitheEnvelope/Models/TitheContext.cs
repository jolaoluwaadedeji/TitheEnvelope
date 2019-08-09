using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelope.Models
{
    public class TitheContext: DbContext
    {
        public TitheContext(DbContextOptions<TitheContext> options): base(options)
        {
        }
        public DbSet<TitheObject> TitheObjects { get; set; }

    }
}
