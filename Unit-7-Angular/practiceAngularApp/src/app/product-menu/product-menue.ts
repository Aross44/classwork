import { Component } from '@angular/core';
import { Product } from '../product';
import { ProductService } from '../product.service';
@Component({
  selector: 'app-product-menue',
  imports: [],
  templateUrl: './product-menue.html',
  styleUrl: './product-menue.css'
})
export class ProductMenue implements OnInit {   // idk?
  allProducts: Product[] = [];

  ngOnInit(): void {
    const service = new ProductService();
    this.allProducts = service.getAllProducts();
  }

}
