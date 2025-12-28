using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace RPGManager.Desktop.Infra.Db.NameConvetion;

public class PostegreSqlNameConvetionConfigurator : NameConvetionConfigurator
{
    private readonly Regex _regex =
    new Regex( "(?<!^)([A-Z])", RegexOptions.Compiled );

    public string ToSnakeCase( string input )
        => _regex.Replace( input, "_$1" ).ToLowerInvariant();

    public override void Configure( IConventionModelBuilder modelBuilder )
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
}