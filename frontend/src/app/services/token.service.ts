import { Injectable } from '@angular/core';

import { STORAGE_KEYS } from '../app.config';
import type { Token } from '../app.model';

@Injectable({
  providedIn: 'root',
})
export class TokenService {
  private token = '';

  setToken(token: Token): void {
    localStorage.setItem(STORAGE_KEYS.TOKEN, token.access_token);
    this.token = token.access_token;
  }

  getToken(): string {
    const token = localStorage.getItem(STORAGE_KEYS.TOKEN)!;
    return this.token || token;
  }

  clearToken(): void {
    localStorage.removeItem(STORAGE_KEYS.TOKEN);
    this.token = '';
  }
}
