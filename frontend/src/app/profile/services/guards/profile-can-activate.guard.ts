import { CanActivateFn, Router, UrlTree } from '@angular/router';
import { inject } from '@angular/core';
import { Observable } from 'rxjs';

import { ROUTING_LIST } from '../../../app.config';
import { UserService } from '../../../services/user.service';

const profileCanActivate: CanActivateFn = (): Observable<boolean | UrlTree> | boolean | UrlTree => {
  const router = inject(Router);
  const userService = inject(UserService);

  return !userService.user() ? router.createUrlTree([ROUTING_LIST.auth, ROUTING_LIST.signIn]) : true;
};

export default profileCanActivate;
