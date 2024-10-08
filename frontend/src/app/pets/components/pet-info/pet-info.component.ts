import { Component, inject, input, OnInit } from '@angular/core';

import { ChipsComponent } from '../../../shared/components/chips/chips.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { BUTTON_CONTENT } from '../../../app.config';
import { GalleryComponent } from '../gallery/gallery.component';
import { PetViewService } from '../../services/pet-view.service';
import { FullViewDetails, ProposalItem } from '../../../app.model';
import { PriceFormatPipe } from '../../../shared/pipes/price-format.pipe';

@Component({
  selector: 'pet-world-pet-info',
  standalone: true,
  imports: [ChipsComponent, ButtonComponent, GalleryComponent, PriceFormatPipe],
  templateUrl: './pet-info.component.html',
  styleUrl: './pet-info.component.scss',
})
export class PetInfoComponent implements OnInit {
  readonly proposal = input<ProposalItem>();
  readonly proposalPreview = input<FullViewDetails>();

  readonly isUserOwned = input<boolean>(false);
  readonly buttonContent = BUTTON_CONTENT;

  private readonly petViewService = inject(PetViewService);

  viewDetails!: FullViewDetails;

  ngOnInit(): void {
    this.viewDetails = this.proposalPreview()
      ? this.proposalPreview()!
      : this.petViewService.getFullViewDetails(this.proposal()!);
  }
}
