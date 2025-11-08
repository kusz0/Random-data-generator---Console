using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Data_Generator
{
    internal class Display
    {


        public void Print()
        {
            Console.WriteLine("===========Random ID Generator=============");

            Console.Write("Write Id length:");
            bool isValidNumber = int.TryParse(Console.ReadLine(), out int idLength);
            while(!isValidNumber)
            {
                Console.WriteLine("Invalid number!!! Try Again");
                Console.Write("Write Id length: ");
                isValidNumber = int.TryParse(Console.ReadLine(), out idLength);
            } 
            RandomDataGen randomDataGen = new RandomDataGen(idLength);

            string randomID = randomDataGen.RandomID();
            Console.Clear();
            Console.WriteLine("===========Random ID Generator=============");
            Console.WriteLine("Your random id: ");
            Console.Write(randomID);
        }

    }
}
