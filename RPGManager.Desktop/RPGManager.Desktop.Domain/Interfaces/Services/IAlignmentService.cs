using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Alignments;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IAlignmentService : ICrudServiceBase<Alignment, AlignmentRegisterDto, AlignmentQueryDto>
{
}
