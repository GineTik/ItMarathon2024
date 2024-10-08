import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { catchError, EMPTY } from 'rxjs';
import { UserService } from '../user.service';
import { TokenService } from '../token.service';
import { Router } from '@angular/router';
import { ROUTING_LIST, TOASTER_MESSAGE, TOASTER_TYPE } from '../../app.config';
import { ToasterService } from '../toaster.service';

export const tokenInterceptor: HttpInterceptorFn = (
  req,
  next,
  router = inject(Router),
  userService = inject(UserService),
  tokenService = inject(TokenService),
  toasterService = inject(ToasterService),
) => {
  return next(req).pipe(
    catchError(({ status, statusText }) => {
      if (status === 401 && statusText === 'Unauthorized') {
        userService.clearUser();
        tokenService.clearToken();
        void router.navigate([ROUTING_LIST.auth, ROUTING_LIST.signIn]).then(() => {
          toasterService.show(TOASTER_TYPE.WARNING, TOASTER_MESSAGE.SESSION_EXPIRED);
        });
      }

      return EMPTY;
    }),
  );
};
