//Imports the component module of Angular 
//Built in modules and other files (services) (models)
//can all be imported at the top
//These using statements in C#, they can be used with existing 
//files or built in ones 
import { Component } from '@angular/core';
import { customer } from './customer';

//These are the settings for this component 
//This is where you tell angular what HTML/CSS files to use 
//This is where you tell angular what services you want to use 
@Component({
  //This sets how we call this component in our HTML files
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

//Component Class - this is where the functionality 
//and data of your component lives
//Why Export our class? 
//That makes the file importable in the rest of our project 
//Think of export in Javascript (node) like public in C# 
//Importing in JS/Node is like our using statement 
export class AppComponent {
  title: string = 'Shop';
  message: string = "Hello There!";
  customer: customer = new customer("Jimmy", 100.00, "Texas", false);
  prices: number[] = [9.00, 15.55, 1.70, 20.01]

}
