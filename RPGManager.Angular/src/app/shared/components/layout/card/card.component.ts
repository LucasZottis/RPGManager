import { Component, input } from '@angular/core';
import { ComponentStyle } from '../../../style.type';

@Component({
  selector: 'rpg-card',
  standalone: true,
  imports: [],
  templateUrl: './card.component.html',
  styleUrl: './card.component.scss',
  host: {
    '[class]': `'card-' + cardStyle()`,
  },
})
export class CardComponent {
  cardStyle = input<ComponentStyle>('default');
}
