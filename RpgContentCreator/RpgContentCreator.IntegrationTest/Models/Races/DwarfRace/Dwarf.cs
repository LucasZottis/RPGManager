using RpgContentCreator.Application.Models;
using RpgContentCreator.Application.Models.Races;
using RpgContentCreator.IntegrationTest.Models.AbilitiesScores;
using RpgContentCreator.IntegrationTest.Models.GameSystems;
using RpgContentCreator.IntegrationTest.Models.Languages;

namespace RpgContentCreator.IntegrationTest.Models.Races.DwarfRace;

internal class Dwarf : RaceModel
{
    public Dwarf(GameSystemModel gameSystem)
    {
        Name = "Anão";
        Description = GetDescription();
        GameSystem = gameSystem;
        RaceAbilitiesScores = GetAbilitiesScores();
        RaceFeatures = GetFeatures();
    }

    private string GetDescription()
    {
        return "";
    }

    protected ICollection<RaceAbilitiesScoreModel> GetAbilitiesScores()
    {
        return [
            new RaceAbilitiesScoreModel { AbilityScore = new Constitution(), Increase = 2  }
        ];
    }

    protected ICollection<RaceFeatureModel> GetFeatures()
    {
        return [
            new RaceFeatureModel {
                Name = "Visão no Escuro",
                Description = "Acostumado à vida subterrânea, você tem uma visão superior no escuro e na penumbra. Você enxerga na penumbra a até 18 metros como se fosse luz plena, e no escuro como se fosse na penumbra. Você não pode discernir cores no escuro, apenas tons de cinza."
            },

            new RaceFeatureModel {
                Name = "Resiliência Anã",
                Description = "Você possui vantagem em testes de resistência contra venenos e resistência contra dano de veneno"
            },

            new RaceFeatureModel {
                Name = "Treinamento Anão em Combate",
                Description = "Você tem proficiência com machados de batalha, machadinhas, martelos leves e martelos de guerra."
            },

            new RaceFeatureModel {
                Name = "Proficiência com Ferramentas",
                Description = "Você tem proficiência em uma ferramenta de artesão à sua escolha entre: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro."
            },

            new RaceFeatureModel {
                Name = "Especialização em Rochas",
                Description = "Sempre que você realizar um teste de Inteligência (História) relacionado à origem de um trabalho em pedra, você é considerado proficiente na perícia História e adiciona o dobro do seu bônus de proficiência ao teste, ao invés do seu bônus de proficiência normal."
            },
        ];
    }

    private ICollection<RaceLanguageModel> GetLanguages()
    {
        return [
            new RaceLanguageModel { Language = new CommonLanguage() },
        ];
    }
}