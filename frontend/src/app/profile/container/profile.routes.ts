import { Routes } from '@angular/router';

import { ProfileComponent } from './profile.component';
import profileResolver from '../services/guards/profile.resolver';

export default [
  {
    path: '',
    component: ProfileComponent,
    resolve: {
      proposals: profileResolver,
    },
  },
] as Routes;
