import { Component } from '@angular/build'
import { PetInfo } from '../../folder/pet.info'
import { PetService } from '../../services/pet.service'



imports: [],
templateURL: './pet-display.html',
StyleURL: './pet- display.css'

// We need to be sure we have a copy of the data so our html can use it 
//Call the service that has the data to get the data

ourPetInfo : PetInfo[]

constructor(thePetData : PetService) {
this.our 
}