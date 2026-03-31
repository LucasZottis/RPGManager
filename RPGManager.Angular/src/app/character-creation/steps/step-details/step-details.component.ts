import { Component, inject, output } from '@angular/core';
import { CharacterDraftService } from '../../helpers/services/character-draft/character-draft.service';

@Component({
  selector: 'rpg-step-details',
  standalone: true,
  imports: [],
  templateUrl: './step-details.component.html',
  styleUrl: './step-details.component.scss'
})
export class StepDetailsComponent {
  readonly next = output<void>();
  readonly prev = output<void>();

  readonly #draft = inject(CharacterDraftService);
  protected readonly draft = this.#draft.draft;

  // Each field patches the draft immediately on change.
  // ngModel two-way binding calls these setters.

  protected setName(v: string): void { this.#draft.patchDetails({ name: v }); }
  protected setLevel(v: number): void { this.#draft.patchDetails({ level: v }); }
  protected setAge(v: string): void { this.#draft.patchDetails({ age: v }); }
  protected setHeight(v: string): void { this.#draft.patchDetails({ height: v }); }
  protected setWeight(v: string): void { this.#draft.patchDetails({ weight: v }); }
  protected setEyes(v: string): void { this.#draft.patchDetails({ eyes: v }); }
  protected setHair(v: string): void { this.#draft.patchDetails({ hair: v }); }
  protected setSkin(v: string): void { this.#draft.patchDetails({ skin: v }); }
  protected setPersonalityTraits(v: string): void { this.#draft.patchDetails({ personalityTraits: v }); }
  protected setIdeals(v: string): void { this.#draft.patchDetails({ ideals: v }); }
  protected setBonds(v: string): void { this.#draft.patchDetails({ bonds: v }); }
  protected setFlaws(v: string): void { this.#draft.patchDetails({ flaws: v }); }

  protected levelOptions = [1, 2, 3, 4, 5];

  protected onNext(): void { this.next.emit(); }
  protected onPrev(): void { this.prev.emit(); }
}
