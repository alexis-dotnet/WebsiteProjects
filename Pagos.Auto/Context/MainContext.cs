using Microsoft.EntityFrameworkCore;
using Pagos.Auto.Entities;
using Pagos.Auto.Mapping;

namespace Pagos.Auto.Context
{
    public class MainContext : DbContext
    {
        public MainContext() { }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarPaymentMap());
        }

        public virtual DbSet<CarPayment> CarPayments { get; set; }
    }
}
