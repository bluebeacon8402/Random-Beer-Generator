using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Random_Beer_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var beerResponse = client.GetStringAsync("http://api.brewerydb.com/v2/beer/random/?key=22a748d7f6d72e4a88aa768513e9c8f0").Result;
            var randomBeer = JToken.Parse(beerResponse);

            var onebeer = randomBeer.SelectToken("data.name").ToString();

            Console.WriteLine(onebeer);
        }
    }
}
