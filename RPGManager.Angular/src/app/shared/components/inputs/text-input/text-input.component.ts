import { Component, input } from '@angular/core';

@Component({
  selector: 'rpg-text-input',
  standalone: true,
  imports: [],
  templateUrl: './text-input.component.html',
  styleUrl: './text-input.component.scss'
})
export class TextInputComponent {
  id = input.required<string>();
  label = input<string>();
}
