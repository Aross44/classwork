import { Component } from '@angular/core';
import { productService} from '';
}
@Component({
  selector: 'app-product-service',
  imports: [],
  templateUrl: './product-service.html',
  styleUrl: './product-service.css'
})
export class ProductService  {
    inventoryArray: [] = [
      { name: 'Volume1', productID: 'Ar101', price: 25},
      { name: 'Volume2', productID: 'Ar102', price: 50},
      { name: 'Volume3', productID: 'Ar1013', price: 75},
      { name: 'Volume4', productID: 'Ar104', price: 100},
      { name: 'Volume5', productID: 'Ar105', price: 125},
      { name: 'Volume6', productID: 'Ar106', price: 150},
    ];










    getAllProducts(): Product[]  {
      return this.inventory;
    }
    //const name: string[] = [];
    //name.push("");  

   // const numbers = [1, 2, 3]; // inferred to type number[]
   //numbers.push(4);
   // numbers.push("2"); // Error: Argument of type 'string' is not assignable to parameter of type 'number'.
   // let head: number = numbers[0];
}
