import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { GameSystemQueryDto } from '../../DTOs/game-systems/game-system-query.dto';

@Injectable({
  providedIn: 'root'
})
export class GameSystemService {
  private _httpClient: HttpClient = inject(HttpClient);

  recover(): Observable<GameSystemQueryDto[]> {
    const url: string = `${environment.apiUrl}/game-system/recover`;
    return this._httpClient.get<GameSystemQueryDto[]>(url);
  }
}
