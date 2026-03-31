import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { TextInputComponent } from "../../../shared/components/inputs/text-input/text-input.component";
import { SecretInputComponent } from "../../../shared/components/inputs/secret-input/secret-input.component";

@Component({
  selector: 'rpg-authentication-page',
  standalone: true,
  imports: [
    ReactiveFormsModule,
    TextInputComponent,
    SecretInputComponent
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
    // console.log(this.authenticateUser.value);
    this._authService.authenticate(this.authenticateUser.value).subscribe();
  }
}