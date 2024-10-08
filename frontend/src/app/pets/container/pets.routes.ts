import { Routes } from '@angular/router';

import { PetsComponent } from './pets.component';
import { ROUTING_LIST } from '../../app.config';
import { AddNewPetComponent } from '../pages/add-new-pet/add-new-pet.component';
import { PetsCatalogComponent } from '../pages/pets-catalog/pets-catalog.component';
import { PetDetailsComponent } from '../pages/pet-details/pet-details.component';
import proposalResolver from '../services/guards/proposal.resolver';
import addPetCanActivate from '../services/guards/add-pet-can-activate.guard';
import petCatalogResolver from '../services/guards/pet-catalog.resolver';
import { PreviewNewPetComponent } from '../pages/preview-new-pet/preview-new-pet.component';

export default [
  {
    path: '',
    component: PetsComponent,
    children: [
      {
        path: '',
        component: PetsCatalogComponent,
        // REMOVE COMMENT IF YOU HAVE .NET API
        // resolve: {
        //   filterFormData: petCatalogResolver,
        // },
      },
      {
        path: ROUTING_LIST.newPet,
        component: AddNewPetComponent,
        // canActivate: [addPetCanActivate],
      },
      {
        path: `${ROUTING_LIST.newPet}/${ROUTING_LIST.preview}`,
        component: PreviewNewPetComponent,
      },
      {
        path: `:proposalId`,
        component: PetDetailsComponent,
        resolve: {
          proposal: proposalResolver,
        },
      },
    ],
  },
] as Routes;
