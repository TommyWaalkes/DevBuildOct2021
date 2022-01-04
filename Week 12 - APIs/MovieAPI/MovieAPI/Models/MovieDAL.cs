using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class MovieDAL
    {
        public SearchParent SearchMoviesByTitle(string title)
        {
            string url = $"https://www.omdbapi.com/?apikey={Secret.movieKey}&s=" + title;

            //This makes the request at our URL 
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //This line sends that request to the SWAPI server 
            //and grabs its response 
            //which will be either an error or JSON data
            //Common Error Codes: 
            //404 Not found
            //500 errors means server side error or servers are down 
            //200 means we are good 
            //300 generally mean the server has moved or there has been a redirect
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //This grabs the file out of the response
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string JSON = rd.ReadToEnd();
            rd.Close();

            SearchParent p = JsonConvert.DeserializeObject<SearchParent>(JSON);

            return p;

        }
    }
}
