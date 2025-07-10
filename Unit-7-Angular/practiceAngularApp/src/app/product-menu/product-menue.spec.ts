import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductMenue } from './product-menue';

describe('ProductMenue', () => {
  let component: ProductMenue;
  let fixture: ComponentFixture<ProductMenue>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProductMenue]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProductMenue);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
