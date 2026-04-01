using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.Seeds;

public class DnD521Seed : SeedBase
{
    public override IEnumerable<GameSystem> GetGameSystems()
    {
        return new List<GameSystem>
        {
            new GameSystem
            {
                Id = GameSystemsId["DnD"],
                Name = "Dungeons & Dragons",
            }
        };
    }

    public override IEnumerable<GameSystemVersion> GetGameSystemVersions()
    {
        return new List<GameSystemVersion> {
            new GameSystemVersion {
                Id = GameSystemVersionsId["521"],
                Version = "5.2.1",
                GameSystemId = GameSystemsId["DnD"],
                //LevelLimit = 20
            },
        };
    }

    public override IEnumerable<AbilityScore> GetAbilityScore()
    {
        return
        [
            new AbilityScore
            {
                Id = AbilitiesScoreId["STR"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Força",
                Description = "Força mede o poder muscular, a capacidade de carregar peso e a potência física geral de um personagem.",
                Abbreviation = "FOR"
            },
            new AbilityScore
            {
                Id = AbilitiesScoreId["DEX"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Destreza",
                Description = "Destreza mede a agilidade, os reflexos e o equilíbrio de um personagem.",
                Abbreviation = "DES"
            },
            new AbilityScore
            {
                Id = AbilitiesScoreId["CON"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Constituição",
                Description = "Constituição mede a saúde e a resistência física de um personagem.",
                Abbreviation = "CON"
            },
            new AbilityScore
            {
                Id = AbilitiesScoreId["INT"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Inteligência",
                Description = "Inteligência mede o raciocínio e a capacidade de memorização de um personagem.",
                Abbreviation = "INT"
            },
            new AbilityScore
            {
                Id = AbilitiesScoreId["WIS"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Sabedoria",
                Description = "Sabedoria mede a percepção e a resistência mental de um personagem.",
                Abbreviation = "SAB"
            },
            new AbilityScore
            {
                Id = AbilitiesScoreId["CHA"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Carisma",
                Description = "Carisma mede a confiança, a postura e o charme de um personagem.",
                Abbreviation = "CAR"
            }
        ];
    }

    public override IEnumerable<Alignment> GetAlignments()
    {
        return
        [
            new Alignment
            {
                Id = AlignmentsId["LG"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Leal e Bom",
                Description = "Criaturas Leais e Boas se esforçam para fazer a coisa certa conforme o esperado pela sociedade. Alguém que combate a injustiça e protege os inocentes sem hesitação provavelmente é Leal e Bom."
            },
            new Alignment
            {
                Id = AlignmentsId["NG"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Neutro e Bom",
                Description = "Criaturas Neutras e Boas fazem o melhor que podem, trabalhando dentro das regras sem se sentirem limitadas por elas. Uma pessoa gentil que ajuda os outros conforme as necessidades provavelmente é Neutra e Boa."
            },
            new Alignment
            {
                Id = AlignmentsId["CG"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Caótico e Bom",
                Description = "Criaturas Caóticas e Boas agem conforme sua consciência, com pouca consideração pelo que os outros esperam. Um rebelde que usa recursos roubados de tiranos para ajudar os pobres provavelmente é Caótico e Bom."
            },
            new Alignment
            {
                Id = AlignmentsId["LN"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Leal e Neutro",
                Description = "Indivíduos Leais e Neutros agem de acordo com a lei, a tradição ou códigos pessoais. Alguém que segue uma disciplina rigorosa de vida sem se deixar influenciar pelos necessitados nem pelas tentações do mal provavelmente é Leal e Neutro."
            },
            new Alignment
            {
                Id = AlignmentsId["N"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Neutro",
                Description = "Neutro é o alinhamento de quem prefere evitar questões morais e não toma partido, fazendo o que parece melhor no momento. Alguém entediado por debates morais provavelmente é Neutro."
            },
            new Alignment
            {
                Id = AlignmentsId["CN"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Caótico e Neutro",
                Description = "Criaturas Caóticas e Neutras seguem seus caprichos, valorizando a liberdade pessoal acima de tudo. Um vagabundo que percorre a terra vivendo de esperteza provavelmente é Caótico e Neutro."
            },
            new Alignment
            {
                Id = AlignmentsId["LE"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Leal e Mau",
                Description = "Criaturas Leais e Más tomam metodicamente o que desejam dentro dos limites de um código de tradição, lealdade ou ordem. Um aristocrata que explora cidadãos enquanto trama pelo poder provavelmente é Leal e Mau."
            },
            new Alignment
            {
                Id = AlignmentsId["NE"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Neutro e Mau",
                Description = "Neutro e Mau é o alinhamento de quem não se incomoda com o mal que causa ao perseguir seus desejos. Um criminoso que rouba e mata à vontade provavelmente é Neutro e Mau."
            },
            new Alignment
            {
                Id = AlignmentsId["CE"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Caótico e Mau",
                Description = "Criaturas Caóticas e Más agem com violência arbitrária, impulsionadas pelo ódio ou sede de sangue. Um vilão que persegue esquemas de vingança e caos provavelmente é Caótico e Mau."
            },
        ];
    }

    public override IEnumerable<CurrencyType> GetCurrencyTypes()
    {
        return
        [
            new CurrencyType
            {
                Id = CurrencyTypesId["CP"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Peça de Cobre",
                Abbreviation = "PC",
            },
            new CurrencyType
            {
                Id = CurrencyTypesId["SP"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Peça de Prata",
                Abbreviation = "PP",
            },
            new CurrencyType
            {
                Id = CurrencyTypesId["EP"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Peça de Electrum",
                Abbreviation = "PE",
            },
            new CurrencyType
            {
                Id = CurrencyTypesId["GP"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Peça de Ouro",
                Abbreviation = "PO",
                IsBaseCurrency = true,
            },
            new CurrencyType
            {
                Id = CurrencyTypesId["PP"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Peça de Platina",
                Abbreviation = "PPt",
            },
        ];
    }

    public override IEnumerable<CurrencyConversionRate> GetCurrencyConversionsRate()
    {
        return
        [
            // CP → *
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["CP"], ToCurrencyTypeId = CurrencyTypesId["SP"], Rate = 0.1m   },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["CP"], ToCurrencyTypeId = CurrencyTypesId["EP"], Rate = 0.02m  },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["CP"], ToCurrencyTypeId = CurrencyTypesId["GP"], Rate = 0.01m  },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["CP"], ToCurrencyTypeId = CurrencyTypesId["PP"], Rate = 0.001m }, 
                                                                                                                                             
            // SP → *                                                                                                                        
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["SP"], ToCurrencyTypeId = CurrencyTypesId["CP"], Rate = 10m },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["SP"], ToCurrencyTypeId = CurrencyTypesId["EP"], Rate = 0.2m },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["SP"], ToCurrencyTypeId = CurrencyTypesId["GP"], Rate = 0.1m },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["SP"], ToCurrencyTypeId = CurrencyTypesId["PP"], Rate = 0.01m },
                                                                                                                                             
            // EP → *                                                                                                                        
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["EP"], ToCurrencyTypeId = CurrencyTypesId["CP"], Rate = 50m    },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["EP"], ToCurrencyTypeId = CurrencyTypesId["SP"], Rate = 5m     },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["EP"], ToCurrencyTypeId = CurrencyTypesId["GP"], Rate = 0.5m   },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["EP"], ToCurrencyTypeId = CurrencyTypesId["PP"], Rate = 0.05m  },
                                                                                                                                             
            // GP → *                                                                                                                        
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["GP"], ToCurrencyTypeId = CurrencyTypesId["CP"], Rate = 100m   },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["GP"], ToCurrencyTypeId = CurrencyTypesId["SP"], Rate = 10m    },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["GP"], ToCurrencyTypeId = CurrencyTypesId["EP"], Rate = 2m     },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["GP"], ToCurrencyTypeId = CurrencyTypesId["PP"], Rate = 0.1m   },
                                                                                                                                             
            // PP → *                                                                                                                        
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["PP"], ToCurrencyTypeId = CurrencyTypesId["CP"], Rate = 1000m  },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["PP"], ToCurrencyTypeId = CurrencyTypesId["SP"], Rate = 100m   },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["PP"], ToCurrencyTypeId = CurrencyTypesId["EP"], Rate = 20m    },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["PP"], ToCurrencyTypeId = CurrencyTypesId["GP"], Rate = 10m    },
        ];
    }

    public override IEnumerable<DamageType> GetDamageTypes()
    {
        return
        [
            new DamageType { Id = DamageTypesId["Acid"],        GameSystemVersionId = GameSystemVersionsId["521"], Name = "Ácido"      },
            new DamageType { Id = DamageTypesId["Bludgeoning"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "Concussão"   },
            new DamageType { Id = DamageTypesId["Cold"],        GameSystemVersionId = GameSystemVersionsId["521"], Name = "Frio"        },
            new DamageType { Id = DamageTypesId["Fire"],        GameSystemVersionId = GameSystemVersionsId["521"], Name = "Fogo"        },
            new DamageType { Id = DamageTypesId["Force"],       GameSystemVersionId = GameSystemVersionsId["521"], Name = "Força"       },
            new DamageType { Id = DamageTypesId["Lightning"],   GameSystemVersionId = GameSystemVersionsId["521"], Name = "Elétrico"    },
            new DamageType { Id = DamageTypesId["Necrotic"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Necrótico"   },
            new DamageType { Id = DamageTypesId["Piercing"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Perfuração"  },
            new DamageType { Id = DamageTypesId["Poison"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Veneno"      },
            new DamageType { Id = DamageTypesId["Psychic"],     GameSystemVersionId = GameSystemVersionsId["521"], Name = "Psíquico"    },
            new DamageType { Id = DamageTypesId["Radiant"],     GameSystemVersionId = GameSystemVersionsId["521"], Name = "Radiante"    },
            new DamageType { Id = DamageTypesId["Slashing"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Corte"       },
            new DamageType { Id = DamageTypesId["Thunder"],     GameSystemVersionId = GameSystemVersionsId["521"], Name = "Trovão"      },
        ];
    }

    public override IEnumerable<DiceType> GetDiceTypes()
    {
        return
        [
            new DiceType { Id = DiceTypesId["D4"],   Name = "D4",   Sides = 4   },
            new DiceType { Id = DiceTypesId["D6"],   Name = "D6",   Sides = 6   },
            new DiceType { Id = DiceTypesId["D8"],   Name = "D8",   Sides = 8   },
            new DiceType { Id = DiceTypesId["D10"],  Name = "D10",  Sides = 10  },
            new DiceType { Id = DiceTypesId["D12"],  Name = "D12",  Sides = 12  },
            new DiceType { Id = DiceTypesId["D20"],  Name = "D20",  Sides = 20  },
            new DiceType { Id = DiceTypesId["D100"], Name = "D100", Sides = 100 },
        ];
    }

    public override IEnumerable<Language> GetLanguages()
    {
        return
        [
            // Standard
            new Language { Id = LanguagesId["Common"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Comum"                  },
            new Language { Id = LanguagesId["CommonSign"],  GameSystemVersionId = GameSystemVersionsId["521"], Name = "Língua de Sinais Comum" },
            new Language { Id = LanguagesId["Draconic"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Dracônico"              },
            new Language { Id = LanguagesId["Dwarvish"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Anão"                   },
            new Language { Id = LanguagesId["Elvish"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Élfico"                 },
            new Language { Id = LanguagesId["Giant"],       GameSystemVersionId = GameSystemVersionsId["521"], Name = "Gigante"                },
            new Language { Id = LanguagesId["Gnomish"],     GameSystemVersionId = GameSystemVersionsId["521"], Name = "Gnômico"                },
            new Language { Id = LanguagesId["Goblin"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Goblin"                 },
            new Language { Id = LanguagesId["Halfling"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Halfling"               },
            new Language { Id = LanguagesId["Orc"],         GameSystemVersionId = GameSystemVersionsId["521"], Name = "Orc"                    },
            // Rare                                                                                                                            
            new Language { Id = LanguagesId["Abyssal"],     GameSystemVersionId = GameSystemVersionsId["521"], Name = "Abissal"                },
            new Language { Id = LanguagesId["Celestial"],   GameSystemVersionId = GameSystemVersionsId["521"], Name = "Celestial"              },
            new Language { Id = LanguagesId["DeepSpeech"],  GameSystemVersionId = GameSystemVersionsId["521"], Name = "Língua Profunda"        },
            new Language { Id = LanguagesId["Druidic"],     GameSystemVersionId = GameSystemVersionsId["521"], Name = "Druídico"               },
            new Language { Id = LanguagesId["Infernal"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Infernal"               },
            new Language { Id = LanguagesId["Primordial"],  GameSystemVersionId = GameSystemVersionsId["521"], Name = "Primordial"             },
            new Language { Id = LanguagesId["Sylvan"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Silvano"                },
            new Language { Id = LanguagesId["ThievesCant"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "Gíria dos Ladrões"      },
            new Language { Id = LanguagesId["Undercommon"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "Subcomum"               },
        ];
    }

    public override IEnumerable<Level> GetLevels()
    {
        return
        [
            new Level { Id = LevelsId["1"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 1,  ExperiencePoints = 0,      ProficiencyBonus = 2 },
            new Level { Id = LevelsId["2"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 2,  ExperiencePoints = 300,    ProficiencyBonus = 2 },
            new Level { Id = LevelsId["3"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 3,  ExperiencePoints = 900,    ProficiencyBonus = 2 },
            new Level { Id = LevelsId["4"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 4,  ExperiencePoints = 2700,   ProficiencyBonus = 2 },
            new Level { Id = LevelsId["5"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 5,  ExperiencePoints = 6500,   ProficiencyBonus = 3 },
            new Level { Id = LevelsId["6"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 6,  ExperiencePoints = 14000,  ProficiencyBonus = 3 },
            new Level { Id = LevelsId["7"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 7,  ExperiencePoints = 23000,  ProficiencyBonus = 3 },
            new Level { Id = LevelsId["8"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 8,  ExperiencePoints = 34000,  ProficiencyBonus = 3 },
            new Level { Id = LevelsId["9"],  GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 9,  ExperiencePoints = 48000,  ProficiencyBonus = 4 },
            new Level { Id = LevelsId["10"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 10, ExperiencePoints = 64000,  ProficiencyBonus = 4 },
            new Level { Id = LevelsId["11"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 11, ExperiencePoints = 85000,  ProficiencyBonus = 4 },
            new Level { Id = LevelsId["12"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 12, ExperiencePoints = 100000, ProficiencyBonus = 4 },
            new Level { Id = LevelsId["13"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 13, ExperiencePoints = 120000, ProficiencyBonus = 5 },
            new Level { Id = LevelsId["14"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 14, ExperiencePoints = 140000, ProficiencyBonus = 5 },
            new Level { Id = LevelsId["15"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 15, ExperiencePoints = 165000, ProficiencyBonus = 5 },
            new Level { Id = LevelsId["16"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 16, ExperiencePoints = 195000, ProficiencyBonus = 5 },
            new Level { Id = LevelsId["17"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 17, ExperiencePoints = 225000, ProficiencyBonus = 6 },
            new Level { Id = LevelsId["18"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 18, ExperiencePoints = 265000, ProficiencyBonus = 6 },
            new Level { Id = LevelsId["19"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 19, ExperiencePoints = 305000, ProficiencyBonus = 6 },
            new Level { Id = LevelsId["20"], GameSystemVersionId = GameSystemVersionsId["521"], LevelNumber = 20, ExperiencePoints = 355000, ProficiencyBonus = 6 },
        ];
    }

    public override IEnumerable<Size> GetSizes()
    {
        return
        [
            new Size { Id = SizesId["Tiny"],       GameSystemVersionId = GameSystemVersionsId["521"], Name = "Minúsculo",  MinHeight = 0f,    MaxHeight = 0.60f },
            new Size { Id = SizesId["Small"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Pequeno",    MinHeight = 0.60f, MaxHeight = 1.20f },
            new Size { Id = SizesId["Medium"],     GameSystemVersionId = GameSystemVersionsId["521"], Name = "Médio",      MinHeight = 1.20f, MaxHeight = 2.45f },
            new Size { Id = SizesId["Large"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Grande",     MinHeight = 2.45f, MaxHeight = 4.90f },
            new Size { Id = SizesId["Huge"],       GameSystemVersionId = GameSystemVersionsId["521"], Name = "Enorme",     MinHeight = 4.90f, MaxHeight = 7.30f },
            new Size { Id = SizesId["Gargantuan"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "Descomunal", MinHeight = 7.30f, MaxHeight = null  },
        ];
    }

    public override IEnumerable<Skill> GetSkills()
    {
        return
        [
            new Skill { Id = SkillsId["Acrobatics"],     GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], Name = "Acrobacia",        Description = "Acrobacia representa a habilidade de se manter em pé em situações difíceis ou de realizar manobras acrobáticas."                               },
            new Skill { Id = SkillsId["AnimalHandling"], GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["WIS"], Name = "Adestrar Animais", Description = "Adestrar Animais representa a habilidade de acalmar ou treinar um animal, ou fazê-lo se comportar de determinada maneira."                          },
            new Skill { Id = SkillsId["Arcana"],         GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["INT"], Name = "Arcanismo",        Description = "Arcanismo representa o conhecimento sobre magias, itens mágicos e os planos de existência."                                                          },
            new Skill { Id = SkillsId["Athletics"],      GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["STR"], Name = "Atletismo",        Description = "Atletismo representa a habilidade de saltar distâncias maiores, se manter à tona em águas agitadas ou quebrar objetos."                             },
            new Skill { Id = SkillsId["Deception"],      GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["CHA"], Name = "Enganação",        Description = "Enganação representa a habilidade de contar uma mentira convincente ou usar um disfarce de forma persuasiva."                                       },
            new Skill { Id = SkillsId["History"],        GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["INT"], Name = "História",         Description = "História representa o conhecimento sobre eventos históricos, personalidades, nações e culturas."                                                     },
            new Skill { Id = SkillsId["Insight"],        GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["WIS"], Name = "Intuição",         Description = "Intuição representa a habilidade de discernir o estado de espírito e as intenções de uma pessoa."                                                    },
            new Skill { Id = SkillsId["Intimidation"],   GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["CHA"], Name = "Intimidação",      Description = "Intimidação representa a habilidade de impressionar ou ameaçar alguém para que faça o que se deseja."                                                 },
            new Skill { Id = SkillsId["Investigation"],  GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["INT"], Name = "Investigação",     Description = "Investigação representa a habilidade de encontrar informações obscuras em livros ou deduzir como algo funciona."                                      },
            new Skill { Id = SkillsId["Medicine"],       GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["WIS"], Name = "Medicina",         Description = "Medicina representa a habilidade de diagnosticar uma doença ou determinar o que matou um ser recém-falecido."                                         },
            new Skill { Id = SkillsId["Nature"],         GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["INT"], Name = "Natureza",         Description = "Natureza representa o conhecimento sobre terrenos, plantas, animais e condições climáticas."                                                           },
            new Skill { Id = SkillsId["Perception"],     GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["WIS"], Name = "Percepção",        Description = "Percepção representa a habilidade de notar algo difícil de detectar usando uma combinação dos sentidos."                                              },
            new Skill { Id = SkillsId["Performance"],    GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["CHA"], Name = "Atuação",          Description = "Atuação representa a habilidade de atuar, contar histórias, fazer música ou dançar."                                                                   },
            new Skill { Id = SkillsId["Persuasion"],     GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["CHA"], Name = "Persuasão",        Description = "Persuasão representa a habilidade de convencer alguém de algo de forma honesta e graciosa."                                                          },
            new Skill { Id = SkillsId["Religion"],       GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["INT"], Name = "Religião",         Description = "Religião representa o conhecimento sobre deuses, rituais religiosos e símbolos sagrados."                                                              },
            new Skill { Id = SkillsId["SleightOfHand"],  GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], Name = "Prestidigitação",  Description = "Prestidigitação representa a habilidade de bater carteiras, ocultar objetos pequenos ou realizar truques de mão."                                     },
            new Skill { Id = SkillsId["Stealth"],        GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], Name = "Furtividade",      Description = "Furtividade representa a habilidade de passar despercebido movendo-se silenciosamente e se escondendo atrás de objetos."                             },
            new Skill { Id = SkillsId["Survival"],       GameSystemVersionId = GameSystemVersionsId["521"], BaseAbilityScoreId = AbilitiesScoreId["WIS"], Name = "Sobrevivência",    Description = "Sobrevivência representa a habilidade de seguir rastros, forragear, encontrar trilhas ou evitar perigos naturais."                                    },
        ];
    }

    public override IEnumerable<ArmorCategory> GetArmorCategories()
    {
        return
        [
            new ArmorCategory
            {
                Id = ArmorCategoriesId["Light"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Leve",
                Description = "Armaduras leves são projetadas para aventureiros ágeis, pois oferecem proteção sem sacrificar a mobilidade. Vestir ou remover uma armadura leve leva 1 minuto.",
            },
            new ArmorCategory
            {
                Id = ArmorCategoriesId["Medium"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Média",
                Description = "Armaduras médias oferecem mais proteção do que as leves, mas também prejudicam um pouco o movimento. Vestir uma armadura média leva 5 minutos e removê-la leva 1 minuto.",
            },
            new ArmorCategory
            {
                Id = ArmorCategoriesId["Heavy"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Pesada",
                Description = "Armaduras pesadas oferecem a maior proteção, mas exigem força para suportá-las com eficiência. Vestir uma armadura pesada leva 10 minutos e removê-la leva 5 minutos.",
            },
            new ArmorCategory
            {
                Id = ArmorCategoriesId["Shield"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                Name = "Escudo",
                Description = "Um escudo é carregado em uma das mãos e concede um bônus à Classe de Armadura. Apenas quem tem treinamento com escudos recebe esse bônus. Vestir ou remover um escudo requer a ação Utilizar.",
            },
        ];
    }

    public override IEnumerable<WearableArmor> GetWearableArmors()
    {
        return
        [
            // Light
            new WearableArmor
            {
                Id = WearableArmorsId["PaddedArmor"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Light"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = AbilitiesScoreId["DEX"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Armadura Acolchoada",
                BaseArmorClass = 11,
                Weight = 8,
                MaxAbilityModifier = 0,
                AppliesAbilityModifier = true,
                DisadvantageOnStealth = true,
                Cost = 5
            },
            new WearableArmor
            {
                Id = WearableArmorsId["LeatherArmor"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Light"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = AbilitiesScoreId["DEX"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Armadura de Couro",
                BaseArmorClass = 11,
                Weight = 10,
                MaxAbilityModifier = 0,
                AppliesAbilityModifier = true,
                DisadvantageOnStealth = false,
                Cost = 10
            },
            new WearableArmor
            {
                Id = WearableArmorsId["StuddedLeatherArmor"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Light"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = AbilitiesScoreId["DEX"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Armadura de Couro Cravejado",
                BaseArmorClass = 12,
                Weight = 13,
                MaxAbilityModifier = 0,
                AppliesAbilityModifier = true,
                DisadvantageOnStealth = false,
                Cost = 45
            },
            // Medium
            new WearableArmor
            {
                Id = WearableArmorsId["HideArmor"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Medium"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = AbilitiesScoreId["DEX"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Armadura de Peles",
                BaseArmorClass = 12,
                Weight = 12,
                MaxAbilityModifier = 2,
                AppliesAbilityModifier = true,
                DisadvantageOnStealth = false,
                Cost = 10
            },
            new WearableArmor
            {
                Id = WearableArmorsId["ChainShirt"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Medium"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = AbilitiesScoreId["DEX"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Camisola de Malha",
                BaseArmorClass = 13,
                Weight = 20,
                MaxAbilityModifier = 2,
                AppliesAbilityModifier = true,
                DisadvantageOnStealth = false,
                Cost = 50
            },
            new WearableArmor
            {
                Id = WearableArmorsId["ScaleMail"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Medium"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = AbilitiesScoreId["DEX"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Armadura de Escamas",
                BaseArmorClass = 14,
                Weight = 45,
                MaxAbilityModifier = 2,
                AppliesAbilityModifier = true,
                DisadvantageOnStealth = true,
                Cost = 50
            },
            new WearableArmor
            {
                Id = WearableArmorsId["Breastplate"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Medium"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = AbilitiesScoreId["DEX"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Peitoral",
                BaseArmorClass = 14,
                Weight = 20,
                MaxAbilityModifier = 2,
                AppliesAbilityModifier = true,
                DisadvantageOnStealth = false,
                Cost = 400
            },
            new WearableArmor
            {
                Id = WearableArmorsId["HalfPlateArmor"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Medium"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = AbilitiesScoreId["DEX"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Meia Armadura de Placas",
                BaseArmorClass = 15,
                Weight = 40,
                MaxAbilityModifier = 2,
                AppliesAbilityModifier = true,
                DisadvantageOnStealth = true,
                Cost = 750
            },
            // Heavy
            new WearableArmor
            {
                Id = WearableArmorsId["RingMail"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Heavy"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = null,
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Armadura de Anéis",
                BaseArmorClass = 14,
                Weight = 40,
                MaxAbilityModifier = 0,
                AppliesAbilityModifier = false,
                DisadvantageOnStealth = true,
                Cost = 30
            },
            new WearableArmor
            {
                Id = WearableArmorsId["ChainMail"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Heavy"],
                RequiredAbilityScoreId = AbilitiesScoreId["STR"],
                ArmorClassAbilityScoreModifierId = null,
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Cota de Malha",
                BaseArmorClass = 16,
                Weight = 55,
                MaxAbilityModifier = 0,
                AppliesAbilityModifier = false,
                DisadvantageOnStealth = true,
                Cost = 75
            },
            new WearableArmor
            {
                Id = WearableArmorsId["SplintArmor"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Heavy"],
                RequiredAbilityScoreId = AbilitiesScoreId["STR"],
                ArmorClassAbilityScoreModifierId = null,
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Armadura de Talas",
                BaseArmorClass = 17,
                Weight = 60,
                MaxAbilityModifier = 0,
                AppliesAbilityModifier = false,
                DisadvantageOnStealth = true,
                Cost = 200
            },
            new WearableArmor
            {
                Id = WearableArmorsId["PlateArmor"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Heavy"],
                RequiredAbilityScoreId = AbilitiesScoreId["STR"],
                ArmorClassAbilityScoreModifierId = null,
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Armadura de Placas",
                BaseArmorClass = 18,
                Weight = 65,
                MaxAbilityModifier = 0,
                AppliesAbilityModifier = false,
                DisadvantageOnStealth = true,
                Cost = 1500
            },
            // Shield
            new WearableArmor
            {
                Id = WearableArmorsId["Shield"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Shield"],
                RequiredAbilityScoreId = null,
                ArmorClassAbilityScoreModifierId = null,
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Escudo",
                BaseArmorClass = 2,
                Weight = 6,
                MaxAbilityModifier = 0,
                AppliesAbilityModifier = false,
                DisadvantageOnStealth = false,
                Cost = 10
            },
        ];
    }

    public override IEnumerable<ShieldArmor> GetShieldArmors()
    {
        return [
            new ShieldArmor
            {
                Id = ShieldArmorsId["Shield"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                ArmorCategoryId = ArmorCategoriesId["Shield"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                RequiredAbilityScoreId = null,
                Name = "Escudo",
                Weight= 6,
                Cost = 10,
                ArmorClassBonus = 2,
                DisadvantageOnStealth = false,
                RequiredAbilityScoreMinimum = 0,                
            },
        ];
    }
}