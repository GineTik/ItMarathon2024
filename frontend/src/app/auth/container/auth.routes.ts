import { AuthComponent } from './auth.component';
import { Routes } from '@angular/router';

import { ROUTING_LIST } from '../../app.config';
import { SignInComponent } from '../pages/sign-in/sign-in.component';
import { ConfirmationCodePageComponent } from '../pages/confirmation-code-page/confirmation-code-page.component';
import { ForgotPasswordComponent } from '../pages/forgot-password/forgot-password.component';
import { SignUpComponent } from '../pages/sign-up/sign-up.component';
import { CreateNewPasswordComponent } from '../pages/create-new-password/create-new-password.component';

export default [
  {
    path: '',
    component: AuthComponent,
    children: [
      {
        path: '',
        redirectTo: ROUTING_LIST.signIn,
        pathMatch: 'full',
      },
      {
        path: ROUTING_LIST.signIn,
        component: SignInComponent,
      },
      {
        path: ROUTING_LIST.signUp,
        component: SignUpComponent,
      },
      {
        path: ROUTING_LIST.confirmation,
        component: ConfirmationCodePageComponent,
      },
      {
        path: ROUTING_LIST.forgotPassword,
        component: ForgotPasswordComponent,
      },
      {
        path: ROUTING_LIST.createNewPassword,
        component: CreateNewPasswordComponent,
      },
    ],
  },
] as Routes;
