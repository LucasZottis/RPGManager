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
             //CP → *
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["CP"], ToCurrencyTypeId = CurrencyTypesId["SP"], Rate = 0.1m   },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["CP"], ToCurrencyTypeId = CurrencyTypesId["EP"], Rate = 0.02m  },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["CP"], ToCurrencyTypeId = CurrencyTypesId["GP"], Rate = 0.01m  },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["CP"], ToCurrencyTypeId = CurrencyTypesId["PP"], Rate = 0.001m },

             //SP → *
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["SP"], ToCurrencyTypeId = CurrencyTypesId["CP"], Rate = 10m },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["SP"], ToCurrencyTypeId = CurrencyTypesId["EP"], Rate = 0.2m },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["SP"], ToCurrencyTypeId = CurrencyTypesId["GP"], Rate = 0.1m },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["SP"], ToCurrencyTypeId = CurrencyTypesId["PP"], Rate = 0.01m },

             //EP → *
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["EP"], ToCurrencyTypeId = CurrencyTypesId["CP"], Rate = 50m    },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["EP"], ToCurrencyTypeId = CurrencyTypesId["SP"], Rate = 5m     },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["EP"], ToCurrencyTypeId = CurrencyTypesId["GP"], Rate = 0.5m   },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["EP"], ToCurrencyTypeId = CurrencyTypesId["PP"], Rate = 0.05m  },

             //GP → *
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["GP"], ToCurrencyTypeId = CurrencyTypesId["CP"], Rate = 100m   },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["GP"], ToCurrencyTypeId = CurrencyTypesId["SP"], Rate = 10m    },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["GP"], ToCurrencyTypeId = CurrencyTypesId["EP"], Rate = 2m     },
            new CurrencyConversionRate { FromCurrencyTypeId = CurrencyTypesId["GP"], ToCurrencyTypeId = CurrencyTypesId["PP"], Rate = 0.1m   },

             //PP → *
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
             //Standard
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
             //Rare
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

    public override IEnumerable<WeaponCategory> GetWeaponCategories()
    {
        return
        [
            new WeaponCategory { Id = WeaponCategoriesId["Simple"],  GameSystemVersionId = GameSystemVersionsId["521"], Name = "Simples"  },
            new WeaponCategory { Id = WeaponCategoriesId["Martial"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "Marcial"  },
        ];
    }

    public override IEnumerable<WeaponMasteryProperty> GetWeaponMasteryProperties()
    {
        return
        [
            new WeaponMasteryProperty { Id = WeaponMasteryPropertiesId["Cleave"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "Corte",       Description = "Se você acertar uma criatura com um ataque corpo a corpo usando esta arma, pode fazer outro ataque corpo a corpo contra uma segunda criatura a até 1,5 m da primeira e dentro do seu alcance. No acerto, a segunda criatura sofre o dano da arma, sem adicionar o modificador de habilidade, a menos que seja negativo." },
            new WeaponMasteryProperty { Id = WeaponMasteryPropertiesId["Graze"],  GameSystemVersionId = GameSystemVersionsId["521"], Name = "Raspão",      Description = "Se o seu ataque com esta arma errar uma criatura, você pode causar dano igual ao modificador de habilidade usado no ataque. O tipo de dano é o mesmo da arma." },
            new WeaponMasteryProperty { Id = WeaponMasteryPropertiesId["Nick"],   GameSystemVersionId = GameSystemVersionsId["521"], Name = "Golpe Extra", Description = "Ao realizar o ataque extra concedido pela propriedade Leve, você pode fazê-lo como parte da ação de Ataque em vez de uma Ação Bônus." },
            new WeaponMasteryProperty { Id = WeaponMasteryPropertiesId["Push"],   GameSystemVersionId = GameSystemVersionsId["521"], Name = "Empurrão",    Description = "Se você acertar uma criatura com esta arma, pode empurrá-la até 3 m diretamente para longe de você, se ela for Grande ou menor." },
            new WeaponMasteryProperty { Id = WeaponMasteryPropertiesId["Sap"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Atordoar",    Description = "Se você acertar uma criatura com esta arma, ela tem Desvantagem no próximo ataque antes do início do seu próximo turno." },
            new WeaponMasteryProperty { Id = WeaponMasteryPropertiesId["Slow"],   GameSystemVersionId = GameSystemVersionsId["521"], Name = "Lentidão",    Description = "Se você acertar e causar dano com esta arma, pode reduzir a Velocidade do alvo em 3 m até o início do seu próximo turno. Múltiplos acertos não acumulam a redução além de 3 m." },
            new WeaponMasteryProperty { Id = WeaponMasteryPropertiesId["Topple"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "Derrubar",    Description = "Se você acertar uma criatura com esta arma, pode forçá-la a realizar um teste de resistência de Constituição (CD 8 + modificador de habilidade + bônus de proficiência). Em caso de falha, a criatura fica Prostrada." },
            new WeaponMasteryProperty { Id = WeaponMasteryPropertiesId["Vex"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Irritar",     Description = "Se você acertar e causar dano a uma criatura com esta arma, tem Vantagem no próximo ataque contra ela antes do fim do seu próximo turno." },
        ];
    }

    public override IEnumerable<WeaponProperty> GetWeaponProperties()
    {
        return
        [
            new WeaponProperty { Id = WeaponPropertiesId["Ammunition"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "Munição",        Description = "Você pode usar uma arma com a propriedade Munição para fazer um ataque à distância somente se tiver munição para disparar. Cada ataque consome uma peça de munição. Após o combate, você pode gastar 1 minuto para recuperar metade da munição usada.",                                                                                              HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["Finesse"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Acuidade",       Description = "Ao atacar com uma arma de Acuidade, use sua escolha entre o modificador de Força ou Destreza para as jogadas de ataque e dano. Você deve usar o mesmo modificador para ambas.",                                                                                                                             AlternativeAbilityScoreId = AbilitiesScoreId["DEX"], HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["Heavy"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Pesada",         Description = "Você tem Desvantagem em jogadas de ataque com uma arma Pesada se for corpo a corpo e sua Força for menor que 13, ou se for à distância e sua Destreza for menor que 13.",                                                                                                                                HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["Light"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Leve",           Description = "Ao realizar a ação de Ataque com uma arma Leve, você pode fazer um ataque extra como Ação Bônus com uma arma Leve diferente. Você não adiciona o modificador de habilidade ao dano do ataque bônus, a menos que seja negativo.",                                                                          HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["Loading"],    GameSystemVersionId = GameSystemVersionsId["521"], Name = "Carregamento",   Description = "Você pode disparar apenas uma peça de munição de uma arma com Carregamento ao usar uma ação, Ação Bônus ou Reação, independentemente do número de ataques que normalmente pode fazer.",                                                                                                                   HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["Range"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Alcance",        Description = "Uma arma com a propriedade Alcance lista dois números entre parênteses: o alcance normal e o alcance longo. Atacar além do alcance normal impõe Desvantagem. Você não pode atacar além do alcance longo.",                                                                                                  HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["Reach"],      GameSystemVersionId = GameSystemVersionsId["521"], Name = "Longo Alcance",  Description = "Uma arma com Longo Alcance adiciona 1,5 m ao seu alcance ao atacar com ela, inclusive para Ataques de Oportunidade.",                                                                                                                                                                                     HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["Thrown"],     GameSystemVersionId = GameSystemVersionsId["521"], Name = "Arremessável",   Description = "Se uma arma tem a propriedade Arremessável, você pode arremessá-la para fazer um ataque à distância. Se for uma arma corpo a corpo, use o mesmo modificador de habilidade do ataque corpo a corpo.",                                                                                                       HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["TwoHanded"],  GameSystemVersionId = GameSystemVersionsId["521"], Name = "Duas Mãos",      Description = "Uma arma com Duas Mãos requer as duas mãos para atacar com ela.",                                                                                                                                                                                                                                         HasAlternativeDiceTypeDamage = false },
            new WeaponProperty { Id = WeaponPropertiesId["Versatile"],  GameSystemVersionId = GameSystemVersionsId["521"], Name = "Versátil",       Description = "Uma arma Versátil pode ser usada com uma ou duas mãos. Um valor de dano entre parênteses indica o dano ao usar com duas mãos em um ataque corpo a corpo.",                                                                                                                                                 HasAlternativeDiceTypeDamage = true  },
        ];
    }

    public override IEnumerable<WeaponType> GetWeaponTypes()
    {
        return
        [
            new WeaponType { Id = WeaponTypesId["Melee"],  GameSystemVersionId = GameSystemVersionsId["521"], Name = "Corpo a Corpo" },
            new WeaponType { Id = WeaponTypesId["Ranged"], GameSystemVersionId = GameSystemVersionsId["521"], Name = "À Distância"   },
        ];
    }

    public override IEnumerable<Weapon> GetWeapons()
    {
        return
        [
            new Weapon { Id = WeaponsId["Club"],          GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["SP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Slow"],   Name = "Clava",              Cost = 1,   Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Dagger"],        GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Nick"],   Name = "Adaga",              Cost = 2,   Weight = 0.45f },
            new Weapon { Id = WeaponsId["Greatclub"],     GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["SP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Push"],   Name = "Clava Grande",       Cost = 2,   Weight = 4.5f  },
            new Weapon { Id = WeaponsId["Handaxe"],       GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Vex"],    Name = "Machadinha",         Cost = 5,   Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Javelin"],       GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["SP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Slow"],   Name = "Dardo de Arremesso", Cost = 5,   Weight = 0.9f  },
            new Weapon { Id = WeaponsId["LightHammer"],   GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Nick"],   Name = "Martelo Leve",       Cost = 2,   Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Mace"],          GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Sap"],    Name = "Maça",               Cost = 5,   Weight = 1.8f  },
            new Weapon { Id = WeaponsId["Quarterstaff"],  GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["SP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Topple"], Name = "Bastão",             Cost = 2,   Weight = 1.8f  },
            new Weapon { Id = WeaponsId["Sickle"],        GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Nick"],   Name = "Foice",              Cost = 1,   Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Spear"],         GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Sap"],    Name = "Lança",              Cost = 1,   Weight = 1.35f },
            new Weapon { Id = WeaponsId["Dart"],          GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["CP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Vex"],    Name = "Dardo",              Cost = 5,   Weight = 0.11f,},
            new Weapon { Id = WeaponsId["LightCrossbow"], GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Slow"],   Name = "Besta Leve",         Cost = 25,  Weight = 2.25f,},
            new Weapon { Id = WeaponsId["Shortbow"],      GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Vex"],    Name = "Arco Curto",         Cost = 25,  Weight = 0.9f, },
            new Weapon { Id = WeaponsId["Sling"],         GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Simple"],  WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["SP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Slow"],   Name = "Funda",              Cost = 1,   Weight = 0,    },
            new Weapon { Id = WeaponsId["Battleaxe"],     GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Topple"], Name = "Machado de Batalha", Cost = 10,  Weight = 1.8f  },
            new Weapon { Id = WeaponsId["Flail"],         GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Sap"],    Name = "Mangual",            Cost = 10,  Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Glaive"],        GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Graze"],  Name = "Glaive",             Cost = 20,  Weight = 2.7f  },
            new Weapon { Id = WeaponsId["Greataxe"],      GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Cleave"], Name = "Machado Grande",     Cost = 30,  Weight = 3.15f },
            new Weapon { Id = WeaponsId["Greatsword"],    GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Graze"],  Name = "Espadão",            Cost = 50,  Weight = 2.7f  },
            new Weapon { Id = WeaponsId["Halberd"],       GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Cleave"], Name = "Alabarda",           Cost = 20,  Weight = 2.7f  },
            new Weapon { Id = WeaponsId["Lance"],         GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Topple"], Name = "Lança de Cavalaria", Cost = 10,  Weight = 2.7f  },
            new Weapon { Id = WeaponsId["Longsword"],     GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Sap"],    Name = "Espada Longa",       Cost = 15,  Weight = 1.35f },
            new Weapon { Id = WeaponsId["Maul"],          GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Topple"], Name = "Malho",              Cost = 10,  Weight = 4.5f  },
            new Weapon { Id = WeaponsId["Morningstar"],   GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Sap"],    Name = "Estrela da Manhã",   Cost = 15,  Weight = 1.8f  },
            new Weapon { Id = WeaponsId["Pike"],          GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Push"],   Name = "Pique",              Cost = 5,   Weight = 8.1f  },
            new Weapon { Id = WeaponsId["Rapier"],        GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Vex"],    Name = "Rapieira",           Cost = 25,  Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Scimitar"],      GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Nick"],   Name = "Cimitarra",          Cost = 25,  Weight = 1.35f },
            new Weapon { Id = WeaponsId["Shortsword"],    GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Vex"],    Name = "Espada Curta",       Cost = 10,  Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Trident"],       GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Topple"], Name = "Tridente",           Cost = 5,   Weight = 1.8f  },
            new Weapon { Id = WeaponsId["Warhammer"],     GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Push"],   Name = "Martelo de Guerra",  Cost = 15,  Weight = 2.25f },
            new Weapon { Id = WeaponsId["WarPick"],       GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Sap"],    Name = "Picareta de Guerra", Cost = 5,   Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Whip"],          GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Melee"],  BaseAbilityScoreId = AbilitiesScoreId["STR"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Slow"],   Name = "Chicote",            Cost = 2,   Weight = 0.9f  },
            new Weapon { Id = WeaponsId["Blowgun"],       GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Vex"],    Name = "Zarabatana",         Cost = 10,  Weight = 0.45f,},
            new Weapon { Id = WeaponsId["HandCrossbow"],  GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Vex"],    Name = "Besta de Mão",       Cost = 75,  Weight = 1.35f,},
            new Weapon { Id = WeaponsId["HeavyCrossbow"], GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Push"],   Name = "Besta Pesada",       Cost = 50,  Weight = 8.1f, },
            new Weapon { Id = WeaponsId["Longbow"],       GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Slow"],   Name = "Arco Longo",         Cost = 50,  Weight = 0.9f, },
            new Weapon { Id = WeaponsId["Musket"],        GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Slow"],   Name = "Mosquete",           Cost = 500, Weight = 4.5f, },
            new Weapon { Id = WeaponsId["Pistol"],        GameSystemVersionId = GameSystemVersionsId["521"], WeaponCategoryId = WeaponCategoriesId["Martial"], WeaponTypeId = WeaponTypesId["Ranged"], BaseAbilityScoreId = AbilitiesScoreId["DEX"], CostCurrencyTypeId = CurrencyTypesId["GP"], WeaponMasteryPropertyId = WeaponMasteryPropertiesId["Vex"],    Name = "Pistola",            Cost = 250, Weight = 1.35f,},
        ];
    }

    public override IEnumerable<WeaponDamage> GetWeaponDamages()
    {
        return
        [
            new WeaponDamage { WeaponId = WeaponsId["Club"],          DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D4"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Dagger"],        DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D4"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Greatclub"],     DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Handaxe"],       DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Javelin"],       DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["LightHammer"],   DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D4"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Mace"],          DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Quarterstaff"],  DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Quarterstaff"],  DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Sickle"],        DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D4"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Spear"],         DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Spear"],         DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Dart"],          DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D4"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["LightCrossbow"], DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Shortbow"],      DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Sling"],         DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D4"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Battleaxe"],     DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Battleaxe"],     DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Flail"],         DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Glaive"],        DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Greataxe"],      DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D12"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Greatsword"],    DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 2 },
            new WeaponDamage { WeaponId = WeaponsId["Halberd"],       DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Lance"],         DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Longsword"],     DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Longsword"],     DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Maul"],          DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 2 },
            new WeaponDamage { WeaponId = WeaponsId["Morningstar"],   DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Pike"],          DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Rapier"],        DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Scimitar"],      DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Shortsword"],    DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Trident"],       DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Trident"],       DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Warhammer"],     DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Warhammer"],     DamageTypeId = DamageTypesId["Bludgeoning"], DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["WarPick"],       DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["WarPick"],       DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Whip"],          DamageTypeId = DamageTypesId["Slashing"],    DiceTypeId = DiceTypesId["D4"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Blowgun"],       DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D4"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["HandCrossbow"],  DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D6"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["HeavyCrossbow"], DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Longbow"],       DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D8"],  DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Musket"],        DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D12"], DiceQuantity = 1 },
            new WeaponDamage { WeaponId = WeaponsId["Pistol"],        DamageTypeId = DamageTypesId["Piercing"],    DiceTypeId = DiceTypesId["D10"], DiceQuantity = 1 },
        ];
    }

    public override IEnumerable<WeaponPropertyAttribute> GetWeaponPropertyAttributes()
    {
        return
        [
            // Club
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Club"],          WeaponPropertyId = WeaponPropertiesId["Light"] },
            // Dagger
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Dagger"],        WeaponPropertyId = WeaponPropertiesId["Finesse"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Dagger"],        WeaponPropertyId = WeaponPropertiesId["Light"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Dagger"],        WeaponPropertyId = WeaponPropertiesId["Thrown"],     NormalRange = 6,    LongRange = 18  },
            // Greatclub
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Greatclub"],     WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Handaxe
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Handaxe"],       WeaponPropertyId = WeaponPropertiesId["Light"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Handaxe"],       WeaponPropertyId = WeaponPropertiesId["Thrown"],     NormalRange = 6,    LongRange = 18  },
            // Javelin
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Javelin"],       WeaponPropertyId = WeaponPropertiesId["Thrown"],     NormalRange = 9,    LongRange = 36  },
            // LightHammer
            new WeaponPropertyAttribute { WeaponId = WeaponsId["LightHammer"],   WeaponPropertyId = WeaponPropertiesId["Light"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["LightHammer"],   WeaponPropertyId = WeaponPropertiesId["Thrown"],     NormalRange = 6,    LongRange = 18  },
            // Quarterstaff
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Quarterstaff"],  WeaponPropertyId = WeaponPropertiesId["Versatile"] },
            // Sickle
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Sickle"],        WeaponPropertyId = WeaponPropertiesId["Light"] },
            // Spear
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Spear"],         WeaponPropertyId = WeaponPropertiesId["Thrown"],     NormalRange = 6,    LongRange = 18  },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Spear"],         WeaponPropertyId = WeaponPropertiesId["Versatile"] },
            // Dart
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Dart"],          WeaponPropertyId = WeaponPropertiesId["Finesse"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Dart"],          WeaponPropertyId = WeaponPropertiesId["Thrown"],     NormalRange = 6,    LongRange = 18  },
            // LightCrossbow
            new WeaponPropertyAttribute { WeaponId = WeaponsId["LightCrossbow"], WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 24,   LongRange = 96  },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["LightCrossbow"], WeaponPropertyId = WeaponPropertiesId["Loading"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["LightCrossbow"], WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Shortbow
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Shortbow"],      WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 24,   LongRange = 96  },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Shortbow"],      WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Sling
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Sling"],         WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 9,    LongRange = 36  },
            // Battleaxe
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Battleaxe"],     WeaponPropertyId = WeaponPropertiesId["Versatile"] },
            // Glaive
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Glaive"],        WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Glaive"],        WeaponPropertyId = WeaponPropertiesId["Reach"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Glaive"],        WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Greataxe
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Greataxe"],      WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Greataxe"],      WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Greatsword
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Greatsword"],    WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Greatsword"],    WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Halberd
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Halberd"],       WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Halberd"],       WeaponPropertyId = WeaponPropertiesId["Reach"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Halberd"],       WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Lance
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Lance"],         WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Lance"],         WeaponPropertyId = WeaponPropertiesId["Reach"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Lance"],         WeaponPropertyId = WeaponPropertiesId["TwoHanded"],  Remarks = "A menos que esteja montado" },
            // Longsword
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Longsword"],     WeaponPropertyId = WeaponPropertiesId["Versatile"] },
            // Maul
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Maul"],          WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Maul"],          WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Pike
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Pike"],          WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Pike"],          WeaponPropertyId = WeaponPropertiesId["Reach"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Pike"],          WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Rapier
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Rapier"],        WeaponPropertyId = WeaponPropertiesId["Finesse"] },
            // Scimitar
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Scimitar"],      WeaponPropertyId = WeaponPropertiesId["Finesse"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Scimitar"],      WeaponPropertyId = WeaponPropertiesId["Light"] },
            // Shortsword
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Shortsword"],    WeaponPropertyId = WeaponPropertiesId["Finesse"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Shortsword"],    WeaponPropertyId = WeaponPropertiesId["Light"] },
            // Trident
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Trident"],       WeaponPropertyId = WeaponPropertiesId["Thrown"],     NormalRange = 6,    LongRange = 18  },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Trident"],       WeaponPropertyId = WeaponPropertiesId["Versatile"] },
            // Warhammer
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Warhammer"],     WeaponPropertyId = WeaponPropertiesId["Versatile"] },
            // WarPick
            new WeaponPropertyAttribute { WeaponId = WeaponsId["WarPick"],       WeaponPropertyId = WeaponPropertiesId["Versatile"] },
            // Whip
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Whip"],          WeaponPropertyId = WeaponPropertiesId["Finesse"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Whip"],          WeaponPropertyId = WeaponPropertiesId["Reach"] },
            // Blowgun
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Blowgun"],       WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 7.5f, LongRange = 30  },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Blowgun"],       WeaponPropertyId = WeaponPropertiesId["Loading"] },
            // HandCrossbow
            new WeaponPropertyAttribute { WeaponId = WeaponsId["HandCrossbow"],  WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 9,    LongRange = 36  },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["HandCrossbow"],  WeaponPropertyId = WeaponPropertiesId["Light"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["HandCrossbow"],  WeaponPropertyId = WeaponPropertiesId["Loading"] },
            // HeavyCrossbow
            new WeaponPropertyAttribute { WeaponId = WeaponsId["HeavyCrossbow"], WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 30,   LongRange = 120 },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["HeavyCrossbow"], WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["HeavyCrossbow"], WeaponPropertyId = WeaponPropertiesId["Loading"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["HeavyCrossbow"], WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Longbow
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Longbow"],       WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 45,   LongRange = 180 },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Longbow"],       WeaponPropertyId = WeaponPropertiesId["Heavy"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Longbow"],       WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Musket
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Musket"],        WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 12,   LongRange = 36  },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Musket"],        WeaponPropertyId = WeaponPropertiesId["Loading"] },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Musket"],        WeaponPropertyId = WeaponPropertiesId["TwoHanded"] },
            // Pistol
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Pistol"],        WeaponPropertyId = WeaponPropertiesId["Ammunition"], NormalRange = 9,    LongRange = 27  },
            new WeaponPropertyAttribute { WeaponId = WeaponsId["Pistol"],        WeaponPropertyId = WeaponPropertiesId["Loading"] },
        ];
    }

    public override IEnumerable<Gear> GetGears()
    {
        return
        [
            new Gear { Id = GearsId["Acid"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Ácido",                  Description = "Ao realizar a ação de Ataque, você pode substituir um de seus ataques por arremessar um frasco de Ácido. Alvo: uma criatura ou objeto visível a até 6 m. O alvo deve ser bem-sucedido em um teste de resistência de Destreza (CD 8 + modificador de Destreza + bônus de proficiência) ou sofre 2d6 de dano de Ácido.", Weight = 0.45f, Cost = 25  },
            new Gear { Id = GearsId["AlchemistsFire"],   GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Fogo de Alquimista",      Description = "Ao realizar a ação de Ataque, você pode substituir um de seus ataques por arremessar um frasco de Fogo de Alquimista. Alvo: uma criatura ou objeto visível a até 6 m. O alvo deve ser bem-sucedido em um teste de resistência de Destreza (CD 8 + modificador de Destreza + bônus de proficiência) ou sofre 1d4 de dano de Fogo e começa a queimar.", Weight = 0.45f, Cost = 50  },
            new Gear { Id = GearsId["Antitoxin"],        GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Antitoxina",              Description = "Uma criatura que bebe este frasco de líquido tem Vantagem em testes de resistência contra veneno por 1 hora. Não beneficia Construtos ou Mortos-Vivos.",                                                                                                                                                                                                      Weight = 0,     Cost = 50  },
            new Gear { Id = GearsId["Backpack"],         GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Mochila",                 Description = "Uma Mochila comporta até 13,5 kg dentro de 0,03 m³. Também pode servir como alforje.",                                                                                                                                                                                                                                                                          Weight = 2.27f, Cost = 2   },
            new Gear { Id = GearsId["BallBearings"],     GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Esferas de Aço",          Description = "Como ação de Utilizar, você pode espalhar Esferas de Aço de sua bolsa, cobrindo uma área de 3 m² dentro de 1,5 m. Uma criatura que entrar nessa área pela primeira vez em um turno deve ser bem-sucedida em um teste de resistência de Destreza (CD 10) ou ficará Prostrada. Leva 10 minutos para recolher as esferas.",                                         Weight = 0.9f,  Cost = 1   },
            new Gear { Id = GearsId["Barrel"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Barril",                  Description = "Um Barril comporta até 150 litros de líquido ou até 0,11 m³ de materiais secos.",                                                                                                                                                                                                                                                                               Weight = 31.75f,Cost = 2   },
            new Gear { Id = GearsId["Basket"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Cesto",                   Description = "Um Cesto comporta até 18 kg dentro de 0,06 m³.",                                                                                                                                                                                                                                                                                                                    Weight = 0.9f,  Cost = 4   },
            new Gear { Id = GearsId["Bedroll"],          GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Saco de Dormir",           Description = "Um Saco de Dormir acomoda uma criatura Pequena ou Média. Enquanto estiver em um Saco de Dormir, você automaticamente tem sucesso em testes de resistência contra frio extremo.",                                                                                                                                                                                   Weight = 3.17f, Cost = 1   },
            new Gear { Id = GearsId["Bell"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Sino",                    Description = "Quando tocado como ação de Utilizar, um Sino produz um som que pode ser ouvido a até 18 m.",                                                                                                                                                                                                                                                                       Weight = 0,     Cost = 1   },
            new Gear { Id = GearsId["Blanket"],          GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Manta",                   Description = "Enquanto envolto em uma Manta, você tem Vantagem em testes de resistência contra frio extremo.",                                                                                                                                                                                                                                                                   Weight = 1.36f, Cost = 5   },
            new Gear { Id = GearsId["BlockAndTackle"],   GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Roldana e Polia",         Description = "Uma Roldana e Polia permite içar até quatro vezes o peso que você normalmente consegue levantar.",                                                                                                                                                                                                                                                                  Weight = 2.27f, Cost = 1   },
            new Gear { Id = GearsId["Book"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Livro",                   Description = "Um Livro contém ficção ou não-ficção. Se você consultar um Livro não-ficção preciso sobre seu tema, ganha +5 em testes de Inteligência (Arcanismo, História, Natureza ou Religião) sobre aquele tema.",                                                                                                                                                            Weight = 2.27f, Cost = 25  },
            new Gear { Id = GearsId["BottleGlass"],      GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Garrafa de Vidro",        Description = "Uma Garrafa de Vidro comporta até 0,71 litros.",                                                                                                                                                                                                                                                                                                                    Weight = 0.9f,  Cost = 2   },
            new Gear { Id = GearsId["Bucket"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Balde",                   Description = "Um Balde comporta até 0,014 m³ de conteúdo.",                                                                                                                                                                                                                                                                                                                       Weight = 0.9f,  Cost = 5   },
            new Gear { Id = GearsId["BurglarsPack"],     GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pacote de Ladrão",        Description = "Contém: Mochila, Esferas de Aço, Sino, 10 Velas, Pé de Cabra, Lanterna Encoberta, 7 frascos de Óleo, 5 dias de Rações, Corda, Isqueiro e Cantil.",                                                                                                                                                                                                                Weight = 19.05f,Cost = 16  },
            new Gear { Id = GearsId["Caltrops"],         GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Caltrops",                Description = "Como ação de Utilizar, você pode espalhar Caltrops de seu saco cobrindo uma área de 1,5 m² dentro de 1,5 m. Uma criatura que entrar nessa área pela primeira vez em um turno deve ser bem-sucedida em um teste de resistência de Destreza (CD 15) ou sofre 1 de dano Perfurante e tem sua Velocidade reduzida a 0 até o início de seu próximo turno.",            Weight = 0.9f,  Cost = 1   },
            new Gear { Id = GearsId["Candle"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Vela",                    Description = "Por 1 hora, uma Vela acesa emite Luz Plena em um raio de 1,5 m e Luz Fraca por mais 1,5 m.",                                                                                                                                                                                                                                                                       Weight = 0,     Cost = 1   },
            new Gear { Id = GearsId["CaseCrossbowBolt"], GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Estojo de Virotes",       Description = "Um Estojo de Virotes comporta até 20 Virotes.",                                                                                                                                                                                                                                                                                                                     Weight = 0.45f, Cost = 1   },
            new Gear { Id = GearsId["CaseMapOrScroll"],  GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Estojo de Mapa ou Pergaminho", Description = "Um Estojo de Mapa ou Pergaminho comporta até 10 folhas de papel ou 5 folhas de pergaminho.",                                                                                                                                                                                                                                                                   Weight = 0.45f, Cost = 1   },
            new Gear { Id = GearsId["Chain"],            GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Corrente",                Description = "Como ação de Utilizar, você pode enrolar uma Corrente em torno de uma criatura relutante a até 1,5 m com a condição Agarrada, Incapacitada ou Restrita, se for bem-sucedido em um teste de Força (CD 13). Escapar da Corrente requer um teste de Destreza bem-sucedido (CD 18). Romper a Corrente requer um teste de Força bem-sucedido (CD 20).",               Weight = 4.54f, Cost = 5   },
            new Gear { Id = GearsId["Chest"],            GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Baú",                     Description = "Um Baú comporta até 0,34 m³ de conteúdo.",                                                                                                                                                                                                                                                                                                                          Weight = 11.34f,Cost = 5   },
            new Gear { Id = GearsId["ClimbersKit"],      GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Kit de Escalada",         Description = "Inclui biqueiras, luvas, pitons e arnês. Como ação de Utilizar, você pode se ancorar; ao fazê-lo, não pode cair mais de 7,5 m do ponto de ancoragem e não pode se mover mais de 7,5 m sem desfazer a ancoragem como Ação Bônus.",                                                                                                                                  Weight = 5.44f, Cost = 25  },
            new Gear { Id = GearsId["ClothesFine"],      GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Roupas Finas",            Description = "Roupas Finas são feitas de tecidos caros e adornadas com detalhes elaborados. Alguns eventos e locais admitem apenas pessoas usando essas roupas.",                                                                                                                                                                                                                  Weight = 2.72f, Cost = 15  },
            new Gear { Id = GearsId["ClothesTravelers"], GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Roupas de Viajante",      Description = "Roupas de Viajante são vestes resistentes projetadas para viagens em vários ambientes.",                                                                                                                                                                                                                                                                            Weight = 1.81f, Cost = 2   },
            new Gear { Id = GearsId["ComponentPouch"],   GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Bolsa de Componentes",    Description = "Uma Bolsa de Componentes é à prova d'água e repleta de compartimentos que guardam todos os Componentes Materiais gratuitos de suas magias.",                                                                                                                                                                                                                       Weight = 0.9f,  Cost = 25  },
            new Gear { Id = GearsId["Costume"],          GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Fantasia",                Description = "Enquanto veste uma Fantasia, você tem Vantagem em qualquer teste de habilidade para se passar pela pessoa ou tipo de pessoa que ela representa.",                                                                                                                                                                                                                    Weight = 1.81f, Cost = 5   },
            new Gear { Id = GearsId["Crowbar"],          GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pé de Cabra",             Description = "Usar um Pé de Cabra concede Vantagem em testes de Força onde a alavanca do Pé de Cabra pode ser aplicada.",                                                                                                                                                                                                                                                         Weight = 2.27f, Cost = 2   },
            new Gear { Id = GearsId["DiplomatsPack"],    GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pacote de Diplomata",     Description = "Contém: Baú, Roupas Finas, Tinta, 5 Penas, Lamparina, 2 Estojos de Mapa ou Pergaminho, 4 frascos de Óleo, 5 folhas de Papel, 5 folhas de Pergaminho, Perfume e Isqueiro.",                                                                                                                                                                                        Weight = 17.69f,Cost = 39  },
            new Gear { Id = GearsId["DungeoneersPack"],  GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pacote de Explorador de Masmorras", Description = "Contém: Mochila, Caltrops, Pé de Cabra, 2 frascos de Óleo, 10 dias de Rações, Corda, Isqueiro, 10 Tochas e Cantil.",                                                                                                                                                                                                                                     Weight = 24.95f,Cost = 12  },
            new Gear { Id = GearsId["EntertainersPack"], GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pacote de Artista",       Description = "Contém: Mochila, Saco de Dormir, Sino, Lanterna de Holofote, 3 Fantasias, Espelho, 8 frascos de Óleo, 9 dias de Rações, Isqueiro e Cantil.",                                                                                                                                                                                                                       Weight = 29.03f,Cost = 40  },
            new Gear { Id = GearsId["ExplorersPack"],    GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pacote de Explorador",    Description = "Contém: Mochila, Saco de Dormir, 2 frascos de Óleo, 10 dias de Rações, Corda, Isqueiro, 10 Tochas e Cantil.",                                                                                                                                                                                                                                                      Weight = 22.68f,Cost = 10  },
            new Gear { Id = GearsId["Flask"],            GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Frasco",                  Description = "Um Frasco comporta até 0,47 litros.",                                                                                                                                                                                                                                                                                                                               Weight = 0.45f, Cost = 2   },
            new Gear { Id = GearsId["GrapplingHook"],    GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Gancho de Escalar",       Description = "Como ação de Utilizar, você pode lançar um Gancho de Escalar para ancorar uma corda em uma superfície a até 15 m.",                                                                                                                                                                                                                                                 Weight = 1.81f, Cost = 2   },
            new Gear { Id = GearsId["HealersKit"],       GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Kit de Cura",             Description = "Este kit contém ataduras, unguentos e talas. Como ação de Utilizar, você pode gastar um uso do kit para estabilizar uma criatura com 0 PV sem precisar fazer um teste de Sabedoria (Medicina). O kit tem 10 usos.",                                                                                                                                                Weight = 1.36f, Cost = 5   },
            new Gear { Id = GearsId["HolyWater"],        GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Água Benta",              Description = "Ao realizar a ação de Ataque, você pode substituir um de seus ataques por arremessar um frasco de Água Benta. Alvo: uma criatura visível a até 6 m. O alvo deve ser bem-sucedido em um teste de resistência de Destreza (CD 8 + modificador de Destreza + bônus de proficiência) ou sofre 2d6 de dano Radiante se for um Morto-Vivo ou Demônio.",              Weight = 0.45f, Cost = 25  },
            new Gear { Id = GearsId["HuntersTrap"],      GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Armadilha de Caçador",    Description = "Como ação de Utilizar, você pode colocar esta armadilha no chão. Uma criatura que pisar nela deve ser bem-sucedida em um teste de resistência de Destreza (CD 13) ou sofre 1d4 de dano Perfurante e tem sua Velocidade reduzida a 0. Escapar requer um teste de Força bem-sucedido (CD 13) como ação.",                                                        Weight = 2.27f, Cost = 5   },
            new Gear { Id = GearsId["Ink"],              GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Tinta",                   Description = "A Tinta vem em um frasco de 28 g, que fornece tinta suficiente para escrever cerca de 500 páginas.",                                                                                                                                                                                                                                                               Weight = 0,     Cost = 10  },
            new Gear { Id = GearsId["InkPen"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Pena",                    Description = "Usando Tinta, uma Pena é usada para escrever ou desenhar.",                                                                                                                                                                                                                                                                                                         Weight = 0,     Cost = 2   },
            new Gear { Id = GearsId["Jug"],              GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Jarro",                   Description = "Um Jarro comporta até 3,79 litros.",                                                                                                                                                                                                                                                                                                                                Weight = 0.9f,  Cost = 2   },
            new Gear { Id = GearsId["Ladder"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Escada",                  Description = "Uma Escada tem 3 m de altura. Você deve escalar para subir ou descer.",                                                                                                                                                                                                                                                                                              Weight = 6.8f,  Cost = 1   },
            new Gear { Id = GearsId["Lamp"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Lamparina",               Description = "Uma Lamparina queima Óleo como combustível emitindo Luz Plena em um raio de 4,5 m e Luz Fraca por mais 9 m.",                                                                                                                                                                                                                                                        Weight = 0.45f, Cost = 5   },
            new Gear { Id = GearsId["LanternBullseye"],  GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Lanterna de Holofote",    Description = "Uma Lanterna de Holofote queima Óleo como combustível emitindo Luz Plena em um Cone de 18 m e Luz Fraca por mais 18 m.",                                                                                                                                                                                                                                            Weight = 2.27f, Cost = 10  },
            new Gear { Id = GearsId["LanternHooded"],    GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Lanterna Encoberta",      Description = "Uma Lanterna Encoberta queima Óleo como combustível emitindo Luz Plena em um raio de 9 m e Luz Fraca por mais 9 m. Como Ação Bônus, você pode baixar o capuz, reduzindo a luz a Luz Fraca em um raio de 1,5 m.",                                                                                                                                                   Weight = 1.36f, Cost = 5   },
            new Gear { Id = GearsId["Lock"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Cadeado",                 Description = "Um Cadeado vem com uma chave. Sem a chave, uma criatura pode usar Ferramentas de Ladrão para abrir o cadeado com um teste de Destreza bem-sucedido (CD 15).",                                                                                                                                                                                                      Weight = 0.45f, Cost = 10  },
            new Gear { Id = GearsId["MagnifyingGlass"],  GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Lupa",                    Description = "Uma Lupa concede Vantagem em testes de habilidade para avaliar ou inspecionar um item altamente detalhado.",                                                                                                                                                                                                                                                        Weight = 0,     Cost = 100 },
            new Gear { Id = GearsId["Manacles"],         GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Algemas",                 Description = "Como ação de Utilizar, você pode usar Algemas para prender uma criatura Pequena ou Média relutante a até 1,5 m com condição Agarrada, Incapacitada ou Restrita, se for bem-sucedido em um teste de Destreza (CD 13). Escapar requer um teste de Destreza bem-sucedido (CD 20).",                                                                                Weight = 0.45f, Cost = 2   },
            new Gear { Id = GearsId["Map"],              GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Mapa",                    Description = "Se você consultar um Mapa preciso, ganha +5 em testes de Sabedoria (Sobrevivência) para encontrar o caminho no lugar representado.",                                                                                                                                                                                                                                 Weight = 0,     Cost = 1   },
            new Gear { Id = GearsId["Mirror"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Espelho",                 Description = "Um Espelho de aço portátil é útil para cosméticos pessoais, mas também para espiar por cantos e refletir luz como sinal.",                                                                                                                                                                                                                                          Weight = 0.23f, Cost = 5   },
            new Gear { Id = GearsId["Net"],              GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Rede",                    Description = "Ao realizar a ação de Ataque, você pode substituir um de seus ataques por arremessar uma Rede. Alvo: uma criatura visível a até 4,5 m. A criatura deve ser bem-sucedida em um teste de resistência de Força (CD 10) ou ficará Restrita até ser liberada.",                                                                                                         Weight = 1.36f, Cost = 1   },
            new Gear { Id = GearsId["Oil"],              GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Óleo",                    Description = "O Óleo vem em frascos de 0,47 litros. Como ação de Utilizar, você pode derramar Óleo em torno de si mesmo em um raio de 1,5 m, ou arremessá-lo a até 6 m. O Óleo derramado queima por 2 rodadas se incendiado.",                                                                                                                                                   Weight = 0.45f, Cost = 1   },
            new Gear { Id = GearsId["Paper"],            GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Papel",                   Description = "O Papel de alta qualidade é adequado para escrever e desenhar.",                                                                                                                                                                                                                                                                                                     Weight = 0,     Cost = 2   },
            new Gear { Id = GearsId["Parchment"],        GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Pergaminho",              Description = "O Pergaminho é feito de couro animal tratado e é durável o suficiente para durar séculos.",                                                                                                                                                                                                                                                                         Weight = 0,     Cost = 1   },
            new Gear { Id = GearsId["Perfume"],          GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Perfume",                 Description = "O Perfume vem em um pequeno frasco.",                                                                                                                                                                                                                                                                                                                               Weight = 0,     Cost = 5   },
            new Gear { Id = GearsId["Pole"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Vara",                    Description = "Uma Vara tem 3 m de comprimento.",                                                                                                                                                                                                                                                                                                                                   Weight = 3.63f, Cost = 5   },
            new Gear { Id = GearsId["PotionOfHealing"],  GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Poção de Cura",           Description = "Como ação de Utilizar, você pode beber esta poção ou administrá-la a outra criatura. A criatura recupera 2d4 + 2 PV.",                                                                                                                                                                                                                                              Weight = 0.23f, Cost = 50  },
            new Gear { Id = GearsId["Pouch"],            GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Bolsa",                   Description = "Uma Bolsa comporta até 3 kg dentro de 0,001 m³.",                                                                                                                                                                                                                                                                                                                    Weight = 0.23f, Cost = 5   },
            new Gear { Id = GearsId["Quiver"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Aljava",                  Description = "Uma Aljava comporta até 20 Flechas.",                                                                                                                                                                                                                                                                                                                               Weight = 0.45f, Cost = 1   },
            new Gear { Id = GearsId["RamPortable"],      GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Aríete Portátil",         Description = "Você pode usar um Aríete Portátil para arrombar portas. Ao fazê-lo, ganha +4 em testes de Força para esse fim. Outra criatura pode ajudá-lo, concedendo Vantagem neste teste.",                                                                                                                                                                                     Weight = 17.24f,Cost = 4   },
            new Gear { Id = GearsId["Rations"],          GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Rações",                  Description = "Rações consistem em alimentos secos adequados para viagens longas, incluindo carne seca, frutas secas, biscoitos e nozes.",                                                                                                                                                                                                                                          Weight = 0.45f, Cost = 5   },
            new Gear { Id = GearsId["Robe"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Robe",                    Description = "Um Robe é uma veste longa e fluida.",                                                                                                                                                                                                                                                                                                                                Weight = 1.81f, Cost = 1   },
            new Gear { Id = GearsId["Rope"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Corda",                   Description = "Uma Corda tem 15 m de comprimento. Uma criatura presa por Corda deve fazer um teste de Destreza bem-sucedido (CD 15) como ação para escapar.",                                                                                                                                                                                                                      Weight = 2.27f, Cost = 1   },
            new Gear { Id = GearsId["Sack"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Saco",                    Description = "Um Saco comporta até 13,5 kg dentro de 0,03 m³.",                                                                                                                                                                                                                                                                                                                   Weight = 0.23f, Cost = 1   },
            new Gear { Id = GearsId["ScholarsPack"],     GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pacote de Estudioso",     Description = "Contém: Mochila, Livro, Tinta, Pena, Lamparina, 10 frascos de Óleo, 10 folhas de Pergaminho e Isqueiro.",                                                                                                                                                                                                                                                           Weight = 18.14f,Cost = 40  },
            new Gear { Id = GearsId["Shovel"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pá",                      Description = "Trabalhando por 1 hora, você pode usar uma Pá para cavar um buraco de 1,5 m de cada lado em solo ou material similar.",                                                                                                                                                                                                                                              Weight = 2.27f, Cost = 2   },
            new Gear { Id = GearsId["SignalWhistle"],    GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Apito de Sinalização",    Description = "Quando soprado como ação de Utilizar, um Apito de Sinalização produz um som que pode ser ouvido a até 180 m.",                                                                                                                                                                                                                                                      Weight = 0,     Cost = 5   },
            new Gear { Id = GearsId["SpellScrollCantrip"],GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pergaminho de Magia (Truque)", Description = "Um Pergaminho de Magia contém as palavras de um truque. Se a magia estiver na lista de magias da sua classe, você pode ler o pergaminho e conjurá-la. O pergaminho se desintegra quando a conjuração é completada.",                                                                                                                                           Weight = 0,     Cost = 30  },
            new Gear { Id = GearsId["SpellScrollLevel1"],GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Pergaminho de Magia (Nível 1)", Description = "Um Pergaminho de Magia contém as palavras de uma magia de nível 1. Se a magia estiver na lista de magias da sua classe, você pode ler o pergaminho e conjurá-la. O CD de resistência é 13 e o bônus de ataque é +5. O pergaminho se desintegra quando a conjuração é completada.",                                                                           Weight = 0,     Cost = 50  },
            new Gear { Id = GearsId["SpikesIron"],       GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Estacas de Ferro",        Description = "Estacas de Ferro vêm em pacotes de 10. Como ação de Utilizar, você pode usar um objeto contundente para cravar uma estaca em madeira, terra ou material similar. Você pode fazer isso para trancar uma porta ou prender uma Corda ou Corrente à estaca.",                                                                                                          Weight = 2.27f, Cost = 1   },
            new Gear { Id = GearsId["Spyglass"],         GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Luneta",                  Description = "Objetos vistos através de uma Luneta são ampliados ao dobro de seu tamanho.",                                                                                                                                                                                                                                                                                       Weight = 0.45f, Cost = 1000},
            new Gear { Id = GearsId["String"],           GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Barbante",                Description = "O Barbante tem 3 m de comprimento. Você pode dar um nó nele como ação de Utilizar.",                                                                                                                                                                                                                                                                               Weight = 0,     Cost = 1   },
            new Gear { Id = GearsId["Tent"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Tenda",                   Description = "Uma Tenda acomoda até duas criaturas Pequenas ou Médias.",                                                                                                                                                                                                                                                                                                           Weight = 9.07f, Cost = 2   },
            new Gear { Id = GearsId["Tinderbox"],        GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Isqueiro",                Description = "Um Isqueiro é um pequeno recipiente com pederneira, fuzil e mecha. Usá-lo para acender uma Vela, Lamparina, Lanterna ou Tocha leva uma Ação Bônus. Acender qualquer outro fogo leva 1 minuto.",                                                                                                                                                                    Weight = 0.45f, Cost = 5   },
            new Gear { Id = GearsId["Torch"],            GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["CP"], Name = "Tocha",                   Description = "Uma Tocha queima por 1 hora, emitindo Luz Plena em um raio de 6 m e Luz Fraca por mais 6 m. Ao realizar a ação de Ataque, você pode atacar com a Tocha como arma simples corpo a corpo. No acerto, o alvo sofre 1 de dano de Fogo.",                                                                                                                             Weight = 0.45f, Cost = 1   },
            new Gear { Id = GearsId["Vial"],             GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["GP"], Name = "Vidro",                   Description = "Um Vidro comporta até 0,12 litros.",                                                                                                                                                                                                                                                                                                                                Weight = 0,     Cost = 1   },
            new Gear { Id = GearsId["Waterskin"],        GameSystemVersionId = GameSystemVersionsId["521"], CostCurrencyTypeId = CurrencyTypesId["SP"], Name = "Cantil",                  Description = "Um Cantil comporta até 1,89 litros. Se você não beber água suficiente, corre risco de desidratação.",                                                                                                                                                                                                                                                               Weight = 0.23f, Cost = 2   },
        ];
    }

    // TODO: Add Ammunition Types
    public override IEnumerable<AmmunitionType> GetAmmunitionTypes()
    {
        return [
            new AmmunitionType {
                Id = AmmunitionTypesId["Arrow"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Flecha",
                Weight = 0.05f,
                Cost = 1,
                Amount = 20,
                Storage = "Aljava",
            },

            new AmmunitionType {
                Id = AmmunitionTypesId["Bolt"],
                GameSystemVersionId = GameSystemVersionsId["521"],
                CostCurrencyTypeId = CurrencyTypesId["GP"],
                Name = "Virote",
                Weight = 0.05f,
                Cost = 1,
                Amount = 20,
                Storage = "Case",
            },
        ];
    }

    // TODO: Add Tool Categories
    public override IEnumerable<ToolCategory> GetToolCategories()
    {
        return [];
    }

    // TODO: Add Tools
    public override IEnumerable<Tool> GetTools()
    {
        return [];
    }
}