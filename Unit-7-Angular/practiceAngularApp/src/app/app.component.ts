// filepath: src/app/app.component.ts
import { Component } from '@angular/core';

import { ProductMenue } from './product-menu/product-menue';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'product-menue',
  standalone: true,
  imports: [], // <-- This line is required for standalone components!
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {tittle= 'Sports Online Shopping';}