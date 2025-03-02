using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class ProjectEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }

    [Column(TypeName = "date")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? EndDate { get; set; }
    public int StatusId { get; set; }
    public int ClientId { get; set; }
    public int ProjectManagerId { get; set; }
    public int? ProductId { get; set; }

    public virtual StatusEntity Status { get; set; } = null!;

    public virtual ClientEntity Client { get; set; } = null!;

    public virtual EmployeeEntity ProjectManager { get; set; } = null!;

    public virtual ProductEntity? Product { get; set; }
}
