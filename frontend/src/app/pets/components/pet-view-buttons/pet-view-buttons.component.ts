import { Component, input, output } from '@angular/core';
import { ButtonComponent } from '../../../shared/components/button/button.component';

@Component({
  selector: 'pet-world-pet-view-buttons',
  standalone: true,
  imports: [ButtonComponent],
  templateUrl: './pet-view-buttons.component.html',
  styleUrl: './pet-view-buttons.component.scss',
})
export class PetViewButtonsComponent {
  readonly submitButton = input.required<string>();
  readonly cancelButton = input.required<string>();
  readonly showButtons = input(false);
  readonly isDisabled = input(false);

  submit = output<void>();
  cancel = output<void>();

  onSubmit(): void {
    this.submit.emit();
  }
  onCancel(): void {
    this.cancel.emit();
  }
}
