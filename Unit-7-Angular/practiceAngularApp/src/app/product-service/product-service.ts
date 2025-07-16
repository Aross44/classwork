//import { Component } from '@angular/core';
import { Product } from '../product';  
import { Injectable } from '@angular/core'; 


@Injectable({  providedIn: 'root'})
export class ProductService {
    Inventory: Product[] = [
      { name: 'LaptopCase', productID: 'Ar101', price: 25},
      { name: 'Mouse', productID: 'Ar102', price: 50},
      { name: 'Charger', productID: 'Ar1013', price: 75},
      { name: 'PrivacyScreen', productID: 'Ar104', price: 100},
      { name: 'ExternalHardrive', productID: 'Ar105', price: 125},
      { name: 'Webcam', productID: 'Ar106', price: 150},
    ]










    getAllProducts(): Product[] {
      return this.Inventory;

    }

  }


 

    










    