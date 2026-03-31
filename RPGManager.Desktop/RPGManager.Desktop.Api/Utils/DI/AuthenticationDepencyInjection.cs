using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using RPGManager.Desktop.Domain.Constants;
using System.Text;

namespace RPGManager.Desktop.Api.Utils.DI;

public static class AuthenticationDepencyInjection
{
    private static void AddPolicies( AuthorizationOptions options )
    {
        options.AddPolicy( "GameSystemControl", policy => policy.RequireRole( Roles.Admin ) );
        options.AddPolicy( "DiceControl", policy => policy.RequireRole( Roles.Admin ) );
    }

    public static IServiceCollection AddJWTAuthentication( this IServiceCollection services )
    {
        var provider = services.BuildServiceProvider();
        var configuration = provider.GetRequiredService<IConfiguration>();
        services.AddAuthentication( JwtBearerDefaults.AuthenticationScheme )
           .AddJwtBearer( options =>
           {
               options.SaveToken = true;
               options.RequireHttpsMetadata = false;
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = false,
                   ValidateAudience = false,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ClockSkew = TimeSpan.Zero,
                   ValidIssuer = configuration.GetValue<string>( "JWT:ValidAudience" ),
                   ValidAudience = configuration.GetValue<string>( "JWT:ValidUssuer" ),
                   IssuerSigningKey = new SymmetricSecurityKey(
                       Encoding.UTF8.GetBytes(
                           configuration.GetValue<string>( "JWT:SecretKey" )
                               ?? throw new InvalidOperationException( "Chave secreta inválida." )
                       )
                   ),
               };
           } );

        services.AddAuthorization( AddPolicies );

        return services;
    }
}