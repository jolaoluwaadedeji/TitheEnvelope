using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitheEnvelopeApi.Models;

namespace TitheEnvelope.Models
{
    public class TitheContext: DbContext
    {
        public TitheContext(DbContextOptions<TitheContext> options): base(options)
        {
        }
        public DbSet<TithePaymentDetail> TithePaymentDetail { get; set; }

        public DbSet<TitherDetail> TitherDetail { get; set; }

    }
}
