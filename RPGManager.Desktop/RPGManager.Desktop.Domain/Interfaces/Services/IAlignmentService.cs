using RPGManager.Desktop.Domain.DTOs.Alignments;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IAlignmentService : ICrudServiceBase<Alignment, AlignmentRegisterDto, AlignmentQueryDto>
{
}
