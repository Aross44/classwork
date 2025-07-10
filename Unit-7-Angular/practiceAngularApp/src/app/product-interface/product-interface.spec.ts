import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductInterface } from './product-interface';

describe('ProductInterface', () => {
  let component: ProductInterface;
  let fixture: ComponentFixture<ProductInterface>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProductInterface]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProductInterface);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
