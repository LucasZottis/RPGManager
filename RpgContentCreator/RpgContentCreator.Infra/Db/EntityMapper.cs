using DevToolz.Library.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RpgContentCreator.Domain;
using RpgContentCreator.Domain.Entities;
using RpgContentCreator.Domain.Enums;
using RpgContentCreator.Domain.Interfaces;
using RpgContentCreator.Library.Interfaces;
using System.Linq.Expressions;

namespace RpgContentCreator.Infra.Db;

public abstract class EntityMapper<TEntity> : IEntityMapper
    where TEntity : EntityBase
{
    protected EntityTypeBuilder<TEntity> EntityTypeBuilder { get; private set; }


    public EntityMapper(EntityTypeBuilder<TEntity> entityTypeBuilder, bool executeInitialMapping = true)
    {
        EntityTypeBuilder = entityTypeBuilder;

        if (executeInitialMapping)
            InitialMapping();
    }
    public EntityMapper(EntityTypeBuilder<TEntity> entityTypeBuilder) : this(entityTypeBuilder, true) { }

    private void InitialMapping()
    {
        MapGuid();
        MapId();
        MapRegistrationDate();
        MapLastUpdateDate();
        MapDeactivationDate();
        MapTable();
        MapPrimaryKey();
    }

    protected string GetEntityName()
        => typeof(TEntity).Name.Replace("Entity", "");

    protected string TransformName(string name)
    {
        //if (AppSettings.GeneralSettings.DataBaseType == DataBaseType.PostgreSql)
        //    return name.ToLower();

        return name;
    }

    protected PropertyBuilder<TProperty> Property<TProperty>(Expression<Func<TEntity, TProperty>> propertyExpression)
        => EntityTypeBuilder.Property(propertyExpression);

    protected virtual void MapGuid(string columnName = "")
    {
        if (columnName.IsEmpty())
            columnName = $"{GetEntityName()}Guid";

        Property(e => e.Id)
            .HasColumnName(TransformName(columnName))
            .HasColumnType(ColumnTypeHelper.GetColumnType(ColumnType.Guid))
            .IsRequired();
    }

    protected virtual void MapId(string columnName = "", bool valueGeneratedOnAdd = true)
    {
        var implementation = typeof(TEntity).IsAssignableFrom(typeof(IIdentifiableEntity));

        if (implementation)
        {
            if (columnName.IsEmpty())
                columnName = $"{GetEntityName()}Id";

            Property(e => ((IIdentifiableEntity)e).Id)
                .HasColumnName(TransformName(columnName))
                .HasColumnType("int")
                .IsRequired();

            if (valueGeneratedOnAdd)
                Property(e => ((IIdentifiableEntity)e).Id)
                    .ValueGeneratedOnAdd();
        }
    }

    protected virtual void MapRegistrationDate(string columnName = "RegistrationDate")
    {
        var implement = typeof(TEntity).IsAssignableFrom(typeof(IRegistrableEntity));

        if (implement)
        {
            Property(e => ((IRegistrableEntity)e).RegistrationDate)
                .HasColumnName(TransformName(columnName))
                .HasColumnType(ColumnTypeHelper.GetColumnType(ColumnType.DateTime))
                .IsRequired();
        }
    }

    protected virtual void MapLastUpdateDate(string columnName = "LastUpdateDate")
    {
        var implement = typeof(TEntity).IsAssignableFrom(typeof(IUpdatableEntity));

        if (implement)
        {
            Property(e => ((IUpdatableEntity)e).LastUpdateDate)
                .HasColumnName(TransformName(columnName))
                .HasColumnType(ColumnTypeHelper.GetColumnType(ColumnType.DateTime))
                .IsRequired(false);
        }
    }

    protected virtual void MapDeactivationDate(string columnName = "DeactivationDate")
    {
        var implement = typeof(TEntity).IsAssignableFrom(typeof(IDeactivatableEntity));

        if (implement)
        {
            Property(e => ((IDeactivatableEntity)e).DeactivationDate)
                .HasColumnName(TransformName(columnName))
                .HasColumnType(ColumnTypeHelper.GetColumnType(ColumnType.DateTime))
                .IsRequired(false);
        }
    }

    protected virtual void MapPrimaryKey(params string[] primariesKeys)
    {
        if (primariesKeys.IsEmpty())
        {
            var primaryKeysList = new List<string>();
            var implementIdentifiableEntity = typeof(TEntity).IsAssignableFrom(typeof(IIdentifiableEntity));

            primaryKeysList.Add(TransformName($"Guid"));

            if (implementIdentifiableEntity)
                primaryKeysList.Add(TransformName($"Id"));

            primariesKeys = primaryKeysList.ToArray();
        }

        EntityTypeBuilder.HasKey(primariesKeys);
    }

    //protected virtual void MapPrimaryKey( Expression<Func<TEntity, object>> primaryKeyExpression )
    //{
    //    if ( primaryKeyExpression.Parameters.Count == 0 )
    //        primaryKeyExpression = e => new { e.Guid };

    //    EntityTypeBuilder.HasKey( primaryKeyExpression );
    //}

    protected virtual void MapTable(string tableName = "")
    {
        if (tableName.IsEmpty())
            tableName = GetEntityName();

        EntityTypeBuilder.ToTable(TransformName(tableName));
    }

    public abstract void Map();
}