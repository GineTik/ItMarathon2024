import { ActivatedRouteSnapshot, Router, RouterStateSnapshot } from '@angular/router';
import { inject } from '@angular/core';
import { catchError, EMPTY, Observable } from 'rxjs';

import { ProfileApiService } from '../profile-api.service';
import { ToasterService } from '../../../services/toaster.service';
import { TOASTER_MESSAGE, TOASTER_TYPE } from '../../../app.config';
import { UserService } from '../../../services/user.service';

const profileResolver = (_route: ActivatedRouteSnapshot, _state: RouterStateSnapshot): Observable<any> => {
  const router = inject(Router);
  const apiService = inject(ProfileApiService);
  const userService = inject(UserService);
  const user = userService.user()!;
  const toasterService = inject(ToasterService);

  return apiService.getUserProposals(Number(user.id), 4).pipe(
    catchError(() => {
      void router.navigate(['/']);
      toasterService.show(TOASTER_TYPE.ERROR, TOASTER_MESSAGE.SERVER_ERROR);

      return EMPTY;
    }),
  );
};

export default profileResolver;
