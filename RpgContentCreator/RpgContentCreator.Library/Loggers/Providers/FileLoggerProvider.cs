using Microsoft.Extensions.Logging;
using RpgContentCreator.Library.Loggers.FileLogger;

namespace RpgContentCreator.Library.Loggers.Providers;

public class FileLoggerProvider : ILoggerProvider
{
    private readonly string _filePath;

    public FileLoggerProvider( string filePath )
    {
        if ( string.IsNullOrWhiteSpace( filePath ) )
            throw new ArgumentException( "O caminho do arquivo não pode ser nulo ou vazio.", nameof( filePath ) );

        _filePath = filePath;
    }

    public FileLoggerProvider() : this( $@"{AppContext.BaseDirectory}\logs" ) { }

    public ILogger CreateLogger( string categoryName )
    {
        var categoryType = Type.GetType( categoryName );

        if ( categoryType.IsNull() )
            return new FileGenericLogger( _filePath );

        var loggerType = typeof( FileLogger<> ).MakeGenericType( categoryType );

        return ( ILogger ) Activator.CreateInstance( loggerType, [_filePath] );
    }

    public void Dispose() { }
}