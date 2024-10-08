import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'priceFormat',
  standalone: true,
})
export class PriceFormatPipe implements PipeTransform {
  transform(value: number | string, currency: string = ''): unknown {
    if (!value && value !== 0) {
      return '';
    }

    let numberValue = typeof value === 'string' ? parseFloat(value) : value;
    if (numberValue === 0) {
      return 'Безкоштовно';
    }

    const [integerPart, decimalPart] = numberValue.toFixed(2).split('.');
    const formattedInteger = integerPart.replace(/\B(?=(\d{3})+(?!\d))/g, ' ');
    const formattedPrice = `${formattedInteger}, ${decimalPart}`;

    return currency ? `${currency} ${formattedPrice}` : formattedPrice;
  }
}
