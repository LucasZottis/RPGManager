//using Microsoft.Extensions.Configuration;
//using RpgContentCreator.Library.Enums;
//using System.Diagnostics;

//namespace RpgContentCreator.Library.Models;

//public class GeneralSettings
//{
//    public string Language { get; private set; }
//    public string ServiceName { get; private set; }
//    public DataBaseType DataBaseType { get; set; }

//    public GeneralSettings( IConfigurationSection configuration )
//    {
//        Debug.WriteLine( $"- {nameof( Language )}: {Language}" );
//        Language = configuration.GetValue<string>( nameof( Language ) ) ?? "";

//        Debug.WriteLine( $"- {nameof( Language )}: {ServiceName}" );
//        ServiceName = configuration.GetValue<string>( nameof( ServiceName ) ) ?? "";

//        Debug.WriteLine( $"- {nameof( Language )}: {DataBaseType}" );
//        DataBaseType = configuration.GetValue<DataBaseType>( nameof( DataBaseType ) );
//    }
//}