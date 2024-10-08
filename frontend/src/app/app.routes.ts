import { Routes } from '@angular/router';

import { MainComponent } from './main/container/main.component';
import { ROUTING_LIST } from './app.config';
import profileCanActivate from './profile/services/guards/profile-can-activate.guard';
import mainResolver from './main/services/guards/main.resolver';

export const routes: Routes = [
  {
    path: '',
    component: MainComponent,
    resolve: {
      proposalList: mainResolver,
    },
  },
  {
    path: ROUTING_LIST.auth,
    loadChildren: () => import('./auth/container/auth.routes'),
  },
  {
    path: ROUTING_LIST.pets,
    loadChildren: () => import('./pets/container/pets.routes'),
  },
  {
    path: ROUTING_LIST.me,
    loadChildren: () => import('./profile/container/profile.routes'),
    canActivate: [profileCanActivate],
  },
];
