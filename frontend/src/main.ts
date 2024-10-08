import { bootstrapApplication } from '@angular/platform-browser';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { APP_INITIALIZER, provideExperimentalZonelessChangeDetection } from '@angular/core';
import { provideRouter, Router, withHashLocation } from '@angular/router';
import { provideHttpClient, withInterceptors } from '@angular/common/http';

import { AppComponent } from './app/app.component';
import { routes } from './app/app.routes';
import { loaderInterceptor } from './app/services/interceptors/loader.interceptor';
import configLoader from './app/shared/utils/config-loader';
import { DictionaryService } from './app/services/dictionary.service';
import { tokenInterceptor } from './app/services/interceptors/token.interceptor';

bootstrapApplication(AppComponent, {
  providers: [
    provideExperimentalZonelessChangeDetection(),
    provideRouter(routes, withHashLocation()),
    provideHttpClient(withInterceptors([loaderInterceptor, tokenInterceptor])),
    provideAnimationsAsync(),
    {
      provide: APP_INITIALIZER,
      useFactory: configLoader,
      multi: true,
      deps: [DictionaryService, Router],
    },
  ],
}).catch(err => console.error(err));
