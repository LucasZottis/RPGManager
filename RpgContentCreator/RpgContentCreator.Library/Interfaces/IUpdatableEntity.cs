namespace RpgContentCreator.Library.Interfaces;

public interface IUpdatableEntity
{
    DateTime? LastUpdateDate { get; set; }
}