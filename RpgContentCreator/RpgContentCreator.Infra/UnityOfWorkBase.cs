using RpgContentCreator.Domain.Interfaces;
using RpgContentCreator.Infra.Db;

namespace RpgContentCreator.Infra;

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