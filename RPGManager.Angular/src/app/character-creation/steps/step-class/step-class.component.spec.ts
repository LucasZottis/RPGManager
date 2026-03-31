import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StepClassComponent } from './step-class.component';

describe('StepClassComponent', () => {
  let component: StepClassComponent;
  let fixture: ComponentFixture<StepClassComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StepClassComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StepClassComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
