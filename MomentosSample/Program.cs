using System;

namespace MomentosSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Momentos!");

            var stockOriginator = new StockOriginator
            {
                Data = new Stock
                {
                    Price = 1.11m,
                    Symbol = "ABCD",
                    Timestamp = DateTime.Now.AddMinutes(-1),
                }
            };

            var stockCaretaker = new StockCaretaker
            {
                Momento = stockOriginator.CreateMomento()
            };

            Console.WriteLine("1. Initializion complete....");

            Console.WriteLine("Originator State:");
            Console.WriteLine(stockOriginator.Data.ToString());

            Console.WriteLine("Momento State:");
            Console.WriteLine(stockCaretaker.Momento.GetState());

            
            stockOriginator.Data = new Stock
            {
                Price = 1.12m,
                Symbol = "ABCD",
                Timestamp = DateTime.Now,
            };

            Console.WriteLine("2. Changed originator state but caretaker allows us to recover previous state.");

            Console.WriteLine("Originator State:");
            Console.WriteLine(stockOriginator.Data.ToString());

            Console.WriteLine("Momento State:");
            Console.WriteLine(stockCaretaker.Momento.GetState());

            stockOriginator.SetMomento(stockCaretaker.Momento);

            Console.WriteLine("2. Committed originator state to caretaker momento....");

            Console.WriteLine("Originator State:");
            Console.WriteLine(stockOriginator.Data.ToString());

            Console.WriteLine("Momento State:");
            Console.WriteLine(stockCaretaker.Momento.GetState());

            Console.ReadLine();
        }
    }
}
