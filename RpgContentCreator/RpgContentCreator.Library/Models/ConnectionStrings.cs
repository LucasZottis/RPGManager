//using Microsoft.Extensions.Configuration;
//using RpgContentCreator.Library.Enums;
//using System.Diagnostics;

//namespace RpgContentCreator.Library.Models;

//public class ConnectionStrings
//{
//    public string SqlServer { get; set; }
//    public string MySql { get; set; }
//    public string SqLite { get; set; }
//    public string PostgreSql { get; set; }

//    public ConnectionStrings( IConfiguration configuration )
//    {
//        Debug.WriteLine( $"- {nameof( SqlServer )}: {SqlServer}" );
//        SqlServer = configuration.GetValue<string>( nameof( SqlServer ) ) ?? "";

//        Debug.WriteLine( $"- {nameof( MySql )}: {MySql}" );
//        MySql = configuration.GetValue<string>( nameof( MySql ) ) ?? "";

//        Debug.WriteLine( $"- {nameof( SqLite )}: {SqLite}" );
//        SqLite = configuration.GetValue<string>( nameof( SqLite ) ) ?? "";

//        Debug.WriteLine( $"- {nameof( PostgreSql )}: {PostgreSql}" );
//        PostgreSql = configuration.GetValue<string>( nameof( PostgreSql ) ) ?? "";
//    }

//    public string GetConnectionString( DataBaseType dataBase )
//    {
//        switch ( dataBase )
//        {
//            case DataBaseType.SqlServer:
//                return SqlServer;
//            case DataBaseType.MySql:
//                return MySql;
//            case DataBaseType.SqLite:
//                return SqLite;
//            case DataBaseType.PostgreSql:
//                return PostgreSql;
//            case DataBaseType.InMemory:
//            default:
//                return "";
//        }
//    }
//}