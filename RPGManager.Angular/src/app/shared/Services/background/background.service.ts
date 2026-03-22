import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { BackgroundQueryDto } from '../../DTOs/baclground/background-query.dto';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BackgroundService {
  private _httpClient: HttpClient = inject(HttpClient);

  recoverByGameSystemId(gameSystemId: string): Observable<BackgroundQueryDto[]> {
    const url: string = `${environment.apiUrl}/background/recover-by-game-system-id/${gameSystemId}`;
    return this._httpClient.get<BackgroundQueryDto[]>(url);
  }
}
