using RPGManager.Desktop.Domain.Interfaces.UnitOfWork;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.UnitsOfWork;

public class UnitOfWorkBase : IUnitOfWorkBase
{
    private readonly Context _context;

    public UnitOfWorkBase( Context context )
    {
        _context = context;
    }

    public async Task Commit()
    {
        _context.SaveChanges();
    }
}