import { Component } from '@angular/core';

import { ModalWrapperComponent } from '../../../shared/components/modal-wrapper/modal-wrapper.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { BUTTON_CONTENT } from '../../../app.config';

@Component({
  selector: 'pet-world-created-profile-modal',
  standalone: true,
  imports: [ModalWrapperComponent, ButtonComponent],
  templateUrl: './created-profile-modal.component.html',
})
export class CreatedProfileModalComponent {
  readonly buttonContent = BUTTON_CONTENT;
}
