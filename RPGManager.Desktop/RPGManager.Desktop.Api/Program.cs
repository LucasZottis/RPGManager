using Microsoft.AspNetCore.HttpLogging;
using RPGManager.Desktop.Api.Utils.DI;
using RPGManager.Desktop.Infra.Db.Contexts;
using RPGManager.Desktop.Infra.DI;

namespace RPGManager.Desktop.Api
{
    public class Program
    {
        public static async Task Main( string[] args )
        {
            var assemblies = AssemblyLoader.LoadAllApplicationAssemblies().Where( a => a.FullName.StartsWith( "RPGManager" ) );
            var builder = WebApplication.CreateBuilder( args );

            // Add services to the container.
            builder.Services.AddDatabase<Context>( builder.Configuration );
            builder.Services.AddRepositoriesAsScoped( [ .. assemblies ] );
            builder.Services.AddServicesAsScoped( [ .. assemblies ] );
            builder.Services.AddMappersAsSingleton( [ .. assemblies ] );
            builder.Services.AddHttpLogging( log =>
            {
                log.LoggingFields = HttpLoggingFields.RequestBody;
                log.RequestBodyLogLimit = 4096;
            } );

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if ( app.Environment.IsDevelopment() )
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            await app.RunAsync();
        }
    }
}
