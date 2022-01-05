using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    public class WeatherDAL
    {

        public string GetDetroit()
        {
            //First step is to put in your Endpoint, your URL 
            string url = "https://api.weather.gov/points/42.3314,-83.0458";

            //Next we need to create our request 
            HttpWebRequest request = WebRequest.CreateHttp(url);
            
            //What is a User Agent? 
            //Some APIs require you to send along info about your app or browser that you're using to test it 
            //APIs will say whether they need a user in their documentation 
            //User Agents in C# are always strings 
            request.UserAgent = "example.com, tommy@grandcircus.co";
            //OR 

            //in HTTP, which is what we use to talk to APIs, we have headers to handle the settings of the API calls 
            //Headers are key value pairs and used in a vareity of ways, again check your API documention for what headers 
            //The API will need and/or accept. 
            //Commonly used to set the user agent and to handle username and password for APIs that use logins
            //request.Headers.Add("User-Agent", "example.com, tommy@grandcircus.co");


            //Next if your API needs any kind of login or key, that may go here 
            //SWAPI doesn't need anything so we're good

            //Now we're ready to send off our request and grab the server's response 
            //Inside our response, the resulting data lives 
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Pull the result into a stream reader which will then give us a string 
            StreamReader rd = new StreamReader(response.GetResponseStream());

            //Grab our response string - read to end starts at the top of our response file and returns each line 
            //until it hits the end. 
            string result = rd.ReadToEnd();
            CityInfo ci = JsonConvert.DeserializeObject<CityInfo>(result);

            string forecastURL = ci.properties.forecast;
            HttpWebRequest request2 = WebRequest.CreateHttp(forecastURL);

            request2.UserAgent = "example.com, tommy@grandcircus.co";
            
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();

            //Pull the result into a stream reader which will then give us a string 
            StreamReader rd2 = new StreamReader(response2.GetResponseStream());

            Forecast f = JsonConvert.DeserializeObject<Forecast>(result);


            //This line converts our JSON string into a person object automatically 
            return result; 
        
        }

    }
}
