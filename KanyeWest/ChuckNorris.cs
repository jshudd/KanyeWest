using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class ChuckNorris
    {
        public ChuckNorris()
        {
        }

        public static string GetQuote()
        {
            var client = new HttpClient();

            var chuckURL = "https://api.chucknorris.io/jokes/random";

            var chuckResponse = client.GetStringAsync(chuckURL).Result;

            var chuckQuote = JObject.Parse(chuckResponse).GetValue("value").ToString();

            return $"Chuck Norris Joke: {chuckQuote}";
        }
    }
}
