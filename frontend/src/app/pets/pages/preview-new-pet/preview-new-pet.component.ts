import { Component, inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { tap } from 'rxjs';

import { AD_FORM_CONTROL_NAME, BUTTON_CONTENT, ROUTING_LIST } from '../../../app.config';
import { ChipsComponent } from '../../../shared/components/chips/chips.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { GalleryComponent } from '../../components/gallery/gallery.component';
import { PetInfoComponent } from '../../components/pet-info/pet-info.component';
import { PetViewButtonsComponent } from '../../components/pet-view-buttons/pet-view-buttons.component';
import { GetPetRequestBodyService } from '../../../services/get-pet-request-body.service';
import { PetApiService } from '../../services/pet-api.service';
import { PetService } from '../../services/pet.service';
import type { FullViewDetails } from '../../../app.model';
import { PetViewService } from '../../services/pet-view.service';

@Component({
  selector: 'pet-world-preview-new-pet',
  standalone: true,
  imports: [ChipsComponent, ButtonComponent, GalleryComponent, PetInfoComponent, PetViewButtonsComponent],
  templateUrl: './preview-new-pet.component.html',
})
export class PreviewNewPetComponent implements OnInit {
  readonly buttonContent = BUTTON_CONTENT;
  readonly formControlName = AD_FORM_CONTROL_NAME;

  private readonly router = inject(Router);
  private readonly petService = inject(PetService);
  private readonly apiService = inject(PetApiService);
  private readonly requestService = inject(GetPetRequestBodyService);
  private readonly petViewService = inject(PetViewService);

  proposal!: FullViewDetails;

  ngOnInit(): void {
    this.proposal = this.petViewService.getProposalPreview();
  }

  onSubmit(): void {
    const requestBody = this.requestService.getRequestBody(this.petService.getAdRequestBody());

    this.apiService
      .addProposal(requestBody)
      .pipe(
        tap(() => {
          void this.router.navigateByUrl(`${ROUTING_LIST.me}`, { state: { isProposalAdded: true } });
        }),
        tap(() => void this.petService.clearForm()),
      )
      .subscribe();
  }

  onCancel(): void {
    this.router.navigateByUrl(`/${ROUTING_LIST.pets}/${ROUTING_LIST.newPet}`);
  }
}
