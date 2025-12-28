using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ILanguageService : IServiceBase<Language, LanguageModel>
{
    //Task<LanguageModel> Add( LanguageModel model );
}