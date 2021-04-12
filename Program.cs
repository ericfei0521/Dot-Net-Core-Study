using System;

namespace GetLastName
{
    class Program
    {
        static void Main()
        {
            IfElseMethod();
        }

        static void IfElseMethod()
        {
            int time = 9;
            if (time < 10) 
            {
                Console.WriteLine("Good morning.");
            } 
            else if (time < 20) 
            {
                Console.WriteLine("Good day.");
            } 
            else 
            {
                Console.WriteLine("Good evening.");
            }   
        }
    }
}