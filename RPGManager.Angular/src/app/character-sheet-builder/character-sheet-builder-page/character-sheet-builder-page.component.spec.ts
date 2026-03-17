import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterSheetBuilderPageComponent } from './character-sheet-builder-page.component';

describe('CharacterSheetBuilderPageComponent', () => {
  let component: CharacterSheetBuilderPageComponent;
  let fixture: ComponentFixture<CharacterSheetBuilderPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CharacterSheetBuilderPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CharacterSheetBuilderPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
