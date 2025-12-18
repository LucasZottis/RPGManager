namespace RpgContentCreator.Library.Loggers;

// Classe para representar a estrutura do log em formato JSON
internal class LogEntry
{
    public string Timestamp { get; set; }
    public string LogLevel { get; set; }
    public int EventId { get; set; }
    public string Message { get; set; }
    public string? Exception { get; set; }
    public string? Category { get; set; }
}