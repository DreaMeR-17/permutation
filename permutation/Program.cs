using System;

namespace permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = ("Nathan");
            string secondName = ("Feuerstein");

            Console.WriteLine(firstName + " " + secondName);

            (firstName, secondName) = (secondName, firstName);

            Console.WriteLine(firstName + " " + secondName);
        }
    }
}
