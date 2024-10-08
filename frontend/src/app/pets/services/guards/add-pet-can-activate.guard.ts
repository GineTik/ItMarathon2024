import { CanActivateFn, Router, UrlTree } from '@angular/router';
import { inject } from '@angular/core';
import { Observable } from 'rxjs';

import { UserService } from '../../../services/user.service';
import { ROUTING_LIST } from '../../../app.config';

const addPetCanActivate: CanActivateFn = (): Observable<boolean | UrlTree> | boolean | UrlTree => {
  const router = inject(Router);
  const userService = inject(UserService);

  if (!userService.user()) {
    return router.createUrlTree([ROUTING_LIST.auth, ROUTING_LIST.signIn]);
  }

  if (!userService.user()?.is_verified || !userService.user()?.phone_number) {
    return router.createUrlTree([ROUTING_LIST.me]);
  }

  return true;
};

export default addPetCanActivate;
