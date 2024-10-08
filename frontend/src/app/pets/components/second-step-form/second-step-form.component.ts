import { Component, DestroyRef, inject, input, OnInit, output } from '@angular/core';
import { Validators, FormControl, FormGroup } from '@angular/forms';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { tap } from 'rxjs';

import { AD_FORM_CONTROL_NAME, INPUT_LABELS, INPUT_TYPES, PERIOD_TYPE_LIST, PLACEHOLDERS } from '../../../app.config';
import { SelectComponent } from '../../../shared/components/select/select.component';
import { InputComponent } from '../../../shared/components/input/input.component';
import { RadioButtonComponent } from '../../../shared/components/radio-button/radio-button.component';
import { ChipsComponent } from '../../../shared/components/chips/chips.component';
import { ParentDifficultControlsDirective } from '../../../shared/directives/parent-directives/parent-difficult-controls.directive';
import { IsChipsActivePipe } from '../../../shared/pipes/is-chips-active.pipe';
import type { ChipsItem, ExpandedPropertyValue } from '../../../app.model';
import type { DifficultForm, SecondStepForm } from '../../pets.model';

@Component({
  selector: 'pet-world-second-step-form',
  standalone: true,
  imports: [SelectComponent, InputComponent, RadioButtonComponent, ChipsComponent, IsChipsActivePipe],
  templateUrl: './second-step-form.component.html',
  styleUrl: './second-step-form.component.scss',
})
export class SecondStepFormComponent extends ParentDifficultControlsDirective implements OnInit {
  readonly healthList = input.required<ChipsItem[]>();
  readonly documentList = input.required<ChipsItem[]>();
  readonly breedList = input.required<ExpandedPropertyValue[]>();
  readonly genderList = input.required<ExpandedPropertyValue[]>();
  readonly dropdownKey = input.required<string>();

  readonly isSecondStepFormValid = output<boolean>();

  private readonly destroy: DestroyRef = inject(DestroyRef);

  readonly periodTypes = PERIOD_TYPE_LIST;
  readonly formControlName = AD_FORM_CONTROL_NAME;
  readonly placeholders = PLACEHOLDERS;
  readonly labelTypes = INPUT_LABELS;
  readonly inputTypes = INPUT_TYPES;

  get breed(): FormControl {
    return this.difficultForm.get('breed') as FormControl;
  }

  get sex(): FormControl {
    return this.difficultForm.get('sex') as FormControl;
  }

  override ngOnInit() {
    super.ngOnInit();
    this.checkValueChanges();
  }

  override ngAfterViewInit() {
    super.ngAfterViewInit();
    setTimeout(this.emitIsFormValid.bind(this));
  }

  getFormValue(): SecondStepForm {
    return this.difficultForm.value as SecondStepForm;
  }

  checkValueChanges(): void {
    this.difficultForm.valueChanges
      .pipe(tap(this.emitIsFormValid.bind(this)), takeUntilDestroyed(this.destroy))
      .subscribe();
  }

  protected override initForm(): FormGroup<SecondStepForm> {
    return this.fb.group({
      ...(super.initForm().controls as unknown as DifficultForm),
      breed: [null as unknown as ExpandedPropertyValue, Validators.required],
      sex: [this.genderList()[0], Validators.required],
    });
  }

  private emitIsFormValid(): void {
    this.isSecondStepFormValid.emit(this.isFormValid());
  }
}
