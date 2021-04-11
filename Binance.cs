using System;
using RestSharp;

namespace trader1
{
    class Binance
    {
        public void Run()
        {
            var client = new RestClient("https://api.binance.com/api/v3/avgPrice?symbol=BTCUSDT");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public decimal getCurrentPair(Pair pair)
        {            
            var client = new RestClient($"https://api.binance.com/api/v3/avgPrice?symbol={pair.LeftCurrency}{pair.RightCurrency}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            decimal result;
            try
            {
                decimal.TryParse(response.Content, out result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                result = 0;
            }
            return result;
        }
    }
}
