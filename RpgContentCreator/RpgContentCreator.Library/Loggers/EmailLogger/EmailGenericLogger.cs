using Microsoft.Extensions.Logging;
using RpgContentCreator.Library.Loggers;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace RpgContentCreator.Library.Loggers.EmailLogger;

public class EmailGenericLogger : ILogger
{
    private readonly string _smtpServer;
    private readonly string _smtpUsername;
    private readonly string _smtpPassword;
    private readonly string _toEmail;
    private readonly string _fromEmail;

    public EmailGenericLogger( string smtpServer, string smtpUsername, string smtpPassword, string toEmail, string fromEmail )
    {
        _smtpServer = smtpServer;
        _smtpUsername = smtpUsername;
        _smtpPassword = smtpPassword;
        _toEmail = toEmail;
        _fromEmail = fromEmail;
    }

    private void SendEmail( string subject, string body )
    {
        var smtpClient = new SmtpClient( _smtpServer )
        {
            Port = 587,  // or 465 for SSL
            Credentials = new NetworkCredential( _smtpUsername, _smtpPassword ),
            EnableSsl = true,
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress( _smtpUsername ),
            Subject = subject,
            Body = body,
            IsBodyHtml = true,
        };

        mailMessage.To.Add( _toEmail );

        smtpClient.Send( mailMessage );
    }

    private string GenerateErrorEmailBody( LogEntry logMessage )
    {
        // Criar o corpo do e-mail em HTML
        var sb = new StringBuilder();

        sb.AppendLine( "<html>" );
        sb.AppendLine( "<head>" );
        sb.AppendLine( "<style>" );
        sb.AppendLine( "body { font-family: Arial, sans-serif; color: #333; }" );
        sb.AppendLine( "table { width: 100%; border-collapse: collapse; margin: 20px 0; }" );
        sb.AppendLine( "th, td { padding: 8px 12px; border: 1px solid #ddd; text-align: left; }" );
        sb.AppendLine( "th { background-color: #f2f2f2; }" );
        sb.AppendLine( ".error { color: red; font-weight: bold; }" );
        sb.AppendLine( "</style>" );
        sb.AppendLine( "</head>" );
        sb.AppendLine( "<body>" );
        sb.AppendLine( "<h2 class='error'>Erro no Servidor</h2>" );
        sb.AppendLine( "<p>Um erro ocorreu no servidor. Detalhes abaixo:</p>" );

        sb.AppendLine( "<table>" );
        sb.AppendLine( "<tr><th>Timestamp</th><td>" + logMessage.Timestamp + "</td></tr>" );
        sb.AppendLine( "<tr><th>Nível de Log</th><td>" + logMessage.LogLevel + "</td></tr>" );
        sb.AppendLine( "<tr><th>EventId</th><td>" + logMessage.EventId + "</td></tr>" );
        sb.AppendLine( "<tr><th>Categoria</th><td>" + logMessage.Category + "</td></tr>" );
        sb.AppendLine( "<tr><th>Mensagem</th><td>" + logMessage.Message + "</td></tr>" );

        if ( !string.IsNullOrEmpty( logMessage.Exception ) )
        {
            sb.AppendLine( "<tr><th>Exceção</th><td><pre>" + logMessage.Exception + "</pre></td></tr>" );
        }

        sb.AppendLine( "</table>" );
        sb.AppendLine( "<p><strong>Por favor, verifique o servidor para mais detalhes.</strong></p>" );
        sb.AppendLine( "</body>" );
        sb.AppendLine( "</html>" );

        return sb.ToString();
    }

    public IDisposable? BeginScope<TState>( TState state ) => null;

    public bool IsEnabled( LogLevel logLevel ) => logLevel == LogLevel.Error;

    public void Log<TState>( LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter )
    {
        if ( !IsEnabled( logLevel ) )
            return;

        if ( formatter.IsNull() )
            return;

        var logEntry = new LogEntry
        {
            Timestamp = DateTime.Now.ToString( "dd/MM/yyyy HH:mm:ss" ),
            LogLevel = logLevel.ToString(),
            EventId = eventId.Id,
            Message = formatter( state, exception ),
            Exception = exception?.ToString(),
            Category = null,
        };

        var message = GenerateErrorEmailBody( logEntry );

        SendEmail( "Erro SysPret", message );
    }
}