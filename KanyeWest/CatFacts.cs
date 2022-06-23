using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class CatFacts
    {
        public CatFacts()
        {
        }

        public static string CatFactsQuote()
        {
            var catFactsURL = "https://catfact.ninja/fact?max_length=140";

            var client = new HttpClient();

            var catFactsResponse = client.GetStringAsync(catFactsURL).Result;

            var catFact = JObject.Parse(catFactsResponse).GetValue("fact").ToString();

            return $"Cat Fact: {catFact}";
        }
        

    }
}
