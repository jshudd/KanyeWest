using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {

                //KanyeQuote(); //Methods defined below
                //Console.WriteLine();

                //RonQuote();
                //Console.WriteLine();

                Console.WriteLine(ChuckNorris.GetQuote());
                Console.WriteLine();

                //Console.WriteLine($"{QuoteKanye.GetQuote()}"); //In Classes
                //Console.WriteLine();

                //Console.WriteLine($"{QuoteRon.GetQuote()}"); //In Class
                //Console.WriteLine();

                //Console.WriteLine(CatFacts.CatFactsQuote());

                Console.WriteLine("Continue? Y or N?");
                var response = Console.ReadLine().ToLower();
                cont = (response == "n") ? false : true;

            } while (cont);
        }

        public static void KanyeQuote()
        {
            //API URL
            var kanyeURL = "https://api.kanye.rest";

            //Allow us to call the API
            var client = new HttpClient();

            //Stores the JSON response in a variable
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //Parse through response
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.WriteLine();
        }

        public static void RonQuote()
        {
            //Ron Swanson
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var client = new HttpClient();

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron Swanson: {ronQuote}");
            Console.WriteLine();
        }
    }
}
