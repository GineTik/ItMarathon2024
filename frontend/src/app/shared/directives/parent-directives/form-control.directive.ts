import { computed, Directive, input } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';

@Directive({
  standalone: true,
})
export class FormControlDirective {
  readonly control = input.required<FormControl>();
  readonly label = input<string>('');
  readonly placeholder = input<string>('');

  readonly isRequired = computed(() => this.control().hasValidator(Validators.required));

  get isInvalid(): boolean {
    return this.control().invalid && this.control().touched && this.control().dirty;
  }
}
