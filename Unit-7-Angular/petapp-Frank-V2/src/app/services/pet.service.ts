// Created via ng g service services/pet.service
// Which makes it Dependency Injectable automatically
//       and creates an empty constructor
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})


// The class of the service (aka module) contains the data and functions to manage the data
export class PetService {

 // Typically data is kept in an array insidethe service
 // and is described by an interface
 petData : any[] = []
  
 // Constructor is run when the service is strated
 // Initialize any data (assign it, get from file, data base or API)
 
 constructor() { 
this.petData.push({name: 'Jenna'  type:Dog})





 }

// Provide a function to return the array of data
getPetData() : PetInfo[]{
    return this.petData;
}

}
