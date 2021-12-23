using System;

namespace SuperStringDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("String Demo");

            // Reference to object of type SuperString
            // Instance of a class
            SuperString myString = new SuperString();

            // Change text of myString
            myString.SetText("Hello From C#");

            // Print out SuperText
            Console.WriteLine(myString.GetText());

            // Null?
            myString.SetText(null);
            Console.WriteLine(myString.GetText());

            // A string can be indexed like an array
            string hello = "hello";
            for (int i = 0; i < hello.Length; i++)
            {
                Console.WriteLine(hello[i]);
            }

            // Reverse the string
            myString.SetText("Hello from C#");
            myString.Reverse();
            Console.WriteLine(myString.GetText());

            // Count characters
            int numberOfOs = myString.CountCharacter('o');
            Console.WriteLine($"Number of O's: {numberOfOs}");

            Console.WriteLine($"Number of x's: {myString.CountCharacter('x')}");

            myString.ToUpperCase();
            Console.WriteLine(myString.GetText());
        }
    }
}
