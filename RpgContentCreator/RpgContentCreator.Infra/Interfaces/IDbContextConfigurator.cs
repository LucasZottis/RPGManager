using Microsoft.EntityFrameworkCore;

namespace RpgContentCreator.Infra.Interfaces;

public interface IDbContextConfigurator
{
    void Configure();
}