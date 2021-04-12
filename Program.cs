using System;
using MyApplication;

namespace GetLastName
{
    class Program
    {
        static void Main()
        {
            IfElseMethod("callback001",9);
            IfElseMethod("callback002",10);
            IfElseMethod("callback003",20);
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine("Ford model: " + Ford.color + " " + Ford.year + " " + Ford.model);
        }

        static void IfElseMethod(string title ,int time)
        {
            if (time < 10) 
            {
                Console.WriteLine(title +" "+ "Good morning.");
            } 
            else if (time < 20) 
            {
                Console.WriteLine(title +" "+ "Good day.");
            } 
            else 
            {
                Console.WriteLine(title +" "+ "Good evening.");
            }   
        }
    }
}