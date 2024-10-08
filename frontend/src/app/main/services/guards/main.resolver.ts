import { ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { inject } from '@angular/core';
import { catchError, EMPTY, Observable, of } from 'rxjs';

import { ErrorService } from '../../../services/error.service';
import { MainApiService } from '../main-api.service';
import PET_RESPONSE_MOCK from '../../../pet-response.mock';

const mainResolver = (_route: ActivatedRouteSnapshot, _state: RouterStateSnapshot): Observable<any> => {
  const errorService = inject(ErrorService);
  const apiService = inject(MainApiService);

  // REMOVE COMMENT IF YOU HAVE .NET API
  // return apiService.getProposalList().pipe(
  return of(PET_RESPONSE_MOCK).pipe(
    catchError(() => {
      errorService.showGeneralError();

      return EMPTY;
    }),
  );
};

export default mainResolver;
