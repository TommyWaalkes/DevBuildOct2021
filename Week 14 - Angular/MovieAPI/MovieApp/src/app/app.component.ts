import { Component } from '@angular/core';
import { Convert, Movie } from './Movie';
import { MovieService } from './movie.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [MovieService]
})
export class AppComponent {
  title = 'MovieApp';
  movie?: Movie;
  constructor(private movieAPI: MovieService) { }

  GetMovie() {
    let title: string = (<HTMLInputElement>document.getElementById("Title")).value;
    this.movieAPI.SearchMovieByTitle(title).subscribe(
      (result: any) => {
        console.log(result);
        //Take a JS 
        let json: string = Convert.movieToJson(result);
        let movie: Movie = Convert.toMovie(json);
        console.log(movie);
        this.movie = movie;
      }
    );
  }
}
