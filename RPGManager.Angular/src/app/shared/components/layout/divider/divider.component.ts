import { Component, input } from '@angular/core';
import { ComponentStyle } from '../../../style.type';

@Component({
  selector: 'rpg-divider',
  standalone: true,
  imports: [],
  templateUrl: './divider.component.html',
  styleUrl: './divider.component.scss',
  host: {
    '[class]': `'divider-' + dividerStyle()`
  }
})
export class DividerComponent {
  dividerStyle = input<ComponentStyle>('default');
}
