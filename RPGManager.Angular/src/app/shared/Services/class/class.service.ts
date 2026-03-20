import { inject, Injectable } from '@angular/core';
import { ClassQueryDto } from '../../DTOs/class/class-query.dto';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ClassService {
  private _httpClient: HttpClient = inject(HttpClient);

  recoverByGameSystemId(gameSystemId: string): Observable<ClassQueryDto[]> {
    const url: string = `${environment.apiUrl}/class/recover-by-game-system-id/${gameSystemId}`;
    return this._httpClient.get<ClassQueryDto[]>(url);
  }
}
