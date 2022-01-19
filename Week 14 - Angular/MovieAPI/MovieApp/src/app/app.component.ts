import { Component } from '@angular/core';
import { Convert } from './Movie';
import { MovieService } from './movie.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [MovieService]
})
export class AppComponent {
  title = 'MovieApp';
  constructor(private movieAPI: MovieService) { }

  GetMovie() {
    let title: string = (<HTMLInputElement>document.getElementById("Title")).value;
    this.movieAPI.SearchMovieByTitle(title).subscribe(
      (result: any) => { console.log(result); Convert.toMovie(result); }
    );
  }
}
