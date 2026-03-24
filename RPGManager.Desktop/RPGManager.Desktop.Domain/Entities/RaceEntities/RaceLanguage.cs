using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

// RPGManager.Desktop.Domain/Entities/RaceEntities/RaceLanguage.cs
public class RaceLanguage : EntityBase
{
    public Guid RaceId { get; set; }
    public Guid? LanguageId { get; set; }     // null = escolha livre
    public bool IsChoice { get; set; }        // true = jogador escolhe o idioma

    public Race Race { get; set; }
    public Language? Language { get; set; }
}