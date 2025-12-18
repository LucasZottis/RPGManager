using Microsoft.Extensions.Logging;

namespace RpgContentCreator.Library.Interfaces;

public interface IPrivateLogger<TCategory> : IBaseLogger, ILogger<TCategory> where TCategory : class
{
}