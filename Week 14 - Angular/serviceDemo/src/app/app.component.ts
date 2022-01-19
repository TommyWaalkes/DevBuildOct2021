import { Component } from '@angular/core';
import { Logger } from './logger.service';
import { MovieAPIService } from './movieAPI.service';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [Logger, MovieAPIService]
})
export class AppComponent {
  title = 'serviceDemo';

  //Type sees the private parameters and knows to do dependcy injection with them
  constructor(private logger: Logger, private movieAPI: MovieAPIService) { }

  testMovie(title: string) {
    this.movieAPI.searchMoviesByTitle(title).subscribe(

      //The response represents the data the API returns 
      (response: any) => { console.log(response) }
    );
  }

  testLog(input: string) {
    this.logger.log(input);
  }
}
