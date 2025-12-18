using Microsoft.EntityFrameworkCore;
using RpgContentCreator.Domain.Entities.RaceEntities;

namespace RpgContentCreator.Infra.Db;

public class Context : ContextBase
{
    internal DbSet<Race> Race { get; set; }
}