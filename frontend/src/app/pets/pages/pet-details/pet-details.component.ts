import { ChangeDetectorRef, Component, DestroyRef, inject, OnInit, ViewChild } from '@angular/core';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { ActivatedRoute } from '@angular/router';
import { finalize, map, tap } from 'rxjs';

import { BUTTON_CONTENT } from '../../../app.config';
import { ChipsComponent } from '../../../shared/components/chips/chips.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { GalleryComponent } from '../../components/gallery/gallery.component';
import { PetInfoComponent } from '../../components/pet-info/pet-info.component';
import { EditAdFormComponent } from '../../components/edit-ad-form/edit-ad-form.component';
import { PetViewButtonsComponent } from '../../components/pet-view-buttons/pet-view-buttons.component';
import { DictionaryService } from '../../../services/dictionary.service';
import { UserService } from '../../../services/user.service';
import type { ChipsItem, ExpandedPropertyValue, ProposalItem } from '../../../app.model';
import { GetPetRequestBodyService } from '../../../services/get-pet-request-body.service';
import { PetApiService } from '../../services/pet-api.service';

@Component({
  selector: 'pet-world-pet-details',
  standalone: true,
  imports: [
    ChipsComponent,
    ButtonComponent,
    GalleryComponent,
    EditAdFormComponent,
    PetInfoComponent,
    PetViewButtonsComponent,
  ],
  templateUrl: './pet-details.component.html',
})
export class PetDetailsComponent implements OnInit {
  @ViewChild('editForm') editForm!: EditAdFormComponent;
  private readonly route = inject(ActivatedRoute);
  private readonly destroyRef = inject(DestroyRef);

  readonly buttonContent = BUTTON_CONTENT;

  proposal!: ProposalItem;
  animalTypes!: ExpandedPropertyValue[];
  genderList!: ExpandedPropertyValue[];
  colorList!: ExpandedPropertyValue[];
  healthList!: ChipsItem[];
  documentList!: ChipsItem[];
  isEditMode = false;
  isEditFormValid = false;
  isUserOwned = false;

  private readonly dictionaryService = inject(DictionaryService);
  private readonly userService = inject(UserService);
  private readonly apiService = inject(PetApiService);
  private readonly requestService = inject(GetPetRequestBodyService);
  private readonly cdr = inject(ChangeDetectorRef);

  get cancelButtonText(): BUTTON_CONTENT {
    if (this.isEditMode) {
      return this.buttonContent.back;
    }

    return this.proposal.isActive ? this.buttonContent.deactivate : this.buttonContent.activate;
  }

  ngOnInit(): void {
    this.getDropdownData();
    this.getProposalData();
    this.isUserOwned = this.checkIsUserOwned();
  }

  setEditMode(event: boolean): void {
    if (this.isEditMode !== event) {
      this.isEditMode = event;
    }
  }

  private getDropdownData(): void {
    this.animalTypes = this.dictionaryService.getAnimalTypes();
    this.genderList = this.dictionaryService.getGenderList();
    this.colorList = this.dictionaryService.getColorList();
    this.healthList = this.dictionaryService.getHealthList();
    this.documentList = this.dictionaryService.getDocumentsList();
  }

  toggleIsActive(): void {
    // TODO API.setIsActive(!this.proposal.isActive)
  }

  onSubmit(): void {
    if (this.isUserOwned && this.isEditMode) {
      this.submitEditForm();
    } else {
      this.setEditMode(true);
    }
  }

  onCancel(): void {
    if (this.isUserOwned && this.isEditMode) {
      this.setEditMode(false);
    } else {
      // this.toggleIsActive(!this.proposal.isActive);
    }
  }

  checkFormValidity(isValid: boolean): void {
    this.isEditFormValid = isValid;
  }

  private getProposalData(): void {
    this.route.data
      .pipe(
        map(data => data['proposal']),
        tap(data => (this.proposal = data)),
        takeUntilDestroyed(this.destroyRef),
      )
      .subscribe();
  }

  private checkIsUserOwned(): boolean {
    return this.userService.user()?.id === this.proposal.appUser.id;
  }

  private submitEditForm(): void {
    if (!this.isEditFormValid) return;

    const formData = this.editForm?.getFormValue()!;
    const requestBody = this.requestService.getRequestBody(formData, true);

    this.apiService
      .updateProposal(this.proposal.id, requestBody)
      .pipe(
        tap(proposal => (this.proposal = proposal)),
        finalize(() =>
          setTimeout(() => {
            this.setEditMode(false);
            this.cdr.detectChanges();
          }),
        ),
      )
      .subscribe();
  }
}
