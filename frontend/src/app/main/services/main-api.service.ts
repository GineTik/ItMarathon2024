import { inject, Injectable } from '@angular/core';

import { ApiService } from '../../services/api.service';
import { FilterService } from '../../services/filter.service';

@Injectable({
  providedIn: 'root',
})
export class MainApiService {
  private readonly apiService = inject(ApiService);
  private readonly filterService = inject(FilterService);

  getProposalList() {
    const query = this.filterService.mainPageFilter();

    return this.apiService.getProposalList(query);
  }
}
