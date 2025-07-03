import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  static service(arg0: string, arg1: () => void) {
    throw new Error('Method not implemented.');
  }
  protected title = 'PracticeAssessment6';
}

interface Product {
  name: string;
  productID: string;
  price: string;
 }






 // array of objects

 let inventory = [
  { type: "h1", fontSize: 32 },
  { type: "h2", fontSize: 24 },
  { type: "h3", fontSize: 18 }
 ];
 inventory.push( { type: "h4", fontSize: 16 } );
 console.log( inventory[0].fontSize ); // 32
 inventory[2].fontSize = 18.7; // replace 18


 //Typescript type

 const product1: { name: string, productID: string, price: number } = {
  name: "item1",
  productID: "homegoods",
  price: 120
};

const product2: { name: string, productID: string, price: number } = {
  name: "item2",
  productID: "apperal",
  price: 25
};
const product3: { name: string, productID: string, price: number } = {
  name: "item3",
  productID: "appliances",
  price: 500
};

const product4: { name: string, productID: string, price: number } = {
  name: "item4",
  productID: "sportsgoods",
  price: 70
};

const product5: { name: string, productID: string, price: number } = {
  name: "wellness",
  productID: "item4",
  price: 35
};

const product6: { name: string, productID: string, price: number } = {
  name: "beauty",
  productID: "item6",
  price: 15
};

product1.name =  () {
  return this.product1Name + " beauty " + this.lastName;
};