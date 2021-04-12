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
            Car volvo = new Car();
            Console.WriteLine("volvo color : "+(volvo.color));
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