import { Component } from '@angular/core';
import { Car } from './models/car';
import { ShopService } from './services/shop.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'CarShopClient';

  cars: Car[] = []

  constructor(private shopService: ShopService) {

  }

  getAllCars(){
    this.shopService.getAllCars().subscribe(result => {
      if (result){
        this.cars = result
      }
    })
  }
}
