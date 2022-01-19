import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class MovieAPIService {
    apiKey: string = "62398519";
    baseApiURL: string = `http://www.omdbapi.com/?`;

    //Inject http client into our class
    //http client is a built Javascript/Typescript class 
    //that allows us to make http calls, in particular 
    //we're going to be doing get calls 
    //though eventually when we're in a full stack app 
    //it'll be used for post, put, and delete calls as well

    //Why the private variable in our constructor? That we don't put into a variable
    //We're using dependcy to pass the HTTP object into our class 
    //TS/JS knows we're doing DI when it sees a private parameter to our constructor.
    constructor(private http: HttpClient) { }

    searchMoviesByTitle(title: string): Observable<any> {
        let fullURL: string = `${this.baseApiURL}t=${title}&apikey=${this.apiKey}`;
        let result = this.http.get(fullURL);
        console.log(result);
        return result;
    }
}