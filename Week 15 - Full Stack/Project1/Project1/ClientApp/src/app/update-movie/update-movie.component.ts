//This component is meant to grab a single movie by id from our database 
//and On its front, it will create a form that lets us edit that movie 
//When done we'll click submit and pass the updated to our API
import { Component, Input, OnInit } from '@angular/core';
import { Movie } from '../Movie';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-update-movie',
  templateUrl: './update-movie.component.html',
  styleUrls: ['./update-movie.component.css'],
  providers: [MovieService]
})
export class UpdateMovieComponent implements OnInit {

  @Input() Id: number;
  movie: Movie;
  constructor(private movieService: MovieService) {

  }

  ngOnInit() {
    this.movieService.GetMovie(this.Id).subscribe(
      (response: any) => {
        console.log(response);
        this.movie = response;
      }
    );
  }

}
