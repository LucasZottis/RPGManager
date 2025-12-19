using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest;

internal static class GameSystemStatic
{
    public static GameSystemModel GameSystem { get; set; }
    public static ICollection<LanguageModel> Languages { get; set; } = [];
    public static ICollection<AbilityScoreModel> AbilityScores { get; set; } = [];
}