using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int>() { 1, 4, 14, 56, 76, 77, 90 };
            //var results = from n in numbers
            //              where n.ToString().StartsWith("1")
            //              && n > 6
            //              select n * 2;

            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}


            //Console.ReadLine();

            //var numbers = Enumerable.Range(1, 100);
            //var results = from n in numbers
            //              select n % 3 == 0 ?
            //                        "Fizz" :
            //                        n.ToString();
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //string[] words = { "hi", "LINQ", "curious", "why", "needed" };

            //var shortWords = from word in words
            //                 where words.Length <= 5
            //                 select words;

            //foreach (var word in shortWords)
            //{
            //    Console.WriteLine(word);
            //}

            string[] words = { "hi", "LINQ", "curious", "why", "needed"};

            //LINQ to query short words
            var shortWords = from word in words
                             where word.Length <= 5
                             select word;

            //iterate through LINQ result set
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
