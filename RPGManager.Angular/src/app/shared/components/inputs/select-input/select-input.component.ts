import { Component, computed, input, model, signal } from '@angular/core';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';

@Component({
  selector: 'rpg-select-input',
  standalone: true,
  imports: [],
  templateUrl: './select-input.component.html',
  styleUrl: './select-input.component.scss',
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: SelectInputComponent,
      multi: true,
    }
  ]
})
export class SelectInputComponent implements ControlValueAccessor {
  id = input.required<string>();
  label = input<string>();

  // Functions to be called when the control's value changes or it's touched
  onChangeFn: any = () => { };
  onTouchedFn: any = () => { };

  // Input for externally set disabled state (e.g., via [disabled] attribute)
  protected readonly disabled = input<boolean>(false);

  // Signal for disabled state managed by the form (via setDisabledState)
  protected readonly formDisabled = signal<boolean>(false);

  // Computed signal that combines both disabled states
  protected readonly isDisabled = computed(() => this.disabled() || this.formDisabled());

  // Model signal for the component's value, enabling two-way binding
  protected readonly value = model<string>('');

  // Signal to indicate an error state for styling
  protected readonly error = signal<boolean>(false);

  /**
   * Writes a new value from the form model into the view (and updates the custom component).
   * @param obj The value to be written.
   */
  writeValue(obj: any): void {
    console.log('writeValue called with:', obj);
    this.value.set(obj);
  }

  /**
   * Registers a function to be called when the control's value changes in the UI.
   * This function should be called by the custom control whenever its value changes.
   * @param fn The function to register.
   */
  registerOnChange(fn: any): void {
    this.onChangeFn = fn;
  }

  /**
   * Registers a function to be called when the control receives a touch event.
   * This function should be called by the custom control when it is "touched" (e.g., blurs).
   * @param fn The function to register.
   */
  registerOnTouched(fn: any): void {
    this.onTouchedFn = fn;
  }

  /**
   * Called by the Forms API to update the control's disabled state.
   * @param isDisabled True if the control should be disabled, false otherwise.
   */
  setDisabledState(isDisabled: boolean): void {
    this.formDisabled.set(isDisabled);
  }

  /**
   * Handles the input event from the native HTML input element (or internal logic).
   * Updates the component's internal value, calls the registered onChangeFn,
   * marks the control as touched, and sets an error state if the input is empty.
   * @param event The input event.
   */
  onChange(event: Event): void {
    console.log('Input changed:', event);
    const inputElement = event.target as HTMLInputElement; // Assuming an input for simplicity
    this.value.set(inputElement.value);
    this.onChangeFn(inputElement.value);
    this.onTouchedFn();
    this.error.set(inputElement.value.trim() === '');
  }
}