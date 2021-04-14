using System;
using System.Data.Common;

namespace MyAnimal
{
    public class  AnimalNum
    {
        public int num = 1;
        public string Name;
        public int Id;
        
        public void  count()
        {
            num++;
        }

        public int getNum()
        {
            return num;
        }
        
        public void getName(string to)
        {
            Console.WriteLine("ID:{0} , Hello {1},I have a {2}", Id, to, Name);
        }

        public static AnimalNum Parse(int id,string str)
        {
            var animal = new AnimalNum {Id=id,Name=str};
            return animal;
        }
    }
}