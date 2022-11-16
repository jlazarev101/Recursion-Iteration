using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinLazarev_B7IS115
{
    class Program
    {
        static void Main()
        {
            //Gathering all 3 variables
            Console.Write("Enter the number that is the start of the arithmetic sequence: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter a common difference for the sequence: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter the nth term of the sequence to calculate: ");
            int n = int.Parse(Console.ReadLine());

            //Calling the functions to display the result
            Console.WriteLine($"\nSum of digits from {x} to term number {n} by iteration are: {SumByIteration(n, x, d)}");
            Console.WriteLine($"Sum of digits from {x} to term number {n} by recursion are: {SumByRecursion(n, x, d)}");

            Console.ReadLine();
        }

        static int SumByIteration(int n, int x, int d)
        {
            //declaration of variable sum
            int sum = 0;
            
            //for loop in which the iteration occurs
            for (int i = 1; i <= n; i++)
            {
                sum = sum + x;
                x = x + d;
            }
            //returning the variable sum. ie the result of the iteration
            return sum;
        }


        static int SumByRecursion(int n, int x, int d)
        {
            //if the n value is zero return zero as that is not a term that returns a value within an arithmetic sequence
            if (n == 0)
                return 0;
            else return x + SumByRecursion(n - 1, x + d, d);
        }
    }

}
