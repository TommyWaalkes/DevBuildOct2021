import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Convert } from './Movie';



@Injectable({
  providedIn: 'root'
})
export class MovieService {
  urlBase: string = "https://www.omdbapi.com/?";
  apiKey: string = "62398519";
  constructor(private http: HttpClient) { }

  SearchMovieByTitle(title: string): Observable<any> {

    //When working with an API you have yet to use getting the url right will be guess n check
    let fullURL: string = `${this.urlBase}apikey=${this.apiKey}&t=${title}`;
    let result: Observable<any> = this.http.get(fullURL);
    return result;
  }

}
