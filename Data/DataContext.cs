
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace HMIS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PersonMaster>? person_m { get; set; }
        public DbSet<PersonAdderess>? person_address_m { get; set; }
        public DbSet<ServiceCenter> Service_Center_m { get; set; }
        public DbSet<SecurityUserMaster> sec_user_m { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        

        // modelBuilder.Entity<PersonMaster>()
        // .HasMany(b => b.PersonAdderess)
        // .WithOne().HasForeignKey(x => x.person_id);

        // modelBuilder.Entity<PersonMaster>().Property(p => p.id)
        // .ValueGeneratedOnAdd()
        // .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
            
        // modelBuilder.Entity<PersonAdderess>().Property(p => p.id)
        // .ValueGeneratedOnAdd()
        // .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        // }
    }
}