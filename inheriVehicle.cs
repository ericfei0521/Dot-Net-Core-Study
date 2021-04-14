using System;

namespace MyVehicle
{
    class Vehicle  // Base class
    {
        public string brand = "Ford";  // Vehicle field
        public  virtual void honk()             // Vehicle method , using virtual for dynamically change the output
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}