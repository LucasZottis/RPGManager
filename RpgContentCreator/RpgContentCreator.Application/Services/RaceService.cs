using RpgContentCreator.Application.Interfaces;
using RpgContentCreator.Application.Models.Races;
using RpgContentCreator.Domain.Entities.RaceEntities;
using RpgContentCreator.Domain.Interfaces.Repositories;

namespace RpgContentCreator.Application.Services;

public class RaceService : IRaceService
{
    private readonly IRaceRepository _raceRepository;
    public RaceService( IRaceRepository raceRepository )
    {
        _raceRepository = raceRepository;
    }

    public async Task Add( RaceModel raceModel )
    {
        var entity = new Race
        {
            Id = raceModel.Id,
            Name = raceModel.Name,
            GameSystemId = raceModel.GameSystem.Id,

            Features = raceModel.RaceFeatures.Select( f => new RaceFeature
            {
                Name = f.Name,
                Description = f.Description
            } ).ToList(),

            Languages = raceModel.RaceLanguages.Select( l => new RaceLanguage
            {
                LanguageId = l.Language.Id
            } ).ToList(),
        };

        if ( raceModel.ParentRace is not null )
            entity.ParentRaceId = raceModel.ParentRace.Id;

        entity.AbilityScores = raceModel.RaceAbilitiesScores.Select( ras =>
        {
            var ability = new RaceAbilityScore
            {
                RaceId = raceModel.Id,
            };

            if ( ras.AbilityScore is not null )
                ability.AbilityScoreId = ras.AbilityScore.Id;

            return ability;
        } ).ToList();

        await _raceRepository.Add( entity );
        await _raceRepository.SaveChanges();
    }
}