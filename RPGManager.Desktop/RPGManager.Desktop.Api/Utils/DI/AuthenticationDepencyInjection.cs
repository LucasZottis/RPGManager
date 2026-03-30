using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using RPGManager.Desktop.Domain.Constants;
using System.Text;

namespace RPGManager.Desktop.Api.Utils.DI;

public static class AuthenticationDepencyInjection
{
    private static TokenValidationParameters GetTokenValidationParameters()
    {
        return new TokenValidationParameters
        {

            //ValidateIssuer = true,
            //ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            //ValidIssuer = "yourdomain.com",
            //ValidAudience = "yourdomain.com",
            IssuerSigningKey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes( "RPGManager" ) )
        };
    }

    private static void AddPolicies( AuthorizationOptions options )
    {
        options.AddPolicy( "GameSystemControl", policy => policy.RequireRole( Roles.Admin ) );
        options.AddPolicy( "DiceControl", policy => policy.RequireRole( Roles.Admin ) );
    }

    public static IServiceCollection AddJWTAuthentication( this IServiceCollection services )
    {
        services.AddAuthentication( JwtBearerDefaults.AuthenticationScheme )
            .AddJwtBearer( options =>
            {
                options.TokenValidationParameters = GetTokenValidationParameters();
            } );

        services.AddAuthorization( AddPolicies );

        return services;
    }
}