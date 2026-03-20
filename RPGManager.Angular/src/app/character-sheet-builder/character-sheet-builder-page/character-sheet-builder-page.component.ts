import { Component, inject, OnInit } from '@angular/core';
import { TextInputComponent } from "../../shared/components/inputs/text-input/text-input.component";
import { CheckBoxInputComponent } from "../../shared/components/inputs/check-box-input/check-box-input.component";
import { RaceCharacterSheetModel } from '../models/race-character-sheet.model';
import { RaceService } from '../../shared/Services/Race/race.service';
import { GameSystemService } from '../../shared/Services/game-system/game-system.service';
import { GameSystemQueryDto } from '../../shared/DTOs/game-systems/game-system-query.dto';
import { AbstractControl, FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { RaceQueryDto } from '../../shared/DTOs/races/race-query.dto';
import { flatMap } from 'rxjs';
import { ClassQueryDto } from '../../shared/DTOs/class/class-query.dto';
import { ClassService } from '../../shared/Services/class/class.service';

@Component({
  selector: 'rpg-character-sheet-builder-page',
  standalone: true,
  imports: [TextInputComponent, ReactiveFormsModule],
  templateUrl: './character-sheet-builder-page.component.html',
  styleUrl: './character-sheet-builder-page.component.scss'
})
export class CharacterSheetBuilderPageComponent implements OnInit {
  private _formBuilder: FormBuilder = inject(FormBuilder);
  private _gameSystemService: GameSystemService = inject(GameSystemService);
  private _raceService: RaceService = inject(RaceService);
  private _classService: ClassService = inject(ClassService);

  protected sheet!: FormGroup;
  protected gameSystems: GameSystemQueryDto[] = [];
  protected races: RaceQueryDto[] = [];
  protected classes: ClassQueryDto[] = [];

  get gameSystemId(): AbstractControl | null {
    return this.sheet.get("gameSystemId");
  }

  get raceId(): AbstractControl | null {
    return this.sheet.get("raceId");
  }

  get isGameSystemIdSet(): boolean {
    if (this.gameSystemId)
      return this.gameSystemId.value !== "";

    return false;
  }

  get isRaceIdSet(): boolean {
    if (this.raceId)
      return this.raceId.value !== "";

    return false;
  }

  private _createSheet(): void {
    this.sheet = this._formBuilder.group({
      gameSystemId: [''],
      raceId: [''],
      classId: [''],
    });

    this._setListeners();
  }

  private _setListeners(): void {
    this.gameSystemId?.valueChanges.subscribe({
      next: (value) => this._getRaces(value),
    });

    this.raceId?.valueChanges.subscribe({
      next: (value) => this._getClasses(value),
    });
  }

  private _getGameSystems(): void {
    console.info("Carregando Sistemas");
    this._gameSystemService.recover().subscribe({
      next: (result) => this.gameSystems = result,
      error: console.error,
      complete: () => console.info("Sistemas carregados"),
    });
  }

  private _getRaces(gameSystemId: string): void {
    console.info("Carregando raças");
    this._raceService.recoverByGameSystemId(gameSystemId).subscribe({
      next: (result) => this.races = result,
      error: console.error,
      complete: () => console.info("Raças carregadas"),
    })
  }

  private _getClasses(gameSystemId: string): void {
    console.info("Carregando classes");
    this._classService.recoverByGameSystemId(gameSystemId).subscribe({
      next: (result) => this.classes = result,
      error: console.error,
      complete: () => console.info("Classes carregadas"),
    })
  }

  ngOnInit(): void {
    this._createSheet();
    this._getGameSystems();
  }
}
