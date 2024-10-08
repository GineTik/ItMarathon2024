import { Component, ElementRef, input, ViewChild } from '@angular/core';
import { NgClass } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { INPUT_TYPES } from '../../../app.config';
import { FormControlDirective } from '../../directives/parent-directives/form-control.directive';
import { LabelDirective } from '../../directives/label.directive';

@Component({
  selector: 'pet-world-input',
  standalone: true,
  imports: [ReactiveFormsModule, NgClass, LabelDirective],
  templateUrl: './input.component.html',
  styleUrl: './input.component.scss',
})
export class InputComponent extends FormControlDirective {
  readonly inputTypes = INPUT_TYPES;
  readonly inputType = input<INPUT_TYPES>(INPUT_TYPES.text);

  iconPath: string = 'assets/icons/sprite-icons-small.svg#password-hidden';

  @ViewChild('epmInput') inputRef!: ElementRef;

  onToggleClick(type: string): void {
    this.toggleInputType(type);
    this.togglePasswordIcon();
  }

  private toggleInputType(type: string) {
    this.inputRef.nativeElement.type =
      type === this.inputTypes.password ? this.inputTypes.text : this.inputTypes.password;
  }

  private togglePasswordIcon() {
    const passwordIconSuffix = this.inputRef.nativeElement.type === this.inputTypes.password ? 'hidden' : 'visible';
    this.iconPath = 'assets/icons/sprite-icons-small.svg#password-' + passwordIconSuffix;
  }
}
