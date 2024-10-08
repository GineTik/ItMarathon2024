import { Component, input } from '@angular/core';
import { TOASTER_MESSAGE, TOASTER_TYPE } from '../../../app.config';
import { ToasterService } from '../../../services/toaster.service';
import { CrossButtonComponent } from '../cross-button/cross-button.component';

@Component({
  selector: 'pet-world-toaster',
  standalone: true,
  imports: [CrossButtonComponent],
  templateUrl: './toaster.component.html',
  styleUrl: './toaster.component.scss',
})
export class ToasterComponent {
  type = input.required<TOASTER_TYPE>();
  message = input.required<TOASTER_MESSAGE>();

  constructor(private toasterService: ToasterService) {}

  onClose(): void {
    this.toasterService.hide();
  }
}
