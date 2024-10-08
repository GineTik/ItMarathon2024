import { Component, input } from '@angular/core';
import { FormControl, ReactiveFormsModule } from '@angular/forms';

import { INPUT_TYPES } from '../../../app.config';

@Component({
  selector: 'pet-world-checkbox',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './checkbox.component.html',
  styleUrl: './checkbox.component.scss',
})
export class CheckboxComponent {
  readonly control = input.required<FormControl>();
  readonly inputType = INPUT_TYPES.checkbox;
}
