import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StepGameSystemVersionComponent } from './step-game-system-version.component';

describe('StepGameSystemVersionComponent', () => {
  let component: StepGameSystemVersionComponent;
  let fixture: ComponentFixture<StepGameSystemVersionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StepGameSystemVersionComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StepGameSystemVersionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
