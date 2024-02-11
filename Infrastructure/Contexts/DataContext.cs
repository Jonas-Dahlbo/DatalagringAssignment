using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<CompanyContactEntity> CompanyContacts { get; set; }
    public DbSet<CompanyEntity> Companies { get; set; }
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyContactEntity>().HasKey(x => new { x.CustomerId, x.CompanyId });
    }
}
