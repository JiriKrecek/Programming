using Coinbase.Pro;
using Flurl.Util;
using System;
using System.Linq;

namespace CoinbasePro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new CoinbaseProClient(new Config
            {
                ApiKey = "817ae338fb8702f4b6c2dde210de5686",
                Secret = "/fMNSrj18pq/AT6WL0dfODKJZzIzO/jMUFLJ2OMyjwSbBYdBaRpgaN8p8JHovE/JbDVzd9YYOcZc2O9vzL+elQ==",
                Passphrase = "test",
            });

            var accounts = client.

            foreach (var item in accounts)
            {
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
