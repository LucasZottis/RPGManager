using RPGManager.Desktop.Domain.Models.Dices;

namespace RPGManager.Desktop.Application.Services;

public class DiceTypeService : CrudServiceBase<DiceType, DiceTypeRegisterDto, DiceTypeQueryDto>, IDiceTypeService
{
    public DiceTypeService( IDiceTypeRepository repository, IDiceTypeMapper mapper ) : base( repository, mapper )
    {
    }
}