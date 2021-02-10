using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf(string[] args)
        {
            int a = 7;
            int b = 4;
            if(a + b > 10)
            Console.WriteLine("greater than 10");
            else{
                Console.WriteLine("not greater than 10");
            }

            int c = 1;
            //both must be true for the argument to work this is because && was used 
            if((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("greater than 10");
                Console.WriteLine("and the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("not greater than 10");
                Console.WriteLine("and the first number is not equal to the second");
            }

            // this is an or either option can be correct
            if((a +b + c > 10) || (a == b))
            {
                Console.WriteLine("the answer is greater than 10");
                Console.WriteLine("or the first and second numbers are equal");
            } else 
            {
                Console.WriteLine("the answer is not greater than 10");
                Console.WriteLine("and the first number is not equal to the second");
            }
        }

        static void ExploreWhile(string[] args)
        {

            //ExploreIf();

            int counter = 13;
            while (counter < 10)
            {
                Console.WriteLine($"the practice counter is {counter}");
                counter++;
            }

            int doCounter = 0;
            do
            {
                Console.WriteLine($"The do counter is {doCounter}");
                doCounter++;
            } while (doCounter < 10);
        }

        static void Main(string[] args)
        {

            //ExploreWhile();
            /*
            for (int index = 7; index <= 10; index++)
            {
                Console.WriteLine($"The index is {index}");
            }

            for (int column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"the column is {column}");
                for (int row = 1; row < 11; row++)
                {
                   Console.WriteLine($"the row is {row}"); 
                }
            }
            */

            //for every number check if it divides by 3 evenly then count up and check again
            //only display if true
            for (int counter = 1; counter < 20;)
            {
                if((counter % 3) == 0)
                {
                    Console.WriteLine($"{counter} is divisble by 3");
                    counter++;
                }else
                {
                    counter++;
                }
            }
        }
    }
}