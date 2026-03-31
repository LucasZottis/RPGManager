import { Component, computed, inject, input, output } from '@angular/core';
import { CharacterDraftService } from '../../helpers/services/character-draft/character-draft.service';
import { ABILITY_KEYS, abilityModifier, ABILITY_LABEL, ABILITY_FULL_LABEL, formatModifier, ALIGNMENT_PT } from '../../models/character-creation.models';

interface AbilitySummaryRow {
  key: string;
  label: string;
  full: string;
  total: number;
  mod: number;
  modStr: string;
  modClass: string;
}

interface MissingItem {
  step: number;
  label: string;
}

@Component({
  selector: 'rpg-step-summary',
  standalone: true,
  imports: [],
  templateUrl: './step-summary.component.html',
  styleUrl: './step-summary.component.scss'
})
export class StepSummaryComponent {
  readonly saving = input.required<boolean>();
  readonly prev = output<void>();
  readonly finish = output<void>();

  readonly #draft = inject(CharacterDraftService);
  protected readonly draft = this.#draft.draft;

  // ── Computed summaries ───────────────────────────────────
  protected readonly abilityRows = computed<AbilitySummaryRow[]>(() => {
    const finals = this.#draft.finalAbilities();
    return ABILITY_KEYS.map(key => {
      const total = finals[key];
      const mod = abilityModifier(total);
      return {
        key,
        label: ABILITY_LABEL[key],
        full: ABILITY_FULL_LABEL[key],
        total,
        mod,
        modStr: formatModifier(mod),
        modClass: mod > 0 ? 'pos' : mod < 0 ? 'neg' : 'zer',
      };
    });
  });

  protected readonly combatStats = computed(() => {
    const d = this.draft();
    const hp = this.#draft.hitPointsLv1();
    const ac = this.#draft.armorClass();
    const pb = this.#draft.proficiencyBonus();
    const ini = formatModifier(this.#draft.initiative());
    return [
      // { label: 'Pontos de Vida (Nível 1)', value: `${hp} (${d.class?.hitDie ?? 'd8'})` },
      // { label: 'Dado de Vida', value: d.class?.hitDie ?? '—' },
      // { label: 'Bônus de Proficiência', value: `+${pb}` },
      // { label: 'Classe de Armadura', value: `${ac}` },
      // { label: 'Iniciativa', value: ini },
      // { label: 'Velocidade', value: d.species?.speed ? `${d.species.speed} ft` : '30 ft' },
    ];
  });

  protected readonly proficientSkills = computed(() => {
    const d = this.draft();
    return [
      ...Array.from(d.backgroundSkills),
      ...Array.from(d.chosenSkills),
    ];
  });

  protected readonly missing = computed<MissingItem[]>(() => {
    const d = this.draft();
    const items: MissingItem[] = [];
    if (!d.class) items.push({ step: 0, label: 'Classe' });
    if (!d.background) items.push({ step: 1, label: 'Antecedente' });
    if (!d.species) items.push({ step: 1, label: 'Espécie' });
    if (!d.alignment) items.push({ step: 3, label: 'Alinhamento' });
    if (!d.name?.trim()) items.push({ step: 4, label: 'Nome' });
    return items;
  });

  protected readonly isComplete = this.#draft.isComplete;

  protected readonly alignmentPt = computed(() => {
    const a = this.draft().alignment;
    return a ? ALIGNMENT_PT[a] : '—';
  });

  // ── Navigation ───────────────────────────────────────────
  protected onPrev(): void { this.prev.emit(); }
  protected onFinish(): void { this.finish.emit(); }
}
