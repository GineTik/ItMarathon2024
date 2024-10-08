import { Component } from '@angular/core';

import { ModalWrapperComponent } from '../../../shared/components/modal-wrapper/modal-wrapper.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { BUTTON_CONTENT } from '../../../app.config';

@Component({
  selector: 'pet-world-created-new-password-modal',
  standalone: true,
  imports: [ModalWrapperComponent, ButtonComponent],
  templateUrl: './created-new-password-modal.component.html',
})
export class CreatedNewPasswordModalComponent {
  readonly buttonContent = BUTTON_CONTENT;
}
