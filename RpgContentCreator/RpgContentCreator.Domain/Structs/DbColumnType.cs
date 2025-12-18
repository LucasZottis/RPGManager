namespace RpgContentCreator.Domain.Structs;

public struct DbColumnType
{
    // Boolean
    public const string SqlServerBoolean = "bit";
    public const string MySqlBoolean = "tinyint(1)";
    public const string SqLiteBoolean = "integer";
    public const string PostgreSqlBoolean = "boolean";

    // Date
    public const string SqlServerDate = "date";
    public const string MySqlDate = "date";
    public const string SqLiteDate = "text";
    public const string PostgreSqlDate = "date";

    // DateTime
    public const string SqlServerDateTime = "datetime2(7)";
    public const string MySqlDateTime = "datetime(6)";
    public const string SqLiteDateTime = "text";
    public const string PostgreSqlDateTime = " timestamp with time zone";

    // Guid
    public const string SqlServerGuid = "uniqueidentifier";
    public const string MySqlGuid = "binary(16)";
    public const string PostgreSqlGuid = "uuid";

    // LongPercentage
    public const string SqlServerLongPercentage = "decimal (18, 4)";
    public const string MySqlLongPercentage = "decimal (18, 4)";
    public const string SqLiteLongPercentage = "decimal (18, 4)";
    public const string PostgreSqlLongPercentage = "decimal (18, 4)";

    // LongText
    public const string SqlServerLongText = "text";
    public const string MySqlLongText = "text0";
    public const string SqLiteLongText = "text";
    public const string PostgreSqlLongText = "text";

    // Money
    public const string SqlServerMoney = "money";
    public const string MySqlMoney = "decimal (14, 2)";
    public const string SqLiteMoney = "numeric";
    public const string PostgreSqlMoney = "decimal (14, 2)";

    // ShorPercentage
    public const string SqlServerShortPercentage = "decimal (18, 2)";
    public const string MySqlShortPercentage = "decimal (18, 2)";
    public const string SqLiteShortPercentage = "decimal (18, 2)";
    public const string PostgreSqlShortPercentage = "decimal (18, 2)";

    // ShortText
    public const string SqlServerShortText = "varchar";
    public const string MySqlShortText = "varchar";
    public const string PostgreSqlShortText = "varchar";
    public const string SqLiteShortText = "text";

    // Time
    public const string SqlServerTime = "timestamp";
    public const string MySqlTime = "timestamp";
    public const string SqLiteTime = "timestamp";
    public const string PostgreSqlTime = "time";

    //Weigth
    public const string SqlServerWeight = "decimal (18, 3)";
    public const string MySqlWeight = "decimal (18, 3)";
    public const string PostgreSqlWeight = "decimal (18, 3)";
}