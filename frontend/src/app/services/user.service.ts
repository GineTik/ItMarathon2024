import { Injectable, signal, WritableSignal } from '@angular/core';

import type { User } from '../app.model';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private user$: WritableSignal<User | null> = signal<User | null>(null);

  user = this.user$.asReadonly();

  setUser(user: User): void {
    this.user$.set(user);
  }

  isUserVerified(): boolean {
    return this.user$()?.is_verified || false;
  }

  clearUser(): void {
    this.user$.set(null);
  }
}
