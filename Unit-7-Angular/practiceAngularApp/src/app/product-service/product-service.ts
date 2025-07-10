import { Component } from '@angular/core';

@Component({
  selector: 'app-product-service',
  imports: [],
  templateUrl: './product-service.html',
  styleUrl: './product-service.css'
})
export class ProductService {
    inventoryArray: [] = [
      { name: '', productID: '', price: },
      { name: '', productID: '', price: },
      { name: '', productID: '', price: },
      { name: '', productID: '', price: },
      { name: '', productID: '', price: },
      { name: '', productID: '', price: },
    ];
    getAllProducts(): Product[] {
      return this.inventory;
    }
    //const name: string[] = [];
    //name.push("");  

   // const numbers = [1, 2, 3]; // inferred to type number[]
   //numbers.push(4);
   // numbers.push("2"); // Error: Argument of type 'string' is not assignable to parameter of type 'number'.
   // let head: number = numbers[0];
}
