using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SWAPIExample.Models
{
    public class SWDAL
    {
        public Person GetPerson(int id)
        {
            //First step is to put in your Endpoint, your URL 
            string url = "https://swapi.dev/api/people/" + id;

            //Next we need to create our request 
            HttpWebRequest request = WebRequest.CreateHttp(url);

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

            //This line converts our JSON string into a person object automatically 
            Person p = JsonConvert.DeserializeObject<Person>(result);

            //Later we'll convert our string into a model which makes it much easier to use for .net
            return p;
        }

        public Planet GetPlanet(int id)
        {
            //First step is to put in your Endpoint, your URL 
            string url = "https://swapi.dev/api/planets/" + id;

            //Next we need to create our request 
            HttpWebRequest request = WebRequest.CreateHttp(url);

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

            //This line converts our JSON string into a person object automatically 
            Planet p = JsonConvert.DeserializeObject<Planet>(result);

            //Later we'll convert our string into a model which makes it much easier to use for .net
            return p;
        }
    }
}
