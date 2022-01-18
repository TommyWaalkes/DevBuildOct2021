import { Component } from '@angular/core';
import { Country } from './Country';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  countries: Country[] = [
    new Country("Shrekadonia", "English", "shrek.jpg", "Shrek"),
    new Country("Icantastan", "Icantaneese", "", "Jim"),
    new Country("Roman Empire", "Latin", "", "Julius Caesar")
  ];
}
