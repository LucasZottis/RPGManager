using Microsoft.AspNetCore.Mvc;




namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/language" )]
public class LanguageController : CrudController<Language, LanguageModel>
{
    public LanguageController( ILanguageService service ) : base( service )
    {
    }
}