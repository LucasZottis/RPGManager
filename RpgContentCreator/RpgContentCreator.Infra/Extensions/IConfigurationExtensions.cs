using Microsoft.Extensions.Configuration;
using RpgContentCreator.Domain.Enums;

namespace RpgContentCreator.Infra.Extensions;

public static class IConfigurationExtensions
{
    public static DataBaseType GetDataBaseType( this IConfiguration configuration )
    {
        var dataBaseTypeString = configuration.GetSection( "DataBaseType" ).Value;

        if ( string.IsNullOrWhiteSpace( dataBaseTypeString ) )
            return DataBaseType.InMemory;

        return Enum.Parse<DataBaseType>( dataBaseTypeString! );
    }
}