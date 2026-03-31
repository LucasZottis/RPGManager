import { Component, computed, inject, signal } from '@angular/core';
import { Router } from '@angular/router';
import { CharacterCreationService } from '../helpers/services/character-creation/character-creation.service';
import { CharacterDraftService } from '../helpers/services/character-draft/character-draft.service';
import { StepOriginComponent } from "../steps/step-origin/step-origin.component";
import { StepClassComponent } from "../steps/step-class/step-class.component";
import { StepAbilitiesComponent } from "../steps/step-abilities/step-abilities.component";
import { StepAlignmentComponent } from "../steps/step-alignment/step-alignment.component";
import { StepDetailsComponent } from "../steps/step-details/step-details.component";
import { StepSummaryComponent } from "../steps/step-summary/step-summary.component";
import { CharacterCreateRequest } from '../models/character-creation.models';
import { StepGameSystemVersionComponent } from "../steps/step-game-system-version/step-game-system-version.component";

export interface WizardStep {
  id: number;
  label: string;
  srdRef: string;   // reference to SRD section
}

export const WIZARD_STEPS: WizardStep[] = [
  { id: 0, label: 'Versão', srdRef: 'Step 0' },
  { id: 1, label: 'Classe', srdRef: 'Step 1' },
  { id: 2, label: 'Origem', srdRef: 'Step 2' },
  { id: 3, label: 'Atributos', srdRef: 'Step 3' },
  { id: 4, label: 'Alinhamento', srdRef: 'Step 4' },
  { id: 5, label: 'Detalhes', srdRef: 'Step 5' },
  { id: 6, label: 'Resumo', srdRef: 'Review' },
];

@Component({
  selector: 'rpg-character-creation-page',
  standalone: true,
  imports: [StepOriginComponent, StepClassComponent, StepAbilitiesComponent, StepAlignmentComponent, StepDetailsComponent, StepSummaryComponent, StepGameSystemVersionComponent],
  templateUrl: './character-creation-page.component.html',
  styleUrl: './character-creation-page.component.scss'
})
export class CharacterCreationPageComponent {
  protected readonly steps = WIZARD_STEPS;
  protected readonly currentStep = signal(0);
  protected readonly saving = signal(false);
  protected readonly toastMsg = signal<{ text: string; type: 'warning' | 'success' } | null>(null);

  protected readonly progressPct = computed(() => {
    const n = this.currentStep();
    return n === 0 ? 0 : (n / (WIZARD_STEPS.length - 1)) * 100;
  });

  readonly #draft = inject(CharacterDraftService);
  readonly #api = inject(CharacterCreationService);
  readonly #router = inject(Router);

  // ── Navigation ────────────────────────────────────────
  protected next(): void {
    const n = this.currentStep();
    if (!this.validateStep(n)) return;
    if (n < WIZARD_STEPS.length - 1) this.currentStep.set(n + 1);
  }

  protected prev(): void {
    const n = this.currentStep();
    if (n > 0) this.currentStep.set(n - 1);
  }

  protected jumpTo(index: number): void {
    if (index <= this.currentStep()) this.currentStep.set(index);
  }

  private validateStep(step: number): boolean {
    const d = this.#draft.draft();
    if (step === 0 && !d.class) { this.toast('⚠️ Selecione uma classe.', 'warning'); return false; }
    if (step === 1 && !d.background) { this.toast('⚠️ Selecione um antecedente.', 'warning'); return false; }
    if (step === 1 && !d.species) { this.toast('⚠️ Selecione uma espécie.', 'warning'); return false; }
    if (step === 3 && !d.alignment) { this.toast('⚠️ Selecione um alinhamento.', 'warning'); return false; }
    if (step === 4 && !d.name.trim()) { this.toast('⚠️ Informe o nome do personagem.', 'warning'); return false; }
    return true;
  }

  // ── Finish ────────────────────────────────────────────
  protected finish(): void {
    if (!this.#draft.isComplete()) return;
    this.saving.set(true);

    const d = this.#draft.draft();
    const finals = this.#draft.finalAbilities();

    const payload: CharacterCreateRequest = {
      name: d.name,
      level: d.level,
      alignment: d.alignment!,
      classId: d.class!,
      backgroundId: d.background!.id,
      speciesId: d.species!.id,
      languages: d.languages,
      abilityScores: finals,
      abilityMethod: d.abilityMethod,
      skillIds: [...d.chosenSkills, ...d.backgroundSkills],
      personalityTraits: d.personalityTraits,
      ideals: d.ideals,
      bonds: d.bonds,
      flaws: d.flaws,
      age: d.age,
      height: d.height,
      weight: d.weight,
      eyes: d.eyes,
      hair: d.hair,
      skin: d.skin,
    };

    this.#api.createCharacter(payload).subscribe({
      next: result => {
        this.saving.set(false);
        this.toast(`🎉 "${result.name}" criado com sucesso!`, 'success');
        setTimeout(() => this.#router.navigate(['/characters', result.id]), 1500);
      },
      error: err => {
        this.saving.set(false);
        this.toast(`❌ Erro ao criar personagem: ${err.message}`, 'warning');
      },
    });
  }

  // ── Toast ─────────────────────────────────────────────
  protected toast(text: string, type: 'warning' | 'success'): void {
    this.toastMsg.set({ text, type });
    setTimeout(() => this.toastMsg.set(null), 3400);
  }

  // ── Template helpers ──────────────────────────────────
  protected readonly draft = this.#draft.draft;
  protected readonly isComplete = this.#draft.isComplete;
}
