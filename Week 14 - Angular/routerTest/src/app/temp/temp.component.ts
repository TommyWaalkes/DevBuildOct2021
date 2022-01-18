import { Component, OnInit } from '@angular/core';
import { TempConverterService } from '../temp-converter.service';

//Settings for the component and pointers to the other 
//parts of the component
@Component({
    selector: 'app-temp',
    templateUrl: './temp.component.html'
})

//A bulk of your time with component will be spent in the 
//Component class
export class TempComponent implements OnInit {

    constructor(private tempService: TempConverterService) { }
    tempF: number = 50;
    //the this keyword means the same thing in JS classes as in C# classes 
    //BUT there's one big difference. For method and variables 
    //In this Typescript class, they MUST use the this keyword when refering to 
    //methods/variables in this class. 

    //Reason being is that in JS there's the possibly that functions 
    //with the same may be floating around. 
    tempC: number = this.tempService.FtoC(this.tempF);
    ngOnInit(): void {
    }

    convertInput() {
        this.tempF = parseInt((<HTMLInputElement>document.getElementById("InputF")).value);
        this.tempC = this.tempService.FtoC(this.tempF);
    }


}
