import { Component, inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';

import { ModalWrapperComponent } from '../../../shared/components/modal-wrapper/modal-wrapper.component';
import type { LinkModalData } from '../../auth.model';

@Component({
  selector: 'pet-world-sent-link-modal',
  standalone: true,
  imports: [ModalWrapperComponent],
  templateUrl: './sent-link-modal.component.html',
})
export class SentLinkModalComponent {
  readonly data = inject(MAT_DIALOG_DATA) as LinkModalData;
}
