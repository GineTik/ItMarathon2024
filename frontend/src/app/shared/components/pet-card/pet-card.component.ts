import { Component, inject, input, OnInit } from '@angular/core';
import { NgClass } from '@angular/common';

import { EditButtonComponent } from '../edit-button/edit-button.component';
import { PetViewService } from '../../../pets/services/pet-view.service';
import type { ProposalItem, ViewDetails } from '../../../app.model';
import { PriceFormatPipe } from '../../pipes/price-format.pipe';

@Component({
  selector: 'pet-world-pet-card',
  standalone: true,
  imports: [EditButtonComponent, NgClass, PriceFormatPipe],
  templateUrl: './pet-card.component.html',
  styleUrl: './pet-card.component.scss',
})
export class PetCardComponent implements OnInit {
  readonly petCard = input.required<ProposalItem>();
  readonly isHorizontal = input(false);

  private readonly petViewService = inject(PetViewService);

  viewDetails!: ViewDetails;
  isImageVisible: boolean = true;
  photoHeight!: number;

  ngOnInit() {
    this.getViewDetails();
    this.getPhotoHeight();
  }

  handleImageError({ type }: Event): void {
    this.isImageVisible = type !== 'error';
  }

  private getViewDetails(): void {
    this.viewDetails = this.petViewService.getViewDetails(this.petCard());
  }

  private getPhotoHeight(): void {
    this.photoHeight = this.isHorizontal() ? 208 : 272;
  }
}
