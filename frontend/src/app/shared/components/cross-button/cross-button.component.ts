import { Component, input, OnInit } from '@angular/core';

@Component({
  selector: 'pet-world-cross-button',
  standalone: true,
  imports: [],
  templateUrl: './cross-button.component.html',
  styleUrl: './cross-button.component.scss',
})
export class CrossButtonComponent implements OnInit {
  type = input<string>('modal');
  iconWidth!: number;
  iconHeight!: number;

  ngOnInit(): void {
    this.iconWidth = this.type() === 'modal' ? 32 : 24;
    this.iconHeight = this.type() === 'modal' ? 32 : 24;
  }
}
