using System;

namespace TryOutNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string option;
            do {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Please enter an int to square");
                    Console.WriteLine($"The Square of the number is: {TestFunction(ValidInt(5))}");
                }
                catch (Exception ex) { Console.WriteLine(ex); }
                Console.WriteLine("Would you like to try again?");
                option = Console.ReadLine();
            } while (option != "n");
            //Validation and error catching

        }

        //Function bodied expression same as { return x * x; }
        static int TestFunction(int x) => x * x;

        //uint to prevent negative values. -- Dosnt work
        //do while - user will have at least one attempt even with a 0 value. 
        static int ValidInt(uint Attempts)
        {
            bool Valid;
            int Count = 0;
            int Output;
            do
            {   //TryParse returns bool,  param 1 = input, param 2 = output.
                //Other overloads for formating strings into region specific format
                if (Valid = int.TryParse(Console.ReadLine(), out Output))
                {
                    Console.WriteLine("Input is valid");
                }
                else
                {
                    Count++;
                    Console.WriteLine("Invalid input, please enter an int");
                }
            } while (!Valid && Count < Attempts);
            if (Count >= Attempts) {
                //throw new Exception if count out of bounds
                throw new Exception ("Too many attempts please try again later."); 
            }
            return Output;
        }
    }
}
