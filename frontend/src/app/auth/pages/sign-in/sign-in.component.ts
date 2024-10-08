import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, NonNullableFormBuilder, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { catchError, EMPTY, map, switchMap, take, tap } from 'rxjs';

import {
  BUTTON_CONTENT,
  INPUT_LABELS,
  INPUT_TYPES,
  PLACEHOLDERS,
  ROUTING_LIST,
  TOASTER_MESSAGE,
  TOASTER_TYPE,
} from '../../../app.config';
import { ToasterService } from '../../../services/toaster.service';
import { TokenService } from '../../../services/token.service';
import { UserService } from '../../../services/user.service';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { CheckboxComponent } from '../../../shared/components/checkbox/checkbox.component';
import { InputComponent } from '../../../shared/components/input/input.component';
import { AuthApiService } from '../../services/auth-api.service';

@Component({
  selector: 'pet-world-sign-in',
  standalone: true,
  imports: [ButtonComponent, InputComponent, RouterLink, CheckboxComponent],
  templateUrl: './sign-in.component.html',
  styleUrl: './sign-in.component.scss',
})
export class SignInComponent {
  private readonly fb = inject(NonNullableFormBuilder);
  private readonly router: Router = inject(Router);
  private readonly apiService: AuthApiService = inject(AuthApiService);
  private readonly toasterService: ToasterService = inject(ToasterService);
  private readonly userService = inject(UserService);
  private readonly tokenService = inject(TokenService);

  readonly buttonContent = BUTTON_CONTENT;
  readonly inputLabels = INPUT_LABELS;
  readonly inputTypes = INPUT_TYPES;
  readonly routingList = ROUTING_LIST;
  readonly placeholders = PLACEHOLDERS;

  authForm!: FormGroup;
  confirmCheckboxControl = new FormControl<boolean>(false);

  get username(): FormControl {
    return this.authForm.get('username') as FormControl;
  }

  get password(): FormControl {
    return this.authForm.get('password') as FormControl;
  }

  get isFormValid(): boolean {
    return this.authForm.valid;
  }

  ngOnInit(): void {
    this.authForm = this.initForm();
  }

  protected initForm(): FormGroup {
    return this.fb.group({
      username: ['', { validators: [Validators.required] }],
      password: ['', { validators: [Validators.required] }],
    });
  }

  signIn(): void {
    if (this.authForm.valid) {
      const requestBody = {
        username: this.authForm.value.username,
        password: this.authForm.value.password,
      };

      this.apiService
        .signIn(requestBody)
        .pipe(
          tap(token => this.tokenService.setToken(token)),
          map(token => token.access_token),
          switchMap(this.apiService.getUserByToken.bind(this)),
          tap(user => {
            this.userService.setUser(user);
          }),
          tap(() => this.router.navigate(['/'])),
          take(1),
          catchError(() => {
            this.toasterService.show(TOASTER_TYPE.ERROR, TOASTER_MESSAGE.SERVER_ERROR);

            return EMPTY;
          }),
        )
        .subscribe();
    }
  }
}
