import { Component, HostBinding, output } from '@angular/core';

import { BUTTON_CONTENT } from '../../../app.config';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { CrossButtonComponent } from '../../../shared/components/cross-button/cross-button.component';

@Component({
  selector: 'pet-world-notification',
  standalone: true,
  imports: [ButtonComponent, CrossButtonComponent],
  templateUrl: './notification.component.html',
  styleUrl: './notification.component.scss',
})
export class NotificationComponent {
  readonly confirmButtonEvent = output<void>();
  readonly cancelButtonEvent = output<void>();

  readonly buttonContent = BUTTON_CONTENT;
  @HostBinding('class.visible') isVisible = false;

  onCancelButton(): void {
    this.cancelButtonEvent.emit();
  }

  onConfirmButton(): void {
    this.confirmButtonEvent.emit();
  }

  toggleVisibility(): void {
    this.isVisible = !this.isVisible;
  }
}
