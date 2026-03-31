import { Component, computed, inject, output, signal } from '@angular/core';
import { CharacterCreationService } from '../../helpers/services/character-creation/character-creation.service';
import { CharacterDraftService } from '../../helpers/services/character-draft/character-draft.service';
import { Background, Species, Language } from '../../models/character-creation.models';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'rpg-step-origin',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './step-origin.component.html',
  styleUrl: './step-origin.component.scss'
})
export class StepOriginComponent {
  readonly next = output<void>();
  readonly prev = output<void>();

  // API data
  protected readonly backgrounds = signal<Background[]>([]);
  protected readonly species = signal<Species[]>([]);
  protected readonly languages = signal<Language[]>([]);

  // Loading / error state per resource
  protected readonly loadingBg = signal(true);
  protected readonly loadingSp = signal(true);
  protected readonly loadingLng = signal(true);
  protected readonly errorBg = signal<string | null>(null);
  protected readonly errorSp = signal<string | null>(null);

  // Expanded detail card
  protected readonly expandedBg = signal<Background | null>(null);
  protected readonly expandedSp = signal<Species | null>(null);

  // Language selection
  protected readonly langSearch = signal('');
  protected readonly filteredLangs = computed(() => {
    const q = this.langSearch().toLowerCase();
    return this.languages().filter(l => l.name.toLowerCase().includes(q));
  });

  readonly #api = inject(CharacterCreationService);
  readonly #draft = inject(CharacterDraftService);
  protected readonly draft = this.#draft.draft;

  ngOnInit(): void {
    this.#api.getBackgrounds().subscribe({
      next: d => { this.backgrounds.set(d); this.loadingBg.set(false); },
      error: e => { this.errorBg.set(e.message); this.loadingBg.set(false); },
    });

    this.#api.getSpecies().subscribe({
      next: d => { this.species.set(d); this.loadingSp.set(false); },
      error: e => { this.errorSp.set(e.message); this.loadingSp.set(false); },
    });

    this.#api.getLanguages().subscribe({
      next: d => { this.languages.set(d); this.loadingLng.set(false); },
      error: _ => this.loadingLng.set(false),
    });
  }

  // ── Background ──────────────────────────────────────────
  protected selectBackground(bg: Background): void {
    this.#draft.setBackground(bg);
    this.expandedBg.set(bg);
  }

  protected isSelectedBg(bg: Background): boolean {
    return this.draft().background?.id === bg.id;
  }

  // ── Species ─────────────────────────────────────────────
  protected selectSpecies(sp: Species): void {
    this.#draft.setSpecies(sp);
    this.expandedSp.set(sp);
  }

  protected isSelectedSp(sp: Species): boolean {
    return this.draft().species?.id === sp.id;
  }

  // ── Languages ───────────────────────────────────────────
  protected isLangSelected(lang: Language): boolean {
    return this.draft().languages.includes(lang.name);
  }

  protected toggleLanguage(lang: Language): void {
    const current = [...this.draft().languages];
    const idx = current.indexOf(lang.name);
    if (idx >= 0) {
      current.splice(idx, 1);
    } else {
      if (current.length >= 2) return;  // max 2 languages per SRD
      current.push(lang.name);
    }
    this.#draft.setLanguages(current);
  }

  protected onNext(): void { this.next.emit(); }
  protected onPrev(): void { this.prev.emit(); }
}
