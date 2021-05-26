import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from '../models/car';

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  private url = `${location}api/car`

  constructor(private http: HttpClient) { }

  public getAllCars(): Observable<Car[]> {
    return this.http.get<Car[]>(`${this.url}`);
  }
}
