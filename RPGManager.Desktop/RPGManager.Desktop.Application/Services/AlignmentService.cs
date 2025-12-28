

namespace RPGManager.Desktop.Application.Services;

public class AlignmentService : ServiceBase<Alignment, AlignmentModel>, IAlignmentService
{
    //private readonly IAlignmentRepository _repositoy;

    //public AlignmentService( IAlignmentRepository repositoy )
    //{
    //    _repositoy = repositoy;
    //}

    //public async Task<AlignmentModel> Add( AlignmentModel model )
    //{
    //    var entity = new Alignment
    //    {
    //        Name = model.Name,
    //        Description = model.Description,
    //        GameSystemId = model.GameSystem.Id
    //    };

    //    await _repositoy.Add( entity );
    //    await _repositoy.SaveChanges();

    //    model.Id = entity.Id;

    //    return model;
    //}

    public AlignmentService( IAlignmentRepository repository, IAlignmentMapper mapper ) : base( repository, mapper )
    {
    }
}