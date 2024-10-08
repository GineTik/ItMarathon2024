import { inject, Injectable } from '@angular/core';
import { Router } from '@angular/router';

import { ToasterService } from './toaster.service';
import { TOASTER_MESSAGE, TOASTER_TYPE } from '../app.config';

@Injectable({
  providedIn: 'root',
})
export class ErrorService {
  private readonly router = inject(Router);
  private readonly toasterService = inject(ToasterService);

  navigateToMain(): void {
    void this.router.navigate(['/']);
    this.toasterService.show(TOASTER_TYPE.ERROR, TOASTER_MESSAGE.SERVER_ERROR);
  }

  showGeneralError(): void {
    this.toasterService.show(TOASTER_TYPE.ERROR, TOASTER_MESSAGE.SERVER_ERROR);
  }
}
