﻿#nullable disable

namespace Saas.Admin.Service.Data;

public class TenantsContext : DbContext
{
    public TenantsContext(DbContextOptions<TenantsContext> options)
        : base(options)
    {
    }

    public DbSet<Tenant> Tenant { get; set; }
}
