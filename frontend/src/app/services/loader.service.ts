import { Injectable, Signal, WritableSignal, signal } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class LoaderService {
  private readonly isLoading$: WritableSignal<boolean> = signal(false);

  readonly isLoading: Signal<boolean> = this.isLoading$.asReadonly();

  show(): void {
    this.isLoading$.set(true);
  }

  hide(): void {
    this.isLoading$.set(false);
  }
}
