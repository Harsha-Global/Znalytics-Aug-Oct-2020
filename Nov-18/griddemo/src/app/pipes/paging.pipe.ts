import { Pipe, PipeTransform } from '@angular/core';
import { Product } from '../models/product';

@Pipe({
  name: 'paging',
})
export class PagingPipe implements PipeTransform {
  transform(
    value: Product[],
    pageSize: number,
    currentPageIndex: number
  ): Product[] {
    if (!value) {
      return value;
    }
    if (value.length == 0) {
      return value;
    }

    var startIndex = currentPageIndex * pageSize;
    var endIndex = startIndex + pageSize;

    var newData = value.slice(startIndex, endIndex);

    return newData;
  }
}

//0    startIndex = 0     endIndex 4
//1    startIndex = 5      to 9
//2    startIndex = 10    to 14
