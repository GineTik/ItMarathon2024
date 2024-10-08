import { inject, Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';

import { ApiService } from '../../services/api.service';
import { STORAGE_KEYS } from '../../app.config';
import type { LoginRequestData, SignUpData } from '../auth.model';
import type { Token, User } from '../../app.model';

@Injectable({
  providedIn: 'root',
})
export class AuthApiService {
  private readonly apiService: ApiService = inject(ApiService);

  signUp(formValue: SignUpData): Observable<User> {
    return this.apiService.signUp(formValue);
  }

  signIn(formValue: LoginRequestData): Observable<Token> {
    return this.apiService.signIn(formValue);
  }

  getUserByToken(token: string): Observable<User> {
    return this.apiService.getUserByToken(token).pipe(
      tap(user => {
        localStorage.setItem(STORAGE_KEYS.USER, JSON.stringify(user));
      }),
    );
  }

  forgotPassword(email: string): Observable<string> {
    return this.apiService.forgotPassword(email);
  }

  createNewPassword(password: string): Observable<string> {
    return this.apiService.createNewPassword(password);
  }
}
