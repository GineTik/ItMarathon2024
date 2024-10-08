import { inject, Injectable } from '@angular/core';

import { ApiService } from '../../services/api.service';
import { FilterService } from '../../services/filter.service';

@Injectable({
  providedIn: 'root',
})
export class ProfileApiService {
  private readonly apiService = inject(ApiService);
  private readonly filerService = inject(FilterService);

  getUserProposals(userId: number, top: number) {
    const query = this.filerService.profilePageFilter(userId, top);

    return this.apiService.getProposalList(query);
  }
}
