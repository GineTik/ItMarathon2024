import { Component, input } from '@angular/core';

@Component({
  selector: 'pet-world-button',
  standalone: true,
  imports: [],
  templateUrl: './button.component.html',
  styleUrl: './button.component.scss',
})
export class ButtonComponent {
  isDisabled = input<boolean>(false);
}
