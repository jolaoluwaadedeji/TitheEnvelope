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
            Database.Migrate();
        }
        public DbSet<TithePaymentDetail> TithePaymentDetail { get; set; }

        public DbSet<TitherDetail> TitherDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TithePaymentDetail>().HasOne(b => b.TitherDetail).WithMany(a => a.TithePaymentDetails).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<TithePaymentDetail>().HasData(new TithePaymentDetail
            {
                Amount = 100M,TitherDetailId = 1, DateInserted = DateTime.Now,PaymentMethod = "Cash",
                DateOfPayment = new DateTime(2019,9,12,0,0,0),IsDeleted = false, Id = 1
            });
        }

    }
}
