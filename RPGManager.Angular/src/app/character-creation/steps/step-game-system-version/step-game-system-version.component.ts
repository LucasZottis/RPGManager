import { Component } from '@angular/core';
import { CardComponent } from "../../../shared/components/layout/card/card.component";
import { SelectInputComponent } from "../../../shared/components/inputs/select-input/select-input.component";

@Component({
  selector: 'rpg-step-game-system-version',
  standalone: true,
  imports: [CardComponent, SelectInputComponent],
  templateUrl: './step-game-system-version.component.html',
  styleUrl: './step-game-system-version.component.scss'
})
export class StepGameSystemVersionComponent {

}
