using System.Text.Json;
using System.Text.Json.Serialization;

namespace RPGManager.Desktop.Application.Mappers;

public class MapperTwo<TEntity> : IMapperTwo<TEntity>
    where TEntity : EntityBase
{
    private JsonSerializerOptions _options = new JsonSerializerOptions
    {
        ReferenceHandler = ReferenceHandler.IgnoreCycles
    };

    public TEntity ToEntity<T>( T model )
    {
        var entityJson = JsonSerializer.Serialize( model, _options );
        return JsonSerializer.Deserialize<TEntity>( entityJson, _options );
    }

    public T ToModel<T>( TEntity entity )
    {
        var modelJson = JsonSerializer.Serialize( entity, _options );
        return JsonSerializer.Deserialize<T>( modelJson, _options );
    }
}