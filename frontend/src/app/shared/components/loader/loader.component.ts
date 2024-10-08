import { Component, inject } from '@angular/core';
import { NgClass } from '@angular/common';

import { LoaderService } from '../../../services/loader.service';

@Component({
  selector: 'pet-world-loader',
  standalone: true,
  imports: [NgClass],
  templateUrl: './loader.component.html',
  styleUrl: './loader.component.scss',
})
export class LoaderComponent {
  readonly loaderService = inject(LoaderService);
}
