using DevToolz.Library.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace RPGManager.Desktop.Infra.Db.Interceptors;

internal class UtcSaveChangesInterceptor : SaveChangesInterceptor
{
    private void ConvertDateTimeToTimeStampPostgreSql(DbContextEventData eventData)
    {
        var context = eventData.Context;

        if ( context.IsNull() )
            return;

        var entries = context!.ChangeTracker.Entries()
            .Where( e => e.State == EntityState.Added || e.State == EntityState.Modified )
            .ToList();

        foreach ( var entry in entries )
        {
            var entity = entry.Entity;
            var properties = entity.GetType().GetProperties()
                .Where( p => p.PropertyType == typeof( DateTime ) || p.PropertyType == typeof( DateTime? ) )
                .ToList();

            foreach ( var property in properties )
            {
                var currentValue = property.GetValue( entity );
                var propertyType = Nullable.GetUnderlyingType( property.PropertyType );

                if ( propertyType != null && propertyType == typeof( DateTime ) && ( ( DateTime? ) currentValue ).HasValue )
                {
                    var dateValue = ( ( DateTime? ) currentValue ).Value;
                    property.SetValue( entity, DateTime.SpecifyKind( dateValue, DateTimeKind.Local ) );
                }
                else if ( currentValue is DateTime dateTimeValue )
                    property.SetValue( entity, DateTime.SpecifyKind( dateTimeValue, DateTimeKind.Local ) );
            }
        }
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        //if (AppSettings.GeneralSettings.DataBaseType == DataBaseType.PostgreSql)
            //ConvertDateTimeToTimeStampPostgreSql(eventData);

        return base.SavingChanges(eventData, result);
    }
}