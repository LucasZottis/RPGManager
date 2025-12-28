

namespace RPGManager.Desktop.Application.Services;

public class AbilityScoreService : ServiceBase<AbilityScore, AbilityScoreModel>, IAbilityScoreService
{
    //private readonly IAbilityScoreRepository _repository;

    //public async Task<AbilityScoreModel> Add( AbilityScoreModel model )
    //{
    //    var entity = new AbilityScore
    //    {
    //        Name = model.Name,
    //        Abbreviation = model.Abbreviation,
    //        Description = model.Description,
    //        GameSystemId = model.GameSystem.Id,
    //        Skills = model.Skills.Select( s => new Skill
    //        {
    //            Name = s.Name,
    //            Description = s.Description,
    //            GameSystemId = s.GameSystem.Id,
    //        } ).ToList()
    //    };

    //    await _repository.Add( entity );
    //    await _repository.SaveChanges();

    //    model.Id = entity.Id;
    //    model.Skills = entity.Skills.Select( s => new SkillModel
    //    {
    //        Name = s.Name,
    //        Description = s.Description,
    //        GameSystem = new GameSystemModel { Id = s.GameSystemId },
    //    } ).ToList();

    //    return model;
    //}

    public AbilityScoreService( IAbilityScoreRepository repository, IAbilityScoreMapper mapper ) : base( repository, mapper )
    {
    }
}