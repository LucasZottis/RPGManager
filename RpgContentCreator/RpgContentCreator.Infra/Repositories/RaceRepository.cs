using RpgContentCreator.Domain.Entities.RaceEntities;
using RpgContentCreator.Domain.Interfaces.Repositories;
using RpgContentCreator.Infra.Db;

namespace RpgContentCreator.Infra.Repositories;

public class RaceRepository : RepositoryBase<Race>, IRaceRepository
{
    public RaceRepository( Context context ) : base( context ) { }
}