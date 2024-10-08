import { Component, inject, OnInit } from '@angular/core';
import { AsyncPipe } from '@angular/common';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { map, Observable } from 'rxjs';

import { BUTTON_CONTENT, INPUT_LABELS, PLACEHOLDERS, ROUTING_LIST } from '../../app.config';
import CITY_LIST from '../../../city-db';
import { SelectComponent } from '../../shared/components/select/select.component';
import { ButtonComponent } from '../../shared/components/button/button.component';
import { PetCategoriesComponent } from '../components/pet-categories/pet-categories.component';
import { PetCardComponent } from '../../shared/components/pet-card/pet-card.component';
import { FilterService } from '../../services/filter.service';
import { DictionaryService } from '../../services/dictionary.service';
import type { ExpandedPropertyValue, MainFilterForm, ProposalItem } from '../../app.model';

@Component({
  selector: 'pet-world-main',
  standalone: true,
  imports: [RouterLink, SelectComponent, ButtonComponent, PetCategoriesComponent, PetCardComponent, AsyncPipe],
  templateUrl: './main.component.html',
  styleUrl: './main.component.scss',
})
export class MainComponent implements OnInit {
  private readonly route = inject(ActivatedRoute);
  private readonly router = inject(Router);
  private readonly fb = inject(FormBuilder);
  private readonly dictionaryService = inject(DictionaryService);
  private readonly filterService = inject(FilterService);

  readonly routingList: typeof ROUTING_LIST = ROUTING_LIST;
  readonly labelTypes: typeof INPUT_LABELS = INPUT_LABELS;
  readonly placeholders: typeof PLACEHOLDERS = PLACEHOLDERS;
  readonly buttonContent: typeof BUTTON_CONTENT = BUTTON_CONTENT;
  readonly cityList: typeof CITY_LIST = CITY_LIST;

  filterForm!: FormGroup;
  animalTypes!: ExpandedPropertyValue[];
  proposals$!: Observable<ProposalItem[]>;

  get animalType(): FormControl {
    return this.filterForm.get('animalType') as FormControl;
  }

  get location(): FormControl {
    return this.filterForm.get('location') as FormControl;
  }

  ngOnInit() {
    this.filterForm = this.initForm();
    this.animalTypes = this.dictionaryService.getAnimalTypes();
    this.getPageData();
  }

  onSearch(): void {
    this.filterService.setQueryFilter(this.filterForm.value);
    void this.router.navigate([ROUTING_LIST.pets]);
  }

  onProposal(id: number): void {
  }

  private initForm(): FormGroup<MainFilterForm> {
    return (this.filterForm = this.fb.group({
      animalType: [null as unknown as ExpandedPropertyValue],
      location: [null as unknown as string],
    }));
  }

  private getPageData(): void {
    this.proposals$ = this.route.data.pipe(map(data => data['proposalList'].items));
  }
}
