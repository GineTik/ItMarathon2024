import { Component, input } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { NgClass, NgStyle } from '@angular/common';

import { FormControlDirective } from '../../directives/parent-directives/form-control.directive';
import { LabelDirective } from '../../directives/label.directive';

@Component({
  selector: 'pet-world-textarea',
  standalone: true,
  imports: [ReactiveFormsModule, NgClass, LabelDirective, NgStyle],
  templateUrl: './textarea.component.html',
  styleUrls: ['./textarea.component.scss', '../input/input.component.scss'],
})
export class TextareaComponent extends FormControlDirective {
  private readonly MAX_LENGTH = 50;
  private readonly ROWS = 2;

  readonly maxLength = input<number>(this.MAX_LENGTH);
  readonly rows = input<number>(this.ROWS);
  readonly isCounterVisible = input<boolean>(false);
  readonly symbolCounter = input<number>(0);
  readonly height = input<string>('80px');
}
