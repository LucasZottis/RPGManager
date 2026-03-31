export interface CharacterClass {
    id: string;
    name: string;
    description: string;
    icon?: string;
    hitDie: string;           // 'd6' | 'd8' | 'd10' | 'd12'
    primaryAbility: string;
    savingThrows: string[];   // ability key names, e.g. ['Strength','Constitution']
    skillChoices: number;
    proficiencies?: string;
    traits?: { id: string; name: string }[];
    tags?: string[];
}