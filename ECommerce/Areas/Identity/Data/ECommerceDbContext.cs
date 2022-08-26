using ECommerce.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ECommerce.Models;

namespace ECommerce.Areas.Identity.Data;

public class ECommerceDbContext : IdentityDbContext<ECommerceUser>
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<ECommerce.Models.Product>? Product { get; set; }

    public DbSet<ECommerce.Models.Category>? Category { get; set; }

    public DbSet<ECommerce.Models.Tag>? Tag { get; set; }
}

