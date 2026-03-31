/* ─────────────────────────────────────────────────────────────
   character-draft.service.ts
   Signal-based state store for the wizard draft.
   Steps read and mutate the draft through this service.
───────────────────────────────────────────────────────────── */
import { Injectable, signal, computed } from '@angular/core';
import { ABILITY_KEYS, AbilityKey, AbilityMethod, abilityModifier, Alignment, Background, CharacterDraft, emptyDraft, POINT_COST, profBonus, Species } from '../../../models/character-creation.models';
import { CharacterClass } from '../../../models/character-class.model';


@Injectable({ providedIn: 'root' })
export class CharacterDraftService {
  // ── private writable state ──────────────────────────────
  readonly #draft = signal<CharacterDraft>(emptyDraft());

  // ── public read-only surface ────────────────────────────
  readonly draft = this.#draft.asReadonly();

  readonly isComplete = computed(() => {
    const d = this.#draft();
    return !!(d.name && d.class && d.background && d.species && d.alignment);
  });

  readonly pointsLeft = computed(() => {
    const d = this.#draft();
    if (d.abilityMethod !== 'pointBuy') return 27;
    const spent = ABILITY_KEYS.reduce(
      (sum, k) => sum + (POINT_COST[d.baseAbilities[k]] ?? 0), 0
    );
    return 27 - spent;
  });

  readonly finalAbilities = computed(() => {
    const d = this.#draft();
    const result = { ...d.baseAbilities };
    if (d.species) {
      for (const [key, bonus] of Object.entries(d.species.abilityBonuses)) {
        result[key as AbilityKey] = (result[key as AbilityKey] ?? 8) + (bonus ?? 0);
      }
    }
    return result as Record<AbilityKey, number>;
  });

  readonly hitPointsLv1 = computed(() => {
    // const d = this.#draft();
    // const conMod = abilityModifier(this.finalAbilities().Constitution);
    // const die = parseInt(d.class?.hitDie?.replace('d', '') ?? '8');
    // return Math.max(1, die + conMod);
    return 0;
  });

  readonly armorClass = computed(() => {
    const dexMod = abilityModifier(this.finalAbilities().Dexterity);
    return 10 + dexMod;
  });

  readonly initiative = computed(() =>
    abilityModifier(this.finalAbilities().Dexterity)
  );

  readonly proficiencyBonus = computed(() =>
    profBonus(this.#draft().level)
  );

  // Reactive counters for Set sizes (Sets are not tracked by signals directly)
  readonly chosenSkillsCount = computed(() => this.#draft().chosenSkills.size);
  readonly backgroundSkillsCount = computed(() => this.#draft().backgroundSkills.size);

  // ── Step 1 — Class ──────────────────────────────────────
  setClass(cls: CharacterClass): void {
    // this.#draft.update(d => ({
    //   ...d,
    //   class: cls,
    //   chosenSkills: new Set(),       // reset on class change
    // }));
  }

  // ── Step 2 — Origin ─────────────────────────────────────
  setBackground(bg: Background): void {
    this.#draft.update(d => ({
      ...d,
      background: bg,
      backgroundSkills: new Set(bg.skills.map(s => s.id)),
    }));
  }

  setSpecies(sp: Species): void {
    this.#draft.update(d => ({ ...d, species: sp }));
  }

  setLanguages(langs: string[]): void {
    this.#draft.update(d => ({ ...d, languages: langs }));
  }

  // ── Step 3 — Abilities ───────────────────────────────────
  setAbilityMethod(method: AbilityMethod): void {
    this.#draft.update(d => ({
      ...d,
      abilityMethod: method,
      baseAbilities: { Strength: 8, Dexterity: 8, Constitution: 8, Intelligence: 8, Wisdom: 8, Charisma: 8 },
    }));
  }

  setAbility(key: AbilityKey, value: number): void {
    this.#draft.update(d => ({
      ...d,
      baseAbilities: { ...d.baseAbilities, [key]: value },
    }));
  }

  setAllAbilities(values: Record<AbilityKey, number>): void {
    this.#draft.update(d => ({ ...d, baseAbilities: { ...values } }));
  }

  toggleSkill(skillId: string, max: number): boolean {
    const d = this.#draft();
    const skills = new Set(d.chosenSkills);
    if (skills.has(skillId)) {
      skills.delete(skillId);
      this.#draft.update(s => ({ ...s, chosenSkills: skills }));
      return true;
    }
    if (skills.size >= max) return false;  // caller shows the toast
    skills.add(skillId);
    this.#draft.update(s => ({ ...s, chosenSkills: skills }));
    return true;
  }

  // ── Step 4 — Alignment ───────────────────────────────────
  setAlignment(alignment: Alignment): void {
    this.#draft.update(d => ({ ...d, alignment }));
  }

  // ── Step 5 — Details ─────────────────────────────────────
  patchDetails(patch: Partial<Pick<CharacterDraft,
    | 'name' | 'level' | 'age' | 'height' | 'weight'
    | 'eyes' | 'hair' | 'skin'
    | 'personalityTraits' | 'ideals' | 'bonds' | 'flaws'
  >>): void {
    this.#draft.update(d => ({ ...d, ...patch }));
  }

  // ── Reset ────────────────────────────────────────────────
  reset(): void {
    this.#draft.set(emptyDraft());
  }
}