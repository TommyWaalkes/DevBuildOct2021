import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  url: string = "https://localhost:44316/Movie";
  constructor(private http: HttpClient) { }

  GetMovieList() {
    return this.http.get(this.url);
  }
}
