/* ─────────────────────────────────────────────────────────────
   character-creation.service.ts
   All HTTP calls for the character-creation wizard.
   Each method maps 1-to-1 to one API endpoint.
───────────────────────────────────────────────────────────── */
import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Background, Species, Language, Skill, CharacterCreateRequest } from '../../../models/character-creation.models';
import { CharacterClass } from '../../../models/character-class.model';
import { environment } from '../../../../../environments/environment';
import { GameSystemVersion } from '../../../models/character-game-system-version.model';

@Injectable({ providedIn: 'root' })
export class CharacterCreationService {
  readonly #http = inject(HttpClient);

  getGamesystemVersions(): Observable<GameSystemVersion[]> {
    const url: string = `${environment.apiUrl}/class/recover}`;
    return this.#http.get<CharacterClass[]>(url);
  }

  /**
   * GET /api/v1/classes
   * Returns the list of available character classes.
   */
  getClasses(gameSystemVersion: string): Observable<CharacterClass[]> {
    const url: string = `${environment.apiUrl}/class/recover/${gameSystemVersion}`;
    return this.#http.get<CharacterClass[]>(url);
  }

  /**
   * GET /api/v1/backgrounds
   * Returns all selectable backgrounds.
   */
  getBackgrounds(): Observable<Background[]> {
    return this.#http.get<Background[]>('/api/v1/backgrounds');
  }

  /**
   * GET /api/v1/species
   * Returns all selectable species (races).
   */
  getSpecies(): Observable<Species[]> {
    return this.#http.get<Species[]>('/api/v1/species');
  }

  /**
   * GET /api/v1/languages
   * Returns all available languages.
   */
  getLanguages(): Observable<Language[]> {
    return this.#http.get<Language[]>('/api/v1/languages');
  }

  /**
   * GET /api/v1/classes/{classId}/skills
   * Returns the skill list the player can choose from for the given class.
   */
  getClassSkills(classId: string): Observable<Skill[]> {
    return this.#http.get<Skill[]>(`/api/v1/classes/${classId}/skills`);
  }

  /**
   * POST /api/v1/characters
   * Submits the completed character draft.
   * Returns the created character with its generated id.
   */
  createCharacter(payload: CharacterCreateRequest): Observable<{ id: string; name: string }> {
    return this.#http.post<{ id: string; name: string }>('/api/v1/characters', payload);
  }
}