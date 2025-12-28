
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RPGManager.Desktop.Application.Mappers;

public class Mapper<TEntity, TModel> : IMapper<TEntity, TModel>
{
    private JsonSerializerOptions _options = new JsonSerializerOptions
    {
        ReferenceHandler = ReferenceHandler.IgnoreCycles
    };

    public virtual TEntity ToEntity( TModel model )
    {
        var entityJson = JsonSerializer.Serialize( model, _options );
        return JsonSerializer.Deserialize<TEntity>( entityJson, _options );
    }

    public virtual TModel ToModel( TEntity entity )
    {
        var modelJson = JsonSerializer.Serialize( entity, _options );
        return JsonSerializer.Deserialize<TModel>( modelJson, _options );
    }
}