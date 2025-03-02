namespace Business.Models;

public  class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public string StartDate { get; set; } = null!;
    public string EndDate { get; set; } = null!;

    public Status Status { get; set; } = null!;

    public Client Client { get; set; } = null!;

    public Employee ProjectManager { get; set; } = null!;

    public  Product? Product { get; set; }
}
