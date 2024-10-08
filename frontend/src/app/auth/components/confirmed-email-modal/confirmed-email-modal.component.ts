import { Component } from '@angular/core';

import { ModalWrapperComponent } from '../../../shared/components/modal-wrapper/modal-wrapper.component';

@Component({
  selector: 'pet-world-confirmed-email-modal',
  standalone: true,
  imports: [ModalWrapperComponent],
  templateUrl: './confirmed-email-modal.component.html',
})
export class ConfirmedEmailModalComponent {}
