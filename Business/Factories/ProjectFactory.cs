using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class ProjectFactory
{
    public static ProjectEntity Map(ProjectUpdate form) => new ProjectEntity()
    {
        Id = form.Id,
        Title = form.Title,
        Description = form.Description,
        StartDate = form.StartDate,
        EndDate = form.EndDate,
        StatusId = form.StatusId,
        ClientId = form.ClientId,
        ProjectManagerId = form.ProjectManagerId,
        ProductId = form.ProductId
    };

    public static ProjectEntity Map(ProjectRegistration form) => new ProjectEntity()
    {
        Title = form.Title,
        Description = form.Description,
        StartDate = form.StartDate,
        EndDate = form.EndDate,
        StatusId = form.StatusId,
        ClientId = form.ClientId,
        ProjectManagerId = form.ProjectManagerId,
        ProductId = form.ProductId

    };
    public static Project Map(ProjectEntity entity) => new Project
    {

        Id = entity.Id,
        Title = entity.Title,
        Description = entity.Description,
        StartDate = entity.StartDate?.ToString("yyyy-MM-dd") ?? string.Empty,
        EndDate = entity.EndDate?.ToString("yyyy-MM-dd") ?? string.Empty,
        Status = StatusFactory.Map(entity.Status),
        Client = ClientFactory.Map(entity.Client),
        ProjectManager = EmployeeFactory.Map(entity.ProjectManager),
        Product = entity.Product == null ? null : ProductFactory.Map(entity.Product)
    };
}