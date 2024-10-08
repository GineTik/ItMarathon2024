import { Component, inject } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';

import { ModalWrapperComponent } from '../../../shared/components/modal-wrapper/modal-wrapper.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { BUTTON_CONTENT } from '../../../app.config';

@Component({
  selector: 'pet-world-created-pet-card-modal',
  standalone: true,
  imports: [ModalWrapperComponent, ButtonComponent],
  templateUrl: './created-pet-card-modal.component.html',
})
export class CreatedPetCardModalComponent {
  readonly buttonContent = BUTTON_CONTENT;

  private readonly dialog = inject(MatDialogRef);

  onClose(): void {
    this.dialog.close();
  }
}
