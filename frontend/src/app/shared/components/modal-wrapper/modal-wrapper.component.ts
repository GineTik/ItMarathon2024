import { Component, output } from '@angular/core';
import { CrossButtonComponent } from '../cross-button/cross-button.component';

@Component({
  selector: 'pet-world-modal-wrapper',
  standalone: true,
  imports: [CrossButtonComponent],
  templateUrl: './modal-wrapper.component.html',
  styleUrl: './modal-wrapper.component.scss',
})
export class ModalWrapperComponent {
  closeModal = output<void>();

  onClose(): void {
    this.closeModal.emit();
  }
}
