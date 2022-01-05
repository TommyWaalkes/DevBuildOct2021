using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{
    public class DeckOfCardsDAL
    {
        public Deck CreateDeck()
        {
            string url = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            //This makes the request at our URL 
            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //This grabs the file out of the response
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string JSON = rd.ReadToEnd();
            rd.Close();

            Deck d = JsonConvert.DeserializeObject<Deck>(JSON);

            return d;
        }

        public Draw DrawCards(string deckId, int drawCount)
        {
            string url = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={drawCount}";
            //This makes the request at our URL 
            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //This grabs the file out of the response
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string JSON = rd.ReadToEnd();
            rd.Close();

            Draw d = JsonConvert.DeserializeObject<Draw>(JSON);

            return d;
        }

    }
}
