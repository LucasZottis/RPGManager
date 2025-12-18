namespace RpgContentCreator.Library.Interfaces;

public interface IBaseLogger
{
    void LogInformation( string message );
    void LogWarning( string message );
    void LogError( string message );
    void LogDebug( string message );
}