import { HttpClient } from '@angular/common/http';
import { computed, inject, Injectable, signal } from '@angular/core';
import { Router } from '@angular/router';
import { tap } from 'rxjs';
import { AuthenticateUser } from '../models/authenticate-user.model';
import { AuthenticatedUser } from '../models/authenticated-user.model';
import { environment } from '../../../environments/environment';
import { ToastService } from '../../shared/Services/Toast/toast.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private readonly ACCESS_TOKEN_KEY = 'ACCESS_TOKEN';
  private readonly API_URL = 'authentication';

  private readonly http: HttpClient = inject(HttpClient);
  private readonly router: Router = inject(Router);
  private readonly toast: ToastService = inject(ToastService);

  // Estado reativo
  private readonly _accessToken = signal<string | null>(
    localStorage.getItem(this.ACCESS_TOKEN_KEY)
  );

  readonly isAuthenticated = computed(() => !!this._accessToken());

  authenticate(payload: AuthenticateUser) {
    const url: string = `${environment.apiUrl}/${this.API_URL}/authenticate`;

    return this.http.post<AuthenticatedUser>(url, payload).pipe(
      tap({ next: response => this.onAuthenticated(response) })
    );
  }

  logout(): void {
    localStorage.removeItem(this.ACCESS_TOKEN_KEY);
    this._accessToken.set(null);
    this.router.navigate(['/login']);
  }

  getAccessToken(): string | null {
    return this._accessToken();
  }

  private onAuthenticated(user: AuthenticatedUser): void {
    localStorage.setItem(this.ACCESS_TOKEN_KEY, user.accessToken);
    this.toast.success("Autenticado");
    this._accessToken.set(user.accessToken);
    this.router.navigate(['/character-builder']);
  }
}