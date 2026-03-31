import { Component, computed, inject, output, signal } from '@angular/core';
import { ABILITY_FULL_LABEL, ABILITY_KEYS, ABILITY_LABEL, AbilityKey, AbilityMethod, abilityModifier, formatModifier, POINT_COST, profBonus, Skill, STANDARD_ARRAY } from '../../models/character-creation.models';
import { CharacterCreationService } from '../../helpers/services/character-creation/character-creation.service';
import { CharacterDraftService } from '../../helpers/services/character-draft/character-draft.service';
import { CommonModule, KeyValuePipe } from '@angular/common';
import { SkillNamesPipe } from '../../helpers/pipes/skill-names.pipe';

interface AbilityVM {
  key: AbilityKey;
  label: string;
  fullLabel: string;
  base: number;
  bonus: number;
  total: number;
  mod: number;
  modStr: string;
  canInc: boolean;
  canDec: boolean;
}

@Component({
  selector: 'rpg-step-alignment',
  standalone: true,
  imports: [CommonModule, KeyValuePipe, SkillNamesPipe],
  templateUrl: './step-alignment.component.html',
  styleUrl: './step-alignment.component.scss'
})
export class StepAlignmentComponent {
  readonly next = output<void>();
  readonly prev = output<void>();

  // Skills
  protected readonly classSkills = signal<Skill[]>([]);
  protected readonly loadingSkills = signal(false);
  protected readonly errorSkills = signal<string | null>(null);
  protected readonly skillToast = signal<string | null>(null);

  // Standard array — tracks which value was assigned to which key
  protected readonly standardAssigned = signal<Partial<Record<AbilityKey, number>>>({});

  readonly #api = inject(CharacterCreationService);
  readonly #draft = inject(CharacterDraftService);

  protected readonly draft = this.#draft.draft;
  protected readonly pointsLeft = this.#draft.pointsLeft;
  protected readonly finalAbils = this.#draft.finalAbilities;

  // Use reactive computed from service instead of draft().chosenSkills.size directly
  protected readonly chosenSkillsCount = this.#draft.chosenSkillsCount;
  protected readonly backgroundSkillsCount = this.#draft.backgroundSkillsCount;

  // ── Computed view models ─────────────────────────────────
  protected readonly abilities = computed<AbilityVM[]>(() => {
    const d = this.draft();
    const finals = this.finalAbils();
    const method = d.abilityMethod;
    const left = this.pointsLeft();

    return ABILITY_KEYS.map(key => {
      const base = d.baseAbilities[key];
      const bonus = d.species?.abilityBonuses?.[key] ?? 0;
      const total = finals[key];
      const mod = abilityModifier(total);

      const maxBase = method === 'roll' ? 18 : 15;
      const canDec = base > 8;
      const canInc = base < maxBase &&
        (method !== 'pointBuy' || left - (POINT_COST[base + 1] ?? 99) + (POINT_COST[base] ?? 0) >= 0);

      return {
        key, label: ABILITY_LABEL[key], fullLabel: ABILITY_FULL_LABEL[key],
        base, bonus, total, mod, modStr: formatModifier(mod), canInc, canDec,
      };
    });
  });

  protected readonly proficiencyBonus = computed(() =>
    profBonus(this.draft().level)
  );

  protected readonly skillVMs = computed(() => {
    const d = this.draft();
    const pb = profBonus(d.level);
    // Access chosenSkillsCount so computed re-runs when skills change
    void this.chosenSkillsCount();

    return this.classSkills().map(skill => {
      const fromBg = d.backgroundSkills.has(skill.id);
      const chosen = d.chosenSkills.has(skill.id);
      const abMod = abilityModifier(this.finalAbils()[skill.ability] ?? 10);
      const total = fromBg || chosen ? abMod + pb : abMod;
      return { ...skill, fromBg, chosen, total, totalStr: formatModifier(total) };
    });
  });

  // protected readonly maxSkills = computed(() => this.draft().class?.skillChoices ?? 2);

  // ── Lifecycle ────────────────────────────────────────────
  ngOnInit(): void {
    this.loadSkills();
  }

  private loadSkills(): void {
    const classId = this.draft().class;
    if (!classId) return;

    this.loadingSkills.set(true);
    this.#api.getClassSkills(classId).subscribe({
      next: data => { this.classSkills.set(data); this.loadingSkills.set(false); },
      error: err => { this.errorSkills.set(err.message); this.loadingSkills.set(false); },
    });
  }

  // ── Method switch ────────────────────────────────────────
  protected setMethod(m: AbilityMethod): void {
    this.#draft.setAbilityMethod(m);
    this.standardAssigned.set({});
  }

  // ── Point Buy / Roll ─────────────────────────────────────
  protected adjust(key: AbilityKey, delta: number): void {
    const cur = this.draft().baseAbilities[key];
    const next = cur + delta;
    const method = this.draft().abilityMethod;

    if (next < 8) return;
    if (method === 'roll' && next > 18) return;
    if (method === 'pointBuy' && next > 15) return;

    if (method === 'pointBuy') {
      const cost = (POINT_COST[next] ?? 99) - (POINT_COST[cur] ?? 0);
      if (cost > this.pointsLeft()) {
        this.showToast('⚠️ Pontos insuficientes.');
        return;
      }
    }

    this.#draft.setAbility(key, next);
  }

  // ── Standard Array ───────────────────────────────────────
  protected assignStd(key: AbilityKey, value: number): void {
    const assigned = { ...this.standardAssigned() };
    if (value === 0) {
      delete assigned[key];
      this.#draft.setAbility(key, 8);
    } else {
      assigned[key] = value;
      this.#draft.setAbility(key, value);
    }
    this.standardAssigned.set(assigned);
  }

  protected stdValueUsed(value: number, forKey: AbilityKey): boolean {
    return Object.entries(this.standardAssigned())
      .some(([k, v]) => v === value && k !== forKey);
  }

  // ── Roll ─────────────────────────────────────────────────
  protected readonly rolling = signal(false);

  protected rollAll(): void {
    this.rolling.set(true);
    setTimeout(() => {
      const rolled = {} as Record<AbilityKey, number>;
      ABILITY_KEYS.forEach(k => {
        const dice = Array.from({ length: 4 }, () => Math.ceil(Math.random() * 6));
        dice.sort((a, b) => a - b);
        rolled[k] = dice[1] + dice[2] + dice[3];
      });
      this.#draft.setAllAbilities(rolled);
      this.rolling.set(false);
    }, 420);
  }

  // ── Skills ───────────────────────────────────────────────
  protected toggleSkill(skillId: string): void {
    // const ok = this.#draft.toggleSkill(skillId, this.maxSkills());
    // if (!ok) this.showToast(`⚠️ Limite de ${this.maxSkills()} perícias atingido.`);
  }

  protected handleSkillClick(skillId: string, locked: boolean): void {
    if (locked) return;
    this.toggleSkill(skillId);
  }

  private showToast(msg: string): void {
    this.skillToast.set(msg);
    setTimeout(() => this.skillToast.set(null), 2800);
  }

  // ── Navigation ───────────────────────────────────────────
  protected onNext(): void { this.next.emit(); }
  protected onPrev(): void { this.prev.emit(); }

  // ── Template helpers ─────────────────────────────────────
  protected readonly ABILITY_KEYS = ABILITY_KEYS;
  protected readonly STANDARD_ARRAY = STANDARD_ARRAY;
  protected readonly methodOptions: { value: AbilityMethod; label: string }[] = [
    { value: 'standard', label: '📋 Array Padrão' },
    { value: 'pointBuy', label: '🪙 Point Buy' },
    { value: 'roll', label: '🎲 Rolar Dados' },
  ];
}
