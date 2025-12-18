using Microsoft.Extensions.Logging;
using RpgContentCreator.Library.Loggers;
using System.Text.Json;

namespace RpgContentCreator.Library.Loggers.FileLogger;

public class FileGenericLogger : ILogger
{
    private readonly string _filePath;
    private static readonly object _fileLock = new();

    public FileGenericLogger( string filePath )
    {
        _filePath = filePath;
    }

    private void WriteTextToFile( string relativePath, string message )
    {
        const int maxRetries = 3;
        const int delayBetweenRetries = 100; // Milissegundos

        var filePath = Path.Combine( _filePath, relativePath );

        for ( int attempt = 0; attempt < maxRetries; attempt++ )
        {
            try
            {
                lock ( _fileLock )
                {
                    Directory.CreateDirectory( Path.GetDirectoryName( filePath )! );

                    using var stream = new FileStream( filePath, FileMode.Append, FileAccess.Write, FileShare.None );
                    using var writer = new StreamWriter( stream );
                    writer.WriteLine( message );
                }

                return; // Sucesso, sai do loop
            }
            catch ( IOException )
            {
                if ( attempt == maxRetries - 1 )
                    throw; // Relança a exceção após atingir o número máximo de tentativas

                Thread.Sleep( delayBetweenRetries ); // Aguarda antes de tentar novamente
            }
            catch ( Exception )
            {
                throw;
            }
        }
    }

    private string ConvertToJson( LogEntry logEntry )
    {
        // Serializa o log como JSON sem escapar caracteres especiais como apóstrofos
        return JsonSerializer.Serialize( logEntry, new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping // Impede o escape de caracteres como apóstrofos
        } );
    }

    public IDisposable? BeginScope<TState>( TState state ) => null;

    public bool IsEnabled( LogLevel logLevel ) => logLevel > LogLevel.Information;

    public void Log<TState>( LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter )
    {
        if ( !IsEnabled( logLevel ) )
            return;

        var logEnttry = new LogEntry
        {
            Timestamp = DateTime.Now.ToString( "dd/MM/yyyy HH:mm:ss" ),
            LogLevel = logLevel.ToString(),
            EventId = eventId.Id,
            Message = formatter( state, exception ),
            Exception = exception?.ToString(),
            Category = null,
        };

        string fileName = logLevel switch
        {
            LogLevel.Debug => $@"debug\{DateTime.Today:yyyyMMdd}.txt",
            LogLevel.Information => $@"info\{DateTime.Today:yyyyMMdd}.txt",
            LogLevel.Warning => $@"warning\{DateTime.Today:yyyyMMdd}.txt",
            LogLevel.Error => $@"error\{DateTime.Today:yyyyMMdd}.txt",
            _ => $@"log\{DateTime.Today:yyyyMMdd}.txt"
        };

        WriteTextToFile( fileName, ConvertToJson( logEnttry ) );
    }
}