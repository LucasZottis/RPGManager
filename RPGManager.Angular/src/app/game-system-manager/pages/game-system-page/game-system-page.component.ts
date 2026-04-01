import { Component, inject, OnInit } from '@angular/core';
import { CardComponent } from "../../../shared/components/layout/card/card.component";
import { StackComponent } from "../../../shared/components/layout/stack/stack.component";
import { ButtonComponent } from "../../../shared/components/buttons/button/button.component";
import { GameSystemApiService } from '../../services/api/game-system-api.service';
import { GameSystem } from '../../models/game-system.model';
import { DividerComponent } from "../../../shared/components/layout/divider/divider.component";

@Component({
  selector: 'rpg-game-system-page',
  standalone: true,
  imports: [CardComponent, StackComponent, ButtonComponent, DividerComponent],
  templateUrl: './game-system-page.component.html',
  styleUrl: './game-system-page.component.scss'
})
export class GameSystemPageComponent implements OnInit {
  private _api: GameSystemApiService = inject(GameSystemApiService);
  gameSystems: GameSystem[] = [];

  ngOnInit(): void {
    this._api.recoverGameSystems().subscribe({
      next: (list) => this.gameSystems = list,
    });
  }
}
