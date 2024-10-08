import { Component } from '@angular/core';

import { ModalWrapperComponent } from '../modal-wrapper/modal-wrapper.component';

@Component({
  selector: 'pet-world-confirm-email-modal',
  standalone: true,
  imports: [ModalWrapperComponent],
  templateUrl: './confirm-email-modal.component.html',
})
export class ConfirmEmailModalComponent {}
