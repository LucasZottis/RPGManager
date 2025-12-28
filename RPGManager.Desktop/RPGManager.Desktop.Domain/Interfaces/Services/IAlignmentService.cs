using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IAlignmentService : IServiceBase<Alignment, AlignmentModel>
{
    //Task<AlignmentModel> Add( AlignmentModel model );
}