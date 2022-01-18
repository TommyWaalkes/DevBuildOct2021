import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GeometryService {

  constructor() { }

  SquareArea(length: number, width: number): number {
    return length * width;
  }
}
