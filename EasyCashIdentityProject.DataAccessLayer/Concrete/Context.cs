using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PCL5CR6\\SQLEXPRESS;initial Catalog=EasyCashIdentityDb;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
        public DbSet<ElectricBill> ElectricBills { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<CustomerAccountProcess>()
               .HasOne(x => x.SenderCustomer)
               .WithMany(y => y.CustomerSender)
               .HasForeignKey(z => z.SenderID)
               .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<CustomerAccountProcess>()
                .HasOne(x => x.ReceiverCustomer)
                .WithMany(y => y.CustomerReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(builder);
        }

    }
}
