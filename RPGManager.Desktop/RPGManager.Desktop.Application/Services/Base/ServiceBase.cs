using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Application.Services.Base;

public abstract class ServiceBase : IServiceBase
{
    protected IMapper Mapper { get; private set; }

    public ServiceBase( IMapper mapper )
    {
        Mapper = mapper;
    }

    public ServiceBase()
    {
        
    }
}