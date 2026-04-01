import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { GameSystem } from '../../models/game-system.model';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class GameSystemApiService {
  private readonly _http: HttpClient = inject(HttpClient);

  recoverGameSystems(): Observable<GameSystem[]> {
    const url: string = `${environment.apiUrl}/game-system/recover`;
    return this._http.get<GameSystem[]>(url);
  }
}
