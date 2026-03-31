import { Component, inject, output, signal } from '@angular/core';
import { CharacterCreationService } from '../../helpers/services/character-creation/character-creation.service';
import { CharacterDraftService } from '../../helpers/services/character-draft/character-draft.service';
import { CharacterClass } from '../../models/character-class.model';

@Component({
  selector: 'rpg-step-class',
  standalone: true,
  imports: [],
  templateUrl: './step-class.component.html',
  styleUrl: './step-class.component.scss'
})
export class StepClassComponent {
  readonly next = output<void>();

  protected readonly classes = signal<CharacterClass[]>([]);
  protected readonly loading = signal(true);
  protected readonly error = signal<string | null>(null);
  protected readonly expanded = signal<CharacterClass | null>(null);

  readonly #api = inject(CharacterCreationService);
  readonly #draft = inject(CharacterDraftService);

  protected readonly selected = this.#draft.draft;

  ngOnInit(): void {
    this.#api.getClasses('').subscribe({
      next: data => { this.classes.set(data); this.loading.set(false); },
      error: err => { this.error.set(err.message); this.loading.set(false); },
    });
  }

  protected select(cls: CharacterClass): void {
    this.#draft.setClass(cls);
    this.expanded.set(cls);
  }

  protected isSelected(cls: CharacterClass): boolean {
    return this.selected().class === cls.id;
  }

  protected onNext(): void {
    this.next.emit();
  }
}
