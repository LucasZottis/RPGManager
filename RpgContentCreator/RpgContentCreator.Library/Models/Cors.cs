//using Microsoft.Extensions.Configuration;
//using System.Diagnostics;

//namespace RpgContentCreator.Library.Models;

//public class Cors
//{
//    public string PolicyName { get; private set; }
//    public IEnumerable<string> AllowedCors { get; private set; }

//    public Cors( IConfigurationSection configuration )
//    {
//        PolicyName = configuration.GetSection( nameof( PolicyName ) ).Get<string>() ?? "";
//        Debug.WriteLine( $"- {nameof( PolicyName )}: {PolicyName}" );

//        AllowedCors = configuration.GetSection( "AllowedCors" ).Get<string[]>()?? Array.Empty<string>();
//        Debug.WriteLine( $"- {nameof( AllowedCors )}: {AllowedCors.Count()}" );
//    }
//}