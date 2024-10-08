import { ActivatedRouteSnapshot, Router, RouterStateSnapshot } from '@angular/router';
import { inject } from '@angular/core';
import { catchError, EMPTY, Observable } from 'rxjs';

import { PetApiService } from '../pet-api.service';
import { ToasterService } from '../../../services/toaster.service';
import { TOASTER_MESSAGE, TOASTER_TYPE } from '../../../app.config';
import type { ProposalResponse } from '../../../app.model';

const petCatalogResolver = (
  _route: ActivatedRouteSnapshot,
  _state: RouterStateSnapshot,
): Observable<ProposalResponse> => {
  const router = inject(Router);
  const apiService = inject(PetApiService);
  const toasterService = inject(ToasterService);

  return apiService.getProposalList().pipe(
    catchError(() => {
      void router.navigate(['/']);
      toasterService.show(TOASTER_TYPE.ERROR, TOASTER_MESSAGE.SERVER_ERROR);

      return EMPTY;
    }),
  );
};

export default petCatalogResolver;
