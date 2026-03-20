import { Component } from '@angular/core';
import { CheckBoxInputComponent } from "../../../shared/components/inputs/check-box-input/check-box-input.component";

@Component({
  selector: 'rpg-race-accordion',
  standalone: true,
  imports: [CheckBoxInputComponent],
  templateUrl: './race-accordion.component.html',
  styleUrl: './race-accordion.component.scss'
})
export class RaceAccordionComponent {

}
