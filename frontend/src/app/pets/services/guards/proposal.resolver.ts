import { ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { inject } from '@angular/core';
import { catchError, EMPTY, Observable } from 'rxjs';

import { PetApiService } from '../pet-api.service';
import { ErrorService } from '../../../services/error.service';
import type { ProposalItem } from '../../../app.model';

const proposalResolver = (route: ActivatedRouteSnapshot, _state: RouterStateSnapshot): Observable<ProposalItem> => {
  const errorService = inject(ErrorService);
  const apiService = inject(PetApiService);
  const id = route.paramMap.get('proposalId');

  if (!id) {
    errorService.navigateToMain();

    return EMPTY;
  }

  // TODO: remove mock id after get pet list implementation
  return apiService.getProposal(+id).pipe(
    catchError(() => {
      errorService.navigateToMain();

      return EMPTY;
    }),
  );
};

export default proposalResolver;
