using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using RPGManager.Desktop.Infra.Db.Enums;
using System.Text.RegularExpressions;

namespace RPGManager.Desktop.Infra.Db;

public sealed class NameConventionConfigurator : IModelFinalizingConvention
{
    private DataBaseType _dataBaseType = DataBaseType.InMemory;

    private readonly Regex _regex =
        new Regex( "(?<!^)([A-Z])", RegexOptions.Compiled );

    public string ToSnakeCase( string input )
        => _regex.Replace( input, "_$1" ).ToLowerInvariant();

    public NameConventionConfigurator( DataBaseType dataBaseType )
    {
        _dataBaseType = dataBaseType;
    }

    private void ConfigureNamesUsingSnakeCase( IConventionModelBuilder modelBuilder, IConventionContext<IConventionModelBuilder> context )
    {
        foreach ( var entity in modelBuilder.Metadata.GetEntityTypes() )
        {
            // tabela
            entity.SetTableName( ToSnakeCase( entity.GetTableName()! ) );

            // colunas
            foreach ( var property in entity.GetProperties() )
                property.SetColumnName( ToSnakeCase( property.GetColumnName()! ) );

            // chaves
            foreach ( var key in entity.GetKeys() )
                key.SetName( ToSnakeCase( key.GetName()! ) );

            // FKs
            foreach ( var fk in entity.GetForeignKeys() )
                fk.SetConstraintName( ToSnakeCase( fk.GetConstraintName()! ) );
        }
    }

    public void ProcessModelFinalizing( IConventionModelBuilder modelBuilder, IConventionContext<IConventionModelBuilder> context )
    {
        switch ( _dataBaseType )
        {
            case DataBaseType.InMemory:
                break;
            case DataBaseType.SqlServer:
                break;
            case DataBaseType.MySql:
                break;
            case DataBaseType.SqLite:
                break;
            case DataBaseType.PostgreSql:
                ConfigureNamesUsingSnakeCase( modelBuilder, context );
                break;
            default:
                break;
        }
    }
}