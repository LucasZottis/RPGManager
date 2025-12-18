//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;
//using RpgContentCreator.Library.Loggers.FileLogger;
//using SysPret.Core.Library.Loggers.EmailLogger;

//namespace RpgContentCreator.Library.Loggers.Providers;

//public class EmailLoggerProvider : ILoggerProvider
//{
//    private readonly string _smtpServer;
//    private readonly string _smtpUsername;
//    private readonly string _smtpPassword;
//    private readonly string _toEmail;
//    private readonly string _fromEmail;

//    public EmailLoggerProvider(IConfiguration configuration)
//    {
//        // Carregar os valores do arquivo de configuração
//        _smtpServer = configuration[ "Logging:Email:SmtpServer" ] ?? "";
//        _smtpUsername = configuration[ "Logging:Email:SmtpUsername" ] ?? "";
//        _smtpPassword = configuration[ "Logging:Email:SmtpPassword" ] ?? "";
//        _toEmail = configuration[ "Logging:Email:ToEmail" ] ?? "";
//        _fromEmail = configuration[ "Logging:Email:FromEmail" ] ?? "";
//    }

//    public ILogger CreateLogger( string categoryName )
//    {
//        var categoryType = Type.GetType( categoryName );

//        if ( categoryType.IsNull() )
//            return new EmailGenericLogger( _smtpServer, _smtpUsername, _smtpPassword, _toEmail, _fromEmail );

//        var loggerType = typeof( FileLogger<> ).MakeGenericType( categoryType );

//        return ( ILogger ) Activator.CreateInstance( loggerType, [ _smtpServer, _smtpUsername, _smtpPassword, _toEmail, _fromEmail ] );
//    }

//    public void Dispose()
//    {
        
//    }
//}