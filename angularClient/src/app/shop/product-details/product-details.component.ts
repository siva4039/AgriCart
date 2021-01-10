import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BreadcrumbService } from 'params-xng-breadcrumb';
import { BasketService } from 'src/app/basket/basket.service';
import { Iproduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
  product: Iproduct;
  quantity = 1

  constructor(private shopService: ShopService, private activateRoute: ActivatedRoute, private bcService: BreadcrumbService, private basketService: BasketService ) {

    this.bcService.set('@productDetails', '');
   }

  ngOnInit() {
    this.loadProduct();
  }
  addItemToBasket() {
    this.basketService.addItemBasket(this.product,this.quantity);
  }

  incrementQuantity() {
    this.quantity++;
  }
  decrementQuantity() {
    if(this.quantity >1) {
      this.quantity--;
    }
  }


  loadProduct() {
    this.shopService.getProduct(+this.activateRoute.snapshot.paramMap.get('id')).subscribe(product => {
      this.product = product;
      this.bcService.set('@productDetails', product.name)
    },error => {
      console.log(error);

    })
  }

}
