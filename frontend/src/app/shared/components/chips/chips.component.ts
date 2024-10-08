import { Component, input } from '@angular/core';
import { NgClass } from '@angular/common';

import type { ChipsItem } from '../../../app.model';

@Component({
  selector: 'pet-world-chips',
  standalone: true,
  imports: [NgClass],
  templateUrl: './chips.component.html',
  styleUrl: './chips.component.scss',
})
export class ChipsComponent {
  readonly isActive = input.required<boolean>();
  readonly isDisabled = input<boolean>(false);
  readonly content = input.required<ChipsItem>();
}
