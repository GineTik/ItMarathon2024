import { Component, DestroyRef, inject, OnInit, Signal } from '@angular/core';
import { AsyncPipe, NgClass } from '@angular/common';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { Router } from '@angular/router';
import { FormControl } from '@angular/forms';
import { skip, switchMap, tap } from 'rxjs';

import { SelectComponent } from '../../../shared/components/select/select.component';
import { INPUT_LABELS, PLACEHOLDERS, ROUTING_LIST, SORT_OPTIONS_LIST } from '../../../app.config';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { PetCardComponent } from '../../../shared/components/pet-card/pet-card.component';
import { FilterFormComponent } from '../../components/filter-form/filter-form.component';
import { DictionaryService } from '../../../services/dictionary.service';
import { PetApiService } from '../../services/pet-api.service';
import { FilterService } from '../../../services/filter.service';
import type { ChipsItem, ExpandedPropertyValue, FilterFormValue, ProposalItem } from '../../../app.model';

@Component({
  selector: 'pet-world-pets-catalog',
  standalone: true,
  imports: [SelectComponent, ButtonComponent, PetCardComponent, NgClass, FilterFormComponent, AsyncPipe],
  templateUrl: './pets-catalog.component.html',
  styleUrl: './pets-catalog.component.scss',
})
export class PetsCatalogComponent implements OnInit {
  readonly labelTypes: typeof INPUT_LABELS = INPUT_LABELS;
  readonly placeholders: typeof PLACEHOLDERS = PLACEHOLDERS;
  readonly sortOptions: typeof SORT_OPTIONS_LIST = SORT_OPTIONS_LIST;

  private readonly router = inject(Router);
  private readonly destroyRef = inject(DestroyRef);
  private readonly apiService = inject(PetApiService);
  private readonly dictionaryService = inject(DictionaryService);
  private readonly filterService = inject(FilterService);

  healthList: ChipsItem[] = [];
  documentList: ChipsItem[] = [];
  petTypes!: ExpandedPropertyValue[];
  breedList!: ExpandedPropertyValue[];

  proposals!: Signal<ProposalItem[]>;

  isHorizontal: boolean = true;
  readonly sortingControl = new FormControl();

  ngOnInit() {
    this.healthList = this.dictionaryService.getHealthList();
    this.documentList = this.dictionaryService.getDocumentsList();
    this.petTypes = this.dictionaryService.getAnimalTypes();
    this.getPetList();
    this.setSortData();
    this.onSortChange();
  }

  toggleView(): void {
    this.isHorizontal = !this.isHorizontal;
  }

  onProposal(id: number): void {
  }

  getBreedList(animalType: ExpandedPropertyValue): void {
    this.breedList = this.dictionaryService.getBreeds(animalType);
  }

  onFilterForm(filterFormValue: FilterFormValue): void {
    this.filterService.setQueryFilter(filterFormValue);

    this.apiService.getProposalList().subscribe();
  }

  private setSortData(): void {
    const sortData = this.filterService.getSortingState();
    this.sortingControl.setValue(sortData, { emitEvent: false });
  }

  private getPetList(): void {
    this.proposals = this.apiService.petList;
  }

  private onSortChange(): void {
    this.sortingControl.valueChanges
      .pipe(
        skip(1),
        tap(value => this.filterService.setSorting(value)),
        switchMap(() => this.apiService.getProposalList()),
        takeUntilDestroyed(this.destroyRef),
      )
      .subscribe();
  }
}
