using System;
using System.Linq;
using MyApplication;
using MyVehicle;
using MyAnimal;

namespace GetLastName
{
    class Program
    {
        static void Main()
        {
            IfElseMethod("callback001",9);
            Vehicle myvehicel = new Vehicle();
            Car Ford = new Car("Mustang", "Red", 1969);
            myvehicel.honk();
            Ford.honk();//call vehicle method
            Console.WriteLine("Ford model: " + Ford.color + " " + Ford.year + " " + Ford.model + Ford.brand);//display the value from vehicle 
            //test class
            var CowNum = AnimalNum.Parse(1,"Cow");
            CowNum.count();
            CowNum.count();
            CowNum.count();
            Console.WriteLine("CowNum{0}",CowNum.getNum());
            CowNum.getName("Eric");
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