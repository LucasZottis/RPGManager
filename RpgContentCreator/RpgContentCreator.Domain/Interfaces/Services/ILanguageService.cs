using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.Domain.Interfaces.Services;

public interface ILanguageService
{
    Task<LanguageModel> Add( LanguageModel model );
}