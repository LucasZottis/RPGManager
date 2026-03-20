import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { RaceQueryDto } from '../../DTOs/races/race-query.dto';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RaceService {
  private _httpClient: HttpClient = inject(HttpClient);

  recoverByGameSystemId(gameSystemId: string): Observable<RaceQueryDto[]> {
    const url: string = `${environment.apiUrl}/race/recover-by-game-system-id/${gameSystemId}`;
    return this._httpClient.get<RaceQueryDto[]>(url);
  }
}