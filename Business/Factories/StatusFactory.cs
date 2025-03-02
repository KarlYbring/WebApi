using Business.Models;
using Data.Entities;
using System.Reflection;

namespace Business.Factories;

public class StatusFactory
{
    public static Status Map(StatusEntity entity) => new Status
    {
        Id = entity.Id,
        StatusName = entity.StatusName
    };
}
