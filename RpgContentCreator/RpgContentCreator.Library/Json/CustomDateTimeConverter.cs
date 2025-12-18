using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RpgContentCreator.Library.Json;

public class CustomDateTimeConverter : JsonConverter<DateTime?>
{
    private const string DateFormat = "dd/MM/yyyy";

    public override DateTime? Read( ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options )
    {
        //if ( reader.TokenType == JsonTokenType.String )
        //{
        //    var dateString = reader.GetString();
        //    if ( DateTime.TryParseExact( dateString, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date ) )
        //    {
        //        return date;
        //    }
        //}
        return null;
    }

    public override void Write( Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options )
    {
        //if ( value.HasValue )
        //{
        //    writer.WriteStringValue( value.Value.ToString( DateFormat ) );
        //}
    }
}