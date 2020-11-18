import { Pipe } from '@angular/core';
import { Product } from '../models/product';

@Pipe({
  name: 'sort',
})
export class SortPipe {
  transform(
    response: Product[],
    sortBy: string,
    sortOrder: string = 'ASC'
  ): Product[] {
    //calling "sort" method of JS arrays
    response.sort((a, b) => {
      //checking whether both arguments are truthy values: not null, not undefined, not 0, not ""
      if (a[sortBy] && b[sortBy]) {
        //store values to compare in two variables
        let firstValue = a[sortBy];
        let secondValue = b[sortBy];

        //checking data type of column value
        if (typeof firstValue == 'string' && typeof secondValue == 'string') {
          firstValue = firstValue[0].toString().toLowerCase();
          secondValue = secondValue[0].toString().toLowerCase();
        }

        if (firstValue < secondValue) {
          return -1;
        } else if (firstValue > secondValue) {
          return 1;
        } else {
          return 0;
        }
      } else {
        return 0;
      }
    }); //end of sort() method of JS arrays

    if (sortOrder == 'DESC') {
      response = response.reverse();
    }
    return response;
  }
}

//less than 0        :   a comes before b
//greater than 0  :   b comes before a
//equal to 0         :   a and b are left unchanged
