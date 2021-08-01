using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionsAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
            
            Task3();

            Task4();
        }

        private static void Task2()
        {
            char symbolToCheck = 's';

            string text = "hhhgggkkkkkflklklkflksdeieieieieighghhghghg";

            int symbolAmount = text.GetSymbolCount(symbolToCheck);

            Console.WriteLine($"Symbol count of {symbolToCheck}: in text {text} is {symbolAmount}");
        }

        private static void Task3()
        {
            List<int> numberList = new List<int>
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 235, 46, 7, 1, 2, 3, 5, 7, 4, 3, 2, 4, 8, 5, 8, 9, 0, 67, 4, 3, 2, 5, 8};

            List<bool> boolList = new List<bool>
                {true, true, false, true, true, false, true, true, false, true, true, false};

            HowManyElementsInList(numberList);
            HowManyElementsInList(boolList);
        }

        private static void HowManyElementsInList<T>(List<T> list)
        {
            IEnumerable<(T Symbol, int Count)> countBySymbols = list
                .GroupBy(symbol => symbol)
                .Select(symbol => (symbol.Key, symbol.Count()));

            foreach (var countBySymbol in countBySymbols)
            {
                Console.WriteLine($"Symbol: {countBySymbol.Symbol}, Count {countBySymbol.Count}");
            }
        }

        private static void Task4()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                {"four", 4},
                {"two", 2},
                {"one", 1},
                {"three", 3},
            };
            var resultDictionary = dictionary.OrderBy(pair => pair.Value);

            foreach (var pair in resultDictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}