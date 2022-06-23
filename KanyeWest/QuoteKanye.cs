using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class QuoteKanye
    {
        public QuoteKanye()
        {
        }

        public static string GetQuote()
        {
            var kanyeURL = "https://api.kanye.rest";

            var client = new HttpClient();

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return $"Kanye: {kanyeQuote}";


        }
    }
}
