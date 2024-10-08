import { Pipe, PipeTransform } from '@angular/core';

import { ChipsItem } from '../../app.model';

@Pipe({
  name: 'isChipsActive',
  standalone: true,
})
export class IsChipsActivePipe implements PipeTransform {
  transform(chips: ChipsItem, chipsList: ChipsItem[]): boolean {
    return chipsList.some(({ name }) => name === chips.name);
  }
}
