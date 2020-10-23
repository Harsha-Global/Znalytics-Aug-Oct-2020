import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'thousandsConverter'
})
export class ThousandsConverterPipe implements PipeTransform
{
  transform(value: number, args: any): string
  {
    var n = value / 1000;
    var result = Math.round(n) + args[0];
    return result;
  }
}
