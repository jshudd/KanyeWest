using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class QuoteRon
    {
        public QuoteRon()
        {
        }

        public static string GetQuote()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var client = new HttpClient();

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return $"Ron Swanson: {ronQuote}";
        }

    }
}
