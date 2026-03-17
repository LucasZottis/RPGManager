import { Component } from '@angular/core';
import { TextInputComponent } from "../../shared/components/inputs/text-input/text-input.component";

@Component({
  selector: 'rpg-character-sheet-builder-page',
  standalone: true,
  imports: [TextInputComponent],
  templateUrl: './character-sheet-builder-page.component.html',
  styleUrl: './character-sheet-builder-page.component.scss'
})
export class CharacterSheetBuilderPageComponent {
  protected selectedClassCardId: string = "";

  onClickClassCard(classCardId: string): void {
    if (this.selectedClassCardId == classCardId)
      this.selectedClassCardId = '';
    else
      this.selectedClassCardId = classCardId;
  }
}
