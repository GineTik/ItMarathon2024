import { Injectable, Signal, WritableSignal, signal } from '@angular/core';
import { TOASTER_MESSAGE, TOASTER_TYPE } from '../app.config';

@Injectable({
  providedIn: 'root',
})
export class ToasterService {
  private readonly isToasterShowed$: WritableSignal<boolean> = signal(false);
  private readonly toasterType$: WritableSignal<TOASTER_TYPE> = signal(TOASTER_TYPE.WARNING);
  private readonly toasterMessage$: WritableSignal<TOASTER_MESSAGE> = signal(TOASTER_MESSAGE.UNAUTHENTICATED);

  readonly isToasterShowed: Signal<boolean> = this.isToasterShowed$.asReadonly();
  readonly toasterType: Signal<TOASTER_TYPE> = this.toasterType$.asReadonly();
  readonly toasterMessage: Signal<TOASTER_MESSAGE> = this.toasterMessage$.asReadonly();

  show(type: TOASTER_TYPE, message: TOASTER_MESSAGE): void {
    this.isToasterShowed$.set(true);
    this.toasterType$.set(type);
    this.toasterMessage$.set(message);
  }

  hide(): void {
    this.isToasterShowed$.set(false);
  }
}
