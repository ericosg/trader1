using System;

namespace trader1
{
    class Program
    {
        static Binance binance = new Binance();
        static void Main(string[] args)
        {
            var pair = new Pair() { Left = C.XRP, Right = C.BNB };
            Console.WriteLine(binance.getCurrentPair(pair));
        }
    }
}
