//import injectable - this makes the service 
//useable with dependcy injection (without this import 
//your injection must be done manually, which is an awkward)
import { Injectable } from '@angular/core';

//Injectable decorator - this tells angular 
//Where the service should be availiable 
//Usually you leave this in root, if the service is in route 
//Then it's useable anywhere in the app
@Injectable({
  providedIn: 'root'
})

//This class is where we write our code for our service 
//Usually this will consist of some useful functions
//and/or data we want available to our whole app

//Javascript/Angular DALs usually exist in services 
//This gets our DAL code to live inside of just one file 
export class TempConverterService {

  constructor() { }

  FtoC(tempF: number): number {
    let tempC: number = (tempF - 32) * 5 / 9;
    return tempC;
  }

  CtoF(tempC: number): number {
    let tempF: number = (tempC * 9 / 5) + 32;
    return tempF;

  }

}
