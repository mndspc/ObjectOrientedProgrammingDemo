using System;


namespace OOPDemo
{
   partial class Animal
    {
        //  Domestic
        public Animal()
        {
          
            Console.WriteLine("This is default constructor of Animal");
        }
    }

    partial class Animal
    {
        //  Wild
        public Animal(string type)
        {
            Console.WriteLine($"This Animal is of type:{type}");
        }
    }
}
