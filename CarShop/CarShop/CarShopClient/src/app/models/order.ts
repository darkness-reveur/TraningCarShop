import { Car } from "./car";

export interface Order {

  id: number

  sum: number

  date: Date

  cars: Car[]

  userId: number
}
