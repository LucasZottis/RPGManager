/* ─────────────────────────────────────────────────────────────
   character-creation.models.ts
   Shared types for all character-creation steps.
   Shape mirrors the API contract — adapt field names if needed.
───────────────────────────────────────────────────────────── */

export interface Species {
    id: string;
    name: string;
    description: string;
    icon?: string;
    speed: number;
    size: string;
    abilityBonuses: Partial<Record<AbilityKey, number>>;
    traits?: { id: string; name: string }[];
    tags?: string[];
}

export interface Background {
    id: string;
    name: string;
    description: string;
    icon?: string;
    feat?: string;
    skills: Skill[];
    languages: string[];
    startingEquipment?: string;
    tags?: string[];
}

export interface Skill {
    id: string;
    name: string;
    ability: AbilityKey;
}

export interface Language {
    id: string;
    name: string;
    typicalSpeakers?: string;
}

export type AbilityKey =
    | 'Strength'
    | 'Dexterity'
    | 'Constitution'
    | 'Intelligence'
    | 'Wisdom'
    | 'Charisma';

export type AbilityMethod = 'standard' | 'roll' | 'pointBuy';

export type Alignment =
    | 'Lawful Good' | 'Neutral Good' | 'Chaotic Good'
    | 'Lawful Neutral' | 'Neutral' | 'Chaotic Neutral'
    | 'Lawful Evil' | 'Neutral Evil' | 'Chaotic Evil';

/** Full wizard state — passed between steps */
export interface CharacterDraft {
    // Step 1 — Class
    class: string | null;

    // Step 2 — Origin
    background: Background | null;
    species: Species | null;
    languages: string[];

    // Step 3 — Abilities
    abilityMethod: AbilityMethod;
    baseAbilities: Record<AbilityKey, number>;
    chosenSkills: Set<string>;   // skill ids chosen by player
    backgroundSkills: Set<string>;   // skill ids granted by background (locked)

    // Step 4 — Alignment
    alignment: Alignment | null;

    // Step 5 — Details
    name: string;
    level: number;
    age?: string;
    height?: string;
    weight?: string;
    eyes?: string;
    hair?: string;
    skin?: string;
    personalityTraits?: string;
    ideals?: string;
    bonds?: string;
    flaws?: string;
}

/** Request payload sent to POST /api/v1/characters */
export interface CharacterCreateRequest {
    name: string;
    level: number;
    alignment: string;
    classId: string;
    backgroundId: string;
    speciesId: string;
    languages: string[];
    abilityScores: Record<AbilityKey, number>;
    abilityMethod: AbilityMethod;
    skillIds: string[];
    personalityTraits?: string;
    ideals?: string;
    bonds?: string;
    flaws?: string;
    age?: string;
    height?: string;
    weight?: string;
    eyes?: string;
    hair?: string;
    skin?: string;
}

export const ABILITY_KEYS: AbilityKey[] = [
    'Strength', 'Dexterity', 'Constitution',
    'Intelligence', 'Wisdom', 'Charisma',
];

export const ABILITY_LABEL: Record<AbilityKey, string> = {
    Strength: 'FOR',
    Dexterity: 'DES',
    Constitution: 'CON',
    Intelligence: 'INT',
    Wisdom: 'SAB',
    Charisma: 'CAR',
};

export const ABILITY_FULL_LABEL: Record<AbilityKey, string> = {
    Strength: 'Força',
    Dexterity: 'Destreza',
    Constitution: 'Constituição',
    Intelligence: 'Inteligência',
    Wisdom: 'Sabedoria',
    Charisma: 'Carisma',
};

export const STANDARD_ARRAY = [15, 14, 13, 12, 10, 8] as const;

export const POINT_COST: Record<number, number> = {
    8: 0, 9: 1, 10: 2, 11: 3, 12: 4, 13: 5, 14: 7, 15: 9,
};

export const ALIGNMENTS: Alignment[] = [
    'Lawful Good', 'Neutral Good', 'Chaotic Good',
    'Lawful Neutral', 'Neutral', 'Chaotic Neutral',
    'Lawful Evil', 'Neutral Evil', 'Chaotic Evil',
];

export const ALIGNMENT_PT: Record<Alignment, string> = {
    'Lawful Good': 'Leal e Bom',
    'Neutral Good': 'Neutro e Bom',
    'Chaotic Good': 'Caótico e Bom',
    'Lawful Neutral': 'Leal e Neutro',
    'Neutral': 'Neutro',
    'Chaotic Neutral': 'Caótico e Neutro',
    'Lawful Evil': 'Leal e Mau',
    'Neutral Evil': 'Neutro e Mau',
    'Chaotic Evil': 'Caótico e Mau',
};

export function profBonus(level: number): number {
    if (level <= 4) return 2;
    if (level <= 8) return 3;
    if (level <= 12) return 4;
    if (level <= 16) return 5;
    return 6;
}

export function abilityModifier(score: number): number {
    return Math.floor((score - 10) / 2);
}

export function formatModifier(mod: number): string {
    return mod >= 0 ? `+${mod}` : `${mod}`;
}

export function emptyDraft(): CharacterDraft {
    return {
        class: null,
        background: null,
        species: null,
        languages: [],
        abilityMethod: 'standard',
        baseAbilities: { Strength: 8, Dexterity: 8, Constitution: 8, Intelligence: 8, Wisdom: 8, Charisma: 8 },
        chosenSkills: new Set(),
        backgroundSkills: new Set(),
        alignment: null,
        name: '',
        level: 1,
    };
}