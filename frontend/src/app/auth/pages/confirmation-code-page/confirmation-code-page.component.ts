import { AfterViewInit, Component, effect, OnInit, signal } from '@angular/core';
import { FormArray, FormBuilder, Validators } from '@angular/forms';
import { interval, Subject, takeUntil, tap } from 'rxjs';

import { BUTTON_CONTENT } from '../../../app.config';
import { ConfirmationCodeItemComponent } from '../../components/confirmation-code-item/confirmation-code-item.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { ConvertToFormControlPipe } from '../../../shared/pipes/convert-to-form-control.pipe';
import { NormalizeTimerPipe } from '../../../shared/pipes/normalize-timer.pipe';

@Component({
  selector: 'pet-world-confirm-page',
  standalone: true,
  imports: [ButtonComponent, ConfirmationCodeItemComponent, ConvertToFormControlPipe, NormalizeTimerPipe],
  templateUrl: './confirmation-code-page.component.html',
  styleUrl: './confirmation-code-page.component.scss',
})
export class ConfirmationCodePageComponent implements OnInit, AfterViewInit {
  readonly buttonContent = BUTTON_CONTENT;
  readonly timerInitialValue = 30;

  confirmationCodeForm!: FormArray;
  counter = signal(this.timerInitialValue);
  notifier = new Subject<void>();

  get isFormValid() {
    return this.confirmationCodeForm.valid;
  }

  constructor(private fb: FormBuilder) {
    this.counterEffect();
  }

  ngOnInit() {
    this.confirmationCodeForm = this.initForm();
  }

  ngAfterViewInit() {
    this.turnOnTimer();
  }

  private initForm(): FormArray {
    return this.fb.array([
      this.fb.control(null, Validators.required),
      this.fb.control(null, Validators.required),
      this.fb.control(null, Validators.required),
      this.fb.control(null, Validators.required),
    ]);
  }

  private counterEffect(): void {
    effect(() => {
      if (!this.counter()) {
        this.notifier.next();
        this.notifier.complete();
      }
    });
  }

  private turnOnTimer(): void {
    interval(1000)
      .pipe(
        tap(() => this.counter.update(value => value - 1)),
        takeUntil(this.notifier),
      )
      .subscribe();
  }
}
