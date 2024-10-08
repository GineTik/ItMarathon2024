import { Component, input, OnInit } from '@angular/core';
import { FormControl, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'pet-world-confirmation-code-item',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './confirmation-code-item.component.html',
  styleUrl: './confirmation-code-item.component.scss',
})
export class ConfirmationCodeItemComponent {
  readonly control = input.required<FormControl>();

  getControlValue(event: KeyboardEvent): void {
    event.preventDefault();
    const value = Number(event.key);

    isNaN(value) ? this.onBackspace(event) : this.control().setValue(value);
  }

  private onBackspace(event: KeyboardEvent): void {
    if (event.key === 'Backspace') this.control().reset();
  }
}
