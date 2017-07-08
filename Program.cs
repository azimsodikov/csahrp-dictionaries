using System;
using System.Collections.Generic;


namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("FB", "Facebook");
            stocks.Add("SNAP", "Snapchat");
            stocks.Add("GM", "General Motors");
            stocks.Add("APP", "Apple");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "CAT", shares: 150, price: 23.21));
            purchases.Add((ticker: "CAT", shares: 20, price: 32.21));
            purchases.Add((ticker: "CAT", shares: 10, price: 28.21));

            purchases.Add((ticker: "FB", shares: 80, price: 19.02));
            purchases.Add((ticker: "FB", shares: 5, price: 13.02));
            purchases.Add((ticker: "FB", shares: 10, price: 19.02));

            purchases.Add((ticker: "SNAP", shares: 120, price: 30.02));
            purchases.Add((ticker: "SNAP", shares: 29, price: 30.02));
            purchases.Add((ticker: "SNAP", shares: 15, price: 40.02));

            purchases.Add((ticker: "GM", shares: 200, price: 11.09));
            purchases.Add((ticker: "GM", shares: 20, price: 15.09));
            purchases.Add((ticker: "GM", shares: 10, price: 12.09));

            purchases.Add((ticker: "APP", shares: 74, price: 15.82));
            purchases.Add((ticker: "APP", shares: 10, price: 19.82));
            purchases.Add((ticker: "APP", shares: 20, price: 12.82));

            Dictionary<string, double> allStocks = new Dictionary<string, double>();
            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                if (stocks.ContainsKey(purchase.ticker)) 
                {  
                    Console.WriteLine("The key already exists");
                    if (allStocks.ContainsKey(stocks[purchase.ticker]))
                    { 
                        allStocks[stocks[purchase.ticker]] += (purchase.shares * purchase.price);
                    } else 
                    {
                        allStocks.Add(stocks[purchase.ticker], purchase.shares * purchase.price);
                    }
                    // If it does, update the total valuation
                }
            }
            foreach( KeyValuePair<string, double> totalStock in allStocks){
                Console.WriteLine(totalStock);
            }           
        }
    }
}
