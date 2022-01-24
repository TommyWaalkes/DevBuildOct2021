import { Component, OnInit } from '@angular/core';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css'],
  providers: [MovieService]
})
export class MovieListComponent implements OnInit {

  constructor(private movieDAL: MovieService) { }

  ngOnInit() {
    this.movieDAL.GetMovieList().subscribe(
      (response: any) => { console.log(response); }
    );
  }

}
