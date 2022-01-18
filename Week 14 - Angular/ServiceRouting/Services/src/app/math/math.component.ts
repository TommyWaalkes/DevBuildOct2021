import { Component, OnInit } from '@angular/core';
import { GeometryService } from '../geometry.service';

@Component({
  selector: 'app-math',
  templateUrl: './math.component.html',
  styleUrls: ['./math.component.css']
})
export class MathComponent implements OnInit {

  constructor(private geometry: GeometryService) { }

  ngOnInit(): void {
    console.log(this.CalcSquare());
  }
  CalcSquare(): number {
    let length: number = 5;
    let width: number = 10;
    let result: number = this.geometry.SquareArea(length, width);
    return result;

  }
}
