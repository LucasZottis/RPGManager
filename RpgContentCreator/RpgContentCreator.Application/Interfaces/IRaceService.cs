using RpgContentCreator.Domain.Models.Races;

namespace RpgContentCreator.Application.Interfaces;

public interface IRaceService
{
    Task Add( RaceModel raceModel );
}