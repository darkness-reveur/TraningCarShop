import { Car } from "./car";

export interface BrandModel {

  id: number

  name: string

  cars: Car[]

  carBrandId: number
}
