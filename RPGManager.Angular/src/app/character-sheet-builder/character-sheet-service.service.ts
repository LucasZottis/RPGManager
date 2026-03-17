import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { RaceCharacterSheetModel } from './models/race-character-sheet.model';

@Injectable({
  providedIn: 'root'
})
export class CharacterSheetServiceService {
  private _httpClient: HttpClient = inject(HttpClient);

  getRaces(): void {
    
  }
}
