using RpgContentCreator.Application.Services;
using RpgContentCreator.Domain.Interfaces.Repositories;
using RpgContentCreator.Domain.Interfaces.Services;
using RpgContentCreator.Infra.Db;
using RpgContentCreator.Infra.Db.DbContextConfigurator;
using RpgContentCreator.Infra.Repositories;

namespace RpgContentCreator.Api
{
    public class Program
    {
        public static void Main( string[] args )
        {
            var builder = WebApplication.CreateBuilder( args );

            // Add services to the container.
            builder.Services.AddDbContext<Context>()
                .AddScoped<DbContextConfiguratorBuilder>();

            builder.Services.AddScoped<IGameSystemRepository, GameSystemRepository>();

            builder.Services.AddScoped<IGameSystemService, GameSystemService>();

            builder.Services.AddControllers();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if ( app.Environment.IsDevelopment() )
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            if ( app.Environment.IsProduction() )
                app.UseHttpsRedirection();

            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
