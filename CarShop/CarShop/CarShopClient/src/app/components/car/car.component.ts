import { Component, Input, OnInit } from '@angular/core';
import { Car } from 'src/app/models/car';
import { ShopService } from 'src/app/services/shop.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.scss']
})
export class CarComponent implements OnInit {

  @Input() action!: string

  @Input() carsList!: Car[]

  constructor(private carService: ShopService) { }

  ngOnInit(): void {
  }

}
