import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'rpg-authentication-page',
  standalone: true,
  imports: [
    ReactiveFormsModule,
  ],
  templateUrl: './authentication-page.component.html',
  styleUrl: './authentication-page.component.scss'
})
export class AuthenticationPageComponent {
  private _formBuilder: FormBuilder = inject(FormBuilder);
  private _authService: AuthService = inject(AuthService);
  protected authenticateUser: FormGroup = this._formBuilder.group({
    email: [''],
    password: [''],
  });

  protected onSubmit(): void {
    this._authService.authenticate(this.authenticateUser.value).subscribe();
  }
}