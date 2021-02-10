using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b= 3;
            if(a +b > 10)
            Console.WriteLine("greater than 10");
            else{
                Console.WriteLine("not greater than 10");
            }

            int c = 4;
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
        }
    }
}