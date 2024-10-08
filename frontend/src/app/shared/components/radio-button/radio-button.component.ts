import { Component, input } from '@angular/core';
import { MatRadioButton, MatRadioGroup } from '@angular/material/radio';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { LabelDirective } from '../../directives/label.directive';

@Component({
  selector: 'pet-world-radio-button',
  standalone: true,
  imports: [MatRadioButton, MatRadioGroup, ReactiveFormsModule, LabelDirective],
  templateUrl: './radio-button.component.html',
  styleUrl: './radio-button.component.scss',
})
export class RadioButtonComponent {
  readonly control = input.required<FormControl>();
  readonly optionList = input.required<any[]>();
  readonly valueKey = input<string>('');
  readonly displayKey = input<string>('');
  readonly label = input.required<string>();
  readonly isRequired = input<boolean>(false);
}
