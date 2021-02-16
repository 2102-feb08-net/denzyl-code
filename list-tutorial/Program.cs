using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkingWithStrings();   

            var fibonacciNumbers = new List<int> {1, 1};

            while (fibonacciNumbers.Count < 20)
            {

                var previous = fibonacciNumbers[fibonacciNumbers.Count -1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count -2];

                fibonacciNumbers.Add(previous + previous2);   

                foreach (var item in fibonacciNumbers)
                {
                    Console.WriteLine(item);
                }
            }
        }
        
        static void WorkingWithStrings(string[] args)
        {
            //create a list and add 3 names to it 
            var names = new List<string> { "Denzyl", "Ana", "Felipe"};
            Console.WriteLine();
            //add 2 names and remove one
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            Console.WriteLine($"my name is {names[0]}");
            Console.WriteLine($"i've added {names[2]} and {names[3]}");
            Console.WriteLine($"the list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            Console.WriteLine($"index is {names[index]}");
            if(index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf return {index}");
            }
            else
            {
                Console.WriteLine($"the name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"when an item is not found, indexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"the name {names[index]} is at index {index}");
            }

            //make list alphabetical 
            names.Sort();
            //print a string for every name in the list
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
