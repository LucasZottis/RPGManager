using DevToolz.Library.Encryption;
using DevToolz.Library.Enums;
using Microsoft.AspNetCore.HttpLogging;
using RPGManager.Desktop.Api.Utils.DI;
using RPGManager.Desktop.Api.Utils.Extensions;
using RPGManager.Desktop.Application;
using RPGManager.Desktop.Application.Options;
using RPGManager.Desktop.Domain.Interfaces;
using RPGManager.Desktop.Infra.Db.Contexts;
using RPGManager.Desktop.Infra.DI;

namespace RPGManager.Desktop.Api;

public class Program
{
    public static async Task Main( string[] args )
    {
        var assemblies = AssemblyLoader.LoadAllApplicationAssemblies().Where( a => a.FullName.StartsWith( "RPGManager" ) );
        var builder = WebApplication.CreateBuilder( args );

        builder.Services.Configure<Encryption>( builder.Configuration.GetSection( Encryption.SettingsKey ) );

        // Add services to the container.
        builder.Services.AddDatabase<Context>( builder.Configuration );
        builder.Services.AddRepositoriesAsScoped( [ .. assemblies ] );
        builder.Services.AddUnitsOfWorkAsScoped( [ .. assemblies ] );
        builder.Services.AddServicesAsScoped( [ .. assemblies ] );
        builder.Services.AddMappersAsSingleton( [ .. assemblies ] );
        builder.Services.AddHttpLogging( log =>
        {
            log.LoggingFields = HttpLoggingFields.RequestBody;
            log.RequestBodyLogLimit = 4096;
        } );

        builder.Services.AddJWTAuthentication();
        builder.Services.AddControllers();
        builder.Services.AddSwagger();
        builder.Services.AddSingleton( c =>
        {
            return CryptFactory.Create( CryptProvider.Aes );
        } );

        builder.Services.AddSingleton<ICrypt, CryptFacade>();

        var app = builder.Build()
            .UseSwaggerGenerator()
            .UseCors()
            .UseAuth()
            .UseHttpsRedirection()
            .UseControllerMapper();

        await app.RunAsync();
    }
}