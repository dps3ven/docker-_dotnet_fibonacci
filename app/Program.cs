using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace fibonacci
{
    class Program
    {
        // F{n}=F_{n-1}+F_{n-2},
        // every number after the first two is the sum of the two preceding ones
        static void Main(string[] args)
        {
            List<BigInteger> numList = new List<BigInteger> { 0, 1 };
            foreach (BigInteger num in Fibonacci(numList))
            {
                Console.WriteLine(num);
            }         
        }

        public static List<BigInteger> Fibonacci(List<BigInteger> sequence)
        {
                BigInteger lastNum = sequence.Last();
                BigInteger secondLast = sequence.ElementAt(sequence.Count() - 2);
                BigInteger nextNum = secondLast + lastNum;
                sequence.Add(nextNum);
                if (sequence.Count <= 100)
                {
                    Fibonacci(sequence);
                }
                return sequence;

        }
    }
}
