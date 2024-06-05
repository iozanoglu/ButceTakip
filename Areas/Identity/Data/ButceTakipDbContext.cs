using ButceTakip.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ButceTakip.Data;

public class ButceTakipDbContext : IdentityDbContext<AppUser>
{
    public ButceTakipDbContext(DbContextOptions<ButceTakipDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
