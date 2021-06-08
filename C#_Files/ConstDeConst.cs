using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReviseCS
{

    class Dog
    {
        public Dog()
        {
            Console.WriteLine("Constructor");
        }

        ~Dog()
        {
            Console.WriteLine("Deconstructor");
        }



        static void Main(string[] args)
        {

            Dog d1 = new Dog();

        }


    }
}




