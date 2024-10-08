import { Component, effect, input, OnInit } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { NgClass } from '@angular/common';
import { NgLabelTemplateDirective, NgSelectComponent } from '@ng-select/ng-select';

import { FormControlDirective } from '../../directives/parent-directives/form-control.directive';
import { LabelDirective } from '../../directives/label.directive';

// TODO: add 'error' state

@Component({
  selector: 'pet-world-select',
  standalone: true,
  imports: [ReactiveFormsModule, NgClass, NgSelectComponent, NgLabelTemplateDirective, LabelDirective],
  templateUrl: './select.component.html',
  styleUrl: './select.component.scss',
})
export class SelectComponent<T> extends FormControlDirective {
  dropdown = input.required<T[]>();
  keyValue = input<string>('');
  isVirtualScroll = input<boolean>(true);
  isSearchable = input<boolean>(true);
  disabled = input<boolean>(false);

  constructor() {
    super();

    effect(() => {
      this.disabled() ? this.control().disable() : this.control().enable();
    });
  }
}
