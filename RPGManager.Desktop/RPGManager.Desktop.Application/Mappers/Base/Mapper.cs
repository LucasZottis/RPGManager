using System.Text.Json;
using System.Text.Json.Serialization;

namespace RPGManager.Desktop.Application.Mappers.Base;

public class Mapper : IMapper
{
    private JsonSerializerOptions _options = new JsonSerializerOptions
    {
        ReferenceHandler = ReferenceHandler.IgnoreCycles
    };

    public TEntity ToEntity<TEntity, TDto>( TDto dto )
    {
        var entityJson = JsonSerializer.Serialize( dto, _options );
        return JsonSerializer.Deserialize<TEntity>( entityJson, _options );
    }

    public TDto ToModel<TEntity, TDto>( TEntity entity )
    {
        var modelJson = JsonSerializer.Serialize( entity, _options );
        return JsonSerializer.Deserialize<TDto>( modelJson, _options );
    }
}