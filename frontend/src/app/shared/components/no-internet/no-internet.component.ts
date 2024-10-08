import { Component } from '@angular/core';

import { BUTTON_CONTENT } from '../../../app.config';
import { ButtonComponent } from '../button/button.component';

@Component({
  selector: 'pet-world-no-internet',
  standalone: true,
  imports: [ButtonComponent],
  templateUrl: './no-internet.component.html',
  styleUrl: './no-internet.component.scss',
})
export class NoInternetComponent {
  readonly buttonContent = BUTTON_CONTENT;
}
