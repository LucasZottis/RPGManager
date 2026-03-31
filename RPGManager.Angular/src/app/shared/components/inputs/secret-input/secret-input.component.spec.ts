import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SecretInputComponent } from './secret-input.component';

describe('SecretInputComponent', () => {
  let component: SecretInputComponent;
  let fixture: ComponentFixture<SecretInputComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SecretInputComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SecretInputComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
