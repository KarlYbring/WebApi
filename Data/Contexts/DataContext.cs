
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected DataContext()
    {
    }

    public virtual DbSet<ProjectEntity> Projects { get; set; }

    public virtual DbSet<StatusEntity> Status { get; set; }

    public virtual DbSet<EmployeeEntity> Employee { get; set; }

    public virtual DbSet<ClientEntity> Client { get; set; }

    public virtual DbSet<ProductEntity> Product { get; set; }

}
