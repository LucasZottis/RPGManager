import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StepAlignmentComponent } from './step-alignment.component';

describe('StepAlignmentComponent', () => {
  let component: StepAlignmentComponent;
  let fixture: ComponentFixture<StepAlignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StepAlignmentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StepAlignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
