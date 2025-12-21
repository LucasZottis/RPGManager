using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.Domain.Interfaces.Services;

public interface IAbilityScoreService
{
    Task<AbilityScoreModel> Add( AbilityScoreModel model );
}