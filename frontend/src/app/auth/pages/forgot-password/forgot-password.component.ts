import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Observable, switchMap, take, tap } from 'rxjs';

import { BUTTON_CONTENT, INPUT_LABELS, PLACEHOLDERS, ROUTING_LIST } from '../../../app.config';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { InputComponent } from '../../../shared/components/input/input.component';
import { AuthApiService } from '../../services/auth-api.service';
import { SentLinkModalComponent } from '../../components/sent-link-modal/sent-link-modal.component';

@Component({
  selector: 'pet-world-forgot-password',
  standalone: true,
  imports: [ButtonComponent, InputComponent],
  templateUrl: './forgot-password.component.html',
  styleUrl: './forgot-password.component.scss',
})
export class ForgotPasswordComponent {
  private readonly router = inject(Router);
  private readonly apiService = inject(AuthApiService);
  private readonly dialog = inject(MatDialog);

  readonly buttonContent = BUTTON_CONTENT;
  readonly inputLabels = INPUT_LABELS;
  readonly placeholders = PLACEHOLDERS;
  readonly email = new FormControl('', [Validators.required, Validators.email]);

  get isEmailInvalid(): boolean {
    return this.email.invalid;
  }

  onResetPassword(): void {
    if (this.email.invalid) return;

    const email = this.email.value || '';

    this.apiService
      .forgotPassword(email)
      .pipe(
        tap(() => void this.router.navigateByUrl(`/${ROUTING_LIST.auth}/${ROUTING_LIST.createNewPassword}`)),
        switchMap(this.openSuccessDialog.bind(this)),
        take(1),
      )
      .subscribe();
  }

  private openSuccessDialog(): Observable<void> {
    return this.dialog
      .open(SentLinkModalComponent, {
        data: { email: this.email.value },
        minWidth: '600px',
      })
      .afterClosed();
  }
}
