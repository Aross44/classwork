import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Product } from '../product';
import { ProductService } from '../product-service/product-service';
import { OnInit } from '@angular/core';
@Component({
  imports: [CommonModule],
  selector: 'app-product-menue',
  standalone : true,
  templateUrl: './product-menue.html',
  styleUrl: './product-menue.css',
})
export class ProductMenue implements OnInit {   // idk?
  allProducts: Product[] = [];

  ngOnInit(): void {
    const service = new ProductService();
    this.allProducts = service.getAllProducts();
  }

}
