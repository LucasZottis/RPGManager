

namespace RpgContentCreator.Domain;

public static class ColumnTypeHelper
{
    //private static DataBaseType _dataBaseType = AppSettings.GeneralSettings.DataBaseType;
    private static DataBaseType _dataBaseType;

    public static string GetColumnType( ColumnType typeName )
    {
        if ( _dataBaseType == DataBaseType.InMemory )
            return typeName.ToString();

        var constName = _dataBaseType.ToString() + typeName;

        if ( constName == typeName.ToString() )
            throw new Exception( $"Não foi configurado o provedor de banco de dados." );

        var columnType = typeof( DbColumnType )
            .GetField( constName )?
            .GetValue( typeof( DbColumnType ) )?
            .ToString() ??
            throw new Exception( $"A coluna do tipo {constName} não existe." );

        return columnType;
    }
}