using RPGManager.Desktop.Domain.Interfaces;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra;

public class UnityOfWorkBase : IUnitOfWorkBase
{
    protected ContextBase Context { get; private set; }

    public UnityOfWorkBase(ContextBase context)
    {
        Context = context;
    }

    public async Task Commit()
    {
        Context.SaveChanges();
    }
}