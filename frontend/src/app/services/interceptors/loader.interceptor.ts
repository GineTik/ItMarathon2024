import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { LoaderService } from '../loader.service';
import { finalize } from 'rxjs';

export const loaderInterceptor: HttpInterceptorFn = (req, next, loaderService = inject(LoaderService)) => {
  loaderService.show();

  return next(req).pipe(finalize(() => loaderService.hide()));
};
