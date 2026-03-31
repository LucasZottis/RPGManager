import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StepOriginComponent } from './step-origin.component';

describe('StepOriginComponent', () => {
  let component: StepOriginComponent;
  let fixture: ComponentFixture<StepOriginComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StepOriginComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StepOriginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
