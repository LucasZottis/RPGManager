namespace RPGManager.Desktop.Api.Utils.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication UseAuth( this WebApplication app )
    {
        app.UseAuthentication();
        app.UseAuthorization();

        return app;
    }

    public static WebApplication UseSwaggerGenerator( this WebApplication app )
    {
        if ( !app.Environment.IsDevelopment() )
            return app;

        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }

    public static WebApplication UseCors( this WebApplication app )
    {
        if ( !app.Environment.IsDevelopment() )
            return app;

        app.UseCors( x =>
        {
            x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed( origin => true ).AllowCredentials();
        } );

        return app;
    }

    public static WebApplication UseHttpsRedirection(this WebApplication app)
    {
        if ( app.Environment.IsDevelopment() )
            return app;

        app.UseHttpsRedirection();

        return app;
    }

    public static WebApplication UseControllerMapper( this WebApplication app )
    {
        app.MapControllers();

        return app;
    }
}