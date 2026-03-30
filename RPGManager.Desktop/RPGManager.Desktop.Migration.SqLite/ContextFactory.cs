//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Options;
//using RPGManager.Desktop.Infra.Db.Contexts;
//using RPGManager.Desktop.Infra.Db.DbContextConfigurator;
//using RPGManager.Desktop.Infra.Db.Enums;
//using RPGManager.Desktop.Infra.Options;

//namespace RPGManager.Desktop.SqLite;

//public class ContextFactory : IDesignTimeDbContextFactory<Context>
//{
//    public Context CreateDbContext( string[] args )
//    {
//        var options = Options.Create( new DataBaseSettings
//        {
//            DataBaseType = DataBaseType.SqLite,
//            ConnectionStrings = new ConnectionStrings
//            {
//                SqLite = $"Data Source={AppContext.BaseDirectory}\\DB\\rpg_manager.db"
//            }
//        } );

//        return new Context(
//            new DbContextConfigurator( options )
//        );
//    }
//}