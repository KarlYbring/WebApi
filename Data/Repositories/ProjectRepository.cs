using Data.Contexts;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class ProjectRepository(DataContext context) : BaseRepository<ProjectEntity>(context)
{
    public override async Task<IEnumerable<ProjectEntity>> GetAllAsync()
    {
        return await _db
            .Include(i => i.Status)
            .Include(i => i.Client)
            .Include(i => i.ProjectManager)
            .Include(i => i.Product)
            .ToListAsync();
    }

    public override async Task<ProjectEntity?> GetAsync(Expression<Func<ProjectEntity, bool>> expression)
    {
        return await _db
            .Include(i => i.Status)
            .Include(i => i.Client)
            .Include(i => i.ProjectManager)
            .Include(i => i.Product)
            .FirstOrDefaultAsync(expression);
    }
}
