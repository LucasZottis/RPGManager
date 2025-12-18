using RpgContentCreator.Application.Models.Races;

namespace RpgContentCreator.Application.Interfaces;

public interface IRaceService
{
    Task Add( RaceModel raceModel );
}