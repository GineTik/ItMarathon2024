import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'normalizeTimer',
  standalone: true,
})
export class NormalizeTimerPipe implements PipeTransform {
  transform(value: number): string {
    return value >= 10 ? value.toString() : `0${value}`;
  }
}
