using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace PokemonAPI
{
    class Program
    {       
        static void Main(string[] args)
        {
            string pokeURL = "https://pokeapi.co/api/v2/pokemon/";  //?limit=100&offset=200
            var client = new HttpClient();
            var response = client.GetStringAsync(pokeURL).Result;
            var pokemon = JsonConvert.DeserializeObject<Root>(response);
            foreach (var poke in pokemon.results)
            {
                var pokeResponse = client.GetStringAsync(poke.url).Result;
                var pokeResult = JsonConvert.DeserializeObject<PokemonRoot>(pokeResponse);
                Console.WriteLine();
                Console.WriteLine("....................");
                Console.WriteLine();
                Console.WriteLine(pokeResult.name + ":");
                Console.Write($"Type: ");
                //var moves = JObject.Parse(pokeResult.moves).SelectToken("Manufacturers[0].Name");
              
                foreach (var pType in pokeResult.types)
                {
                    Console.Write(pType.type.name + ", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            string vulpixURL = "https://pokeapi.co/api/v2/pokemon/vulpix";
            var responseV = client.GetStringAsync(vulpixURL).Result;
            //Console.WriteLine(responseV);
            var resultV = JsonConvert.DeserializeObject<PokemonRoot>(responseV);
        
            Console.WriteLine($"My favorite Pokemon is {resultV.name}");
            Console.Write($"{resultV.name} is a ");
            foreach (var vType in resultV.types)
            {
                Console.Write($"{vType.type.name} ");
            }
            Console.Write("type.");
            Console.WriteLine();
            


        }
    }
}
