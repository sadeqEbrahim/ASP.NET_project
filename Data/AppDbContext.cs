using Microsoft.EntityFrameworkCore;
using GestionaleApi.Models;

namespace GestionaleApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Customer> Customers => Set<Customer>();
}
