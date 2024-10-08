import { Component } from '@angular/core';

import { BUTTON_CONTENT } from '../../../app.config';
import { ButtonComponent } from '../button/button.component';

@Component({
  selector: 'pet-world-not-found',
  standalone: true,
  imports: [ButtonComponent],
  templateUrl: './not-found.component.html',
  styleUrl: './not-found.component.scss',
})
export class NotFoundComponent {
  readonly buttonContent = BUTTON_CONTENT;
}
