using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db;

public static class PropertyBuilderExtension
{
    public static PropertyBuilder<TProperty> HasValueComparer<TProperty, TValueComparer>( this PropertyBuilder<TProperty> propertyBuilder, ValueComparer<TValueComparer> valueComparer )
    {
        propertyBuilder.Metadata.SetValueComparer( valueComparer );
        return propertyBuilder;
    }
}