import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StepAbilitiesComponent } from './step-abilities.component';

describe('StepAbilitiesComponent', () => {
  let component: StepAbilitiesComponent;
  let fixture: ComponentFixture<StepAbilitiesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StepAbilitiesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StepAbilitiesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
