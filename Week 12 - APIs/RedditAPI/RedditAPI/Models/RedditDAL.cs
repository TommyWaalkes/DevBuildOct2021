using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RedditAPI.Models
{
    public class RedditDAL
    {
        public Child GetPost(int index)
        {
            string url = "https://www.reddit.com/r/aww/.json";

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
            SubReddit sr = JsonConvert.DeserializeObject<SubReddit>(result);
            return sr.data.children[index];

            
        }
    }
}
