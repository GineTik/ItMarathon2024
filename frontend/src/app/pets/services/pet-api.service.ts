import { inject, Injectable, signal } from '@angular/core';
import { Observable, tap } from 'rxjs';

import { ApiService } from '../../services/api.service';
import { FilterService } from '../../services/filter.service';
import type { FilterFormValue, PetRequestBody, ProposalItem, ProposalResponse } from '../../app.model';
import PET_RESPONSE_MOCK from '../../pet-response.mock';

@Injectable({
  providedIn: 'root',
})
export class PetApiService {
  private apiService = inject(ApiService);
  private filterService = inject(FilterService);
  private readonly petList$ = signal<ProposalItem[]>(PET_RESPONSE_MOCK.items);

  readonly petList = this.petList$.asReadonly();

  addProposal(proposalData: PetRequestBody): Observable<any> {
    return this.apiService.addProposal(proposalData);
  }

  getProposalList(): Observable<ProposalResponse> {
    const query = this.filterService.getFilterQuery();

    return this.apiService.getProposalList(query).pipe(tap(res => this.petList$.set(res.items)));
  }

  getProposal(id: number): Observable<ProposalItem> {
    return this.apiService.getProposal(id);
  }

  updateProposal(proposalId: number, proposalData: Partial<any>): Observable<any> {
    return this.apiService.updateProposal(proposalId, proposalData);
  }
}
