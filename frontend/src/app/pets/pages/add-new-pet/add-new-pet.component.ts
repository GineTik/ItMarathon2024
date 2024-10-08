import { Component, inject, OnInit, viewChild } from '@angular/core';
import { NgClass, NgStyle } from '@angular/common';
import { Router, RouterLink } from '@angular/router';
import { MatRadioButton, MatRadioGroup } from '@angular/material/radio';
import { tap } from 'rxjs';

import { TextareaComponent } from '../../../shared/components/textarea/textarea.component';
import { InputComponent } from '../../../shared/components/input/input.component';
import { CheckboxComponent } from '../../../shared/components/checkbox/checkbox.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { SelectComponent } from '../../../shared/components/select/select.component';
import { FirstStepFormComponent } from '../../components/first-step-form/first-step-form.component';
import { SecondStepFormComponent } from '../../components/second-step-form/second-step-form.component';
import { ThirdStepFormComponent } from '../../components/third-step-form/third-step-form.component';
import { DictionaryService } from '../../../services/dictionary.service';
import { PetService } from '../../services/pet.service';
import { PetApiService } from '../../services/pet-api.service';
import { GetPetRequestBodyService } from '../../../services/get-pet-request-body.service';
import { ROUTING_LIST } from '../../../app.config';
import type { ChipsItem, ExpandedPropertyValue, PropertyValue } from '../../../app.model';
import type { StepConfig, StepConfigItem } from '../../pets.model';

@Component({
  selector: 'pet-world-add-new-pet',
  standalone: true,
  imports: [
    NgClass,
    NgStyle,
    MatRadioButton,
    MatRadioGroup,
    TextareaComponent,
    InputComponent,
    CheckboxComponent,
    ButtonComponent,
    SelectComponent,
    FirstStepFormComponent,
    SecondStepFormComponent,
    ThirdStepFormComponent,
    RouterLink,
  ],
  templateUrl: './add-new-pet.component.html',
  styleUrl: './add-new-pet.component.scss',
})
export class AddNewPetComponent implements OnInit {
  readonly firstStep = viewChild<FirstStepFormComponent>('firstStep');
  readonly secondStep = viewChild<SecondStepFormComponent>('secondStep');
  readonly thirdStep = viewChild<ThirdStepFormComponent>('thirdStep');

  private readonly router = inject(Router);
  private readonly dictionaryService: DictionaryService = inject(DictionaryService);
  private readonly petService = inject(PetService);
  private readonly apiService = inject(PetApiService);
  private readonly requestService = inject(GetPetRequestBodyService);

  routingList = ROUTING_LIST;

  readonly dropdownKey: string = 'value';
  readonly stepperConfig: StepConfig = [
    {
      stepNumber: 1,
      title: 'Загальна інформація',
      progress: 33,
    },
    {
      stepNumber: 2,
      title: 'Інформація про тварину',
      progress: 66,
    },
    {
      stepNumber: 3,
      title: 'Вигляд тварини',
      progress: 100,
    },
  ];

  animalTypes!: ExpandedPropertyValue[];
  breeds!: ExpandedPropertyValue[];
  genderList!: ExpandedPropertyValue[];
  colorList!: ExpandedPropertyValue[];
  healthList!: ChipsItem[];
  documentList!: ChipsItem[];
  currentStep: StepConfigItem = this.stepperConfig[0];
  currentStepNumber = 0;
  isActiveFormValid = false;

  get isLastPage(): boolean {
    return this.currentStepNumber === this.stepperConfig.length - 1;
  }

  ngOnInit() {
    this.getDropdownData();
  }

  increaseStep(): void {
    this.saveForm();

    if (this.currentStep === this.stepperConfig[this.stepperConfig.length - 1]) {
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
      return;
    }

    this.currentStepNumber++;
    this.getCurrentStepConfig();
  }

  decreaseStep(): void {
    this.saveForm();
    this.currentStepNumber--;
    this.getCurrentStepConfig();
  }

  getBreeds(animalType: PropertyValue): void {
    this.breeds = this.dictionaryService.getBreeds(animalType);
  }

  checkFormValidity(isValid: boolean): void {
    this.isActiveFormValid = isValid;
  }

  onPreview(): void {
    this.saveForm();
    this.router.navigateByUrl(`/${ROUTING_LIST.pets}/${ROUTING_LIST.newPet}/${ROUTING_LIST.preview}`);
  }

  private getCurrentStepConfig(): void {
    this.currentStep = this.stepperConfig[this.currentStepNumber];
  }

  private getDropdownData(): void {
    this.animalTypes = this.dictionaryService.getAnimalTypes();
    this.genderList = this.dictionaryService.getGenderList();
    this.colorList = this.dictionaryService.getColorList();
    this.healthList = this.dictionaryService.getHealthList();
    this.documentList = this.dictionaryService.getDocumentsList();
  }

  private getFormComponents(): FirstStepFormComponent | SecondStepFormComponent | ThirdStepFormComponent {
    const componentList = {
      0: this.firstStep(),
      1: this.secondStep(),
      2: this.thirdStep(),
    };

    return componentList[this.currentStepNumber as keyof typeof componentList]!;
  }

  private getSaveFormMethod() {
    const methodList = {
      0: this.petService.saveFirstForm,
      1: this.petService.saveSecondForm,
      2: this.petService.saveThirdForm,
    };

    return methodList[this.currentStepNumber as keyof typeof methodList];
  }

  private saveForm(): void {
    const component = this.getFormComponents();
    const saveMethod = this.getSaveFormMethod();
    saveMethod.call(this.petService, component.getFormValue() as unknown);
  }
}
