import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GameSystemPageComponent } from './game-system-page.component';

describe('GameSystemPageComponent', () => {
  let component: GameSystemPageComponent;
  let fixture: ComponentFixture<GameSystemPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GameSystemPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GameSystemPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
